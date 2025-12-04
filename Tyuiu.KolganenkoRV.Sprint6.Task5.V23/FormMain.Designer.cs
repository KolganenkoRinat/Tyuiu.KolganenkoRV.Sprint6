namespace Tyuiu.KolganenkoRV.Sprint6.Task5.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_KRV = new GroupBox();
            textBoxTask_KRV = new TextBox();
            buttonOpen_KRV = new Button();
            buttoninfo_KRV = new Button();
            buttonDone_KRV = new Button();
            groupBoxOutPut_KRV = new GroupBox();
            dataGridViewNums_KRV = new DataGridView();
            chartFunction_KRV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_KRV.SuspendLayout();
            groupBoxOutPut_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KRV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KRV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KRV
            // 
            groupBoxTask_KRV.Controls.Add(textBoxTask_KRV);
            groupBoxTask_KRV.Location = new Point(12, 12);
            groupBoxTask_KRV.Name = "groupBoxTask_KRV";
            groupBoxTask_KRV.Size = new Size(614, 118);
            groupBoxTask_KRV.TabIndex = 1;
            groupBoxTask_KRV.TabStop = false;
            groupBoxTask_KRV.Text = "Условие:";
            // 
            // textBoxTask_KRV
            // 
            textBoxTask_KRV.Location = new Point(8, 24);
            textBoxTask_KRV.Multiline = true;
            textBoxTask_KRV.Name = "textBoxTask_KRV";
            textBoxTask_KRV.ReadOnly = true;
            textBoxTask_KRV.Size = new Size(583, 83);
            textBoxTask_KRV.TabIndex = 0;
            textBoxTask_KRV.Text = "Протабулировать функцию и построить график.";
            // 
            // buttonOpen_KRV
            // 
            buttonOpen_KRV.Location = new Point(642, 17);
            buttonOpen_KRV.Name = "buttonOpen_KRV";
            buttonOpen_KRV.Size = new Size(89, 49);
            buttonOpen_KRV.TabIndex = 7;
            buttonOpen_KRV.Text = "Open File";
            buttonOpen_KRV.UseVisualStyleBackColor = true;
            buttonOpen_KRV.Click += buttonOpen_KRV_Click;
            // 
            // buttoninfo_KRV
            // 
            buttoninfo_KRV.Location = new Point(642, 72);
            buttoninfo_KRV.Name = "buttoninfo_KRV";
            buttoninfo_KRV.Size = new Size(89, 53);
            buttoninfo_KRV.TabIndex = 8;
            buttoninfo_KRV.Text = "?";
            buttoninfo_KRV.UseVisualStyleBackColor = true;
            buttoninfo_KRV.Click += buttoninfo_KRV_Click;
            // 
            // buttonDone_KRV
            // 
            buttonDone_KRV.Location = new Point(737, 17);
            buttonDone_KRV.Name = "buttonDone_KRV";
            buttonDone_KRV.Size = new Size(540, 113);
            buttonDone_KRV.TabIndex = 9;
            buttonDone_KRV.Text = "Выполнить";
            buttonDone_KRV.UseVisualStyleBackColor = true;
            buttonDone_KRV.Click += buttonDone_KRV_Click;
            // 
            // groupBoxOutPut_KRV
            // 
            groupBoxOutPut_KRV.Controls.Add(dataGridViewNums_KRV);
            groupBoxOutPut_KRV.Location = new Point(20, 150);
            groupBoxOutPut_KRV.Name = "groupBoxOutPut_KRV";
            groupBoxOutPut_KRV.Size = new Size(406, 522);
            groupBoxOutPut_KRV.TabIndex = 10;
            groupBoxOutPut_KRV.TabStop = false;
            groupBoxOutPut_KRV.Text = "Вывод данных:";
            // 
            // dataGridViewNums_KRV
            // 
            dataGridViewNums_KRV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_KRV.Location = new Point(5, 22);
            dataGridViewNums_KRV.Name = "dataGridViewNums_KRV";
            dataGridViewNums_KRV.Size = new Size(398, 496);
            dataGridViewNums_KRV.TabIndex = 0;
            // 
            // chartFunction_KRV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KRV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KRV.Legends.Add(legend1);
            chartFunction_KRV.Location = new Point(440, 158);
            chartFunction_KRV.Name = "chartFunction_KRV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KRV.Series.Add(series1);
            chartFunction_KRV.Size = new Size(839, 514);
            chartFunction_KRV.TabIndex = 11;
            chartFunction_KRV.Text = "chart1";
            title1.BackColor = Color.White;
            title1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.DarkOrange;
            title1.Name = "sin";
            title1.Text = "Функция ";
            chartFunction_KRV.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 703);
            Controls.Add(chartFunction_KRV);
            Controls.Add(groupBoxOutPut_KRV);
            Controls.Add(buttonDone_KRV);
            Controls.Add(buttoninfo_KRV);
            Controls.Add(buttonOpen_KRV);
            Controls.Add(groupBoxTask_KRV);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxTask_KRV.ResumeLayout(false);
            groupBoxTask_KRV.PerformLayout();
            groupBoxOutPut_KRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KRV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KRV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KRV;
        private TextBox textBoxTask_KRV;
        private Button buttonOpen_KRV;
        private Button buttoninfo_KRV;
        private Button buttonDone_KRV;
        private GroupBox groupBoxOutPut_KRV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KRV;
        private DataGridView dataGridViewNums_KRV;
    }
}
