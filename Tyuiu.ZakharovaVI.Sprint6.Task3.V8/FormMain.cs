using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZakharovaVI.Sprint6.Task3.V8.Lib;

namespace Tyuiu.ZakharovaVI.Sprint6.Task3.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -10, 10, -7, 19, 6 }, { 15, -13, -19, 9, 1 }, { -20, -15, -6, 8, -4 }, { 10, 18, -5, 9, -6 }, { 16, -10, 4, 15, 16 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            int[,] result = ds.Calculate(mtrx);
            int rows = result.GetUpperBound(0) + 1;
            int columns = result.Length / rows;
            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 50;
            }
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = Convert.ToString(ds.Calculate(mtrx));
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИБКСб-25-1 Захарова Валерия Игоревна");
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
