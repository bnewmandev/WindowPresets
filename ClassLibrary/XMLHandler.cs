using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public static class XMLHandler
    {
        public static void WriteProfile(Profile output)
        {
            string dir = (Environment.SpecialFolder.ApplicationData) + "/WindowsPresets/Profiles/";
            System.IO.Directory.CreateDirectory(dir);
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Profile));
            var path = dir + output.Name;
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, output);
            file.Close();
        }
    }
}
