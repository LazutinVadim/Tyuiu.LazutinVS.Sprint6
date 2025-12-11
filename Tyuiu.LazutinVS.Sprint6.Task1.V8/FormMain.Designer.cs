namespace Tyuiu.LazutinVS.Sprint6.Task1.V8
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
            buttonGET_LVS = new Button();
            textBoxStart_LVS = new TextBox();
            textBoxEnd_LVS = new TextBox();
            TexStart_LVS = new Label();
            TextEnd_LVS = new Label();
            textResult_LVS = new TextBox();
            labelResult_LVS = new Label();
            SuspendLayout();
            // 
            // buttonGET_LVS
            // 
            buttonGET_LVS.BackColor = Color.Lime;
            buttonGET_LVS.Location = new Point(594, 335);
            buttonGET_LVS.Name = "buttonGET_LVS";
            buttonGET_LVS.Size = new Size(194, 101);
            buttonGET_LVS.TabIndex = 0;
            buttonGET_LVS.Text = "Выполнить";
            buttonGET_LVS.UseVisualStyleBackColor = false;
            buttonGET_LVS.Click += buttonGET_LVS_Click;
            // 
            // textBoxStart_LVS
            // 
            textBoxStart_LVS.Location = new Point(12, 370);
            textBoxStart_LVS.Name = "textBoxStart_LVS";
            textBoxStart_LVS.Size = new Size(198, 31);
            textBoxStart_LVS.TabIndex = 1;
            // 
            // textBoxEnd_LVS
            // 
            textBoxEnd_LVS.Location = new Point(285, 370);
            textBoxEnd_LVS.Name = "textBoxEnd_LVS";
            textBoxEnd_LVS.Size = new Size(197, 31);
            textBoxEnd_LVS.TabIndex = 2;
            // 
            // TexStart_LVS
            // 
            TexStart_LVS.AutoSize = true;
            TexStart_LVS.Location = new Point(12, 342);
            TexStart_LVS.Name = "TexStart_LVS";
            TexStart_LVS.Size = new Size(57, 25);
            TexStart_LVS.TabIndex = 3;
            TexStart_LVS.Text = "Старт";
            // 
            // TextEnd_LVS
            // 
            TextEnd_LVS.AutoSize = true;
            TextEnd_LVS.Location = new Point(285, 342);
            TextEnd_LVS.Name = "TextEnd_LVS";
            TextEnd_LVS.Size = new Size(63, 25);
            TextEnd_LVS.TabIndex = 4;
            TextEnd_LVS.Text = "Конец";
            // 
            // textResult_LVS
            // 
            textResult_LVS.Location = new Point(466, 104);
            textResult_LVS.Multiline = true;
            textResult_LVS.Name = "textResult_LVS";
            textResult_LVS.Size = new Size(305, 153);
            textResult_LVS.TabIndex = 5;
            // 
            // labelResult_LVS
            // 
            labelResult_LVS.AutoSize = true;
            labelResult_LVS.Location = new Point(603, 76);
            labelResult_LVS.Name = "labelResult_LVS";
            labelResult_LVS.Size = new Size(63, 25);
            labelResult_LVS.TabIndex = 6;
            labelResult_LVS.Text = "Конец";
            labelResult_LVS.Click += labelResult_LVS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult_LVS);
            Controls.Add(textResult_LVS);
            Controls.Add(TextEnd_LVS);
            Controls.Add(TexStart_LVS);
            Controls.Add(textBoxEnd_LVS);
            Controls.Add(textBoxStart_LVS);
            Controls.Add(buttonGET_LVS);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGET_LVS;
        private TextBox textBoxStart_LVS;
        private TextBox textBoxEnd_LVS;
        private Label TexStart_LVS;
        private Label TextEnd_LVS;
        private TextBox textResult_LVS;
        private Label labelResult_LVS;
    }
}
