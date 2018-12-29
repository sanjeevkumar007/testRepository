using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerConfigClasses
{
    public class RegistryClass
    {
        public static string InstallationDir { get; set; }
        public static string TspmInstallDir { get; set; }
        public static string InitialBackupPath { get; set; }
        public static string InitialBackupVersion { get; set; }
        public static string ConnectionString { get; set; }
        public static string IsHttp { get; set; }
        public static string IsHttps { get; set; }
        public static string HttpsPortNumber { get; set; }
        public static string HttpPortNumber { get; set; }
        public static string PatchDir { get; set; }
        public static string CertDir { get; set; }
    }
}
