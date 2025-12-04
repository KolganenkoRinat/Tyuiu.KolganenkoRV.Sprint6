using Tyuiu.KolganenkoRV.Sprint6.Task5.V23.Lib;

namespace Tyuiu.KolganenkoRV.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V23.txt";

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_KRV_Click(object sender, EventArgs e)
        {
            dataGridViewNums_KRV.ColumnCount = 2;
            dataGridViewNums_KRV.Columns[0].Width = 20;
            dataGridViewNums_KRV.Columns[1].Width = 50;
            this.chartFunction_KRV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_KRV.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_KRV.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_KRV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_KRV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttoninfo_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБКСб-25-1 Колганенко Ринат Витальевич", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonOpen_KRV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }

}
