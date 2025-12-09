using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZakharovaVI.Sprint6.Task5.V14.Lib;

namespace Tyuiu.ZakharovaVI.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        //string path = @"C:\Users\Пользователь\source\repos\Tyuiu.ZakharovaVI.Sprint6\Tyuiu.ZakharovaVI.Sprint6.Task5.V14\bin\Debug\InPutDataFileTask5V14.txt";
        //string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask5.txt");

        string path = @"C:\DataSprint6\InPutDataFileTask5V14.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width = 20;
            dataGridViewNums.Columns[1].Width = 50;

            this.chartDiag.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag.Series[0].Points.Clear();
            dataGridViewNums.Rows.Clear();

            double[] numsMass = ds.LoadFromDataFile(path);

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {

                dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ИБКСб-25-1 Захарова Валерия Игоревна");
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Red; 
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
