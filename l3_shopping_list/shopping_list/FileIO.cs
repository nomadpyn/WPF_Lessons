using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace shopping_list
{
    internal class FileIO
    {
        private readonly string Path;
        public FileIO(string path)
        {
            this.Path = path;
        }
        public BindingList<Product> loadFile()
        {
            var fileExist = File.Exists(this.Path);
            if (!fileExist)
            {
                File.CreateText(this.Path).Dispose();
                return new BindingList<Product>();
            }
            using (FileStream fs = new FileStream(this.Path, FileMode.Open))
            {
                return JsonSerializer.Deserialize<BindingList<Product>>(fs);
            }
        }
        public void saveData(BindingList<Product> products)
        {
            using (FileStream fs = new FileStream(this.Path, FileMode.OpenOrCreate))
            {
                
                JsonSerializer.SerializeAsync<BindingList<Product>>(fs, products);
            }
        }
    }
}
