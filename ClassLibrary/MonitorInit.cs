using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public static class MonitorInit
    {
        public static List<MonitorData> Initialize()
        {
            List<MonitorData> output = new List<MonitorData>();
            int screens = Screen.AllScreens.Length;
            int i = 0;
            while (i < screens)
            {
                var retDat = new MonitorData(i);
                output.Add(retDat);
                i++;
            }

            return output;
        }

        public static void ExportToXml()
        {
            var output = Initialize();
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/WindowsPresets");
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(List<MonitorData>));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/WindowsPresets/MonitorConfig.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, output);
            file.Close();
        }
    }
}
