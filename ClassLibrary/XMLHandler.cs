using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        public static byte[] ObjectToByteArray(Profile output)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, output);
                return ms.ToArray();
            }
        }

        public static void ByteArrayToBin (byte[] output, string name)
        {
            string dir = (Environment.SpecialFolder.ApplicationData) + "/WindowsPresets/Profiles/";
            Directory.CreateDirectory(dir);
            Directory.CreateDirectory(dir + name);
            FileStream fs = new FileStream(dir + name + "/" + name +".bin", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output);
            bw.Close();
        }

    }
}
