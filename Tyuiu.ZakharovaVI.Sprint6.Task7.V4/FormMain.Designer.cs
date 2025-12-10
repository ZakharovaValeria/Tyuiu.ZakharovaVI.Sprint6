namespace Tyuiu.ZakharovaVI.Sprint6.Task7.V4
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
            components = new System.ComponentModel.Container();
            buttonDone = new Button();
            buttonHelp = new Button();
            buttonOpenFile = new Button();
            button1 = new Button();
            buttonSaveFile = new Button();
            button3 = new Button();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxOutPutData = new GroupBox();
            dataGridViewIn = new DataGridView();
            textBoxVvod = new TextBox();
            groupBoxResult = new GroupBox();
            dataGridViewOut = new DataGridView();
            textBoxResult = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            groupBoxTask.SuspendLayout();
            groupBoxOutPutData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(103, 14);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 68);
            buttonDone.TabIndex = 15;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Location = new Point(713, 14);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 68);
            buttonHelp.TabIndex = 13;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile.Location = new Point(12, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 70);
            buttonOpenFile.TabIndex = 14;
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(-443, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 70);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSaveFile.Location = new Point(194, 14);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(75, 68);
            buttonSaveFile.TabIndex = 13;
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // button3
            // 
            button3.Location = new Point(-352, 14);
            button3.Name = "button3";
            button3.Size = new Size(75, 68);
            button3.TabIndex = 15;
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 97);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(721, 98);
            groupBoxTask.TabIndex = 16;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(702, 70);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию sin(x) на заданном диапазоне от -5 до 5. Результат вывести в textBox, построить график функции и сохранить в файл\r\nпо нажатию кнопки";
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(dataGridViewIn);
            groupBoxOutPutData.Controls.Add(textBoxVvod);
            groupBoxOutPutData.Location = new Point(12, 201);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(356, 282);
            groupBoxOutPutData.TabIndex = 1;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Ввод";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(6, 32);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(344, 244);
            dataGridViewIn.TabIndex = 19;
            dataGridViewIn.CellContentClick += dataGridViewIn_CellContentClick;
            // 
            // textBoxVvod
            // 
            textBoxVvod.Location = new Point(3, 26);
            textBoxVvod.Multiline = true;
            textBoxVvod.Name = "textBoxVvod";
            textBoxVvod.ReadOnly = true;
            textBoxVvod.ScrollBars = ScrollBars.Vertical;
            textBoxVvod.Size = new Size(392, 256);
            textBoxVvod.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridViewOut);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(413, 201);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(386, 282);
            groupBoxResult.TabIndex = 17;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(0, 32);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(344, 244);
            dataGridViewOut.TabIndex = 19;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(337, 216);
            textBoxResult.TabIndex = 1;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(groupBoxTask);
            Controls.Add(button3);
            Controls.Add(buttonDone);
            Controls.Add(buttonSaveFile);
            Controls.Add(button1);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOpenFile);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 4 |  Захарова В.И.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private Button buttonHelp;
        private Button buttonOpenFile;
        private Button button1;
        private Button buttonSaveFile;
        private Button button3;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxOutPutData;
        private TextBox textBoxVvod;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMatrix;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
    }
}
