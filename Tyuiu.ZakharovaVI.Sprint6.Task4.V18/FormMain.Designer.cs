namespace Tyuiu.ZakharovaVI.Sprint6.Task4.V18
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
            panel1 = new Panel();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            groupBoxVvod = new GroupBox();
            textBoxStartStep = new TextBox();
            textBoxStop = new TextBox();
            textBoxStopStep = new TextBox();
            textBoxStart = new TextBox();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panel2 = new Panel();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            panel3 = new Panel();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            groupBoxVvod.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxResult.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(groupBoxVvod);
            panel1.Controls.Add(groupBoxTask);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1313, 101);
            panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Location = new Point(1180, 16);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(121, 70);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.Location = new Point(1057, 16);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(121, 70);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone.Location = new Point(930, 16);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(121, 70);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(textBoxStartStep);
            groupBoxVvod.Controls.Add(textBoxStop);
            groupBoxVvod.Controls.Add(textBoxStopStep);
            groupBoxVvod.Controls.Add(textBoxStart);
            groupBoxVvod.Location = new Point(592, 3);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(332, 98);
            groupBoxVvod.TabIndex = 3;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод данных";
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 56);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(134, 27);
            textBoxStartStep.TabIndex = 0;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(192, 22);
            textBoxStop.Multiline = true;
            textBoxStop.Name = "textBoxStop";
            textBoxStop.ReadOnly = true;
            textBoxStop.Size = new Size(134, 27);
            textBoxStop.TabIndex = 0;
            textBoxStop.Text = "Конец шага:";
            textBoxStop.TextChanged += textBox5_TextChanged;
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(192, 56);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(134, 27);
            textBoxStopStep.TabIndex = 0;
            textBoxStopStep.TextChanged += textBox5_TextChanged;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 22);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.ReadOnly = true;
            textBoxStart.Size = new Size(134, 27);
            textBoxStart.TabIndex = 0;
            textBoxStart.Text = "Старт шага:";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(3, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(583, 98);
            groupBoxTask.TabIndex = 3;
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
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(groupBoxResult);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 101);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(266, 478);
            panel2.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Dock = DockStyle.Fill;
            groupBoxResult.Location = new Point(5, 5);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(256, 468);
            groupBoxResult.TabIndex = 3;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод";
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 23);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(250, 442);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBox9_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Controls.Add(chartFunction);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(266, 101);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(1047, 478);
            panel3.TabIndex = 0;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(8, 6);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(1031, 464);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции sin(x)";
            chartFunction.Titles.Add(title1);
            chartFunction.Click += chartFunction_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(266, 101);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 478);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 579);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 18 |  Захарова В.И.";
            panel1.ResumeLayout(false);
            groupBoxVvod.ResumeLayout(false);
            groupBoxVvod.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxVvod;
        private TextBox textBoxStart;
        private TextBox textBoxStopStep;
        private TextBox textBoxStartStep;
        private Button buttonDone;
        private TextBox textBoxStop;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttonHelp;
        private Button buttonSave;
    }
}
