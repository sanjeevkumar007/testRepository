using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using ManagerConfigClasses;

namespace InstallationLocation
{
    public partial class LocationUserControl : UserControl
    {
        const string Install_Dir = "Install_Dir";
        const string Tspm_Path = "Tspm_InstallDir";
        const string BackUp_Path = "DBFilesDir";
        const string BackUp_Version = "BackupVersion";
        const string Patches_Dir = "PatchsDir";
        const string Http = "Http";
        const string Https = "Https";
        const string HttpsPort_Number = "HttpsPort_Number";
        const string HttpPort_Number = "HttpPort_Number";
        const string Connection_String = "Connection_String";
        const string Certificate_Dir = "Certificate_Dir";

        RegistryKey keys = Registry.CurrentUser.OpenSubKey(@"Software\Fiscal Solutions Test\S4BackOffice\ProcessManager",RegistryKeyPermissionCheck.ReadWriteSubTree);
        public LocationUserControl()
        {
            InitializeComponent();

        }

     

        private void LocationUserControl_Load(object sender, EventArgs e)
        {
            LoadFromRegistry(keys);
            txtTspmInstallDir.Text = RegistryClass.TspmInstallDir;
            txtInitialDatabaseLocation.Text = RegistryClass.InitialBackupPath;
            txtInitialDatabaseVersion.Text = RegistryClass.InitialBackupVersion;
            txtPatchFolderLocation.Text = RegistryClass.PatchDir;
            txtCertificateLocation.Text = RegistryClass.CertDir;
        }

        public static void LoadFromRegistry(RegistryKey keys)
        {
            if (keys!=null)
            {
                RegistryClass.InstallationDir = (string)keys.GetValue(Install_Dir);
                RegistryClass.TspmInstallDir = (string)keys.GetValue(Tspm_Path);
                RegistryClass.InitialBackupPath = (string)(string)keys.GetValue(BackUp_Path);
                RegistryClass.InitialBackupVersion = (string)keys.GetValue(BackUp_Version);
                RegistryClass.ConnectionString = (string)keys.GetValue(Connection_String);
                RegistryClass.IsHttp = (string)keys.GetValue(Http);
                RegistryClass.IsHttps = (string)keys.GetValue(Https);
                RegistryClass.HttpsPortNumber = (string)keys.GetValue(HttpsPort_Number);
                RegistryClass.HttpPortNumber = (string)keys.GetValue(HttpPort_Number);
                RegistryClass.PatchDir = (string)keys.GetValue(Patches_Dir);
                RegistryClass.CertDir = (string)keys.GetValue(Certificate_Dir);

            }

            try
            {
                if (!String.IsNullOrEmpty(RegistryClass.HttpsPortNumber))
                {
                    keys.SetValue(HttpsPort_Number, RegistryClass.HttpsPortNumber);

                }

                if (!String.IsNullOrEmpty(RegistryClass.HttpPortNumber))
                {
                    keys.SetValue(HttpPort_Number, RegistryClass.HttpPortNumber);

                }

                if (!String.IsNullOrEmpty(RegistryClass.ConnectionString))
                {
                    keys.SetValue(Connection_String, RegistryClass.ConnectionString);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
