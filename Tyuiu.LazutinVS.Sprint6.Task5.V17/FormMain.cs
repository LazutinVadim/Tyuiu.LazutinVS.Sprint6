using System.IO;
using Tyuiu.LazutinVS.Sprint6.Task5.V17.Lib;

namespace Tyuiu.LazutinVS.Sprint6.Task5.V17
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V17.txt");

        public FormMain()
        {
            InitializeComponent();
        }

        private void button_LVS_Click(object sender, EventArgs e)
        {
            dataGridView_LVS.ColumnCount = 2;
            dataGridView_LVS.Columns[0].Width = 20;
            dataGridView_LVS.Columns[1].Width = 50;

            this.chart_LVS.ChartAreas[0].AxisX.Title = "X";
            this.chart_LVS.ChartAreas[0].AxisY.Title = "Y";

            chart_LVS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView_LVS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chart_LVS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
        private void buttonChoose_LVS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }


        private void dataGridView_LVS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
