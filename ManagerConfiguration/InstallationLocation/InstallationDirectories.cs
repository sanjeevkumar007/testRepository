using ConfigPlugings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallationLocation
{
    public class InstallationDirectories : IConfigPlugin
    {
        UserControl usrInstallationDirectoryControl = null;
        public string PluginName
        {
            get
            {
                return "Installation Directories";
            }
        }

        public UserControl UserConfigControl
        {
            get
            {
                if (usrInstallationDirectoryControl == null)
                {
                    usrInstallationDirectoryControl = new LocationUserControl();
                }

                return usrInstallationDirectoryControl;
            }
        }

        public TabPage ApplyMenuPlugin(TabPage tabMenuPlugin)
        {
            tabMenuPlugin.Text = PluginName;
            tabMenuPlugin.Controls.Add(UserConfigControl);
            return tabMenuPlugin;
        }
    }
}
