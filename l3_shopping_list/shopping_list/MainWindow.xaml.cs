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
        private BindingList<Product> products;
        private readonly string path = "products.json";
        private FileIO fileIO;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fileIO= new FileIO(path);
            this.products =fileIO.loadFile();
            this.productGrid.ItemsSource = this.products;            
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {            
            fileIO.saveData(deleteBuy());            
        }
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