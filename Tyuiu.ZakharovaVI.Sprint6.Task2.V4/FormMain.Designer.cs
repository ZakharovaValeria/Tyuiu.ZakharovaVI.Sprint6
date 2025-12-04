namespace Tyuiu.ZakharovaVI.Sprint6.Task2.V4
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
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxResult = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            textBoxRes = new TextBox();
            groupBoxVvod = new GroupBox();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            groupBoxVvod.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(720, 292);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(623, 115);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию f(x) на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartFunction);
            groupBoxResult.Controls.Add(dataGridViewFunction);
            groupBoxResult.Controls.Add(textBoxRes);
            groupBoxResult.Location = new Point(748, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(576, 428);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных:";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(233, 60);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(343, 322);
            chartFunction.TabIndex = 3;
            chartFunction.Text = "chart1";
            chartFunction.Click += chartFunction_Click;
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewFunction.Location = new Point(15, 59);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(183, 392);
            dataGridViewFunction.TabIndex = 2;
            dataGridViewFunction.CellContentClick += dataGridViewFunction_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(x)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(15, 26);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(159, 27);
            textBoxRes.TabIndex = 1;
            textBoxRes.Text = "Результат:";
            // 
            // groupBoxVvod
            // 
            groupBoxVvod.Controls.Add(textBoxStart);
            groupBoxVvod.Controls.Add(textBoxStop);
            groupBoxVvod.Controls.Add(textBoxStopStep);
            groupBoxVvod.Controls.Add(textBoxStartStep);
            groupBoxVvod.Location = new Point(12, 341);
            groupBoxVvod.Name = "groupBoxVvod";
            groupBoxVvod.Size = new Size(403, 99);
            groupBoxVvod.TabIndex = 1;
            groupBoxVvod.TabStop = false;
            groupBoxVvod.Text = "Ввод данных";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(208, 26);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.ReadOnly = true;
            textBoxStart.Size = new Size(164, 27);
            textBoxStart.TabIndex = 2;
            textBoxStart.Text = "Старт шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(6, 26);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.ReadOnly = true;
            textBoxStop.Size = new Size(164, 27);
            textBoxStop.TabIndex = 3;
            textBoxStop.Text = "Конец шага: ";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(208, 59);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(164, 27);
            textBoxStopStep.TabIndex = 5;
            textBoxStopStep.TextChanged += textBox4_TextChanged;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 59);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(164, 27);
            textBoxStartStep.TabIndex = 4;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.InactiveCaption;
            buttonHelp.Location = new Point(435, 350);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(120, 90);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(574, 350);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(158, 90);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 471);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxVvod);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 4 |  Захарова В.И.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            groupBoxVvod.ResumeLayout(false);
            groupBoxVvod.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxResult;
        private GroupBox groupBoxVvod;
        private Button buttonHelp;
        private Button buttonDone;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private TextBox textBoxStartStep;
        private TextBox textBoxStopStep;
        private TextBox textBoxTask;
        private TextBox textBoxRes;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
