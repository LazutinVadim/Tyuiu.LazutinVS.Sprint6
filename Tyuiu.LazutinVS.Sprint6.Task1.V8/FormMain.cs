using System.Windows.Forms.VisualStyles;
using Tyuiu.LazutinVS.Sprint6.Task1.V8.Lib;

namespace Tyuiu.LazutinVS.Sprint6.Task1.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonGET_LVS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int start = Convert.ToInt32(textBoxStart_LVS.Text);
                int stop = Convert.ToInt32(textBoxEnd_LVS.Text);
                string str;
                int len = ds.GetMassFunction(start, stop).Length;
                double[] value = new double[len];
                value = ds.GetMassFunction(start, stop);
                textResult_LVS.Text = "";
                textResult_LVS.AppendText("+-----------+----------+" + Environment.NewLine);
                textResult_LVS.AppendText("+    X      +    F(x)  +" + Environment.NewLine);
                textResult_LVS.AppendText("+-----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {

                    str = String.Format("|{0,7:d}   ||{1, 7:f2}   |", start, value[i]);
                    textResult_LVS.AppendText(str + Environment.NewLine);
                    start++;
                }
                textResult_LVS.AppendText("+-----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Îøèáêàà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelResult_LVS_Click(object sender, EventArgs e)
        {

        }
    }
}
