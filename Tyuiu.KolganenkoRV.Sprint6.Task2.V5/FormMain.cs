using Tyuiu.KolganenkoRV.Sprint6.Task2.V5.Lib;

namespace Tyuiu.KolganenkoRV.Sprint6.Task2.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonStart_KRV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KRV.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_KRV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_KRV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    
                    startStep++;

                }
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void buttoninfo_KRV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-25-1 Колганенко Ринат Витальевич", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
