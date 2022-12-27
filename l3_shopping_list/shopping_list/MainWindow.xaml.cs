using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace shopping_list
{
   
    public partial class MainWindow : Window
    {
// BindigList для списка продуктов
        private BindingList<Product> products;
// путь для файла в json
        private readonly string path = "products.json";
// объект сохранения и загрузки данных из json
        private FileIO fileIO;
        public MainWindow()
        {
            InitializeComponent();
        }
// при загрузке программы происходит загрузка данных из файла и подгрузка их в productGrid
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fileIO= new FileIO(path);
            this.products =fileIO.loadFile();
            this.productGrid.ItemsSource = this.products;            
        }
// при закрытии окна происходит сохранение данных методом deleteBuy
        private void Window_Closing(object sender, CancelEventArgs e)
        {            
            fileIO.saveData(deleteBuy());            
        }
// метод который удаляет выполненые дела из списка до его сохранения
        private BindingList<Product> deleteBuy()
        {
            BindingList<Product> nw = new BindingList<Product>();
            foreach(Product P in this.products)
            {
                if (P.IsBuy == false)
                {
                    nw.Add(P);
                }
            }
            return nw;
        }
    }
}