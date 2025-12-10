using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZakharovaVI.Sprint6.Task7.V4.Lib;


namespace Tyuiu.ZakharovaVI.Sprint6.Task7.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile.Enabled = true;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;  
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn.ColumnCount = columns;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = columns;
            dataGridViewOut.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
                dataGridViewOut.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonDone.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn.ColumnCount = 50;
            dataGridViewOut.ColumnCount = 50;

            dataGridViewIn.RowCount = 50;
            dataGridViewOut.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
                dataGridViewOut.Columns[i].Width = 25;
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7V4.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut.RowCount;
            int columns = dataGridViewOut.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }

        private void dataGridViewIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
