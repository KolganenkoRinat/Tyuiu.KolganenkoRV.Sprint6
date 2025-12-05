using Tyuiu.KolganenkoRV.Sprint6.Task6.V1.Lib;

namespace Tyuiu.KolganenkoRV.Sprint6.Task6.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string openFilePath;
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_KRV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KRV.ShowDialog();
            openFilePath = openFileDialogTask_KRV.FileName;
            textBoxInPut_KRV.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_KRV.Text = groupBoxOutPut_KRV.Text + "" + openFileDialogTask_KRV.FileName;
            buttonDone_KRV.Enabled = true;

        }

        private void buttonDone_KRV_Click(object sender, EventArgs e)
        {
            
            textBoxOutPut_KRV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_KRV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
