using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Xml.Serialization;

namespace reg_window
{
    public static class FileIO
    {
        public static void SaveFile(List<User> data)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<User>));
            try
            {
                using (Stream fStream = File.Create("users.xml"))
                {
                    xmlFormat.Serialize(fStream, data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static List<User> LoadFile()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<User>));
            try
            {
                using (Stream fStream =File.OpenRead("users.xml"))
                {
                    return (List<User>)xmlFormat.Deserialize(fStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Создан новый файл");
            }

            return new List<User>();
        }
    }
}