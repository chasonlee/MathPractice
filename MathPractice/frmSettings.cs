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
namespace MathPractice
{
	public partial class frmSettings : Form
	{
		public frmSettings()
		{
			InitializeComponent();
		}
		frmMain form1;
		public frmSettings(frmMain form1)
		{
			InitializeComponent();
			this.form1 = form1;
		}
		clsDoXML doXml = new clsDoXML();

		//加载窗体
		private void Settings_Load(object sender, EventArgs e)
		{
			//初始化控件
			InitControls();

		}
		//初始化控件
		private void InitControls()
		{
			//按规则读Xml文件
			doXml.ReadXMLrules();
			//根据当前等级设置等级控件
			SetLevel();
			//根据等级下标，设置控件参数
			SetControls(clsLevels.PreLevelInx);
			//设置控件的可操作性
			SetMask();
		}
		//根据当前等级设置等级控件
		private void SetLevel()
		{
			switch (clsLevels.PreLevel)
			{
				case clsLevels.Beginner:
					this.rdoBeginner.Checked = true;
					break;
				case clsLevels.Primary:
					this.rdoPrimary.Checked = true;
					break;
				case clsLevels.Medium:
					this.rdoMedium.Checked = true;
					break;
				case clsLevels.Advanced:
					this.rdoAdvanced.Checked = true;
					break;
				case clsLevels.Master:
					this.rdoMaster.Checked = true;
					break;
				case clsLevels.Custom:
					this.rdoCustom.Checked = true;
					break;
			}
		}
		//根据等级下标inx，设置控件参数
		private void SetControls(int inx)
		{
			//勾选运算符
			if (doXml.levels[inx].getOperator().Contains("+") == true)	//包含+号
				this.cklOperator.SetItemChecked(0, true);
			else
				this.cklOperator.SetItemChecked(0, false);

			if (doXml.levels[inx].getOperator().Contains("-") == true)
				this.cklOperator.SetItemChecked(1, true);
			else
				this.cklOperator.SetItemChecked(1, false);

			if (doXml.levels[inx].getOperator().Contains("*") == true)
				this.cklOperator.SetItemChecked(2, true);
			else
				this.cklOperator.SetItemChecked(2, false);

			if (doXml.levels[inx].getOperator().Contains("/") == true)
				this.cklOperator.SetItemChecked(3, true);
			else
				this.cklOperator.SetItemChecked(3, false);

			//设置小数位数
			this.cmbAccuracy.Text = doXml.levels[inx].getAccuracy();
			//设置限制时间
			this.cmbLimitTime.Text = doXml.levels[inx].getLimitTime();
			//设置最大位数
			this.cmbMaxDigit.Text = doXml.levels[inx].getMaxDigit();
			//设置题目数量
			this.cmbQuantity.Text = doXml.levels[inx].getQuantity();
		}
		//设置控件的可操作性
		private void SetMask()
		{
			//非自定义的参数不可操作
			if (clsLevels.PreLevel != clsLevels.Custom)
			{
				this.cklOperator.Enabled = false;
				this.cmbAccuracy.Enabled = false;
				this.cmbLimitTime.Enabled = false;
				this.cmbMaxDigit.Enabled = false;
				this.cmbQuantity.Enabled = false;
			}
			else
			{
				this.cklOperator.Enabled = true;
				this.cmbAccuracy.Enabled = true;
				this.cmbLimitTime.Enabled = true;
				this.cmbMaxDigit.Enabled = true;
				this.cmbQuantity.Enabled = true;
			}
		}
		//选择等级事件
		private void SelectLevel(object sender, EventArgs e)
		{	//提取等级下标并更新当前等级
			int inx = 0;
			RadioButton snd = (RadioButton)sender;
			switch (snd.Tag.ToString())
			{
				case clsLevels.Beginner:
					inx = 0;
					clsLevels.PreLevel = clsLevels.Beginner;
					clsLevels.PreLevelCN = clsLevels.BeginnerCN;
					break;
				case clsLevels.Primary:
					inx = 1;
					clsLevels.PreLevel = clsLevels.Primary;
					clsLevels.PreLevelCN = clsLevels.PrimaryCN;
					break;
				case clsLevels.Medium:
					inx = 2;
					clsLevels.PreLevel = clsLevels.Medium;
					clsLevels.PreLevelCN = clsLevels.MediumCN;
					break;
				case clsLevels.Advanced:
					inx = 3;
					clsLevels.PreLevel = clsLevels.Advanced;
					clsLevels.PreLevelCN = clsLevels.AdvancedCN;
					break;
				case clsLevels.Master:
					inx = 4;
					clsLevels.PreLevel = clsLevels.Master;
					clsLevels.PreLevelCN = clsLevels.MasterCN;
					break;
				case clsLevels.Custom:
					inx = 5;
					clsLevels.PreLevel = clsLevels.Custom;
					clsLevels.PreLevelCN = clsLevels.CustomCN;
					break;
			}
			//根据等级下标inx，设置控件参数
			SetControls(inx);
			//设置控件的可操作性
			SetMask();
		}
		//保存自定义参数
		private void SaveCustom()
		{
			//获取运算符信息
			string opr = "";
			for( int i = 0; i < 4; i++){
				if (this.cklOperator.GetItemChecked(i)) 
					opr += this.cklOperator.Items[i];
			}
			doXml.levels[5].setOperator(opr);
			doXml.levels[5].setAccuracy(this.cmbAccuracy.Text);
			doXml.levels[5].setLimitTime(this.cmbLimitTime.Text);
			doXml.levels[5].setMaxDigit(this.cmbMaxDigit.Text);
			doXml.levels[5].setQuantity(this.cmbQuantity.Text);
		}
		//确定按钮事件
		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if (this.cklOperator.CheckedItems.Count == 0)
			{
				MessageBox.Show("至少要选择一个运算符号！","提示");
				return;
			}
			//保存自定义参数
			SaveCustom();
			//按规则写XML文件
			doXml.WriteXMLrules();
			//从XML更新等级信息
			form1.UpdateXML();
			//重置全部信息
			form1.ResetAll();
			//关闭当前窗体
			this.Dispose();
		}
		//取消按钮事件
		private void btnCancel_Click(object sender, EventArgs e)
		{
			//关闭当前窗体
			this.Dispose();
		}
		
	}
}
