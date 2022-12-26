using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<QuizData> data = new List<QuizData>
        {
            new QuizData("Кто глава дома Симпсонов?","Гомер","Барни","Мо","Мэгги"),
            new QuizData("Сколько сезонов на данный момент?","33","1","15","21"),
            new QuizData("Кем никогда не работал Гомер?","Разработчик","Астронавт","Бармен","Телохранитель"),
            new QuizData("Как звали рыжего суперзлодея?","Скорпио","Бонд","Золотой Глаз","Бен"),
            new QuizData("Какого цвета у Мардж машина?","Красная","Синяя","Белая","Желтая"),
            new QuizData("Кто средний по возрасту из Симпсонов","Барт","Мэгги","Лиза","Гомер")
        };
        string[] answers = new string[6]; 
        public MainWindow()
        {
            InitializeComponent();

            for (byte i = 0; i < 6; i++)
            {
                addDataToTab(i);
            }
        }
        private void addDataToTab(byte index)
        {
            object wantedTextBlock = tabs.FindName($"tab{index+1}_quest");
            if(wantedTextBlock is TextBlock)
            {
                TextBlock wantedChild = wantedTextBlock as TextBlock;
                wantedChild.Text = data[index].Question;
            }
            int[] arr = new int []{ 0, 1, 2, 3 };
            Random rnd = new Random();
            int[] RandomArray = arr.OrderBy(x => rnd.Next()).ToArray();
            for (int i = 1; i <= 4; i++)
            {
                object wantedButton = tabs.FindName($"tab{index+1}_answer{i}");
                if (wantedButton is Button)
                {
                    Button wantedChild = wantedButton as Button;
                    
                    wantedChild.Content = data[index].Answers[RandomArray[i-1]];
                }
            }
        }

        private void addProgress(byte tab, byte choise)
        {
            for (int i = 1; i <= 4; i++)
            {
                object wantedButton = tabs.FindName($"tab{tab}_answer{i}");
                if (wantedButton is Button)
                {
                    Button wantedChild = wantedButton as Button;
                    if (i == choise)
                    {
                        answers[tab-1] = wantedChild.Content.ToString();
                        wantedChild.Background = Brushes.LightSlateGray;
                        continue;
                    }

                    wantedChild.IsEnabled = false;
                }
            }
            progress.Value++;
        }
        private void tab1_answer1_Click(object sender, RoutedEventArgs e)
        {
            addProgress(1, 1);
        }

        private void tab1_answer2_Click(object sender, RoutedEventArgs e)
        {
            addProgress(1, 2);
        }

        private void tab1_answer3_Click(object sender, RoutedEventArgs e)
        {
            addProgress(1, 3);
        }

        private void tab1_answer4_Click(object sender, RoutedEventArgs e)
        {
            addProgress(1, 4);
        }

        private void tab2_answer1_Click(object sender, RoutedEventArgs e)
        {
            addProgress(2, 1);
        }

        private void tab2_answer2_Click(object sender, RoutedEventArgs e)
        {
            addProgress(2, 2);
        }

        private void tab2_answer3_Click(object sender, RoutedEventArgs e)
        {
            addProgress(2, 3);
        }

        private void tab2_answer4_Click(object sender, RoutedEventArgs e)
        {
            addProgress(2, 4);
        }

        private void tab3_answer1_Click(object sender, RoutedEventArgs e)
        {
            addProgress(3, 1);
        }

        private void tab3_answer2_Click(object sender, RoutedEventArgs e)
        {
            addProgress(3, 2);
        }

        private void tab3_answer3_Click(object sender, RoutedEventArgs e)
        {
            addProgress(3, 3);
        }

        private void tab3_answer4_Click(object sender, RoutedEventArgs e)
        {
            addProgress(3,4);
        }

        private void tab4_answer1_Click(object sender, RoutedEventArgs e)
        {
            addProgress(4, 1);
        }

        private void tab4_answer2_Click(object sender, RoutedEventArgs e)
        {
            addProgress(4, 2);
        }

        private void tab4_answer3_Click(object sender, RoutedEventArgs e)
        {
            addProgress(4, 3);
        }

        private void tab4_answer4_Click(object sender, RoutedEventArgs e)
        {
            addProgress(4, 4);
        }

        private void tab5_answer1_Click(object sender, RoutedEventArgs e)
        {
            addProgress(5, 1);
        }

        private void tab5_answer2_Click(object sender, RoutedEventArgs e)
        {
            addProgress(5, 2);
        }

        private void tab5_answer3_Click(object sender, RoutedEventArgs e)
        {
            addProgress(5, 3);
        }

        private void tab5_answer4_Click(object sender, RoutedEventArgs e)
        {
            addProgress(5, 4);
        }

        private void tab6_answer1_Click(object sender, RoutedEventArgs e)
        {
            addProgress(6, 1);
        }

        private void tab6_answer2_Click(object sender, RoutedEventArgs e)
        {
            addProgress(6, 2);
        }

        private void tab6_answer3_Click(object sender, RoutedEventArgs e)
        {
            addProgress(6, 3);
        }

        private void tab6_answer4_Click(object sender, RoutedEventArgs e)
        {
            addProgress(6, 4);
        }

        private void progress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (progress.Value == 6)
            {
                EndAnswer.IsEnabled = true;
            }
        }

        private void EndAnswer_Click(object sender, RoutedEventArgs e)
        {
             MessageBox.Show(Points());
            this.Close();
        }
        private string Points()
        {
            byte point = 0;
            for(byte i = 0; i < 6; i++)
            {
                if (answers[i] == data[i].Answers[0])
                    point++;
            }
            if (point == 5 || point == 6)
                return $"Вы отлично знаете!\n {point} из 6";
            else if (point == 3 || point == 4)
                return $"Вы хорошо знаете!\n {point} из 6";
            else 
                return $"Вы плохо знаете!\n {point} из 6";

        }
    }
}
