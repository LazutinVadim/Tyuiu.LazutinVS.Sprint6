using Tyuiu.LazutinVS.Sprint6.Task4.V11.Lib;

namespace Tyuiu.LazutinVS.Sprint6.Task4.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            int startStep = Convert.ToInt32(textBoxStart_LVS.Text);
            int stopStep = Convert.ToInt32(textBoxEnd_LVS.Text);
            string strLine;
            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] array = new double[len];
            array = ds.GetMassFunction(startStep, stopStep);
            textBox3_LVS.Text = "";
            textBox3_LVS.AppendText("+------------+------------+" + Environment.NewLine);
            textBox3_LVS.AppendText("|      X     +     f(x)   +" + Environment.NewLine);
            textBox3_LVS.AppendText("+------------+------------+" + Environment.NewLine);
            for (int i = 0; i < len; i++)
            {
                strLine = String.Format("|{0,5:d}      |   {1, 5:f2}     |", startStep, array[i]);
                textBox3_LVS.AppendText(strLine + Environment.NewLine);
                startStep++;
            }
            textBox3_LVS.AppendText("+------------+------------+" + Environment.NewLine);
            this.chart_LVS.Titles.Add("Текст");
            this.chart_LVS.ChartAreas[0].AxisX.Title = "X";
            this.chart_LVS.ChartAreas[0].AxisY.Title = "Y";
            for (int i = 0; i < len; i++)
            {

                this.chart_LVS.Series[0].Points.AddXY(startStep, array[i]);
                startStep++;
            }
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V11.txt";
            File.WriteAllText(path, textBox3_LVS.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
