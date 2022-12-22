using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace button_set
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void buttonNavy_Click(object sender, RoutedEventArgs e)
        {
            Title = "Navy";
            this.background.Background = new SolidColorBrush(Colors.Navy);
        }
        private void buttonBlue_Click(object sender, RoutedEventArgs e)
        {
            Title = "Blue";
            this.background.Background = new SolidColorBrush(Colors.Blue);
        }
        private void buttonAqua_Click(object sender, RoutedEventArgs e)
        {
            Title = "Aqua";
            this.background.Background = new SolidColorBrush(Colors.Aqua);
        }
        private void buttonTeal_Click(object sender, RoutedEventArgs e)
        {
            Title = "Teal";
            this.background.Background = new SolidColorBrush(Colors.Teal);
        }
        private void buttonOlive_Click(object sender, RoutedEventArgs e)
        {
            Title = "Olive";
            this.background.Background = new SolidColorBrush(Colors.Olive);
        }
        private void buttonGreen_Click(object sender, RoutedEventArgs e)
        {
            Title = "Green";
            this.background.Background = new SolidColorBrush(Colors.Green);
        }
        private void buttonLime_Click(object sender, RoutedEventArgs e)
        {
            Title = "Lime";
            this.background.Background = new SolidColorBrush(Colors.Lime);
        }
        private void buttonYellow_Click(object sender, RoutedEventArgs e)
        {
            Title = "Yellow";
            this.background.Background = new SolidColorBrush(Colors.Yellow);
        }
        private void buttonOrange_Click(object sender, RoutedEventArgs e)
        {
            Title = "Orange";
            this.background.Background = new SolidColorBrush(Colors.Orange);
        }
        private void buttonRed_Click(object sender, RoutedEventArgs e)
        {
            Title = "Red";
            this.background.Background = new SolidColorBrush(Colors.Red);
        }
        private void buttonMaroon_Click(object sender, RoutedEventArgs e)
        {
            Title = "Maroon";
            this.background.Background = new SolidColorBrush(Colors.Maroon);
        }
        private void buttonFuchsia_Click(object sender, RoutedEventArgs e)
        {
            Title = "Fuchsia";
            this.background.Background = new SolidColorBrush(Colors.Fuchsia);
        }
        private void buttonPurple_Click(object sender, RoutedEventArgs e)
        {
            Title = "Purple";
            this.background.Background = new SolidColorBrush(Colors.Purple);
        }
        private void buttonBlack_Click(object sender, RoutedEventArgs e)
        {
            Title = "Black";
            this.background.Background = new SolidColorBrush(Colors.Black);
        }
        private void buttonSilver_Click(object sender, RoutedEventArgs e)
        {
            Title = "Silver";
            this.background.Background = new SolidColorBrush(Colors.Silver);
        }
        private void buttonGray_Click(object sender, RoutedEventArgs e)
        {
            Title = "Gray";
            this.background.Background = new SolidColorBrush(Colors.Gray);
        }
        private void buttonWhite_Click(object sender, RoutedEventArgs e)
        {
            Title = "White";
            this.background.Background = new SolidColorBrush(Colors.White);
        }
    }
}
