using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
namespace MathPractice
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}
		//从XML更新等级信息
		public void UpdateXML()
		{
			//按规则读Xml文件
			doXml.ReadXMLrules();
		}
		//重置全部信息
		public void ResetAll()
		{
			//设置标题
			this.Text = "心算大师 - 【" + clsLevels.PreLevelCN + "】";
			//设置小数精度
			this.lblAccTipNum.Text = doXml.levels[clsLevels.PreLevelInx].getAccuracy();
			//设置剩余题目数
			this.lblRestQNum.Text = doXml.levels[clsLevels.PreLevelInx].getQuantity();
			quantity = int.Parse(this.lblRestQNum.Text);
			//设置限制时间
			this.lblTimeLNum.Text = doXml.levels[clsLevels.PreLevelInx].getLimitTime();
			countdown = int.Parse(this.lblTimeLNum.Text);
			//设置分数
			score = 0;
			this.lblScoreNum.Text = score.ToString() + " / " + doXml.levels[clsLevels.PreLevelInx].getQuantity();
			//重置题目数
			this.lblRestQNum.Text = doXml.levels[clsLevels.PreLevelInx].getQuantity();
			quantity = int.Parse(this.lblRestQNum.Text);
			//重置倒计时
			this.lblTimeLNum.Text = doXml.levels[clsLevels.PreLevelInx].getLimitTime();
			countdown = int.Parse(this.lblTimeLNum.Text);
			//重置历史数据
			this.lstHistory.Items.Clear();
			//重置算术式子
			this.lblFactor1.Text = "";
			this.lblFactor2.Text = "";
			this.lblOperator.Text = "";
			//初始化答案文本框
			InitText();
		}

		clsDoXML doXml = new clsDoXML();
		bool RoW = false;
		bool BeginStatus = false;
		decimal rightAns = 0;
		int countdown = 0;
		int quantity = 0;
		int score = 0;

		//取beginN 到 endN-1 的随机整数
		private int GetRandomInt(int beginN, int endN)
		{
			int res = 0;
			long tick = DateTime.Now.Ticks; //设置随机因子为当前时间
			Random rnd = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
			res = rnd.Next(beginN, endN);
			return res;
		}
		//随机取一个允许的运算符
		private string GetRandomOperator(string allowOpr)
		{
			int num = 0;
			string res = "";
			long tick = DateTime.Now.Ticks; //设置随机因子为当前时间
			Random rnd = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
			//都不允许时返回空
			if (allowOpr.Contains("+") == false &&
				allowOpr.Contains("-") == false &&
				allowOpr.Contains("*") == false &&
				allowOpr.Contains("/") == false)
				return res;
			do
			{
				num = rnd.Next(1, 5);
				switch (num)
				{
					case 1:
						res = "+";
						break;
					case 2:
						res = "-";
						break;
					case 3:
						res = "*";
						break;
					case 4:
						res = "/";
						break;
				}
			} while (allowOpr.Contains(res) == false);
			return res;
		}
		//按规则随机出一题
		private void RndQuestion()
		{
			//更新剩余题目数
			if (quantity > 0)
			{
				quantity = quantity - 1;
				this.lblRestQNum.Text = quantity.ToString();
			}
			//根据最大位数生成算数因子
			int maxd = 0;
			maxd = (int)Math.Pow(10d, double.Parse(doXml.levels[clsLevels.PreLevelInx].getMaxDigit()));
			this.lblFactor1.Text = GetRandomInt(1, maxd).ToString();
			Thread.Sleep(100);
			this.lblOperator.Text = GetRandomOperator(doXml.levels[clsLevels.PreLevelInx].getOperator());
			Thread.Sleep(100);
			this.lblFactor2.Text = GetRandomInt(1, maxd).ToString();
			
		}
		//四舍五入到指定小数位
		private decimal Rounds(decimal dou)
		{
			//double会在除时会丢失精度，所以这里用decimal
			decimal res = 0;
			int num = int.Parse(doXml.levels[clsLevels.PreLevelInx].getAccuracy());
			for (int i = 0; i < num; i++) dou *= 10;
			//考虑正负时的四舍五入
			res = (dou >= 0) ? (int)(dou + (decimal)0.5) : (int)(dou - (decimal)0.5);
			for (int i = 0; i < num; i++) res /= 10;
			return res;
		}
		//重启倒计时
		private void RestartCountdown()
		{
			this.lblTimeLNum.Text = doXml.levels[clsLevels.PreLevelInx].getLimitTime();
			countdown = int.Parse(this.lblTimeLNum.Text);
			this.tmrCountDown.Enabled = true;
		}
		//开始延时自动切题并锁定文本框
		private void DelayLock()
		{
			this.tmrDelay.Enabled = true;
			this.txtAnswer.ReadOnly = true;
		}
		//提交答案并自动切题
		private void Submit()
		{
			decimal res = 0;
			if (decimal.TryParse(this.txtAnswer.Text, out res) && CheckAnswer(res))
			{	//正确时
				this.txtAnswer.BackColor = Color.Green;	
				RoW = true;
				//加分数
				score++;
				this.lblScoreNum.Text = score.ToString() + " / " + doXml.levels[clsLevels.PreLevelInx].getQuantity();
			}
			else
			{	//错误时
				this.txtAnswer.BackColor = Color.Red;	
				RoW = false;
			}
			//开始延时自动切题并锁定文本框
			DelayLock();
		}
		//得出正确答案
		private void GetRightAnswer()
		{
			decimal fac1 = decimal.Parse(this.lblFactor1.Text);
			decimal fac2 = decimal.Parse(this.lblFactor2.Text);
			switch (this.lblOperator.Text)
			{
				case "+":
					rightAns = fac1 + fac2;
					break;
				case "-":
					rightAns = fac1 - fac2;
					break;
				case "*":
					rightAns = fac1 * fac2;
					break;
				case "/":
					rightAns = fac1 / fac2;
					break;
			}
			//四舍五入到指定小数位
			rightAns = Rounds(rightAns);
		}
		//判断答案
		private bool CheckAnswer(decimal myans)
		{
			//得出正确答案
			GetRightAnswer();
			//比较结果
			if (myans == rightAns) 
				return true;
			else 
				return false;
		}
		//记录当前式子到历史记录中
		private void Record()
		{
			int num = int.Parse(doXml.levels[clsLevels.PreLevelInx].getQuantity()) - quantity;
			string text = "第" + num.ToString() + "题:\t";
			text += this.lblFactor1.Text.PadLeft(3) + " " + 
				this.lblOperator.Text + " " +
				this.lblFactor2.Text.PadRight(3) + " " +
				this.lblEqual.Text + " " +
				this.txtAnswer.Text.PadRight(6);
			//得出正确答案
			GetRightAnswer();
			//显示正确答案
			if (RoW)
				text += "\t√";
			else
				text += "\t×\t正确答案：" + rightAns.ToString();
			this.lstHistory.Items.Add(text);
		}
		//窗体加载事件
		private void Form1_Load(object sender, EventArgs e)
		{
			//从XML更新等级信息
			UpdateXML();
			//重置全部信息
			ResetAll();
		}
		//初始化答案文本框
		private void InitText()
		{
			this.txtAnswer.BackColor = Color.AliceBlue;
			this.txtAnswer.Text = "";
		}
		//可操作性控制
		private void ControlMask()
		{
			if (BeginStatus == true)
			{	//开始答题时
				this.btnBegin.Enabled = false;
				this.btnStop.Enabled = true;
				this.btnSetRules.Enabled = false;
				this.txtAnswer.ReadOnly = false;	
			}
			else
			{	//结束答题时
				this.btnBegin.Enabled = true;
				this.btnStop.Enabled = false;
				this.btnSetRules.Enabled = true;
				this.txtAnswer.ReadOnly = true;	
			}
			
		}
		//开始事件
		private void btnBegin_Click(object sender, EventArgs e)
		{
			//重置全部信息
			ResetAll();
			//标识答题已开始
			BeginStatus = true;
			//可操作性控制
			ControlMask();
			//按规则随机出一题
			RndQuestion();
			//开始倒计时
			tmrCountDown.Enabled = true;
			//聚焦在答案文本框
			this.txtAnswer.Focus();
		}
		//结束事件
		private void btnStop_Click(object sender, EventArgs e)
		{
			//重置全部信息
			ResetAll();
			//标识答题已结束
			BeginStatus = false;
			//可操作性控制
			ControlMask();
		}
		//设置规则事件
		private void btnSetRules_Click(object sender, EventArgs e)
		{
			frmSettings settings = new frmSettings(this);
			settings.Show();
		}
		//文本框键盘事件
		private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
		{
			//回车且答案不为空时反馈颜色信息
			if (e.KeyChar == 13)
			{
				decimal res = 0;
				//合法性检查
				if (decimal.TryParse(this.txtAnswer.Text, out res))
				{
					//提交答案并自动切题
					Submit();
				}
				
			}
		}
		//延时周期事件
		private void tmrDelay_Tick(object sender, EventArgs e)
		{
			//延时自停
			tmrDelay.Enabled = false;
			//正在答题时才有反应
			if (BeginStatus == true)
			{
				//记录当前式子到历史记录中
				Record();
				//判断剩余题目数
				if (quantity > 0)
				{
					//解锁文本框
					this.txtAnswer.ReadOnly = false;
					//初始化答案文本框
					InitText();
					//按规则随机出一题
					RndQuestion();
					//重启倒计时
					RestartCountdown();
					//聚焦在答案文本框
					this.txtAnswer.Focus();
				}
				else
				{
					//标识答题已结束
					BeginStatus = false;
					//可操作性控制
					ControlMask();
				}
			}
		}
		//倒计时周期事件
		private void tmrCountDown_Tick(object sender, EventArgs e)
		{
			if (BeginStatus == true && countdown > 0)
			{
				//更新计时状态
				countdown = countdown - 1;
				this.lblTimeLNum.Text = countdown.ToString();
				//计时完毕自动提交
				if (countdown == 0)
				{
					tmrCountDown.Enabled = false;
					//提交答案并自动切题
					Submit();
				}
			}
			
		}



	}
}
