namespace MathPractice
{
	partial class frmMain
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.btnBegin = new System.Windows.Forms.Button();
			this.lblScore = new System.Windows.Forms.Label();
			this.pnlBackGround = new System.Windows.Forms.Panel();
			this.lblAccTipNum = new System.Windows.Forms.Label();
			this.lblAccTip2 = new System.Windows.Forms.Label();
			this.lblAccTip = new System.Windows.Forms.Label();
			this.lblAnswerTip = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.lblEqual = new System.Windows.Forms.Label();
			this.lblFactor2 = new System.Windows.Forms.Label();
			this.lblOperator = new System.Windows.Forms.Label();
			this.lblFactor1 = new System.Windows.Forms.Label();
			this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
			this.lstHistory = new System.Windows.Forms.ListBox();
			this.lblTimeLeft = new System.Windows.Forms.Label();
			this.lblTimeLNum = new System.Windows.Forms.Label();
			this.lblRestQu = new System.Windows.Forms.Label();
			this.lblRestQNum = new System.Windows.Forms.Label();
			this.lblScoreNum = new System.Windows.Forms.Label();
			this.btnSetRules = new System.Windows.Forms.Button();
			this.tmrDelay = new System.Windows.Forms.Timer(this.components);
			this.btnStop = new System.Windows.Forms.Button();
			this.pnlBackGround.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBegin
			// 
			this.btnBegin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnBegin.Location = new System.Drawing.Point(397, 72);
			this.btnBegin.Name = "btnBegin";
			this.btnBegin.Size = new System.Drawing.Size(95, 31);
			this.btnBegin.TabIndex = 0;
			this.btnBegin.Text = "开始";
			this.btnBegin.UseVisualStyleBackColor = true;
			this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblScore.Location = new System.Drawing.Point(359, 18);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(69, 26);
			this.lblScore.TabIndex = 3;
			this.lblScore.Text = "得分：";
			// 
			// pnlBackGround
			// 
			this.pnlBackGround.BackColor = System.Drawing.Color.SteelBlue;
			this.pnlBackGround.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlBackGround.Controls.Add(this.lblAccTipNum);
			this.pnlBackGround.Controls.Add(this.lblAccTip2);
			this.pnlBackGround.Controls.Add(this.lblAccTip);
			this.pnlBackGround.Controls.Add(this.lblAnswerTip);
			this.pnlBackGround.Controls.Add(this.txtAnswer);
			this.pnlBackGround.Controls.Add(this.lblEqual);
			this.pnlBackGround.Controls.Add(this.lblFactor2);
			this.pnlBackGround.Controls.Add(this.lblOperator);
			this.pnlBackGround.Controls.Add(this.lblFactor1);
			this.pnlBackGround.Location = new System.Drawing.Point(12, 72);
			this.pnlBackGround.Name = "pnlBackGround";
			this.pnlBackGround.Size = new System.Drawing.Size(356, 119);
			this.pnlBackGround.TabIndex = 4;
			// 
			// lblAccTipNum
			// 
			this.lblAccTipNum.AutoSize = true;
			this.lblAccTipNum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblAccTipNum.ForeColor = System.Drawing.Color.Aqua;
			this.lblAccTipNum.Location = new System.Drawing.Point(284, 10);
			this.lblAccTipNum.Name = "lblAccTipNum";
			this.lblAccTipNum.Size = new System.Drawing.Size(14, 14);
			this.lblAccTipNum.TabIndex = 8;
			this.lblAccTipNum.Text = "0";
			// 
			// lblAccTip2
			// 
			this.lblAccTip2.AutoSize = true;
			this.lblAccTip2.ForeColor = System.Drawing.SystemColors.Info;
			this.lblAccTip2.Location = new System.Drawing.Point(300, 10);
			this.lblAccTip2.Name = "lblAccTip2";
			this.lblAccTip2.Size = new System.Drawing.Size(41, 12);
			this.lblAccTip2.TabIndex = 7;
			this.lblAccTip2.Text = "位小数";
			// 
			// lblAccTip
			// 
			this.lblAccTip.AutoSize = true;
			this.lblAccTip.ForeColor = System.Drawing.SystemColors.Info;
			this.lblAccTip.Location = new System.Drawing.Point(214, 10);
			this.lblAccTip.Name = "lblAccTip";
			this.lblAccTip.Size = new System.Drawing.Size(77, 12);
			this.lblAccTip.TabIndex = 6;
			this.lblAccTip.Text = "四舍五入到：";
			// 
			// lblAnswerTip
			// 
			this.lblAnswerTip.AutoSize = true;
			this.lblAnswerTip.ForeColor = System.Drawing.SystemColors.Info;
			this.lblAnswerTip.Location = new System.Drawing.Point(241, 93);
			this.lblAnswerTip.Name = "lblAnswerTip";
			this.lblAnswerTip.Size = new System.Drawing.Size(77, 12);
			this.lblAnswerTip.TabIndex = 5;
			this.lblAnswerTip.Text = "输入回车确定";
			// 
			// txtAnswer
			// 
			this.txtAnswer.AccessibleDescription = "";
			this.txtAnswer.BackColor = System.Drawing.Color.AliceBlue;
			this.txtAnswer.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtAnswer.ForeColor = System.Drawing.Color.Orange;
			this.txtAnswer.Location = new System.Drawing.Point(218, 34);
			this.txtAnswer.MaxLength = 8;
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.ReadOnly = true;
			this.txtAnswer.Size = new System.Drawing.Size(123, 46);
			this.txtAnswer.TabIndex = 4;
			this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
			// 
			// lblEqual
			// 
			this.lblEqual.AutoSize = true;
			this.lblEqual.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblEqual.ForeColor = System.Drawing.Color.SandyBrown;
			this.lblEqual.Location = new System.Drawing.Point(173, 37);
			this.lblEqual.Name = "lblEqual";
			this.lblEqual.Size = new System.Drawing.Size(39, 39);
			this.lblEqual.TabIndex = 3;
			this.lblEqual.Text = "=";
			// 
			// lblFactor2
			// 
			this.lblFactor2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblFactor2.ForeColor = System.Drawing.Color.SandyBrown;
			this.lblFactor2.Location = new System.Drawing.Point(95, 37);
			this.lblFactor2.Name = "lblFactor2";
			this.lblFactor2.Size = new System.Drawing.Size(88, 39);
			this.lblFactor2.TabIndex = 2;
			this.lblFactor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblOperator
			// 
			this.lblOperator.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblOperator.ForeColor = System.Drawing.Color.SandyBrown;
			this.lblOperator.Location = new System.Drawing.Point(69, 37);
			this.lblOperator.Name = "lblOperator";
			this.lblOperator.Size = new System.Drawing.Size(39, 39);
			this.lblOperator.TabIndex = 1;
			this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFactor1
			// 
			this.lblFactor1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblFactor1.ForeColor = System.Drawing.Color.SandyBrown;
			this.lblFactor1.Location = new System.Drawing.Point(-2, 37);
			this.lblFactor1.Name = "lblFactor1";
			this.lblFactor1.Size = new System.Drawing.Size(78, 39);
			this.lblFactor1.TabIndex = 0;
			this.lblFactor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tmrCountDown
			// 
			this.tmrCountDown.Interval = 1000;
			this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
			// 
			// lstHistory
			// 
			this.lstHistory.BackColor = System.Drawing.Color.LightGray;
			this.lstHistory.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lstHistory.ForeColor = System.Drawing.Color.Sienna;
			this.lstHistory.FormattingEnabled = true;
			this.lstHistory.HorizontalScrollbar = true;
			this.lstHistory.ItemHeight = 14;
			this.lstHistory.Location = new System.Drawing.Point(12, 209);
			this.lstHistory.Name = "lstHistory";
			this.lstHistory.Size = new System.Drawing.Size(480, 172);
			this.lstHistory.TabIndex = 6;
			// 
			// lblTimeLeft
			// 
			this.lblTimeLeft.AutoSize = true;
			this.lblTimeLeft.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblTimeLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTimeLeft.Location = new System.Drawing.Point(169, 18);
			this.lblTimeLeft.Name = "lblTimeLeft";
			this.lblTimeLeft.Size = new System.Drawing.Size(126, 26);
			this.lblTimeLeft.TabIndex = 7;
			this.lblTimeLeft.Text = "本题倒计时：";
			// 
			// lblTimeLNum
			// 
			this.lblTimeLNum.AutoSize = true;
			this.lblTimeLNum.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblTimeLNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lblTimeLNum.Location = new System.Drawing.Point(301, 18);
			this.lblTimeLNum.Name = "lblTimeLNum";
			this.lblTimeLNum.Size = new System.Drawing.Size(36, 26);
			this.lblTimeLNum.TabIndex = 9;
			this.lblTimeLNum.Text = "10";
			// 
			// lblRestQu
			// 
			this.lblRestQu.AutoSize = true;
			this.lblRestQu.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblRestQu.ForeColor = System.Drawing.Color.Green;
			this.lblRestQu.Location = new System.Drawing.Point(7, 18);
			this.lblRestQu.Name = "lblRestQu";
			this.lblRestQu.Size = new System.Drawing.Size(107, 26);
			this.lblRestQu.TabIndex = 10;
			this.lblRestQu.Text = "剩余题数：";
			// 
			// lblRestQNum
			// 
			this.lblRestQNum.AutoSize = true;
			this.lblRestQNum.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblRestQNum.ForeColor = System.Drawing.Color.Green;
			this.lblRestQNum.Location = new System.Drawing.Point(116, 18);
			this.lblRestQNum.Name = "lblRestQNum";
			this.lblRestQNum.Size = new System.Drawing.Size(36, 26);
			this.lblRestQNum.TabIndex = 11;
			this.lblRestQNum.Text = "10";
			// 
			// lblScoreNum
			// 
			this.lblScoreNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblScoreNum.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblScoreNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblScoreNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblScoreNum.Location = new System.Drawing.Point(422, 18);
			this.lblScoreNum.Name = "lblScoreNum";
			this.lblScoreNum.Size = new System.Drawing.Size(85, 32);
			this.lblScoreNum.TabIndex = 12;
			this.lblScoreNum.Text = "0";
			// 
			// btnSetRules
			// 
			this.btnSetRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnSetRules.Location = new System.Drawing.Point(397, 160);
			this.btnSetRules.Name = "btnSetRules";
			this.btnSetRules.Size = new System.Drawing.Size(95, 31);
			this.btnSetRules.TabIndex = 13;
			this.btnSetRules.Text = "规则设置";
			this.btnSetRules.UseVisualStyleBackColor = true;
			this.btnSetRules.Click += new System.EventHandler(this.btnSetRules_Click);
			// 
			// tmrDelay
			// 
			this.tmrDelay.Interval = 1000;
			this.tmrDelay.Tick += new System.EventHandler(this.tmrDelay_Tick);
			// 
			// btnStop
			// 
			this.btnStop.Enabled = false;
			this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnStop.Location = new System.Drawing.Point(397, 116);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(95, 31);
			this.btnStop.TabIndex = 14;
			this.btnStop.Text = "结束";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BurlyWood;
			this.ClientSize = new System.Drawing.Size(510, 397);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnSetRules);
			this.Controls.Add(this.lblScoreNum);
			this.Controls.Add(this.lblRestQNum);
			this.Controls.Add(this.lblRestQu);
			this.Controls.Add(this.lblTimeLNum);
			this.Controls.Add(this.lblTimeLeft);
			this.Controls.Add(this.lstHistory);
			this.Controls.Add(this.pnlBackGround);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.btnBegin);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "心算大师";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.pnlBackGround.ResumeLayout(false);
			this.pnlBackGround.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBegin;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Panel pnlBackGround;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Label lblEqual;
		private System.Windows.Forms.Label lblFactor2;
		private System.Windows.Forms.Label lblOperator;
		private System.Windows.Forms.Label lblFactor1;
		private System.Windows.Forms.Timer tmrCountDown;
		private System.Windows.Forms.ListBox lstHistory;
		private System.Windows.Forms.Label lblTimeLeft;
		private System.Windows.Forms.Label lblTimeLNum;
		private System.Windows.Forms.Label lblRestQu;
		private System.Windows.Forms.Label lblRestQNum;
		private System.Windows.Forms.Label lblScoreNum;
		private System.Windows.Forms.Button btnSetRules;
		private System.Windows.Forms.Label lblAnswerTip;
		private System.Windows.Forms.Label lblAccTip2;
		private System.Windows.Forms.Label lblAccTip;
		private System.Windows.Forms.Label lblAccTipNum;
		private System.Windows.Forms.Timer tmrDelay;
		private System.Windows.Forms.Button btnStop;
	}
}

