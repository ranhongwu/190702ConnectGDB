using System;
using System.Windows.Forms;
using System.Collections.Generic;
using CreateConnectEnterpriseDB;

namespace CreateCollectEnterpriseDB
{
    public partial class FrmSDEConnect : DevExpress.XtraEditors.XtraForm
    {
        public FrmSDEConnect()
        {
            InitializeComponent();
        }

        #region 定义变量
        private string DB_type;
        private string IP;
        private string DB_name;
        private string user_name;
        private string pwd;
        EnterpriseDB eDB = new EnterpriseDB();
        #endregion

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combxDBType.Text=="Oracle")
            {
                labelControl3.Visible = false;
                combxDBName.Visible = false;
            }
            DB_type = combxDBType.Text;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxIP_EditValueChanged(object sender, EventArgs e)
        {
            IP = tbxIP.Text;
        }

        private void tbxPwd_EditValueChanged(object sender, EventArgs e)
        {
            pwd = tbxPwd.Text;
        }

        private void combxDBName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        //点击下拉框获取所有的数据库名
        private void combxDBName_Click(object sender, EventArgs e)
        {
            user_name = tbxUser.Text;
            if(DB_type==null)
            {
                MessageBox.Show(null, "请选择数据库类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (IP == null)
            {
                MessageBox.Show(null, "请输入IP地址", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (user_name == null)
            {
                MessageBox.Show(null, "请输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (pwd == null)
            {
                MessageBox.Show(null, "请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            combxDBName.Properties.Items.Clear();
            //预留oracle和SQL Server数据库接口
            if (DB_type.ToLower() == "postgresql")
            {
                user_name = tbxUser.Text;
                List<string> db_names = eDB.GetAllPGDataBase(IP, user_name, pwd);
                for (int i = 0; i < db_names.Count; i++)
                {
                    combxDBName.Properties.Items.Add(db_names[i]);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            user_name = tbxUser.Text;
            DB_name = combxDBName.Text;

            #region 输入参数判断
            if (DB_type == null)
            {
                MessageBox.Show(null, "请选择数据库类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (IP == null)
            {
                MessageBox.Show(null, "请输入IP地址", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (user_name == null)
            {
                MessageBox.Show(null, "请输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (pwd == null)
            {
                MessageBox.Show(null, "请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(DB_name==null)
            {
                MessageBox.Show(null, "请选择数据库", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            #endregion

            //预留oracle和SQL Server数据库接口
            if (DB_type.ToLower() == "postgresql")
            {
                try
                {
                    eDB.ConnectPGDB(DB_type, IP, DB_name, user_name, pwd);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show(null, "数据库连接失败", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}