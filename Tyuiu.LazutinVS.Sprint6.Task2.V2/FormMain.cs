using Tyuiu.LazutinVS.Sprint6.Task2.V2.Lib;

namespace Tyuiu.LazutinVS.Sprint6.Task2.V2
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonStart_LVS_Click(object sender, EventArgs e)
        {

            try {
                int start = Convert.ToInt32(textBoxStart_LVS.Text);  // <-- TextBox, а не Label
                int stop = Convert.ToInt32(textBoxEnd_LVS.Text);    // <-- TextBox, а не Label

                double[] mass = ds.GetMassFunction(start, stop);

                dataGridView_LVS.Rows.Clear();  // Очищаем старые строки (важно!)

                for (int i = 0; i < mass.Length; i++)
                {
                    dataGridView_LVS.Rows.Add(start + i, Math.Round(mass[i], 2));  // Округляем до 2 знаков
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные. Введите целые числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
