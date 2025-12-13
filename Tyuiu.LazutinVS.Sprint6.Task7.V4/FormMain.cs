using Tyuiu.LazutinVS.Sprint6.Task7.V4.Lib;

namespace Tyuiu.LazutinVS.Sprint6.Task7.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath) // Метод загрузки матрицы из файла
        {
            string fileData = File.ReadAllText(filePath); // Чтение с файла в переменную
            fileData = fileData.Replace('\n', '\r'); // Унификация строк (замена одиночных символов)
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries); // Разбиение текст на массив строк по \r, удаляя пустые строки

            rows = lines.Length; // Запись рядов матрицы
            columns = lines[0].Split(';').Length; // Запись колонок

            int[,] arrayValues = new int[rows, columns]; // двумерный массив rows * columns

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';'); // разбиение строки по ;
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]); // Запись в массив
                }
            }
            return arrayValues;
        }

        private void buttonOpen_LVS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_LVS.ShowDialog(); // Диалог выбора файла
            openFilePath = openFileDialogTask_LVS.FileName; // Путь к файлу

            int[,] arrayValues = new int[rows, columns]; // двумерный массив rows * columns

            arrayValues = LoadFromFileData(openFilePath); // Загружаем данные

            Input_LVS.ColumnCount = columns;
            Input_LVS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                Input_LVS.Columns[i].Width = 25;
                Output_LVS.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Input_LVS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonExecute_LVS.Enabled = true;
        }

        private void labelInput_LVS_Click(object sender, EventArgs e)
        {

        }
        private void openFileDialogTask_FileOk(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Input_LVS.ColumnCount = 50;
            Output_LVS.ColumnCount = 50;

            Input_LVS.RowCount = 50;
            Output_LVS.RowCount = 50;
        }

        private void buttonS_LVS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonExecute_LVS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Output_LVS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_LVS.Enabled = true;
        }

        private void buttonSave_LVS_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_LVS.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_LVS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_LVS.ShowDialog();

            string path = saveFileDialogMatrix_LVS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = Output_LVS.RowCount;
            int columns = Output_LVS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + Output_LVS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + Output_LVS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void saveFileDialogMatrix_LVS_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
