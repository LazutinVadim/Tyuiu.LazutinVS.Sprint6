using Tyuiu.LazutinVS.Sprint6.Task0.V5.Lib;

namespace Tyuiu.LazutinVS.Sprint6.Task0.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonget_LVS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_LVS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_LVS.Text)));
            }
            catch
            {
                MessageBox.Show("Ошибкаа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
