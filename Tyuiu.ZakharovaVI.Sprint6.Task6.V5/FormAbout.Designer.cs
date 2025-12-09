namespace Tyuiu.ZakharovaVI.Sprint6.Task6.V5
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelInfo = new Label();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(120, 21);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(342, 80);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Разработчик: Захарова В.И.\r\nГруппа ИБКСб-25-1\r\n\r\nПрограмма разработана в рамках изучения C#";
            labelInfo.Click += labelInfo_Click;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(368, 156);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 2;
            buttonOk.Text = "ОК";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 197);
            Controls.Add(buttonOk);
            Controls.Add(labelInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
        private Button buttonOk;
    }
}