using System;
using System.Drawing;
using System.Windows.Forms;

namespace Andrii
{
    public partial class Test : Form
    {
        private string[][] answers;
        private int currentQuestionIndex = 0;
        private Color winColor = Color.Lime; 
        private Color loseColor = Color.Red; 
        private int displayTimeInSeconds = 3; 
        private int score = 0; 

        private Panel colorPanel; 
        private PictureBox pictureBox; 
        private System.Windows.Forms.Timer timer; 

        private string[] imagePaths = new string[]
        {
            "D:\\Нова папка\\Andrii\\Image\\test1.png",
            "D:\\Нова папка\\Andrii\\Image\\test2.png",
            "D:\\Нова папка\\Andrii\\Image\\test3.png",
            "D:\\Нова папка\\Andrii\\Image\\test4.png",
            "D:\\Нова папка\\Andrii\\Image\\test5.png",
            "D:\\Нова папка\\Andrii\\Image\\test6.png",
            "D:\\Нова папка\\Andrii\\Image\\test7.png",
            "D:\\Нова папка\\Andrii\\Image\\test8.png",
            "D:\\Нова папка\\Andrii\\Image\\test9.png",
            "D:\\Нова папка\\Andrii\\Image\\test10.png"
        };

        private int[] correctAnswers = { 0, 1, 2, 3, 1, 0, 0, 1, 3, 2 };

        public Test()
        {
            InitializeComponent();
            InitializeQuestionsAndAnswers();
            InitializeColorPanel();
            InitializePictureBox();
            InitializeTimer();
            DisplayQuestion();
        }

        private void InitializeQuestionsAndAnswers()
        {
           
            answers = new string[][]
            {
                new string[] { "Додати їх модулі", "Відняти їх модулі", "Нічого не робити", "Поставити після дорівнює +" },
                new string[] { "додатнє число", "від'ємне число", "нуль", "1" },
                new string[] { "-4 очки", "6 очок", "-6 очок", "4 очки" },
                new string[] { "-2", "2", "4", "-4" },
                new string[] { "-2", "-3", "3", "-1" },
                new string[] { "-80", "80", "79", "81" },
                new string[] { "0", "10", "-10", "5" },
                new string[] { "4", "-4", "5", "-5" },
                new string[] { "-2", "-1", "2", "1" },
                new string[] { "-2", "2", "3", "-3" }
            };
        }

        private void InitializeColorPanel()
        {
          
            colorPanel = new Panel();
            colorPanel.Dock = DockStyle.Fill;
            Controls.Add(colorPanel);
        }

        private void InitializePictureBox()
        {
       
            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(pictureBox);
        }

        private void InitializeTimer()
        {
          
            timer = new System.Windows.Forms.Timer();
            timer.Interval = displayTimeInSeconds * 1000; 
            timer.Tick += Timer_Tick;
        }

        private void DisplayQuestion()
        {
           
            colorPanel.BackColor = SystemColors.Control;

            button1.Text = answers[currentQuestionIndex][0];
            button2.Text = answers[currentQuestionIndex][1];
            button3.Text = answers[currentQuestionIndex][2];
            button4.Text = answers[currentQuestionIndex][3];

            pictureBox.Image = null;

            pictureBox1.Image = Image.FromFile(imagePaths[currentQuestionIndex]);
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            int buttonIndex = -1;
            if (clickedButton == button1)
            {
                buttonIndex = 0;
            }
            else if (clickedButton == button2)
            {
                buttonIndex = 1;
            }
            else if (clickedButton == button3)
            {
                buttonIndex = 2;
            }
            else if (clickedButton == button4)
            {
                buttonIndex = 3;
            }

            int correctAnswerIndex = correctAnswers[currentQuestionIndex];
            string correctAnswer = answers[currentQuestionIndex][correctAnswerIndex];

            if (buttonIndex == correctAnswerIndex)
            {
                DisplayColor(winColor);

                score++;
            }
            else
            {
                DisplayColor(loseColor);
            }

            pictureBox.Image = null;

            pictureBox.Image = Image.FromFile(imagePaths[currentQuestionIndex]);

            timer.Start();
        }

        private void DisplayColor(Color color)
        {
            colorPanel.BackColor = color;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            colorPanel.BackColor = SystemColors.Control;

            currentQuestionIndex++;

            if (currentQuestionIndex >= answers.Length)
            {
                ShowResultForm();
            }
            else
            {
                DisplayQuestion();
            }
        }

        private void ShowResultForm()
        {
            ResultForm resultForm = new ResultForm(score);
            resultForm.ShowDialog(); 

 
            score = 0;
            currentQuestionIndex = 0;

   
            DisplayQuestion();
        }
    }
}
