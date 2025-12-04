namespace Tyuiu.KolganenkoRV.Sprint6.Task4.V15
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
            groupBoxInPut_KRV = new GroupBox();
            textBoxE_KRV = new TextBox();
            textBoxS_KRV = new TextBox();
            textBoxEnd_KRV = new TextBox();
            textBoxStart_KRV = new TextBox();
            buttoninfo_KRV = new Button();
            buttonDone_KRV = new Button();
            groupBoxOutPut_KRV = new GroupBox();
            textBoxOutPut_KRV = new TextBox();
            chartFunction_KRV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonSave_KRV = new Button();
            groupBoxTask_KRV.SuspendLayout();
            groupBoxInPut_KRV.SuspendLayout();
            groupBoxOutPut_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KRV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KRV
            // 
            groupBoxTask_KRV.Controls.Add(textBoxTask_KRV);
            groupBoxTask_KRV.Location = new Point(5, 7);
            groupBoxTask_KRV.Name = "groupBoxTask_KRV";
            groupBoxTask_KRV.Size = new Size(614, 118);
            groupBoxTask_KRV.TabIndex = 0;
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
            // groupBoxInPut_KRV
            // 
            groupBoxInPut_KRV.Controls.Add(textBoxE_KRV);
            groupBoxInPut_KRV.Controls.Add(textBoxS_KRV);
            groupBoxInPut_KRV.Controls.Add(textBoxEnd_KRV);
            groupBoxInPut_KRV.Controls.Add(textBoxStart_KRV);
            groupBoxInPut_KRV.Location = new Point(625, 7);
            groupBoxInPut_KRV.Name = "groupBoxInPut_KRV";
            groupBoxInPut_KRV.Size = new Size(402, 118);
            groupBoxInPut_KRV.TabIndex = 1;
            groupBoxInPut_KRV.TabStop = false;
            groupBoxInPut_KRV.Text = "Ввод данных:";
            // 
            // textBoxE_KRV
            // 
            textBoxE_KRV.Location = new Point(208, 73);
            textBoxE_KRV.Multiline = true;
            textBoxE_KRV.Name = "textBoxE_KRV";
            textBoxE_KRV.Size = new Size(162, 23);
            textBoxE_KRV.TabIndex = 3;
            // 
            // textBoxS_KRV
            // 
            textBoxS_KRV.Location = new Point(6, 73);
            textBoxS_KRV.Multiline = true;
            textBoxS_KRV.Name = "textBoxS_KRV";
            textBoxS_KRV.Size = new Size(162, 23);
            textBoxS_KRV.TabIndex = 2;
            // 
            // textBoxEnd_KRV
            // 
            textBoxEnd_KRV.Location = new Point(208, 27);
            textBoxEnd_KRV.Multiline = true;
            textBoxEnd_KRV.Name = "textBoxEnd_KRV";
            textBoxEnd_KRV.ReadOnly = true;
            textBoxEnd_KRV.Size = new Size(162, 23);
            textBoxEnd_KRV.TabIndex = 1;
            textBoxEnd_KRV.Text = "Конец шага:";
            // 
            // textBoxStart_KRV
            // 
            textBoxStart_KRV.Location = new Point(6, 27);
            textBoxStart_KRV.Multiline = true;
            textBoxStart_KRV.Name = "textBoxStart_KRV";
            textBoxStart_KRV.ReadOnly = true;
            textBoxStart_KRV.Size = new Size(162, 27);
            textBoxStart_KRV.TabIndex = 0;
            textBoxStart_KRV.Text = "Старт шага:";
            // 
            // buttoninfo_KRV
            // 
            buttoninfo_KRV.Location = new Point(1041, 72);
            buttoninfo_KRV.Name = "buttoninfo_KRV";
            buttoninfo_KRV.Size = new Size(89, 53);
            buttoninfo_KRV.TabIndex = 2;
            buttoninfo_KRV.Text = "?";
            buttoninfo_KRV.UseVisualStyleBackColor = true;
            // 
            // buttonDone_KRV
            // 
            buttonDone_KRV.Location = new Point(1143, 12);
            buttonDone_KRV.Name = "buttonDone_KRV";
            buttonDone_KRV.Size = new Size(134, 113);
            buttonDone_KRV.TabIndex = 3;
            buttonDone_KRV.Text = "Выполнить";
            buttonDone_KRV.UseVisualStyleBackColor = true;
            buttonDone_KRV.Click += buttonDone_KRV_Click;
            // 
            // groupBoxOutPut_KRV
            // 
            groupBoxOutPut_KRV.Controls.Add(textBoxOutPut_KRV);
            groupBoxOutPut_KRV.Location = new Point(5, 134);
            groupBoxOutPut_KRV.Name = "groupBoxOutPut_KRV";
            groupBoxOutPut_KRV.Size = new Size(406, 522);
            groupBoxOutPut_KRV.TabIndex = 4;
            groupBoxOutPut_KRV.TabStop = false;
            groupBoxOutPut_KRV.Text = "Вывод данных:";
            // 
            // textBoxOutPut_KRV
            // 
            textBoxOutPut_KRV.Location = new Point(0, 20);
            textBoxOutPut_KRV.Multiline = true;
            textBoxOutPut_KRV.Name = "textBoxOutPut_KRV";
            textBoxOutPut_KRV.ReadOnly = true;
            textBoxOutPut_KRV.Size = new Size(404, 500);
            textBoxOutPut_KRV.TabIndex = 0;
            // 
            // chartFunction_KRV
            // 
            chartFunction_KRV.AllowDrop = true;
            chartArea1.Name = "ChartArea1";
            chartFunction_KRV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KRV.Legends.Add(legend1);
            chartFunction_KRV.Location = new Point(445, 154);
            chartFunction_KRV.Name = "chartFunction_KRV";
            chartFunction_KRV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KRV.Series.Add(series1);
            chartFunction_KRV.Size = new Size(832, 498);
            chartFunction_KRV.TabIndex = 5;
            chartFunction_KRV.Text = "chartFunction";
            title1.Name = "TitleSin";
            title1.Text = "График функции sin(x)";
            chartFunction_KRV.Titles.Add(title1);
            // 
            // buttonSave_KRV
            // 
            buttonSave_KRV.Location = new Point(1041, 12);
            buttonSave_KRV.Name = "buttonSave_KRV";
            buttonSave_KRV.Size = new Size(89, 49);
            buttonSave_KRV.TabIndex = 6;
            buttonSave_KRV.Text = "Save";
            buttonSave_KRV.UseVisualStyleBackColor = true;
            buttonSave_KRV.Click += buttonSave_KRV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 664);
            Controls.Add(buttonSave_KRV);
            Controls.Add(chartFunction_KRV);
            Controls.Add(groupBoxOutPut_KRV);
            Controls.Add(buttonDone_KRV);
            Controls.Add(buttoninfo_KRV);
            Controls.Add(groupBoxInPut_KRV);
            Controls.Add(groupBoxTask_KRV);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxTask_KRV.ResumeLayout(false);
            groupBoxTask_KRV.PerformLayout();
            groupBoxInPut_KRV.ResumeLayout(false);
            groupBoxInPut_KRV.PerformLayout();
            groupBoxOutPut_KRV.ResumeLayout(false);
            groupBoxOutPut_KRV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KRV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KRV;
        private GroupBox groupBoxInPut_KRV;
        private Button buttoninfo_KRV;
        private Button buttonDone_KRV;
        private GroupBox groupBoxOutPut_KRV;
        private TextBox textBoxTask_KRV;
        private TextBox textBoxE_KRV;
        private TextBox textBoxS_KRV;
        private TextBox textBoxEnd_KRV;
        private TextBox textBoxStart_KRV;
        private TextBox textBoxOutPut_KRV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KRV;
        private Button buttonSave_KRV;
    }
}
