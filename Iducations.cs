using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andrii
{
    public partial class Iducations : Form
    {
        private string[] imagePaths;
        private int currentImageIndex = 0;

        public Iducations()
        {
            InitializeComponent();
            InitializeImagePaths();
        }

        private void InitializeImagePaths()
        {
            // Ініціалізуйте масив шляхів до зображень
            imagePaths = new string[]
            {
                "D:\\Нова папка\\Andrii\\Image\\one.png",
                "D:\\Нова папка\\Andrii\\Image\\two.png",
                "D:\\Нова папка\\Andrii\\Image\\three.png",
                "D:\\Нова папка\\Andrii\\Image\\fo.png",
                "D:\\Нова папка\\Andrii\\Image\\five.png",
                "D:\\Нова папка\\Andrii\\Image\\six.png"
                // Додайте інші шляхи до зображень за потреби
            };

            // Встановіть початкове зображення
            if (imagePaths.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(imagePaths[currentImageIndex]);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (btnUp.Text == "Почати тест")
            {
                // Відкриваємо нову форму для тесту
                Test testForm = new Test();
                testForm.Show();
                this.Hide(); // Приховуємо поточну форму
                return;
            }

            currentImageIndex++;

            // Якщо індекс перевищує кількість зображень, поверніть його до нуля
            if (currentImageIndex >= imagePaths.Length)
            {
                currentImageIndex = 0;
            }

            // Встановіть нове зображення для PictureBox
            pictureBox1.Image = Image.FromFile(imagePaths[currentImageIndex]);

            // Якщо ми на останньому зображенні, змінюємо текст кнопки
            if (currentImageIndex == imagePaths.Length - 1)
            {
                btnUp.Text = "Почати тест";
            }
            else
            {
                // Якщо ми не на останньому зображенні, повертаємо стандартний текст
                btnUp.Text = "Далі";
            }
        }
    }
}
