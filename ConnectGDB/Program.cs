using CreateCollectEnterpriseDB;
using ESRI.ArcGIS.esriSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateConnectEnterpriseDB
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.Desktop);
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            ESRI.ArcGIS.RuntimeManager.BindLicense(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            IAoInitialize aoInit = new AoInitializeClass();
            aoInit.Initialize(esriLicenseProductCode.esriLicenseProductCodeArcServer);
            //IAoInitialize aoInit = new AoInitializeClass();
            //aoInit.Initialize(esriLicenseProductCode.esriLicenseProductCodeEngine);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //KYKJ.MIS.Initial.InitialConfig.Execute();
            Application.Run(new FrmSDEConnect());
        }
    }
}
