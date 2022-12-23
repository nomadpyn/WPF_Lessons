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
        public MainWindow()
        {
            InitializeComponent();

            this.products = new BindingList<Product>();
            this.productGrid.ItemsSource = this.products;
        }               
    }
}
