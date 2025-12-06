namespace Tyuiu.KolganenkoRV.Sprint6.Task7.V27
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpenFile_KRV = new Button();
            buttonDone_KRV = new Button();
            buttonHelp_KRV = new Button();
            groupBoxTask_KRV = new GroupBox();
            textBox1 = new TextBox();
            groupBoxInPut_KRV = new GroupBox();
            groupBoxOutPut_KRV = new GroupBox();
            dataGridViewInPut_KRV = new DataGridView();
            dataGridViewOutPut_KRV = new DataGridView();
            buttonSave_KRV = new Button();
            openFileDialogTask_KRV = new OpenFileDialog();
            saveFileDialogMatrix_KRV = new SaveFileDialog();
            toolTipButton_KRV = new ToolTip(components);
            groupBoxTask_KRV.SuspendLayout();
            groupBoxInPut_KRV.SuspendLayout();
            groupBoxOutPut_KRV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_KRV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_KRV).BeginInit();
            SuspendLayout();
            // 
            // buttonOpenFile_KRV
            // 
            buttonOpenFile_KRV.Location = new Point(22, 12);
            buttonOpenFile_KRV.Name = "buttonOpenFile_KRV";
            buttonOpenFile_KRV.Size = new Size(78, 72);
            buttonOpenFile_KRV.TabIndex = 1;
            buttonOpenFile_KRV.Text = "Open File";
            toolTipButton_KRV.SetToolTip(buttonOpenFile_KRV, "Open File\r\nChoose file for processing\r\n");
            buttonOpenFile_KRV.UseVisualStyleBackColor = true;
            buttonOpenFile_KRV.Click += buttonOpenFile_KRV_Click;
            // 
            // buttonDone_KRV
            // 
            buttonDone_KRV.Location = new Point(125, 12);
            buttonDone_KRV.Name = "buttonDone_KRV";
            buttonDone_KRV.Size = new Size(78, 72);
            buttonDone_KRV.TabIndex = 3;
            buttonDone_KRV.Text = "Done";
            buttonDone_KRV.UseVisualStyleBackColor = true;
            buttonDone_KRV.Click += buttonDone_KRV_Click;
            // 
            // buttonHelp_KRV
            // 
            buttonHelp_KRV.Location = new Point(952, 12);
            buttonHelp_KRV.Name = "buttonHelp_KRV";
            buttonHelp_KRV.Size = new Size(78, 72);
            buttonHelp_KRV.TabIndex = 4;
            buttonHelp_KRV.Text = "Help";
            buttonHelp_KRV.UseVisualStyleBackColor = true;
            buttonHelp_KRV.Click += buttonHelp_KRV_Click;
            // 
            // groupBoxTask_KRV
            // 
            groupBoxTask_KRV.Controls.Add(textBox1);
            groupBoxTask_KRV.Enabled = false;
            groupBoxTask_KRV.FlatStyle = FlatStyle.Flat;
            groupBoxTask_KRV.Location = new Point(0, 90);
            groupBoxTask_KRV.Name = "groupBoxTask_KRV";
            groupBoxTask_KRV.Size = new Size(1048, 119);
            groupBoxTask_KRV.TabIndex = 5;
            groupBoxTask_KRV.TabStop = false;
            groupBoxTask_KRV.Text = "Condition";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1048, 91);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxInPut_KRV
            // 
            groupBoxInPut_KRV.Controls.Add(dataGridViewInPut_KRV);
            groupBoxInPut_KRV.Location = new Point(0, 215);
            groupBoxInPut_KRV.Name = "groupBoxInPut_KRV";
            groupBoxInPut_KRV.Size = new Size(522, 448);
            groupBoxInPut_KRV.TabIndex = 6;
            groupBoxInPut_KRV.TabStop = false;
            groupBoxInPut_KRV.Text = "Input";
            // 
            // groupBoxOutPut_KRV
            // 
            groupBoxOutPut_KRV.Controls.Add(dataGridViewOutPut_KRV);
            groupBoxOutPut_KRV.Location = new Point(553, 215);
            groupBoxOutPut_KRV.Name = "groupBoxOutPut_KRV";
            groupBoxOutPut_KRV.Size = new Size(495, 448);
            groupBoxOutPut_KRV.TabIndex = 7;
            groupBoxOutPut_KRV.TabStop = false;
            groupBoxOutPut_KRV.Text = "OutPut";
            // 
            // dataGridViewInPut_KRV
            // 
            dataGridViewInPut_KRV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_KRV.Location = new Point(0, 22);
            dataGridViewInPut_KRV.Name = "dataGridViewInPut_KRV";
            dataGridViewInPut_KRV.Size = new Size(519, 436);
            dataGridViewInPut_KRV.TabIndex = 0;
            // 
            // dataGridViewOutPut_KRV
            // 
            dataGridViewOutPut_KRV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_KRV.Location = new Point(0, 22);
            dataGridViewOutPut_KRV.Name = "dataGridViewOutPut_KRV";
            dataGridViewOutPut_KRV.Size = new Size(495, 426);
            dataGridViewOutPut_KRV.TabIndex = 1;
            // 
            // buttonSave_KRV
            // 
            buttonSave_KRV.Enabled = false;
            buttonSave_KRV.FlatStyle = FlatStyle.Flat;
            buttonSave_KRV.Location = new Point(231, 13);
            buttonSave_KRV.Name = "buttonSave_KRV";
            buttonSave_KRV.Size = new Size(76, 71);
            buttonSave_KRV.TabIndex = 8;
            buttonSave_KRV.Text = "Save";
            toolTipButton_KRV.SetToolTip(buttonSave_KRV, "Save your file with result\r\n");
            buttonSave_KRV.UseVisualStyleBackColor = true;
            buttonSave_KRV.Click += buttonSave_KRV_Click;
            // 
            // openFileDialogTask_KRV
            // 
            openFileDialogTask_KRV.FileName = "InPutFileTask7V27.csv";
            // 
            // toolTipButton_KRV
            // 
            toolTipButton_KRV.ToolTipTitle = "Prompting";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 667);
            Controls.Add(buttonSave_KRV);
            Controls.Add(groupBoxOutPut_KRV);
            Controls.Add(groupBoxInPut_KRV);
            Controls.Add(groupBoxTask_KRV);
            Controls.Add(buttonHelp_KRV);
            Controls.Add(buttonDone_KRV);
            Controls.Add(buttonOpenFile_KRV);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxTask_KRV.ResumeLayout(false);
            groupBoxTask_KRV.PerformLayout();
            groupBoxInPut_KRV.ResumeLayout(false);
            groupBoxOutPut_KRV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_KRV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_KRV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile_KRV;
        private Button buttonDone_KRV;
        private Button buttonHelp_KRV;
        private GroupBox groupBoxTask_KRV;
        private TextBox textBox1;
        private GroupBox groupBoxInPut_KRV;
        private GroupBox groupBoxOutPut_KRV;
        private DataGridView dataGridViewInPut_KRV;
        private DataGridView dataGridViewOutPut_KRV;
        private Button buttonSave_KRV;
        private OpenFileDialog openFileDialogTask_KRV;
        private SaveFileDialog saveFileDialogMatrix_KRV;
        private ToolTip toolTipButton_KRV;
    }
}
