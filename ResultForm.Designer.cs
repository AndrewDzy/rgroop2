namespace Andrii
{
    partial class ResultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblScore = new Label();
            teg = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblScore.Location = new Point(187, 82);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(91, 38);
            lblScore.TabIndex = 0;
            lblScore.Text = "label1";
            // 
            // teg
            // 
            teg.AutoSize = true;
            teg.BackColor = SystemColors.ActiveCaption;
            teg.Font = new Font("Wide Latin", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teg.Location = new Point(84, 9);
            teg.Name = "teg";
            teg.Size = new Size(504, 46);
            teg.TabIndex = 1;
            teg.Text = "Молодець твій результат";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(187, 184);
            button1.Name = "button1";
            button1.Size = new Size(256, 75);
            button1.TabIndex = 2;
            button1.Text = "Перейти до навчання";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(689, 271);
            Controls.Add(button1);
            Controls.Add(teg);
            Controls.Add(lblScore);
            Name = "ResultForm";
            Text = "ResultForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private Label teg;
        private Button button1;
    }
}