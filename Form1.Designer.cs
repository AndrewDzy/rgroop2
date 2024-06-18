namespace Andrii
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGO = new Button();
            btnTest = new Button();
            SuspendLayout();
            // 
            // btnGO
            // 
            btnGO.BackColor = SystemColors.ActiveCaption;
            btnGO.FlatStyle = FlatStyle.Flat;
            btnGO.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnGO.Location = new Point(295, 270);
            btnGO.Name = "btnGO";
            btnGO.Size = new Size(253, 70);
            btnGO.TabIndex = 0;
            btnGO.Text = "Почати навчання";
            btnGO.UseVisualStyleBackColor = false;
            btnGO.Click += btnGO_Click;
            // 
            // btnTest
            // 
            btnTest.BackColor = SystemColors.ActiveCaption;
            btnTest.FlatStyle = FlatStyle.Flat;
            btnTest.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnTest.Location = new Point(580, 270);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(276, 70);
            btnTest.TabIndex = 1;
            btnTest.Text = "Перевірити знання";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += btnTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1059, 585);
            Controls.Add(btnTest);
            Controls.Add(btnGO);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGO;
        private Button btnTest;
    }
}
