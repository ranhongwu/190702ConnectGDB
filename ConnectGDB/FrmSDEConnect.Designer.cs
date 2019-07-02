namespace CreateCollectEnterpriseDB
{
    partial class FrmSDEConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSDEConnect));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbxIP = new DevExpress.XtraEditors.TextEdit();
            this.combxDBType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tbxPwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbxUser = new DevExpress.XtraEditors.TextEdit();
            this.combxDBName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbxIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combxDBType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combxDBName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 182);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 14);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "数据库名称：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 14);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "IP地址：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "数据库类型：";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(88, 41);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(218, 20);
            this.tbxIP.TabIndex = 7;
            this.tbxIP.EditValueChanged += new System.EventHandler(this.tbxIP_EditValueChanged);
            // 
            // combxDBType
            // 
            this.combxDBType.Location = new System.Drawing.Point(88, 12);
            this.combxDBType.Name = "combxDBType";
            this.combxDBType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combxDBType.Properties.Items.AddRange(new object[] {
            "SQL_Srever",
            "PostgreSQL",
            "Oracle"});
            this.combxDBType.Size = new System.Drawing.Size(218, 20);
            this.combxDBType.TabIndex = 6;
            this.combxDBType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tbxPwd);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.tbxUser);
            this.groupControl1.Location = new System.Drawing.Point(12, 76);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(295, 84);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "数据库身份验证";
            // 
            // tbxPwd
            // 
            this.tbxPwd.Location = new System.Drawing.Point(77, 53);
            this.tbxPwd.Name = "tbxPwd";
            this.tbxPwd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tbxPwd.Properties.PasswordChar = '·';
            this.tbxPwd.Properties.UseSystemPasswordChar = true;
            this.tbxPwd.Size = new System.Drawing.Size(208, 20);
            this.tbxPwd.TabIndex = 10;
            this.tbxPwd.EditValueChanged += new System.EventHandler(this.tbxPwd_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 59);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "密码：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "用户名：";
            // 
            // tbxUser
            // 
            this.tbxUser.EditValue = "sde";
            this.tbxUser.Location = new System.Drawing.Point(77, 27);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(208, 20);
            this.tbxUser.TabIndex = 8;
            // 
            // combxDBName
            // 
            this.combxDBName.Location = new System.Drawing.Point(88, 179);
            this.combxDBName.Name = "combxDBName";
            this.combxDBName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combxDBName.Size = new System.Drawing.Size(218, 20);
            this.combxDBName.TabIndex = 13;
            this.combxDBName.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.combxDBName_ButtonClick);
            this.combxDBName.Click += new System.EventHandler(this.combxDBName_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(88, 214);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 20;
            this.simpleButton3.Text = "取消";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(231, 214);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 19;
            this.simpleButton2.Text = "确定";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(10, 205);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 21;
            // 
            // FrmSDEConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 249);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.combxDBName);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.combxDBType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSDEConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接数据库";
            ((System.ComponentModel.ISupportInitialize)(this.tbxIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combxDBType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combxDBName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbxIP;
        private DevExpress.XtraEditors.ComboBoxEdit combxDBType;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tbxPwd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tbxUser;
        private DevExpress.XtraEditors.ComboBoxEdit combxDBName;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
    }
}