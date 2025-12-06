namespace Tyuiu.KolganenkoRV.Sprint6.Task7.V27
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox_KRV = new PictureBox();
            labelinfo_KRV = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_KRV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_KRV
            // 
            pictureBox_KRV.Image = (Image)resources.GetObject("pictureBox_KRV.Image");
            pictureBox_KRV.Location = new Point(23, 23);
            pictureBox_KRV.Name = "pictureBox_KRV";
            pictureBox_KRV.Size = new Size(184, 184);
            pictureBox_KRV.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_KRV.TabIndex = 1;
            pictureBox_KRV.TabStop = false;
            // 
            // labelinfo_KRV
            // 
            labelinfo_KRV.AutoSize = true;
            labelinfo_KRV.Location = new Point(257, 23);
            labelinfo_KRV.Name = "labelinfo_KRV";
            labelinfo_KRV.Size = new Size(302, 90);
            labelinfo_KRV.TabIndex = 2;
            labelinfo_KRV.Text = "Разработчик: Колганенко Р.В.\r\nгруппа ИБКСб-25-1\r\n\r\nПрограмма разработана в рамках изучения языка С#\r\n\r\nТюменский индустриальный университет \r\n";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 244);
            Controls.Add(labelinfo_KRV);
            Controls.Add(pictureBox_KRV);
            Name = "FormAbout";
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox_KRV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_KRV;
        private Label labelinfo_KRV;
    }
}