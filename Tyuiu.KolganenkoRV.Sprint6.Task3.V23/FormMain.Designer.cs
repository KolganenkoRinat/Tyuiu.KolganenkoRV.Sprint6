namespace Tyuiu.KolganenkoRV.Sprint6.Task3.V23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_KRV = new GroupBox();
            textBoxTask_KRV = new TextBox();
            groupBoxRes_KRV = new GroupBox();
            textBoxRes_KRV = new TextBox();
            textBoxResult_KRV = new TextBox();
            dataGridViewMatrix_KRV = new DataGridView();
            buttonifo_KRV = new Button();
            buttonStart_KRV = new Button();
            groupBoxTask_KRV.SuspendLayout();
            groupBoxRes_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KRV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KRV
            // 
            groupBoxTask_KRV.Controls.Add(textBoxTask_KRV);
            groupBoxTask_KRV.Location = new Point(13, 16);
            groupBoxTask_KRV.Name = "groupBoxTask_KRV";
            groupBoxTask_KRV.Size = new Size(359, 396);
            groupBoxTask_KRV.TabIndex = 0;
            groupBoxTask_KRV.TabStop = false;
            groupBoxTask_KRV.Text = "Условие:";
            // 
            // textBoxTask_KRV
            // 
            textBoxTask_KRV.Location = new Point(6, 33);
            textBoxTask_KRV.Multiline = true;
            textBoxTask_KRV.Name = "textBoxTask_KRV";
            textBoxTask_KRV.ReadOnly = true;
            textBoxTask_KRV.Size = new Size(180, 205);
            textBoxTask_KRV.TabIndex = 0;
            textBoxTask_KRV.Text = resources.GetString("textBoxTask_KRV.Text");
            // 
            // groupBoxRes_KRV
            // 
            groupBoxRes_KRV.Controls.Add(textBoxRes_KRV);
            groupBoxRes_KRV.Controls.Add(textBoxResult_KRV);
            groupBoxRes_KRV.Location = new Point(669, 16);
            groupBoxRes_KRV.Name = "groupBoxRes_KRV";
            groupBoxRes_KRV.Size = new Size(254, 346);
            groupBoxRes_KRV.TabIndex = 1;
            groupBoxRes_KRV.TabStop = false;
            groupBoxRes_KRV.Text = "Вывод данных:";
            // 
            // textBoxRes_KRV
            // 
            textBoxRes_KRV.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_KRV.Location = new Point(6, 68);
            textBoxRes_KRV.Multiline = true;
            textBoxRes_KRV.Name = "textBoxRes_KRV";
            textBoxRes_KRV.Size = new Size(242, 272);
            textBoxRes_KRV.TabIndex = 1;
            // 
            // textBoxResult_KRV
            // 
            textBoxResult_KRV.Location = new Point(4, 33);
            textBoxResult_KRV.Multiline = true;
            textBoxResult_KRV.Name = "textBoxResult_KRV";
            textBoxResult_KRV.ReadOnly = true;
            textBoxResult_KRV.Size = new Size(79, 20);
            textBoxResult_KRV.TabIndex = 0;
            textBoxResult_KRV.Text = "Результат:";
            // 
            // dataGridViewMatrix_KRV
            // 
            dataGridViewMatrix_KRV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_KRV.Location = new Point(388, 19);
            dataGridViewMatrix_KRV.Name = "dataGridViewMatrix_KRV";
            dataGridViewMatrix_KRV.Size = new Size(275, 393);
            dataGridViewMatrix_KRV.TabIndex = 2;
            // 
            // buttonifo_KRV
            // 
            buttonifo_KRV.Location = new Point(692, 394);
            buttonifo_KRV.Name = "buttonifo_KRV";
            buttonifo_KRV.Size = new Size(44, 29);
            buttonifo_KRV.TabIndex = 3;
            buttonifo_KRV.Text = "?";
            buttonifo_KRV.UseVisualStyleBackColor = true;
            buttonifo_KRV.Click += buttoninfo_KRV_Click;
            // 
            // buttonStart_KRV
            // 
            buttonStart_KRV.Location = new Point(756, 394);
            buttonStart_KRV.Name = "buttonStart_KRV";
            buttonStart_KRV.Size = new Size(161, 29);
            buttonStart_KRV.TabIndex = 4;
            buttonStart_KRV.Text = "Выполнить";
            buttonStart_KRV.UseVisualStyleBackColor = true;
            buttonStart_KRV.Click += buttonStart_KRV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 450);
            Controls.Add(buttonStart_KRV);
            Controls.Add(buttonifo_KRV);
            Controls.Add(dataGridViewMatrix_KRV);
            Controls.Add(groupBoxRes_KRV);
            Controls.Add(groupBoxTask_KRV);
            Name = "FormMain";
            Text = "Спринт 6 | Задание 3 | Колганенко Р.В.";
            Load += FormMain_Load;
            groupBoxTask_KRV.ResumeLayout(false);
            groupBoxTask_KRV.PerformLayout();
            groupBoxRes_KRV.ResumeLayout(false);
            groupBoxRes_KRV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KRV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KRV;
        private GroupBox groupBoxRes_KRV;
        private DataGridView dataGridViewMatrix_KRV;
        private TextBox textBoxTask_KRV;
        private TextBox textBoxRes_KRV;
        private TextBox textBoxResult_KRV;
        private Button buttonifo_KRV;
        private Button buttonStart_KRV;
    }
}
