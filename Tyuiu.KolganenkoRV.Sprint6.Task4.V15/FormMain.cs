using Tyuiu.KolganenkoRV.Sprint6.Task4.V15.Lib;

namespace Tyuiu.KolganenkoRV.Sprint6.Task4.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Ваш код при загрузке формы
        }

        private void buttonDone_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxS_KRV.Text);
                int stopStep = Convert.ToInt32(textBoxE_KRV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KRV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KRV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPut_KRV.Text = "";

                chartFunction_KRV.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_KRV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutPut_KRV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;

                }
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(@"C:\DataSprint5\", "OutPutFileTask4.txt"); ;
                File.WriteAllText(path, textBoxOutPut_KRV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "Сохранен успешно");

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
