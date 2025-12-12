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
            buttonnNotify_LVS = new Button();
            textBox_LVS = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_LVS).BeginInit();
            SuspendLayout();
            // 
            // button_LVS
            // 
            button_LVS.BackColor = Color.Lime;
            button_LVS.Location = new Point(720, 477);
            button_LVS.Name = "button_LVS";
            button_LVS.Size = new Size(221, 54);
            button_LVS.TabIndex = 0;
            button_LVS.Text = "Start";
            button_LVS.UseVisualStyleBackColor = false;
            button_LVS.Click += button_LVS_Click;
            // 
            // dataGridViewOutput_LVS
            // 
            dataGridViewOutput_LVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_LVS.Location = new Point(321, 69);
            dataGridViewOutput_LVS.Name = "dataGridViewOutput_LVS";
            dataGridViewOutput_LVS.RowHeadersWidth = 62;
            dataGridViewOutput_LVS.Size = new Size(311, 362);
            dataGridViewOutput_LVS.TabIndex = 5;
            dataGridViewOutput_LVS.CellContentClick += dataGridViewOutput_LVS_CellContentClick;
            // 
            // buttonnNotify_LVS
            // 
            buttonnNotify_LVS.BackColor = Color.FromArgb(224, 224, 224);
            buttonnNotify_LVS.Location = new Point(645, 477);
            buttonnNotify_LVS.Name = "buttonnNotify_LVS";
            buttonnNotify_LVS.Size = new Size(69, 54);
            buttonnNotify_LVS.TabIndex = 6;
            buttonnNotify_LVS.Text = "!!!";
            buttonnNotify_LVS.UseVisualStyleBackColor = false;
            buttonnNotify_LVS.Click += buttonnNotify_LVS_Click;
            // 
            // textBox_LVS
            // 
            textBox_LVS.Location = new Point(12, 51);
            textBox_LVS.Multiline = true;
            textBox_LVS.Name = "textBox_LVS";
            textBox_LVS.Size = new Size(229, 310);
            textBox_LVS.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 543);
            Controls.Add(textBox_LVS);
            Controls.Add(buttonnNotify_LVS);
            Controls.Add(dataGridViewOutput_LVS);
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
        private Button buttonnNotify_LVS;
        private TextBox textBox_LVS;
    }
}
