namespace Tyuiu.KolganenkoRV.Sprint6.Task2.V5
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
            textBoxStart_KRV = new TextBox();
            textBoxEnd_KRV = new TextBox();
            dataGridViewFunction_KRV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            buttoninfo_KRV = new Button();
            buttonStart_KRV = new Button();
            groupBoxTask_KRV = new GroupBox();
            groupBoxInPut_KRV = new GroupBox();
            groupBoxOutPut_KRV = new GroupBox();
            textBoxTask_KRV = new TextBox();
            textBoxStr_KRV = new TextBox();
            textBoxStp_KRV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KRV).BeginInit();
            groupBoxTask_KRV.SuspendLayout();
            groupBoxInPut_KRV.SuspendLayout();
            groupBoxOutPut_KRV.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStart_KRV
            // 
            textBoxStart_KRV.Location = new Point(6, 60);
            textBoxStart_KRV.Name = "textBoxStart_KRV";
            textBoxStart_KRV.Size = new Size(133, 23);
            textBoxStart_KRV.TabIndex = 0;
            // 
            // textBoxEnd_KRV
            // 
            textBoxEnd_KRV.Location = new Point(188, 60);
            textBoxEnd_KRV.Name = "textBoxEnd_KRV";
            textBoxEnd_KRV.Size = new Size(133, 23);
            textBoxEnd_KRV.TabIndex = 1;
            // 
            // dataGridViewFunction_KRV
            // 
            dataGridViewFunction_KRV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_KRV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewFunction_KRV.Location = new Point(9, 26);
            dataGridViewFunction_KRV.Name = "dataGridViewFunction_KRV";
            dataGridViewFunction_KRV.RowHeadersVisible = false;
            dataGridViewFunction_KRV.Size = new Size(103, 276);
            dataGridViewFunction_KRV.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // buttoninfo_KRV
            // 
            buttoninfo_KRV.Location = new Point(367, 372);
            buttoninfo_KRV.Name = "buttoninfo_KRV";
            buttoninfo_KRV.Size = new Size(73, 63);
            buttoninfo_KRV.TabIndex = 3;
            buttoninfo_KRV.Text = "Справка";
            buttoninfo_KRV.UseVisualStyleBackColor = true;
            buttoninfo_KRV.Click += buttoninfo_KRV_Click;
            // 
            // buttonStart_KRV
            // 
            buttonStart_KRV.Location = new Point(455, 372);
            buttonStart_KRV.Name = "buttonStart_KRV";
            buttonStart_KRV.Size = new Size(133, 63);
            buttonStart_KRV.TabIndex = 4;
            buttonStart_KRV.Text = "Выполнить";
            buttonStart_KRV.UseVisualStyleBackColor = true;
            buttonStart_KRV.Click += buttonStart_KRV_Click;
            // 
            // groupBoxTask_KRV
            // 
            groupBoxTask_KRV.Controls.Add(textBoxTask_KRV);
            groupBoxTask_KRV.Location = new Point(5, 8);
            groupBoxTask_KRV.Name = "groupBoxTask_KRV";
            groupBoxTask_KRV.Size = new Size(492, 329);
            groupBoxTask_KRV.TabIndex = 5;
            groupBoxTask_KRV.TabStop = false;
            groupBoxTask_KRV.Text = "Условие";
            // 
            // groupBoxInPut_KRV
            // 
            groupBoxInPut_KRV.Controls.Add(textBoxStp_KRV);
            groupBoxInPut_KRV.Controls.Add(textBoxStr_KRV);
            groupBoxInPut_KRV.Controls.Add(textBoxEnd_KRV);
            groupBoxInPut_KRV.Controls.Add(textBoxStart_KRV);
            groupBoxInPut_KRV.Location = new Point(8, 352);
            groupBoxInPut_KRV.Name = "groupBoxInPut_KRV";
            groupBoxInPut_KRV.Size = new Size(353, 90);
            groupBoxInPut_KRV.TabIndex = 6;
            groupBoxInPut_KRV.TabStop = false;
            groupBoxInPut_KRV.Text = "Ввод данных:";
            // 
            // groupBoxOutPut_KRV
            // 
            groupBoxOutPut_KRV.Controls.Add(dataGridViewFunction_KRV);
            groupBoxOutPut_KRV.Location = new Point(524, 8);
            groupBoxOutPut_KRV.Name = "groupBoxOutPut_KRV";
            groupBoxOutPut_KRV.Size = new Size(597, 329);
            groupBoxOutPut_KRV.TabIndex = 7;
            groupBoxOutPut_KRV.TabStop = false;
            groupBoxOutPut_KRV.Text = "Вывод данных:";
            // 
            // textBoxTask_KRV
            // 
            textBoxTask_KRV.Location = new Point(5, 23);
            textBoxTask_KRV.Multiline = true;
            textBoxTask_KRV.Name = "textBoxTask_KRV";
            textBoxTask_KRV.ReadOnly = true;
            textBoxTask_KRV.Size = new Size(472, 66);
            textBoxTask_KRV.TabIndex = 0;
            textBoxTask_KRV.Text = "Протабулировать функцию на заданном диапазоне.  Результат вывести в DataGridView и построить график функции.";
            // 
            // textBoxStr_KRV
            // 
            textBoxStr_KRV.Location = new Point(6, 22);
            textBoxStr_KRV.Name = "textBoxStr_KRV";
            textBoxStr_KRV.ReadOnly = true;
            textBoxStr_KRV.Size = new Size(133, 23);
            textBoxStr_KRV.TabIndex = 2;
            textBoxStr_KRV.Text = "Старт шага:";
            // 
            // textBoxStp_KRV
            // 
            textBoxStp_KRV.Location = new Point(188, 22);
            textBoxStp_KRV.Multiline = true;
            textBoxStp_KRV.Name = "textBoxStp_KRV";
            textBoxStp_KRV.ReadOnly = true;
            textBoxStp_KRV.Size = new Size(133, 23);
            textBoxStp_KRV.TabIndex = 3;
            textBoxStp_KRV.Text = "Конец шага:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 450);
            Controls.Add(groupBoxOutPut_KRV);
            Controls.Add(groupBoxInPut_KRV);
            Controls.Add(groupBoxTask_KRV);
            Controls.Add(buttonStart_KRV);
            Controls.Add(buttoninfo_KRV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Колганенко Р.В.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KRV).EndInit();
            groupBoxTask_KRV.ResumeLayout(false);
            groupBoxTask_KRV.PerformLayout();
            groupBoxInPut_KRV.ResumeLayout(false);
            groupBoxInPut_KRV.PerformLayout();
            groupBoxOutPut_KRV.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxStart_KRV;
        private TextBox textBoxEnd_KRV;
        private DataGridView dataGridViewFunction_KRV;
        private Button buttoninfo_KRV;
        private Button buttonStart_KRV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private GroupBox groupBoxTask_KRV;
        private GroupBox groupBoxInPut_KRV;
        private GroupBox groupBoxOutPut_KRV;
        private TextBox textBoxTask_KRV;
        private TextBox textBoxStp_KRV;
        private TextBox textBoxStr_KRV;
    }
}
