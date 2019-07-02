using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataManagementTools;
using ESRI.ArcGIS.Geoprocessor;
using ESRI.ArcGIS.DataSourcesGDB;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Geometry;
using System.Data;
using System.Data.SqlClient;
using Npgsql;

namespace CreateConnectEnterpriseDB
{
    class EnterpriseDB
    {
        #region 定义变量
        private static IWorkspaceFactory2 pWorkspaceFactory = new SdeWorkspaceFactoryClass();
        public static IWorkspace pWorkspace;//工作空间
        public static List<IFeatureLayer> pFeaLayers=new List<IFeatureLayer>();//存储矢量数据的图层
        public static List<IRasterLayer> pRstLayers = new List<IRasterLayer>();//存储栅格数据的图层
        #endregion
        

        #region 地理数据库和连接
        /// <summary>
        /// 创建企业地理数据库
        /// </summary>
        /// <param name="DB_platform">数据库类型</param>
        /// <param name="instance">地址</param>
        /// <param name="DB_Name">数据库名</param>
        /// <param name="DB_admin">数据库用户名</param>
        /// <param name="DB_pwd">数据库密码</param>
        /// <param name="GDB_admin">地理数据库用户名</param>
        /// <param name="GDB_pwd">地理数据库密码</param>
        /// <param name="auth_path">许可路径</param>
        /// 
        public void CreateEnterpriseDB(string DB_platform,string instance,string DB_name,
            string DB_admin,string DB_pwd, string GDB_admin, string GDB_pwd,string auth_path)
        {
            Geoprocessor gp = new Geoprocessor();
            gp.OverwriteOutput = true;
            CreateEnterpriseGeodatabase ceGDB = new CreateEnterpriseGeodatabase();
            ceGDB.database_platform = DB_platform;
            ceGDB.instance_name =instance;
            ceGDB.database_name = DB_name;
            ceGDB.database_admin =DB_admin;
            ceGDB.database_admin_password = DB_pwd;
            ceGDB.gdb_admin_name = GDB_admin;
            ceGDB.gdb_admin_password = GDB_pwd;
            ceGDB.authorization_file = auth_path;

            gp.Execute(ceGDB, null);
        }

        /// <summary>
        /// 遍历服务器中所有postgreSQL数据库
        /// </summary>
        /// <param name="ip">服务器IP地址</param>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>返回服务器所有postgresSQL数据库名的列表</returns>
        public List<string> GetAllPGDataBase(string ip, string username, string password)
        {
            List<string> DBNameList = new List<string>();
            string connectionString = "Server="+ip+";Port=5432;User Id="+username+";Password="+password+";Database=template1;";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            NpgsqlCommand command =new NpgsqlCommand("select datname from pg_database",conn);
            NpgsqlDataReader reader= command.ExecuteReader();
            while (reader.Read())
            {
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    DBNameList.Add(reader[i].ToString());
                }
            }
            conn.Close();
            return DBNameList;
        }

        /// <summary>
        /// 添加数据库连接，连接的数据库类型为PostgreSQL,Oracle等
        /// </summary>
        /// <param name="type">数据库类型，如postgresql,Oracle等</param>
        /// <param name="IP">IP地址</param>
        /// <param name="database">数据库</param>
        /// <param name="user">用户名</param>
        /// <param name="pwd">密码</param>
        /// 
        public void ConnectPGDB(string type,string IP,string database ,string user,string pwd)
        {
            IAoInitialize m_AoInitialize = new AoInitialize();
            //必须添加ArcServer许可
            m_AoInitialize.Initialize(esriLicenseProductCode.esriLicenseProductCodeArcServer);

            IPropertySet pPropertySet = new PropertySetClass();
            pPropertySet.SetProperty("SERVER", IP);
            pPropertySet.SetProperty("INSTANCE", "sde:"+type+":"+IP);
            pPropertySet.SetProperty("DATABASE", database);
            pPropertySet.SetProperty("USER", user);
            pPropertySet.SetProperty("PASSWORD", pwd);

            pWorkspace = pWorkspaceFactory.Open(pPropertySet, 0);
            MessageBox.Show("数据库连接成功");

        }
        #endregion


        #region 遍历数据库中的数据名
        /// <summary>
        /// 遍历数据库中的矢量数据
        /// </summary>
        /// <param name="workspaceToGetName">工作空间</param>
        /// <returns>数据名的集合</returns>
        public List<string> get_FeatureDataName(IWorkspace workspaceToGetName)
        {
            List<string> s = new List<string>();
            IEnumDataset enumDataset = pWorkspace.Datasets[esriDatasetType.esriDTAny];
            IDataset pDS = null;
            enumDataset.Reset();
            while ((pDS= enumDataset.Next()) != null)
            {
                if (pDS.Type == esriDatasetType.esriDTFeatureClass)
                    s.Add(pDS.Name);
            }
            return s;   
        }

        /// <summary>
        /// 遍历数据库中的栅格数据
        /// </summary>
        /// <param name="workspaceToGetName"></param>
        /// <returns>数据名的集合</returns>
        public List<string> get_RasterName(IWorkspace workspaceToGetName)
        {
            List<string> s = new List<string>();
            IEnumDataset enumDataset = pWorkspace.Datasets[esriDatasetType.esriDTAny];
            IDataset pDS = null;
            enumDataset.Reset();
            while ((pDS = enumDataset.Next()) != null)
            {
                if (pDS.Type == esriDatasetType.esriDTRasterDataset)
                    s.Add(pDS.Name);
            }
            return s;
        }
        #endregion

    }
}
