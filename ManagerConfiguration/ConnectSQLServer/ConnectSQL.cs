using ConfigPlugings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectSQLServer
{
    public class ConnectSQL : IConfigPlugin
    {
        UserControl usrConnectSQL = null;
        public string PluginName
        {
            get
            {
                return "SQL Connect";
            }
        }

        public UserControl UserConfigControl
        {
            get
            {
                if (usrConnectSQL == null)
                {
                    usrConnectSQL = new SQLServerConnect();
                }

                return usrConnectSQL;
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
