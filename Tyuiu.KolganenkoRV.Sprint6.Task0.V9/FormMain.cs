using Tyuiu.KolganenkoRV.Sprint6.Task0.V9.Lib;
namespace Tyuiu.KolganenkoRV.Sprint6.Task0.V9
{
        public partial class Formmain : Form
        {
            public Formmain()
            {
                InitializeComponent();
            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {
                // Ваш код обработки события Enter для groupBox
                // Например:
                // groupBoxTask_KRV.BackColor = Color.LightBlue;
            }

            private void Formmain_Load(object sender, EventArgs e)
            {
                // Ваш код загрузки формы
                // Инициализация компонентов, загрузка данных и т.д.
            }

            private void buttonStart_KRV_Click(object sender, EventArgs e)
            {
                DataService ds = new DataService();
                try
                {
                    textBoxOutPut_KRV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInPut_KRV.Text)));
                }
                catch

                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void textBoxInPut_KRV_KeyPress(object sender, KeyPressEventArgs e)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
                {
                    e.Handled = true;
                }

        }
            private void buttoninfo_KRV_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Таск 0 выполнил студент группы ИБКСб-25-1 Колганенко Ринат Витальевич", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
}
