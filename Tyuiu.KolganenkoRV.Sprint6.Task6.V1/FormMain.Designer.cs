namespace Tyuiu.KolganenkoRV.Sprint6.Task6.V1
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
            buttonHelp_KRV = new Button();
            buttonDone_KRV = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            openFileDialogTask_KRV = new OpenFileDialog();
            toolTip_KRV = new ToolTip(components);
            groupBoxInPut_KRV = new GroupBox();
            textBoxInPut_KRV = new TextBox();
            groupBoxOutPut_KRV = new GroupBox();
            textBoxOutPut_KRV = new TextBox();
            groupBox1.SuspendLayout();
            groupBoxInPut_KRV.SuspendLayout();
            groupBoxOutPut_KRV.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile_KRV
            // 
            buttonOpenFile_KRV.Location = new Point(8, 10);
            buttonOpenFile_KRV.Name = "buttonOpenFile_KRV";
            buttonOpenFile_KRV.Size = new Size(78, 72);
            buttonOpenFile_KRV.TabIndex = 0;
            buttonOpenFile_KRV.Text = "Open File";
            toolTip_KRV.SetToolTip(buttonOpenFile_KRV, "Open File\r\nChoose file for processing\r\n\r\n");
            buttonOpenFile_KRV.UseVisualStyleBackColor = true;
            buttonOpenFile_KRV.Click += buttonOpenFile_KRV_Click;
            // 
            // buttonHelp_KRV
            // 
            buttonHelp_KRV.Location = new Point(934, 10);
            buttonHelp_KRV.Name = "buttonHelp_KRV";
            buttonHelp_KRV.Size = new Size(78, 72);
            buttonHelp_KRV.TabIndex = 1;
            buttonHelp_KRV.Text = "Help";
            buttonHelp_KRV.UseVisualStyleBackColor = true;
            buttonHelp_KRV.Click += buttonHelp_KRV_Click;
            // 
            // buttonDone_KRV
            // 
            buttonDone_KRV.Location = new Point(108, 10);
            buttonDone_KRV.Name = "buttonDone_KRV";
            buttonDone_KRV.Size = new Size(78, 72);
            buttonDone_KRV.TabIndex = 2;
            buttonDone_KRV.Text = "Done";
            buttonDone_KRV.UseVisualStyleBackColor = true;
            buttonDone_KRV.Click += buttonDone_KRV_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(-2, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1048, 119);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
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
            // openFileDialogTask_KRV
            // 
            openFileDialogTask_KRV.FileName = "InPutDataFileTask6V1.txt";
            // 
            // toolTip_KRV
            // 
            toolTip_KRV.ToolTipIcon = ToolTipIcon.Info;
            toolTip_KRV.ToolTipTitle = "Prompting";
            // 
            // groupBoxInPut_KRV
            // 
            groupBoxInPut_KRV.Controls.Add(textBoxInPut_KRV);
            groupBoxInPut_KRV.Location = new Point(1, 221);
            groupBoxInPut_KRV.Name = "groupBoxInPut_KRV";
            groupBoxInPut_KRV.Size = new Size(529, 448);
            groupBoxInPut_KRV.TabIndex = 4;
            groupBoxInPut_KRV.TabStop = false;
            groupBoxInPut_KRV.Text = "Input";
            // 
            // textBoxInPut_KRV
            // 
            textBoxInPut_KRV.Location = new Point(-3, 28);
            textBoxInPut_KRV.Multiline = true;
            textBoxInPut_KRV.Name = "textBoxInPut_KRV";
            textBoxInPut_KRV.Size = new Size(532, 414);
            textBoxInPut_KRV.TabIndex = 0;
            // 
            // groupBoxOutPut_KRV
            // 
            groupBoxOutPut_KRV.Controls.Add(textBoxOutPut_KRV);
            groupBoxOutPut_KRV.Location = new Point(557, 221);
            groupBoxOutPut_KRV.Name = "groupBoxOutPut_KRV";
            groupBoxOutPut_KRV.Size = new Size(475, 448);
            groupBoxOutPut_KRV.TabIndex = 5;
            groupBoxOutPut_KRV.TabStop = false;
            groupBoxOutPut_KRV.Text = "OutPut";
            // 
            // textBoxOutPut_KRV
            // 
            textBoxOutPut_KRV.Location = new Point(0, 28);
            textBoxOutPut_KRV.Multiline = true;
            textBoxOutPut_KRV.Name = "textBoxOutPut_KRV";
            textBoxOutPut_KRV.Size = new Size(475, 414);
            textBoxOutPut_KRV.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 697);
            Controls.Add(groupBoxOutPut_KRV);
            Controls.Add(groupBoxInPut_KRV);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone_KRV);
            Controls.Add(buttonHelp_KRV);
            Controls.Add(buttonOpenFile_KRV);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxInPut_KRV.ResumeLayout(false);
            groupBoxInPut_KRV.PerformLayout();
            groupBoxOutPut_KRV.ResumeLayout(false);
            groupBoxOutPut_KRV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile_KRV;
        private Button buttonHelp_KRV;
        private Button buttonDone_KRV;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private ToolTip toolTip_KRV;
        private OpenFileDialog openFileDialogTask_KRV;
        private GroupBox groupBoxInPut_KRV;
        private GroupBox groupBoxOutPut_KRV;
        private TextBox textBoxInPut_KRV;
        private TextBox textBoxOutPut_KRV;
    }
}
