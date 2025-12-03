namespace Tyuiu.ZakharovaVI.Sprint6.Task1.V2
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
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            textBoxStartStep = new TextBox();
            textBoxStopStep = new TextBox();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBox2 = new GroupBox();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxRes = new TextBox();
            groupBoxTask.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 59);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(207, 347);
            textBoxResult.TabIndex = 2;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.ScrollBar;
            buttonDone.Location = new Point(455, 332);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(108, 92);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaption;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(360, 332);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(89, 92);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 59);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(161, 27);
            textBoxStartStep.TabIndex = 5;
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(175, 59);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(161, 27);
            textBoxStopStep.TabIndex = 6;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(551, 314);
            groupBoxTask.TabIndex = 7;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(529, 269);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию f(x) на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxStart);
            groupBox2.Controls.Add(textBoxStop);
            groupBox2.Controls.Add(textBoxStartStep);
            groupBox2.Controls.Add(textBoxStopStep);
            groupBox2.Location = new Point(12, 332);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(342, 92);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 26);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.ReadOnly = true;
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 8;
            textBoxStart.Text = "Старт шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(175, 26);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.ReadOnly = true;
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 7;
            textBoxStop.Text = "Конец шага:";
            textBoxStop.TextChanged += textBoxStop_TextChanged;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxRes);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(569, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(219, 412);
            groupBoxResult.TabIndex = 9;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных:";
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 26);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(125, 27);
            textBoxRes.TabIndex = 9;
            textBoxRes.Text = "Результат: ";
            textBoxRes.TextChanged += textBox1_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 2 | Захарова В.И. ";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxResult;
        private Button buttonDone;
        private Button buttonHelp;
        private TextBox textBoxStartStep;
        private TextBox textBoxStopStep;
        private GroupBox groupBoxTask;
        private GroupBox groupBox2;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private GroupBox groupBoxResult;
        private TextBox textBoxRes;
        private TextBox textBoxTask;
    }
}
