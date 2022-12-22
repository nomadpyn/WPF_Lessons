using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
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

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (currentBox.Text != "") { addDigit("0"); } 
        }
        private void button1_Click(object sender, RoutedEventArgs e) { addDigit("1"); }
        private void button2_Click(object sender, RoutedEventArgs e) { addDigit("2"); }
        private void button3_Click(object sender, RoutedEventArgs e) { addDigit("3"); }  
        private void button4_Click(object sender, RoutedEventArgs e) { addDigit("4"); }
        private void button5_Click(object sender, RoutedEventArgs e) { addDigit("5"); }
        private void button6_Click(object sender, RoutedEventArgs e) { addDigit("6"); }
        private void button7_Click(object sender, RoutedEventArgs e) { addDigit("7"); }
        private void button8_Click(object sender, RoutedEventArgs e) { addDigit("8"); }
        private void button9_Click(object sender, RoutedEventArgs e) { addDigit("9"); }
        private void buttonPoint_Click(object sender, RoutedEventArgs e)
        {
            if (!this.currentBox.Text.Contains("."))
            {
                if (this.currentBox.Text == "") 
                    addDigit("0."); 
                else
                    addDigit(".");
            }
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e) { addSign("/"); }
        private void buttonMult_Click(object sender, RoutedEventArgs e) { addSign("*"); }
        private void buttonSub_Click(object sender, RoutedEventArgs e) { addSign("-"); }
        private void buttonAdd_Click(object sender, RoutedEventArgs e) { addSign("+"); }
        private void buttonResult_Click(object sender, RoutedEventArgs e)
        {   
            this.resultBox.Text = new DataTable().Compute(this.resultBox.Text, null).ToString();
            this.currentBox.Text = null;            
        }
        private void buttonCE_Click(object sender, RoutedEventArgs e)
        {
            this.currentBox.Text = null;
        }
        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            this.currentBox.Text = null;
            this.resultBox.Text= null;
        }
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (this.currentBox.Text != "")
            {
                int ind = this.currentBox.Text.Length - 1;
                this.currentBox.Text = this.currentBox.Text.Remove(ind, 1);
                int ind2 = this.resultBox.Text.Length - 1;
                this.resultBox.Text = this.resultBox.Text.Remove(ind2, 1);
            }
        }
        private void addDigit(string digit)
        {
            this.currentBox.Text += digit;
            this.resultBox.Text += digit;
        }
        private void addSign(string sign)
        {
            if (!resultBox.Text.EndsWith("*") && !resultBox.Text.EndsWith("/") && !resultBox.Text.EndsWith("-")
                && !resultBox.Text.EndsWith("+"))
            {
                this.resultBox.Text += sign;
                this.currentBox.Text = null;
            }
        }
    }
}
