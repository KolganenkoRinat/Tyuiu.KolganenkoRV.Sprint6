using System.ComponentModel.Design.Serialization;
using Tyuiu.KolganenkoRV.Sprint6.Task7.V27.Lib;

namespace Tyuiu.KolganenkoRV.Sprint6.Task7.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KRV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KRV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int colums;

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0;c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_KRV.ColumnCount = 50;
            dataGridViewOutPut_KRV.ColumnCount = 50;

            dataGridViewInPut_KRV.RowCount = 50;
            dataGridViewOutPut_KRV.RowCount = 50;
            

            for (int i = 0; i < 50;  i++)
            {
                dataGridViewInPut_KRV.Columns[i].Width = 25;
                dataGridViewOutPut_KRV.Columns[i].Width = 25;
            }
        }

        private void buttonSave_KRV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KRV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KRV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KRV.ShowDialog();

            string path = saveFileDialogMatrix_KRV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            { 
                File.Delete(path);
            }
            
            int rows = dataGridViewOutPut_KRV.Rows.Count;
            int colums = dataGridViewOutPut_KRV.Columns.Count;

            string str = "";

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + dataGridViewOutPut_KRV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_KRV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
            
        }

        private void buttonOpenFile_KRV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KRV.ShowDialog();
            openFilePath = openFileDialogTask_KRV.FileName;
            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_KRV.ColumnCount = colums;
            dataGridViewInPut_KRV.RowCount = rows;
            dataGridViewOutPut_KRV.RowCount = rows;
            dataGridViewOutPut_KRV.ColumnCount = colums;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInPut_KRV.Columns[i].Width = 25;
                dataGridViewOutPut_KRV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInPut_KRV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }

            }
            
            buttonDone_KRV.Enabled = true;
        }

        private void buttonDone_KRV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath); 

            for (int r = 0;r < rows; r++)
            {
                for(int c = 0;c < colums; c++)
                {
                    dataGridViewOutPut_KRV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_KRV.Enabled = true;
        }

        private void buttonHelp_KRV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
