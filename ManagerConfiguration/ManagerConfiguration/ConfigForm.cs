using ConfigPlugings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ManagerConfiguration
{
    public partial class ConfigForm : Form
    {
        string pluginPath = Application.StartupPath + "\\ConfigMenuPlugin";
        string customMenuConfig = Application.StartupPath + "\\ConfigMenuPlugin\\CustomPluginSequence.xml";
        IConfigPlugin ICPlugins = null;
        List<UserControl> userControlList = new List<UserControl>();
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(pluginPath);

            XmlDocument document = new XmlDocument();
            document.Load(customMenuConfig);

            XmlNodeList xmlNodeList = document.GetElementsByTagName("Plugin");

            int dllCount = xmlNodeList.Count;

            string[] files = new string[dllCount];

            for (int i = 0; i < xmlNodeList.Count; i++)
            {
                files[i] = pluginPath + "\\" + xmlNodeList[i].InnerText.ToString();
            }


            foreach (var file in files)
            {
                Assembly assembly = Assembly.LoadFrom(file);


                foreach (var type in assembly.GetTypes())
                {
                    if (type.GetInterfaces().Contains(typeof(IConfigPlugin)))
                    {
                        TabPage tabPage = new TabPage();
                        ICPlugins = Activator.CreateInstance(type) as IConfigPlugin;
                        tabPage = ICPlugins.ApplyMenuPlugin(tabPage);
                        ConfigTabControl.Controls.Add(tabPage);
                        userControlList.Add(ICPlugins.UserConfigControl);
                    }
                }
            }

        }
    }
}
