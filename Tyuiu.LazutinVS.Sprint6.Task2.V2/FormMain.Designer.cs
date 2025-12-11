namespace Tyuiu.LazutinVS.Sprint6.Task2.V2
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
            dataGridView_LVS = new DataGridView();
            textBoxStart_LVS = new TextBox();
            labelStart_LVS = new Label();
            textBoxEnd_LVS = new TextBox();
            button1 = new Button();
            labelEnd_LVS = new Label();
            button_LVS = new Button();
            ColumnX = new DataGridViewTextBoxColumn();
            columnValue = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LVS).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_LVS
            // 
            dataGridView_LVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_LVS.Columns.AddRange(new DataGridViewColumn[] { ColumnX, columnValue });
            dataGridView_LVS.Location = new Point(3, 92);
            dataGridView_LVS.Name = "dataGridView_LVS";
            dataGridView_LVS.RowHeadersWidth = 62;
            dataGridView_LVS.Size = new Size(322, 232);
            dataGridView_LVS.TabIndex = 0;
            // 
            // textBoxStart_LVS
            // 
            textBoxStart_LVS.Location = new Point(392, 293);
            textBoxStart_LVS.Name = "textBoxStart_LVS";
            textBoxStart_LVS.Size = new Size(150, 31);
            textBoxStart_LVS.TabIndex = 1;
            // 
            // labelStart_LVS
            // 
            labelStart_LVS.AutoSize = true;
            labelStart_LVS.Location = new Point(392, 265);
            labelStart_LVS.Name = "labelStart_LVS";
            labelStart_LVS.Size = new Size(48, 25);
            labelStart_LVS.TabIndex = 2;
            labelStart_LVS.Text = "Start";
            // 
            // textBoxEnd_LVS
            // 
            textBoxEnd_LVS.Location = new Point(573, 293);
            textBoxEnd_LVS.Name = "textBoxEnd_LVS";
            textBoxEnd_LVS.Size = new Size(150, 31);
            textBoxEnd_LVS.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(679, 270);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // labelEnd_LVS
            // 
            labelEnd_LVS.AutoSize = true;
            labelEnd_LVS.Location = new Point(573, 262);
            labelEnd_LVS.Name = "labelEnd_LVS";
            labelEnd_LVS.Size = new Size(42, 25);
            labelEnd_LVS.TabIndex = 5;
            labelEnd_LVS.Text = "End";
            // 
            // button_LVS
            // 
            button_LVS.BackColor = Color.Lime;
            button_LVS.Location = new Point(430, 368);
            button_LVS.Name = "button_LVS";
            button_LVS.Size = new Size(266, 56);
            button_LVS.TabIndex = 6;
            button_LVS.Text = "Старт";
            button_LVS.UseVisualStyleBackColor = false;
            button_LVS.Click += buttonStart_LVS_Click;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "";
            ColumnX.MinimumWidth = 8;
            ColumnX.Name = "ColumnX";
            ColumnX.Width = 150;
            // 
            // columnValue
            // 
            columnValue.HeaderText = "";
            columnValue.MinimumWidth = 8;
            columnValue.Name = "columnValue";
            columnValue.Width = 150;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_LVS);
            Controls.Add(labelEnd_LVS);
            Controls.Add(button1);
            Controls.Add(textBoxEnd_LVS);
            Controls.Add(labelStart_LVS);
            Controls.Add(textBoxStart_LVS);
            Controls.Add(dataGridView_LVS);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_LVS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_LVS;
        private TextBox textBoxStart_LVS;
        private Label labelStart_LVS;
        private TextBox textBoxEnd_LVS;
        private Button button1;
        private Label labelEnd_LVS;
        private Button button_LVS;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn columnValue;
    }
}
