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
// статический класс для взаимодействия с данными в xml
    public static class FileIO
    {
// метод сохранения данных в xml
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
// метод возвращает список пользователей, если файла нет, то пустой список
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