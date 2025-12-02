namespace Tyuiu.KolganenkoRV.Sprint6.Task1.V13
{
    partial class FormMain
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
            groupBoxTask_KRV = new GroupBox();
            textBoxTask_KRV = new TextBox();
            groupBox2 = new GroupBox();
            textBoxPutEnd_KRV = new TextBox();
            textBoxPutStart_KRV = new TextBox();
            TexBoxEnd_KRV = new TextBox();
            textBoxStart_KRV = new TextBox();
            groupBoxRes_KRV = new GroupBox();
            textBoxResult_KRV = new TextBox();
            textBoxRes_KRV = new TextBox();
            buttoninfo_KRV = new Button();
            buttonStart_KRV = new Button();
            groupBoxTask_KRV.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxRes_KRV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KRV
            // 
            groupBoxTask_KRV.Controls.Add(textBoxTask_KRV);
            groupBoxTask_KRV.Location = new Point(10, 13);
            groupBoxTask_KRV.Name = "groupBoxTask_KRV";
            groupBoxTask_KRV.Size = new Size(501, 294);
            groupBoxTask_KRV.TabIndex = 0;
            groupBoxTask_KRV.TabStop = false;
            groupBoxTask_KRV.Text = "Условие:";
            groupBoxTask_KRV.Enter += groupBoxTask_KRV_Enter;
            // 
            // textBoxTask_KRV
            // 
            textBoxTask_KRV.Location = new Point(0, 22);
            textBoxTask_KRV.Multiline = true;
            textBoxTask_KRV.Name = "textBoxTask_KRV";
            textBoxTask_KRV.ReadOnly = true;
            textBoxTask_KRV.Size = new Size(501, 272);
            textBoxTask_KRV.TabIndex = 0;
            textBoxTask_KRV.Text = "Протабулировать функцию на заданном диапазоне. Результат вынести в виде таблицы.";
            textBoxTask_KRV.TextChanged += textBoxTask_KRV_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxPutEnd_KRV);
            groupBox2.Controls.Add(textBoxPutStart_KRV);
            groupBox2.Controls.Add(TexBoxEnd_KRV);
            groupBox2.Controls.Add(textBoxStart_KRV);
            groupBox2.Location = new Point(10, 334);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 104);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных:";
            // 
            // textBoxPutEnd_KRV
            // 
            textBoxPutEnd_KRV.Location = new Point(151, 75);
            textBoxPutEnd_KRV.Multiline = true;
            textBoxPutEnd_KRV.Name = "textBoxPutEnd_KRV";
            textBoxPutEnd_KRV.Size = new Size(126, 30);
            textBoxPutEnd_KRV.TabIndex = 5;
            // 
            // textBoxPutStart_KRV
            // 
            textBoxPutStart_KRV.Location = new Point(9, 73);
            textBoxPutStart_KRV.Multiline = true;
            textBoxPutStart_KRV.Name = "textBoxPutStart_KRV";
            textBoxPutStart_KRV.Size = new Size(116, 39);
            textBoxPutStart_KRV.TabIndex = 4;
            // 
            // TexBoxEnd_KRV
            // 
            TexBoxEnd_KRV.Location = new Point(150, 31);
            TexBoxEnd_KRV.Multiline = true;
            TexBoxEnd_KRV.Name = "TexBoxEnd_KRV";
            TexBoxEnd_KRV.ReadOnly = true;
            TexBoxEnd_KRV.Size = new Size(91, 22);
            TexBoxEnd_KRV.TabIndex = 1;
            TexBoxEnd_KRV.Text = "Конец шага:";
            // 
            // textBoxStart_KRV
            // 
            textBoxStart_KRV.Location = new Point(7, 31);
            textBoxStart_KRV.Multiline = true;
            textBoxStart_KRV.Name = "textBoxStart_KRV";
            textBoxStart_KRV.ReadOnly = true;
            textBoxStart_KRV.Size = new Size(90, 24);
            textBoxStart_KRV.TabIndex = 0;
            textBoxStart_KRV.Text = "Старт шага:";
            // 
            // groupBoxRes_KRV
            // 
            groupBoxRes_KRV.Controls.Add(textBoxResult_KRV);
            groupBoxRes_KRV.Controls.Add(textBoxRes_KRV);
            groupBoxRes_KRV.Location = new Point(529, 13);
            groupBoxRes_KRV.Name = "groupBoxRes_KRV";
            groupBoxRes_KRV.Size = new Size(259, 426);
            groupBoxRes_KRV.TabIndex = 2;
            groupBoxRes_KRV.TabStop = false;
            groupBoxRes_KRV.Text = "Вывод данных:";
            // 
            // textBoxResult_KRV
            // 
            textBoxResult_KRV.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KRV.Location = new Point(4, 61);
            textBoxResult_KRV.Multiline = true;
            textBoxResult_KRV.Name = "textBoxResult_KRV";
            textBoxResult_KRV.ReadOnly = true;
            textBoxResult_KRV.Size = new Size(264, 372);
            textBoxResult_KRV.TabIndex = 1;
            textBoxResult_KRV.TextChanged += textBoxResult_KRV_TextChanged;
            // 
            // textBoxRes_KRV
            // 
            textBoxRes_KRV.Location = new Point(6, 22);
            textBoxRes_KRV.Multiline = true;
            textBoxRes_KRV.Name = "textBoxRes_KRV";
            textBoxRes_KRV.ReadOnly = true;
            textBoxRes_KRV.Size = new Size(247, 29);
            textBoxRes_KRV.TabIndex = 0;
            textBoxRes_KRV.Text = "Результат:";
            // 
            // buttoninfo_KRV
            // 
            buttoninfo_KRV.Location = new Point(317, 345);
            buttoninfo_KRV.Name = "buttoninfo_KRV";
            buttoninfo_KRV.Size = new Size(87, 87);
            buttoninfo_KRV.TabIndex = 3;
            buttoninfo_KRV.Text = "Справка";
            buttoninfo_KRV.UseVisualStyleBackColor = true;
            // 
            // buttonStart_KRV
            // 
            buttonStart_KRV.Location = new Point(419, 345);
            buttonStart_KRV.Name = "buttonStart_KRV";
            buttonStart_KRV.Size = new Size(103, 86);
            buttonStart_KRV.TabIndex = 4;
            buttonStart_KRV.Text = "Выполнить";
            buttonStart_KRV.UseVisualStyleBackColor = true;
            buttonStart_KRV.Click += buttonStart_KRV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStart_KRV);
            Controls.Add(buttoninfo_KRV);
            Controls.Add(groupBoxTask_KRV);
            Controls.Add(groupBoxRes_KRV);
            Controls.Add(groupBox2);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxTask_KRV.ResumeLayout(false);
            groupBoxTask_KRV.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxRes_KRV.ResumeLayout(false);
            groupBoxRes_KRV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KRV;
        private GroupBox groupBox2;
        private GroupBox groupBoxRes_KRV;
        private TextBox textBoxTask_KRV;
        private TextBox TexBoxEnd_KRV;
        private TextBox textBoxStart_KRV;
        private TextBox textBoxResult_KRV;
        private TextBox textBoxRes_KRV;
        private Button buttoninfo_KRV;
        private Button buttonStart_KRV;
        private TextBox textBoxPutEnd_KRV;
        private TextBox textBoxPutStart_KRV;
    }
}
