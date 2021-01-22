using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    // Data structure to save question
    class QuizQuestion
    {
        public int QuestionNumber;
        public int QuestionType;
        public string Question;
        public string Answer;
        public string Option1;
        public string Option2;
        public string Option3;
        public string Option4;
        public string PictureName;

        // Constructor to save question
        public QuizQuestion(int questionNumber, int questionType, string question, string answer, string option1, string option2, string option3, string option4, string pictureName)
        {
            QuestionNumber = questionNumber;
            QuestionType = questionType;
            Question = question;
            Answer = answer;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            Option4 = option4;
            PictureName = pictureName;

        }

    }
}
