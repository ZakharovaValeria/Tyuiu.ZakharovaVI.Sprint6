using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZakharovaVI.Sprint6.Task6.V5.Lib;

namespace Tyuiu.ZakharovaVI.Sprint6.Task6.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            
            textBoxResult.Text = ds.CollectTextFromFile(openFilePath);
        }



        private void buttonOpenFile_Click(object sender, EventArgs e)
        {

            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxVvod.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " - " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        private void buttonHelp_Click_1(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        

        private void openFileDialogTask_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }



        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
