using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        // the class responsilble for providing data to the front end
        private QuizEngine _quizEngine = QuizEngine.Instance;

        private Color ORANGE_COLOR = Color.FromArgb(233, 130, 48);
        private Color WHITE_COLOR = Color.FromArgb(204, 220, 231);
        private bool completed = false;
        public Form1()
        {
            // this will initialize the components
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this will call the function from the quiz engine class and load the file
            QuizEngine.Instance.LoadFile(); // this will load the file
            _quizEngine.Score = 0; // this will set the score to zero
            _quizEngine.CurrentQuestion = 0; // this will set current question to zero
            Next_Question(); // will render/ update the require label to run the question
        }

        private void Next_Question()
        {
            // if the current question is less then the total question in the list
            if (_quizEngine.CurrentQuestion < _quizEngine.QuizQuestions.Count)
            {
                QuizQuestion quizQuestion = _quizEngine.QuizQuestions[_quizEngine.CurrentQuestion];
                QuestionNoLabel.Text = @"Question " + quizQuestion.QuestionNumber;
                QuestionTextBox1.Text = quizQuestion.Question;
                OptionRadioButton1.Text = quizQuestion.Option1;
                OptionRadioButton2.Text = quizQuestion.Option2;
                OptionRadioButton3.Text = quizQuestion.Option3;
                OptionRadioButton4.Text = quizQuestion.Option4;
                ScoreLabel.Text = @"SCORE : " + _quizEngine.Score;
                if (quizQuestion.QuestionType == 3 || quizQuestion.QuestionType == 4)
                {
                    OptionRadioButton2.Visible = false;
                    OptionRadioButton3.Visible = false;
                }
                else
                {
                    OptionRadioButton2.Visible = true;
                    OptionRadioButton3.Visible = true;
                }
                if (quizQuestion.QuestionType == 2 || quizQuestion.QuestionType == 4)
                {
                    PictureBox.Visible = true;
                    PictureBox.Image = Image.FromFile(quizQuestion.PictureName);
                }
                else
                {
                    PictureBox.Visible = false;
                }
                _quizEngine.CurrentQuestion++;
            }
            else // or it means that all the question are solved
            {
                // this will generate a dialog box that will tell that the total score and will ask to start a new game
                DialogResult res = MessageBox.Show(@"Your Score is " + _quizEngine.Score + @" Do you want to Restart", @"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    Form1 form1 = new Form1(); // create new form
                    form1.ShowDialog(); // start the new form
                    Close(); // close the current form

                }
                if (res == DialogResult.No)
                {
                    Close(); // this will close this form
                }
            }
        }

        private void Check_Question(int option)
        {
            // this will get the current question the is asked
            QuizQuestion quizQuestion = _quizEngine.QuizQuestions[_quizEngine.CurrentQuestion - 1];
            // if the option is one and the correct answer is one then this will update the score
            if (quizQuestion.Option1.Equals(quizQuestion.Answer))
            {
                OptionRadioButton1.BackColor = Color.LimeGreen;
                if(1==option)
                    Add_score();
            }
            // if the option is two and the correct answer is two then this will update the score
            else if (OptionRadioButton2.Text.Equals(quizQuestion.Answer))
            {
                OptionRadioButton2.BackColor = Color.LimeGreen;
                if (2 == option)
                    Add_score();
            }
            // if the option is three and the correct answer is three then this will update the score
            else if (OptionRadioButton3.Text.Equals(quizQuestion.Answer))
            {
                OptionRadioButton3.BackColor = Color.LimeGreen;
                if (3 == option)
                    Add_score();
            }
            // if the option is four and the correct answer is four then this will update the score
            else if (OptionRadioButton4.Text.Equals(quizQuestion.Answer))
            {
                OptionRadioButton4.BackColor = Color.LimeGreen;
                if (4 == option)
                    Add_score();
            }
            else // this will be for wrong answer
            {
                Console.WriteLine(@"Wrong Answer");
            }
        }

        public void Add_score() 
        {
            // add the score and update it to the UI
            _quizEngine.Score++;
            ScoreLabel.Text = @"SCORE : " + _quizEngine.Score;
            completed = true;
        }

        // When next button is clicked
        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            Next_Question();
            All_Reset();
        }

        // when option one is clicked
        private void OptionRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            OptionRadioButton1.BackColor = Color.Red;
            AllOptionFalse();
            Check_Question(1);
            Disable_Options();
            //uncheck the radio button
            OptionRadioButton1.Checked = false;
            NextQuestionButton.Enabled = true;
        }

        private void OptionRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            OptionRadioButton2.BackColor = Color.Red;
            AllOptionFalse();
            Check_Question(2);
            Disable_Options();
            OptionRadioButton2.Checked = false;
            NextQuestionButton.Enabled = true;
        }

        private void OptionRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            OptionRadioButton3.BackColor = Color.Red;
            AllOptionFalse();
            Check_Question(3);
            Disable_Options();
            OptionRadioButton3.Checked = false;
            NextQuestionButton.Enabled = true;

        }

        private void OptionRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            OptionRadioButton4.BackColor = Color.Red;
            AllOptionFalse();
            Check_Question(4);
            Disable_Options();
            OptionRadioButton4.Checked = false;
            NextQuestionButton.Enabled = true;

        }

        void AllOptionFalse()
        {
            // uncheck all option radio buttons
            OptionRadioButton1.Checked = false;
            OptionRadioButton2.Checked = false;
            OptionRadioButton3.Checked = false;
            OptionRadioButton4.Checked = false;
        }

        void All_Reset()
        {
            // reset the back color to orange of the options
            OptionRadioButton1.BackColor = ORANGE_COLOR;
            OptionRadioButton2.BackColor = ORANGE_COLOR;
            OptionRadioButton3.BackColor = ORANGE_COLOR;
            OptionRadioButton4.BackColor = ORANGE_COLOR;
            OptionRadioButton1.Checked = false;
            OptionRadioButton2.Checked = false;
            OptionRadioButton3.Checked = false;
            OptionRadioButton4.Checked = false;
            NextQuestionButton.Enabled = false;
            OptionRadioButton1.Enabled = true;
            OptionRadioButton2.Enabled = true;
            OptionRadioButton3.Enabled = true;
            OptionRadioButton4.Enabled = true;
        }

        void Disable_Options()
        {
            //disable all the options
            OptionRadioButton1.Enabled = false;
            OptionRadioButton2.Enabled = false;
            OptionRadioButton3.Enabled = false;
            OptionRadioButton4.Enabled = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // closes the form1
            this.Close();
        }
    }
}
