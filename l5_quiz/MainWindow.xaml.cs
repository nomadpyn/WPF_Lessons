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
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                addDataToTab(i);
            }
        }
        private void addDataToTab(int index)
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

    }
}
