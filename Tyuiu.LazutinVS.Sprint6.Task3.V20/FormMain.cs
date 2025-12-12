using Tyuiu.LazutinVS.Sprint6.Task3.V20.Lib;

namespace Tyuiu.LazutinVS.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        int[,] matrix = { { -14, 17, -19, 3, 2   },
                              { -4, -14, -19, -9, -1 },
                              { 1, 0, 13, 14, 8      },
                              { 13, 7, 8, -3, -15    },
                              { 2, -20, 12, -14, 4   } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int r = matrix.GetUpperBound(0) + 1;
            int c = matrix.Length / r;
            dataGridViewOutput_LVS.ColumnCount = c;
            dataGridViewOutput_LVS.RowCount = r;
            for (int i = 0; i < c; i++)
            {
                dataGridViewOutput_LVS.Columns[i].Width = 25;
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    dataGridViewOutput_LVS.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        public FormMain()
        {
            InitializeComponent();
        }
        private void button_LVS_Click(object sender, EventArgs e)
        {
            int[,] ResultMatrix = ds.Calculate(matrix);

            int rows = ResultMatrix.GetUpperBound(0) + 1;
            int columns = ResultMatrix.Length / rows;

            dataGridViewOutput_LVS.ColumnCount = columns;
            dataGridViewOutput_LVS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutput_LVS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput_LVS.Rows[i].Cells[j].Value = Convert.ToString(ResultMatrix[i, j]);
                }
            }
        }

        private void dataGridViewOutput_LVS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textResult_LVS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
