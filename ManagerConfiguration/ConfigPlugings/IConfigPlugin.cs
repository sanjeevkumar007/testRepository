using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigPlugings
{
    public interface IConfigPlugin
    {
        string PluginName { get; }
        TabPage ApplyMenuPlugin(TabPage tabMenuPlugin);
        UserControl UserConfigControl { get; }
    }
}
