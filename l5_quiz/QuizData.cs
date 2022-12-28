using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
// класс для храненя данных о вопросе 
    public class QuizData
    {
// переменная для хранения вопроса
        public string? Question { get; set; }
// массив ответов индекс 0 правильный ответ, остальные неправильные
        public string? [] Answers { get; set; }
// конструктор по умолчанию
        public QuizData() { }
// конструктор с параметрами
        public QuizData(string? question, string? answerCorrect, string? answerIncorrect1, string? answerIncorrect2, string? answerIncorrect3)
        {
            Question = question;
            Answers = new string[] {answerCorrect,answerIncorrect1,answerIncorrect2,answerIncorrect3};
           
        }
    }
}
