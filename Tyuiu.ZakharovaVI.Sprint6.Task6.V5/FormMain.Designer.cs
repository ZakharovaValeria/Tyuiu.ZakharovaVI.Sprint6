namespace Tyuiu.ZakharovaVI.Sprint6.Task6.V5
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
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            buttonOpenFile = new Button();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxOutPutData = new GroupBox();
            textBoxVvod = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            groupBoxTask.SuspendLayout();
            groupBoxResult.SuspendLayout();
            groupBoxOutPutData.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 86);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(721, 98);
            groupBoxTask.TabIndex = 5;
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
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(109, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 68);
            buttonDone.TabIndex = 12;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Location = new Point(655, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 68);
            buttonHelp.TabIndex = 10;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click_1;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile.Location = new Point(18, 10);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(75, 70);
            buttonOpenFile.TabIndex = 11;
            toolTip1.SetToolTip(buttonOpenFile, "Открыть файл. Выберите нужный файл для обработки");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(377, 190);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(356, 248);
            groupBoxResult.TabIndex = 13;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод";
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
            textBoxResult.TextChanged += textBox2_TextChanged;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(textBoxVvod);
            groupBoxOutPutData.Location = new Point(18, 190);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(356, 248);
            groupBoxOutPutData.TabIndex = 0;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Ввод";
            // 
            // textBoxVvod
            // 
            textBoxVvod.Location = new Point(3, 26);
            textBoxVvod.Multiline = true;
            textBoxVvod.Name = "textBoxVvod";
            textBoxVvod.ReadOnly = true;
            textBoxVvod.ScrollBars = ScrollBars.Vertical;
            textBoxVvod.Size = new Size(350, 216);
            textBoxVvod.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(groupBoxResult);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOpenFile);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 5 |  Захарова В.И.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private Button buttonDone;
        private Button buttonHelp;
        private Button buttonOpenFile;
        private GroupBox groupBoxResult;
        private GroupBox groupBoxOutPutData;
        private TextBox textBoxResult;
        private TextBox textBoxVvod;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip1;
    }
}
