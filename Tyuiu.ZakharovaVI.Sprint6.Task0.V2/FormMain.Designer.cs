namespace Tyuiu.ZakharovaVI.Sprint6.Task0.V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            pictureBoxFormula = new PictureBox();
            TextBoxTask = new TextBox();
            textBoxVarX = new TextBox();
            groupBox2 = new GroupBox();
            textBoxPr = new TextBox();
            groupBox3 = new GroupBox();
            textBoxRes = new TextBox();
            textBoxResult = new TextBox();
            buttonHelp = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(550, 386);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(238, 58);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxFormula);
            groupBox1.Controls.Add(TextBoxTask);
            groupBox1.Location = new Point(12, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 193);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(509, 26);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(261, 139);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // TextBoxTask
            // 
            TextBoxTask.Location = new Point(0, 26);
            TextBoxTask.Multiline = true;
            TextBoxTask.Name = "TextBoxTask";
            TextBoxTask.ReadOnly = true;
            TextBoxTask.Size = new Size(497, 139);
            TextBoxTask.TabIndex = 0;
            TextBoxTask.Text = "Вычислить значение по формуле";
            TextBoxTask.TextChanged += В_TextChanged;
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(6, 80);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(157, 27);
            textBoxVarX.TabIndex = 2;
            textBoxVarX.TextChanged += textBox3_TextChanged;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxPr);
            groupBox2.Controls.Add(textBoxVarX);
            groupBox2.Location = new Point(12, 249);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 131);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBoxPr
            // 
            textBoxPr.Location = new Point(6, 34);
            textBoxPr.Multiline = true;
            textBoxPr.Name = "textBoxPr";
            textBoxPr.ReadOnly = true;
            textBoxPr.Size = new Size(125, 27);
            textBoxPr.TabIndex = 3;
            textBoxPr.Text = "Переменная Х:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxRes);
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Location = new Point(480, 249);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(308, 131);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(15, 34);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(125, 27);
            textBoxRes.TabIndex = 2;
            textBoxRes.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(15, 80);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(206, 27);
            textBoxResult.TabIndex = 1;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(480, 386);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(64, 58);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 456);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 2 | Захарова В.И";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox TextBoxTask;
        private TextBox textBoxVarX;
        private GroupBox groupBox3;
        private TextBox textBoxResult;
        private Button buttonHelp;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxPr;
        private TextBox textBoxRes;
    }
}
