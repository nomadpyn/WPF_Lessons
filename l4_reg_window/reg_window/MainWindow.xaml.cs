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

namespace reg_window
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
// список пользователей
        List<User> users;
        public MainWindow()
        {
            InitializeComponent();
        }
// обработка нажатия кпопки Зарегистрироваться, проверка на правильность ввода данных, и вывод ошибок пользователю
        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (loginBox.Text.Length < 4)
            {
                loginBox.ToolTip = "Слишком короткий логин";
                loginBox.Background = Brushes.IndianRed;
            }
            else if (passwordBox1.Password.Length < 6)
            {
                byDefault(ref loginBox, 'l');
                passwordBox1.ToolTip = "Слишком короткий пароль";
                passwordBox1.Background = Brushes.IndianRed;
            }
            else if(passwordBox1.Password != passwordBox2.Password)
            {
                byDefault(ref passwordBox1, 1);
                passwordBox2.ToolTip = "Пароли не совпадают";
                passwordBox2.Background = Brushes.IndianRed;
            }
            else if(!emailBox.Text.Contains("@") || !emailBox.Text.Contains(".ru"))
            {
                byDefault(ref passwordBox2, 2);
                emailBox.ToolTip = "E-Mail введен неправильно";
                emailBox.Background = Brushes.IndianRed;
            }
            else
            {
                byDefault(ref emailBox, 'e');
                if (checkLogin())
                {
                    users.Add(new User(loginBox.Text, passwordBox2.Password, emailBox.Text));
                    MessageBox.Show("Вы успешно зарегистрированы", "Поздравляем");
                    clearForm();

                }
                else
                {
                    MessageBox.Show("Такой пользователь уже существует", "Ошибка");
                }
            }
        }
// метод возвращающий TextBox в форме к первоначальному виду
        private void byDefault(ref TextBox obj, char name)
        {
            if (name == 'l')
            {
                obj.ToolTip = "Не менее 4 символов";                
            }
            if (name == 'e')
            {
                obj.ToolTip = "Только в домене .ru";
            }
            obj.Background = Brushes.Transparent;
        }
// метод возвращающий PasswordBox в форме к первоначальному виду
        private void byDefault(ref PasswordBox obj, byte name)
        {
            if (name == 1)
            {
                obj.ToolTip = "Не менее 6 символов";
            }
            if (name == 2)
            {
                obj.ToolTip = "Пароли должны совпадать";
            }
            obj.Background = Brushes.Transparent;
        }
// метод проверки на существование пользователя с таким именем
        private bool checkLogin()
        {
            foreach(User u in this.users)
            {
                if (u.Name == loginBox.Text)
                {
                    return false;
                }
            }
            return true;
        }
// метод очистки данных в форме
        private void clearForm()
        {
            loginBox.Text = null;
            passwordBox1.Password = null;
            passwordBox2.Password = null;
            emailBox.Text = null;
        }
// загрузка списка пользователей при старте программы
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            users = FileIO.LoadFile();
        }
// сохранения списка пользователей при закрытии программы
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FileIO.SaveFile(users);
        }
    }
}
