namespace Tyuiu.ZakharovaVI.Sprint6.Task3.V8
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
            groupBoxTask = new GroupBox();
            dataGridViewMatrix = new DataGridView();
            textBoxTask = new TextBox();
            groupBoxResult = new GroupBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            textBoxResult = new TextBox();
            textBoxRes = new TextBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(dataGridViewMatrix);
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(781, 426);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(410, 26);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(365, 369);
            dataGridViewMatrix.TabIndex = 2;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(398, 369);
            textBoxTask.TabIndex = 1;
            textBoxTask.Text = "Дана матрица 5 на 5\r\n-10 10 -7 19 6\r\n15 -13 -19 9 1\r\n-20 -15 -6 8 -4\r\n10 18 -5 9 -6\r\n16 -10 4 15 16\r\nЗаменить четные знаения в 4 строке на 0";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(buttonHelp);
            groupBoxResult.Controls.Add(buttonDone);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Controls.Add(textBoxRes);
            groupBoxResult.Location = new Point(799, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(197, 426);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ControlLight;
            buttonHelp.Location = new Point(6, 385);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(39, 35);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.ControlLight;
            buttonDone.Location = new Point(78, 385);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(113, 35);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 69);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(152, 27);
            textBoxResult.TabIndex = 3;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 26);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(125, 27);
            textBoxRes.TabIndex = 2;
            textBoxRes.Text = "Результат:";
            textBoxRes.TextChanged += textBox2_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 8 |  Захарова В.И.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxResult;
        private TextBox textBoxRes;
        private TextBox textBoxTask;
        private TextBox textBoxResult;
        private Button buttonHelp;
        private Button buttonDone;
        private DataGridView dataGridViewMatrix;
    }
}
