using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class QuizEngine
    {
        // the static instance for others classes to access this class
        public static QuizEngine Instance = new QuizEngine();
        // this contains the list of all question which are read from the file
        public List<QuizQuestion> QuizQuestions;
        // the file name that you have to read from the questions
        private const string FileName = "gameData.txt";
        // current question number index that is asked  
        public int CurrentQuestion = 0;
        // total score that is attained by the user
        public int Score = 0;
        //constructor
        private QuizEngine()
        {
            QuizQuestions = new List<QuizQuestion>();
        }
        // this will load file and make a list of all question that are in the file 
        public bool LoadFile()
        {
            try
            {
                string[] lines = File.ReadAllLines(FileName);// this will read all lines in a files
                for (int i = 0; i < lines.Length; i++) // loop through each line
                {
                    string[] parts = lines[i].Split(';'); // divide a single line(question) on ';'
                    int qno = int.Parse(parts[0]); // the first divided part 
                    int type = int.Parse(parts[1]); // the second divided part
                    string question = parts[2];// the third divided part
                    string answer = parts[3];// the forth divided part
                    string[] options = parts[4].Split('/'); // the fifth is the options that are separated by '/'
                    string imageName = ""; // image name
                    if (type == 2 || type == 4) // if it is image then the last argument will be set else it will be null
                        imageName = parts[5];
                    QuizQuestion quizQuestion;
                    if (type == 3 || type == 4) // if question is true/false
                    {
                        quizQuestion = new QuizQuestion(qno, type, question, answer, options[0], "", "", options[1], imageName);
                    }
                    else // if question is mcq
                    {
                        quizQuestion = new QuizQuestion(qno, type, question, answer, options[0], options[1], options[2], options[3], imageName);
                    }
                    Console.WriteLine(quizQuestion.Question);
                    QuizQuestions.Add(quizQuestion); // store this into the list
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
