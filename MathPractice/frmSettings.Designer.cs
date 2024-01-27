namespace MathPractice
{
	partial class frmSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
			this.btnConfirm = new System.Windows.Forms.Button();
			this.rdoBeginner = new System.Windows.Forms.RadioButton();
			this.rdoPrimary = new System.Windows.Forms.RadioButton();
			this.rdoMedium = new System.Windows.Forms.RadioButton();
			this.rdoAdvanced = new System.Windows.Forms.RadioButton();
			this.rdoMaster = new System.Windows.Forms.RadioButton();
			this.rdoCustom = new System.Windows.Forms.RadioButton();
			this.grpLevels = new System.Windows.Forms.GroupBox();
			this.cklOperator = new System.Windows.Forms.CheckedListBox();
			this.cmbAccuracy = new System.Windows.Forms.ComboBox();
			this.cmbLimitTime = new System.Windows.Forms.ComboBox();
			this.cmbQuantity = new System.Windows.Forms.ComboBox();
			this.cmbMaxDigit = new System.Windows.Forms.ComboBox();
			this.grpRules = new System.Windows.Forms.GroupBox();
			this.lblMaxDigit = new System.Windows.Forms.Label();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.lblLimitTime = new System.Windows.Forms.Label();
			this.lblAccuracy = new System.Windows.Forms.Label();
			this.lblOperator = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grpLevels.SuspendLayout();
			this.grpRules.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(70, 283);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(75, 23);
			this.btnConfirm.TabIndex = 0;
			this.btnConfirm.Text = "确定";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// rdoBeginner
			// 
			this.rdoBeginner.AutoSize = true;
			this.rdoBeginner.Location = new System.Drawing.Point(25, 30);
			this.rdoBeginner.Name = "rdoBeginner";
			this.rdoBeginner.Size = new System.Drawing.Size(47, 16);
			this.rdoBeginner.TabIndex = 2;
			this.rdoBeginner.TabStop = true;
			this.rdoBeginner.Tag = "Beginner";
			this.rdoBeginner.Text = "新手";
			this.rdoBeginner.UseVisualStyleBackColor = true;
			this.rdoBeginner.CheckedChanged += new System.EventHandler(this.SelectLevel);
			// 
			// rdoPrimary
			// 
			this.rdoPrimary.AutoSize = true;
			this.rdoPrimary.Location = new System.Drawing.Point(25, 66);
			this.rdoPrimary.Name = "rdoPrimary";
			this.rdoPrimary.Size = new System.Drawing.Size(47, 16);
			this.rdoPrimary.TabIndex = 3;
			this.rdoPrimary.TabStop = true;
			this.rdoPrimary.Tag = "Primary";
			this.rdoPrimary.Text = "初级";
			this.rdoPrimary.UseVisualStyleBackColor = true;
			this.rdoPrimary.CheckedChanged += new System.EventHandler(this.SelectLevel);
			// 
			// rdoMedium
			// 
			this.rdoMedium.AutoSize = true;
			this.rdoMedium.Location = new System.Drawing.Point(25, 102);
			this.rdoMedium.Name = "rdoMedium";
			this.rdoMedium.Size = new System.Drawing.Size(47, 16);
			this.rdoMedium.TabIndex = 4;
			this.rdoMedium.TabStop = true;
			this.rdoMedium.Tag = "Medium";
			this.rdoMedium.Text = "中级";
			this.rdoMedium.UseVisualStyleBackColor = true;
			this.rdoMedium.CheckedChanged += new System.EventHandler(this.SelectLevel);
			// 
			// rdoAdvanced
			// 
			this.rdoAdvanced.AutoSize = true;
			this.rdoAdvanced.Location = new System.Drawing.Point(25, 138);
			this.rdoAdvanced.Name = "rdoAdvanced";
			this.rdoAdvanced.Size = new System.Drawing.Size(47, 16);
			this.rdoAdvanced.TabIndex = 5;
			this.rdoAdvanced.TabStop = true;
			this.rdoAdvanced.Tag = "Advanced";
			this.rdoAdvanced.Text = "高级";
			this.rdoAdvanced.UseVisualStyleBackColor = true;
			this.rdoAdvanced.CheckedChanged += new System.EventHandler(this.SelectLevel);
			// 
			// rdoMaster
			// 
			this.rdoMaster.AutoSize = true;
			this.rdoMaster.Location = new System.Drawing.Point(25, 174);
			this.rdoMaster.Name = "rdoMaster";
			this.rdoMaster.Size = new System.Drawing.Size(59, 16);
			this.rdoMaster.TabIndex = 6;
			this.rdoMaster.TabStop = true;
			this.rdoMaster.Tag = "Master";
			this.rdoMaster.Text = "大师级";
			this.rdoMaster.UseVisualStyleBackColor = true;
			this.rdoMaster.CheckedChanged += new System.EventHandler(this.SelectLevel);
			// 
			// rdoCustom
			// 
			this.rdoCustom.AutoSize = true;
			this.rdoCustom.Location = new System.Drawing.Point(25, 210);
			this.rdoCustom.Name = "rdoCustom";
			this.rdoCustom.Size = new System.Drawing.Size(59, 16);
			this.rdoCustom.TabIndex = 7;
			this.rdoCustom.TabStop = true;
			this.rdoCustom.Tag = "Custom";
			this.rdoCustom.Text = "自定义";
			this.rdoCustom.UseVisualStyleBackColor = true;
			this.rdoCustom.CheckedChanged += new System.EventHandler(this.SelectLevel);
			// 
			// grpLevels
			// 
			this.grpLevels.Controls.Add(this.rdoBeginner);
			this.grpLevels.Controls.Add(this.rdoCustom);
			this.grpLevels.Controls.Add(this.rdoPrimary);
			this.grpLevels.Controls.Add(this.rdoMaster);
			this.grpLevels.Controls.Add(this.rdoMedium);
			this.grpLevels.Controls.Add(this.rdoAdvanced);
			this.grpLevels.Location = new System.Drawing.Point(12, 15);
			this.grpLevels.Name = "grpLevels";
			this.grpLevels.Size = new System.Drawing.Size(111, 249);
			this.grpLevels.TabIndex = 8;
			this.grpLevels.TabStop = false;
			this.grpLevels.Text = "等级选择：";
			// 
			// cklOperator
			// 
			this.cklOperator.CheckOnClick = true;
			this.cklOperator.FormattingEnabled = true;
			this.cklOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
			this.cklOperator.Location = new System.Drawing.Point(103, 20);
			this.cklOperator.Name = "cklOperator";
			this.cklOperator.Size = new System.Drawing.Size(65, 68);
			this.cklOperator.TabIndex = 9;
			// 
			// cmbAccuracy
			// 
			this.cmbAccuracy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAccuracy.FormattingEnabled = true;
			this.cmbAccuracy.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
			this.cmbAccuracy.Location = new System.Drawing.Point(103, 103);
			this.cmbAccuracy.Name = "cmbAccuracy";
			this.cmbAccuracy.Size = new System.Drawing.Size(65, 20);
			this.cmbAccuracy.TabIndex = 10;
			// 
			// cmbLimitTime
			// 
			this.cmbLimitTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLimitTime.FormattingEnabled = true;
			this.cmbLimitTime.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "15",
            "20",
            "30"});
			this.cmbLimitTime.Location = new System.Drawing.Point(103, 140);
			this.cmbLimitTime.Name = "cmbLimitTime";
			this.cmbLimitTime.Size = new System.Drawing.Size(65, 20);
			this.cmbLimitTime.TabIndex = 11;
			// 
			// cmbQuantity
			// 
			this.cmbQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbQuantity.FormattingEnabled = true;
			this.cmbQuantity.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
			this.cmbQuantity.Location = new System.Drawing.Point(103, 214);
			this.cmbQuantity.Name = "cmbQuantity";
			this.cmbQuantity.Size = new System.Drawing.Size(65, 20);
			this.cmbQuantity.TabIndex = 12;
			// 
			// cmbMaxDigit
			// 
			this.cmbMaxDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMaxDigit.FormattingEnabled = true;
			this.cmbMaxDigit.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.cmbMaxDigit.Location = new System.Drawing.Point(103, 177);
			this.cmbMaxDigit.Name = "cmbMaxDigit";
			this.cmbMaxDigit.Size = new System.Drawing.Size(65, 20);
			this.cmbMaxDigit.TabIndex = 13;
			// 
			// grpRules
			// 
			this.grpRules.Controls.Add(this.lblMaxDigit);
			this.grpRules.Controls.Add(this.lblQuantity);
			this.grpRules.Controls.Add(this.lblLimitTime);
			this.grpRules.Controls.Add(this.lblAccuracy);
			this.grpRules.Controls.Add(this.lblOperator);
			this.grpRules.Controls.Add(this.cklOperator);
			this.grpRules.Controls.Add(this.cmbMaxDigit);
			this.grpRules.Controls.Add(this.cmbAccuracy);
			this.grpRules.Controls.Add(this.cmbQuantity);
			this.grpRules.Controls.Add(this.cmbLimitTime);
			this.grpRules.Location = new System.Drawing.Point(129, 13);
			this.grpRules.Name = "grpRules";
			this.grpRules.Size = new System.Drawing.Size(200, 251);
			this.grpRules.TabIndex = 14;
			this.grpRules.TabStop = false;
			this.grpRules.Text = "规则选项：";
			// 
			// lblMaxDigit
			// 
			this.lblMaxDigit.AutoSize = true;
			this.lblMaxDigit.Location = new System.Drawing.Point(32, 180);
			this.lblMaxDigit.Name = "lblMaxDigit";
			this.lblMaxDigit.Size = new System.Drawing.Size(65, 12);
			this.lblMaxDigit.TabIndex = 18;
			this.lblMaxDigit.Text = "最大位数：";
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Location = new System.Drawing.Point(32, 217);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Size = new System.Drawing.Size(65, 12);
			this.lblQuantity.TabIndex = 17;
			this.lblQuantity.Text = "题目数量：";
			// 
			// lblLimitTime
			// 
			this.lblLimitTime.AutoSize = true;
			this.lblLimitTime.Location = new System.Drawing.Point(32, 143);
			this.lblLimitTime.Name = "lblLimitTime";
			this.lblLimitTime.Size = new System.Drawing.Size(65, 12);
			this.lblLimitTime.TabIndex = 16;
			this.lblLimitTime.Text = "限制时间：";
			// 
			// lblAccuracy
			// 
			this.lblAccuracy.AutoSize = true;
			this.lblAccuracy.Location = new System.Drawing.Point(32, 106);
			this.lblAccuracy.Name = "lblAccuracy";
			this.lblAccuracy.Size = new System.Drawing.Size(65, 12);
			this.lblAccuracy.TabIndex = 15;
			this.lblAccuracy.Text = "精确小数：";
			// 
			// lblOperator
			// 
			this.lblOperator.AutoSize = true;
			this.lblOperator.Location = new System.Drawing.Point(32, 52);
			this.lblOperator.Name = "lblOperator";
			this.lblOperator.Size = new System.Drawing.Size(65, 12);
			this.lblOperator.TabIndex = 14;
			this.lblOperator.Text = "运算符号：";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(191, 283);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BurlyWood;
			this.ClientSize = new System.Drawing.Size(338, 320);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.grpRules);
			this.Controls.Add(this.grpLevels);
			this.Controls.Add(this.btnConfirm);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.Text = "规则设置";
			this.Load += new System.EventHandler(this.Settings_Load);
			this.grpLevels.ResumeLayout(false);
			this.grpLevels.PerformLayout();
			this.grpRules.ResumeLayout(false);
			this.grpRules.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.RadioButton rdoBeginner;
		private System.Windows.Forms.RadioButton rdoPrimary;
		private System.Windows.Forms.RadioButton rdoMedium;
		private System.Windows.Forms.RadioButton rdoAdvanced;
		private System.Windows.Forms.RadioButton rdoMaster;
		private System.Windows.Forms.RadioButton rdoCustom;
		private System.Windows.Forms.GroupBox grpLevels;
		private System.Windows.Forms.CheckedListBox cklOperator;
		private System.Windows.Forms.ComboBox cmbAccuracy;
		private System.Windows.Forms.ComboBox cmbLimitTime;
		private System.Windows.Forms.ComboBox cmbQuantity;
		private System.Windows.Forms.ComboBox cmbMaxDigit;
		private System.Windows.Forms.GroupBox grpRules;
		private System.Windows.Forms.Label lblMaxDigit;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Label lblLimitTime;
		private System.Windows.Forms.Label lblAccuracy;
		private System.Windows.Forms.Label lblOperator;
		private System.Windows.Forms.Button btnCancel;
	}
}