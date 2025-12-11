namespace Tyuiu.LazutinVS.Sprint6.Task0.V5
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
            textBoxInput_LVS = new TextBox();
            buttonget_LVS = new Button();
            textBoxResult_LVS = new TextBox();
            SuspendLayout();
            // 
            // textBoxInput_LVS
            // 
            textBoxInput_LVS.Location = new Point(106, 341);
            textBoxInput_LVS.Name = "textBoxInput_LVS";
            textBoxInput_LVS.Size = new Size(150, 31);
            textBoxInput_LVS.TabIndex = 0;
            // 
            // buttonget_LVS
            // 
            buttonget_LVS.Location = new Point(342, 402);
            buttonget_LVS.Name = "buttonget_LVS";
            buttonget_LVS.Size = new Size(112, 34);
            buttonget_LVS.TabIndex = 1;
            buttonget_LVS.Text = "Выполнить";
            buttonget_LVS.UseVisualStyleBackColor = true;
            buttonget_LVS.Click += buttonget_LVS_Click;
            // 
            // textBoxResult_LVS
            // 
            textBoxResult_LVS.Location = new Point(342, 341);
            textBoxResult_LVS.Name = "textBoxResult_LVS";
            textBoxResult_LVS.Size = new Size(150, 31);
            textBoxResult_LVS.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 477);
            Controls.Add(textBoxResult_LVS);
            Controls.Add(buttonget_LVS);
            Controls.Add(textBoxInput_LVS);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput_LVS;
        private Button buttonget_LVS;
        private TextBox textBoxResult_LVS;
    }
}
