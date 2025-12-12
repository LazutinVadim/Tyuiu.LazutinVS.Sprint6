namespace Tyuiu.LazutinVS.Sprint6.Task3.V20
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
            button_LVS = new Button();
            dataGridViewOutput_LVS = new DataGridView();
            textResult_LVS = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_LVS).BeginInit();
            SuspendLayout();
            // 
            // button_LVS
            // 
            button_LVS.BackColor = Color.Lime;
            button_LVS.Location = new Point(633, 352);
            button_LVS.Name = "button_LVS";
            button_LVS.Size = new Size(279, 77);
            button_LVS.TabIndex = 0;
            button_LVS.Text = "Start";
            button_LVS.UseVisualStyleBackColor = false;
            button_LVS.Click += button_LVS_Click;
            // 
            // dataGridViewOutput_LVS
            // 
            dataGridViewOutput_LVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_LVS.Location = new Point(12, 27);
            dataGridViewOutput_LVS.Name = "dataGridViewOutput_LVS";
            dataGridViewOutput_LVS.RowHeadersWidth = 62;
            dataGridViewOutput_LVS.Size = new Size(545, 247);
            dataGridViewOutput_LVS.TabIndex = 5;
            dataGridViewOutput_LVS.CellContentClick += dataGridViewOutput_LVS_CellContentClick;
            // 
            // textResult_LVS
            // 
            textResult_LVS.Location = new Point(104, 375);
            textResult_LVS.Name = "textResult_LVS";
            textResult_LVS.Size = new Size(279, 31);
            textResult_LVS.TabIndex = 1;
            textResult_LVS.TextChanged += textResult_LVS_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 543);
            Controls.Add(dataGridViewOutput_LVS);
            Controls.Add(textResult_LVS);
            Controls.Add(button_LVS);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_LVS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_LVS;
        private DataGridView dataGridViewOutput_LVS;
        private TextBox textResult_LVS;
    }
}
