
using System;
using Tyuiu.KolganenkoRV.Sprint6.Task3.V23.Lib;
namespace Tyuiu.KolganenkoRV.Sprint6.Task3.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { 0, -19,  25,  34,   0},
                                        {-19, -16,   1,  -5,  34},
                                        { 1,  13,  -5, -17,  -5},
                                        {  3,  -9, -15,  -1,   0},
                                        {1,  20,  15,  -5,  31 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_KRV.ColumnCount = columns;
            dataGridViewMatrix_KRV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            { 
                dataGridViewMatrix_KRV.Columns[i].Width = 25;
            }

            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KRV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }

            }
        }

        private void buttoninfo_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-25-1 Колганенко Ринат Витальевич", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonStart_KRV_Click(object sender, EventArgs e)
        {
            int[,] sortedMatrix = ds.Calculate(matrix);

            // Очищаем TextBox перед выводом
            textBoxRes_KRV.Clear();

            // Выводим отсортированный массив в TextBox
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // Добавляем значение с табуляцией
                    textBoxRes_KRV.Text += Convert.ToString(sortedMatrix[i, j]) + "\t";
                }
                // Переход на новую строку после каждой строки массива
                textBoxRes_KRV.Text += Environment.NewLine;
            }

        }
    }
}
