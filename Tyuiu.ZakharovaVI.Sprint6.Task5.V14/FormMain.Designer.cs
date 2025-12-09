namespace Tyuiu.ZakharovaVI.Sprint6.Task5.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panel1 = new Panel();
            groupBoxResult = new GroupBox();
            dataGridViewNums = new DataGridView();
            textBoxResult = new TextBox();
            panel2 = new Panel();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            buttonDone = new Button();
            buttonHelp = new Button();
            buttonOpenFile = new Button();
            groupBoxTask.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(3, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(583, 98);
            groupBoxTask.TabIndex = 4;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(563, 70);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию sin(x) на заданном диапазоне от -5 до 5\r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nпо нажатию кнопки";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxResult);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 478);
            panel1.TabIndex = 5;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridViewNums);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Dock = DockStyle.Fill;
            groupBoxResult.Location = new Point(0, 0);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(237, 478);
            groupBoxResult.TabIndex = 4;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод";
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Location = new Point(3, 23);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.RowHeadersWidth = 51;
            dataGridViewNums.Size = new Size(208, 440);
            dataGridViewNums.TabIndex = 2;
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 23);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(231, 452);
            textBoxResult.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(chartDiag);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(976, 478);
            panel2.TabIndex = 5;
            // 
            // chartDiag
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag.Legends.Add(legend1);
            chartDiag.Location = new Point(243, 6);
            chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag.Series.Add(series1);
            chartDiag.Size = new Size(721, 460);
            chartDiag.TabIndex = 5;
            chartDiag.Text = "chart1";
            title1.Name = "Title1";
            chartDiag.Titles.Add(title1);
            chartDiag.Click += chart1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonDone);
            panel3.Controls.Add(buttonHelp);
            panel3.Controls.Add(groupBoxTask);
            panel3.Controls.Add(buttonOpenFile);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(976, 101);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(592, 25);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(121, 70);
            buttonDone.TabIndex = 9;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Location = new Point(846, 25);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(121, 70);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile.Location = new Point(719, 25);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(121, 70);
            buttonOpenFile.TabIndex = 7;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 579);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 14 |  Захарова В.И.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panel1.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Button buttonHelp;
        private Button buttonOpenFile;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private Button buttonDone;
        private DataGridView dataGridViewNums;
    }
}
