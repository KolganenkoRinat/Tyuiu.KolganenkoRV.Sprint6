namespace Tyuiu.KolganenkoRV.Sprint6.Task0.V9
{
    partial class Formmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formmain));
            helpProvider1 = new HelpProvider();
            groupBoxTask_KRV = new GroupBox();
            pictureBoxFormuls_KRV = new PictureBox();
            textBoxTask_KRV = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBoxOutPut_KRV = new TextBox();
            groupBoxInPut_KRV = new GroupBox();
            textBoxInPut_KRV = new TextBox();
            textBoxX_KRV = new TextBox();
            groupBoxOutPut_KRV = new GroupBox();
            textBoxRes_KRV = new TextBox();
            buttonStart_KRV = new Button();
            buttoninfo_KRV = new Button();
            groupBoxTask_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormuls_KRV).BeginInit();
            groupBoxInPut_KRV.SuspendLayout();
            groupBoxOutPut_KRV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KRV
            // 
            groupBoxTask_KRV.Controls.Add(pictureBoxFormuls_KRV);
            groupBoxTask_KRV.Controls.Add(textBoxTask_KRV);
            groupBoxTask_KRV.Location = new Point(12, 12);
            groupBoxTask_KRV.Name = "groupBoxTask_KRV";
            groupBoxTask_KRV.Size = new Size(603, 222);
            groupBoxTask_KRV.TabIndex = 0;
            groupBoxTask_KRV.TabStop = false;
            groupBoxTask_KRV.Text = "Условие";
            groupBoxTask_KRV.Enter += groupBox1_Enter;
            // 
            // pictureBoxFormuls_KRV
            // 
            pictureBoxFormuls_KRV.Image = (Image)resources.GetObject("pictureBoxFormuls_KRV.Image");
            pictureBoxFormuls_KRV.Location = new Point(467, 22);
            pictureBoxFormuls_KRV.Name = "pictureBoxFormuls_KRV";
            pictureBoxFormuls_KRV.Size = new Size(106, 61);
            pictureBoxFormuls_KRV.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFormuls_KRV.TabIndex = 1;
            pictureBoxFormuls_KRV.TabStop = false;
            // 
            // textBoxTask_KRV
            // 
            textBoxTask_KRV.Location = new Point(6, 22);
            textBoxTask_KRV.Multiline = true;
            textBoxTask_KRV.Name = "textBoxTask_KRV";
            textBoxTask_KRV.ReadOnly = true;
            textBoxTask_KRV.Size = new Size(434, 184);
            textBoxTask_KRV.TabIndex = 2;
            textBoxTask_KRV.Text = "Вычеслите выражение по формуле";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(18, 240);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(126, 23);
            maskedTextBox1.TabIndex = 2;
            // 
            // textBoxOutPut_KRV
            // 
            textBoxOutPut_KRV.Location = new Point(9, 60);
            textBoxOutPut_KRV.Name = "textBoxOutPut_KRV";
            textBoxOutPut_KRV.ReadOnly = true;
            textBoxOutPut_KRV.Size = new Size(205, 23);
            textBoxOutPut_KRV.TabIndex = 3;
            // 
            // groupBoxInPut_KRV
            // 
            groupBoxInPut_KRV.Controls.Add(textBoxInPut_KRV);
            groupBoxInPut_KRV.Controls.Add(textBoxX_KRV);
            groupBoxInPut_KRV.Location = new Point(12, 240);
            groupBoxInPut_KRV.Name = "groupBoxInPut_KRV";
            groupBoxInPut_KRV.Size = new Size(312, 113);
            groupBoxInPut_KRV.TabIndex = 4;
            groupBoxInPut_KRV.TabStop = false;
            groupBoxInPut_KRV.Text = "Ввод данных:";
            // 
            // textBoxInPut_KRV
            // 
            textBoxInPut_KRV.Location = new Point(9, 70);
            textBoxInPut_KRV.Name = "textBoxInPut_KRV";
            textBoxInPut_KRV.Size = new Size(266, 23);
            textBoxInPut_KRV.TabIndex = 6;
            textBoxInPut_KRV.KeyPress += textBoxInPut_KRV_KeyPress;
            // 
            // textBoxX_KRV
            // 
            textBoxX_KRV.Location = new Point(6, 29);
            textBoxX_KRV.Multiline = true;
            textBoxX_KRV.Name = "textBoxX_KRV";
            textBoxX_KRV.ReadOnly = true;
            textBoxX_KRV.Size = new Size(96, 25);
            textBoxX_KRV.TabIndex = 5;
            textBoxX_KRV.Text = "Переменная X:";
            // 
            // groupBoxOutPut_KRV
            // 
            groupBoxOutPut_KRV.Controls.Add(textBoxOutPut_KRV);
            groupBoxOutPut_KRV.Controls.Add(textBoxRes_KRV);
            groupBoxOutPut_KRV.Location = new Point(390, 240);
            groupBoxOutPut_KRV.Name = "groupBoxOutPut_KRV";
            groupBoxOutPut_KRV.Size = new Size(225, 113);
            groupBoxOutPut_KRV.TabIndex = 5;
            groupBoxOutPut_KRV.TabStop = false;
            groupBoxOutPut_KRV.Text = "Вывод данных:";
            // 
            // textBoxRes_KRV
            // 
            textBoxRes_KRV.Location = new Point(11, 29);
            textBoxRes_KRV.Multiline = true;
            textBoxRes_KRV.Name = "textBoxRes_KRV";
            textBoxRes_KRV.ReadOnly = true;
            textBoxRes_KRV.Size = new Size(71, 19);
            textBoxRes_KRV.TabIndex = 4;
            textBoxRes_KRV.Text = "Результат:";
            // 
            // buttonStart_KRV
            // 
            buttonStart_KRV.Location = new Point(458, 360);
            buttonStart_KRV.Name = "buttonStart_KRV";
            buttonStart_KRV.Size = new Size(146, 42);
            buttonStart_KRV.TabIndex = 5;
            buttonStart_KRV.Text = "Выполнить";
            buttonStart_KRV.UseVisualStyleBackColor = true;
            buttonStart_KRV.Click += buttonStart_KRV_Click;
            // 
            // buttoninfo_KRV
            // 
            buttoninfo_KRV.Location = new Point(401, 360);
            buttoninfo_KRV.Name = "buttoninfo_KRV";
            buttoninfo_KRV.Size = new Size(46, 42);
            buttoninfo_KRV.TabIndex = 5;
            buttoninfo_KRV.Text = "?";
            buttoninfo_KRV.UseVisualStyleBackColor = true;
            buttoninfo_KRV.Click += buttoninfo_KRV_Click;
            // 
            // Formmain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 414);
            Controls.Add(buttoninfo_KRV);
            Controls.Add(buttonStart_KRV);
            Controls.Add(groupBoxInPut_KRV);
            Controls.Add(maskedTextBox1);
            Controls.Add(groupBoxTask_KRV);
            Controls.Add(groupBoxOutPut_KRV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Formmain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "c";
            Load += Formmain_Load;
            groupBoxTask_KRV.ResumeLayout(false);
            groupBoxTask_KRV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormuls_KRV).EndInit();
            groupBoxInPut_KRV.ResumeLayout(false);
            groupBoxInPut_KRV.PerformLayout();
            groupBoxOutPut_KRV.ResumeLayout(false);
            groupBoxOutPut_KRV.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HelpProvider helpProvider1;
        private GroupBox groupBoxTask_KRV;
        private PictureBox pictureBoxFormuls_KRV;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBoxOutPut_KRV;
        private TextBox textBoxTask_KRV;
        private GroupBox groupBoxInPut_KRV;
        private TextBox textBoxX_KRV;
        private GroupBox groupBoxOutPut_KRV;
        private TextBox textBoxRes_KRV;
        private Button buttonStart_KRV;
        private Button buttoninfo_KRV;
        private TextBox textBoxInPut_KRV;
    }
}
