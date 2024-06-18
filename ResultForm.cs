using System;
using System.Windows.Forms;

namespace Andrii
{
    public partial class ResultForm : Form
    {
        private int score;

        public ResultForm(int score)
        {
            InitializeComponent();
            this.score = score;
            lblScore.Text = $"Ваш рахунок: {score} з 10";

            // Визначаємо текст для teg в залежності від результату
            if (score > 5)
            {
                teg.Text = "Молодець! Твій результат:";
                button1.Visible = false; // Приховуємо кнопку навчання
            }
            else
            {
                teg.Text = "Потрібно вивчити матеріал!";
                button1.Visible = true; // Показуємо кнопку навчання
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Закриваємо форму з результатами
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var educationForm = new Iducations();
            educationForm.Show();
        }
    }
}
