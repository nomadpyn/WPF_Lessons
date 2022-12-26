using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public class QuizData
    {
        public string? Question { get; set; }
        public string? [] Answers { get; set; }
        public QuizData() { }
        public QuizData(string? question, string? answerCorrect, string? answerIncorrect1, string? answerIncorrect2, string? answerIncorrect3)
        {
            Question = question;
            Answers = new string[] {answerCorrect,answerIncorrect1,answerIncorrect2,answerIncorrect3};
           
        }
    }
}
