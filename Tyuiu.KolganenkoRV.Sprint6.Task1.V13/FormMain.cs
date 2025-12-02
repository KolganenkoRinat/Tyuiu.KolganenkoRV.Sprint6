using Tyuiu.KolganenkoRV.Sprint6.Task1.V13.Lib;
namespace Tyuiu.KolganenkoRV.Sprint6.Task1.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Ваш код обработки события Enter для groupBox
            // Например:
            // groupBoxTask_KRV.BackColor = Color.LightBlue;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Ваш код загрузки формы
            // Инициализация компонентов, загрузка данных и т.д.
        }

        private void buttonStart_KRV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxPutStart_KRV.Text);
                int stopStep = Convert.ToInt32(textBoxPutEnd_KRV.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KRV.Text = "";
                textBoxResult_KRV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KRV.AppendText("|    X     |    f(X)  |" + Environment.NewLine);
                textBoxResult_KRV.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |   {1, 5:f2}  |", startStep, valueArray[i]);
                    textBoxResult_KRV.AppendText(strLine + Environment.NewLine);
                    startStep++;

                }
                textBoxResult_KRV.AppendText("+----------+----------+" + Environment.NewLine);

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

        private void groupBoxTask_KRV_Enter(object sender, EventArgs e)
        {

        }



        private void textBoxTask_KRV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_KRV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
