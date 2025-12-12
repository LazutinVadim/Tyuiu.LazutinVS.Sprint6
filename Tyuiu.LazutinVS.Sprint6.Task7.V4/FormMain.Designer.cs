namespace Tyuiu.LazutinVS.Sprint6.Task7.V4
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
            labelInput_LVS = new Label();
            label1 = new Label();
            label2 = new Label();
            textUslovie_LVS = new TextBox();
            buttonOpen_LVS = new Button();
            buttonExecute_LVS = new Button();
            buttonSave_LVS = new Button();
            buttonS_LVS = new Button();
            openFileDialogTask_LVS = new OpenFileDialog();
            Input_LVS = new DataGridView();
            Output_LVS = new DataGridView();
            saveFileDialogMatrix_LVS = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)Input_LVS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Output_LVS).BeginInit();
            SuspendLayout();
            // 
            // labelInput_LVS
            // 
            labelInput_LVS.AutoSize = true;
            labelInput_LVS.Location = new Point(12, 204);
            labelInput_LVS.Name = "labelInput_LVS";
            labelInput_LVS.Size = new Size(53, 25);
            labelInput_LVS.TabIndex = 2;
            labelInput_LVS.Text = "Ввод";
            labelInput_LVS.Click += labelInput_LVS_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(528, 204);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 3;
            label1.Text = "Вывод";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 4;
            label2.Text = "Условие";
            // 
            // textUslovie_LVS
            // 
            textUslovie_LVS.Location = new Point(12, 108);
            textUslovie_LVS.Multiline = true;
            textUslovie_LVS.Name = "textUslovie_LVS";
            textUslovie_LVS.Size = new Size(1026, 93);
            textUslovie_LVS.TabIndex = 5;
            textUslovie_LVS.Text = resources.GetString("textUslovie_LVS.Text");
            // 
            // buttonOpen_LVS
            // 
            buttonOpen_LVS.BackColor = Color.FromArgb(128, 255, 128);
            buttonOpen_LVS.Location = new Point(12, 15);
            buttonOpen_LVS.Name = "buttonOpen_LVS";
            buttonOpen_LVS.Size = new Size(159, 62);
            buttonOpen_LVS.TabIndex = 6;
            buttonOpen_LVS.Text = "Открыть файл";
            buttonOpen_LVS.UseVisualStyleBackColor = false;
            buttonOpen_LVS.Click += buttonOpen_LVS_Click;
            // 
            // buttonExecute_LVS
            // 
            buttonExecute_LVS.Enabled = false;
            buttonExecute_LVS.FlatStyle = FlatStyle.Flat;
            buttonExecute_LVS.Location = new Point(177, 12);
            buttonExecute_LVS.Name = "buttonExecute_LVS";
            buttonExecute_LVS.Size = new Size(159, 70);
            buttonExecute_LVS.TabIndex = 7;
            buttonExecute_LVS.Text = "Выполнить";
            buttonExecute_LVS.UseVisualStyleBackColor = true;
            buttonExecute_LVS.Click += buttonExecute_LVS_Click;
            // 
            // buttonSave_LVS
            // 
            buttonSave_LVS.BackColor = SystemColors.ActiveCaption;
            buttonSave_LVS.Enabled = false;
            buttonSave_LVS.FlatStyle = FlatStyle.Flat;
            buttonSave_LVS.Location = new Point(342, 12);
            buttonSave_LVS.Name = "buttonSave_LVS";
            buttonSave_LVS.Size = new Size(159, 70);
            buttonSave_LVS.TabIndex = 8;
            buttonSave_LVS.Text = "Сохранить файл";
            buttonSave_LVS.UseVisualStyleBackColor = false;
            buttonSave_LVS.Click += buttonSave_LVS_Click;
            // 
            // buttonS_LVS
            // 
            buttonS_LVS.BackColor = SystemColors.ActiveCaption;
            buttonS_LVS.Location = new Point(978, 12);
            buttonS_LVS.Name = "buttonS_LVS";
            buttonS_LVS.Size = new Size(60, 70);
            buttonS_LVS.TabIndex = 9;
            buttonS_LVS.Text = "?";
            buttonS_LVS.UseVisualStyleBackColor = false;
            buttonS_LVS.Click += buttonS_LVS_Click;
            // 
            // openFileDialogTask_LVS
            // 
            openFileDialogTask_LVS.FileName = "openFileDialog1";
            openFileDialogTask_LVS.FileOk += openFileDialogTask_FileOk;
            // 
            // Input_LVS
            // 
            Input_LVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Input_LVS.Location = new Point(12, 232);
            Input_LVS.Name = "Input_LVS";
            Input_LVS.RowHeadersWidth = 62;
            Input_LVS.Size = new Size(489, 510);
            Input_LVS.TabIndex = 10;
            // 
            // Output_LVS
            // 
            Output_LVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Output_LVS.Location = new Point(528, 232);
            Output_LVS.Name = "Output_LVS";
            Output_LVS.RowHeadersWidth = 62;
            Output_LVS.Size = new Size(510, 510);
            Output_LVS.TabIndex = 11;
            // 
            // saveFileDialogMatrix_LVS
            // 
            saveFileDialogMatrix_LVS.FileOk += saveFileDialogMatrix_LVS_FileOk;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 754);
            Controls.Add(Output_LVS);
            Controls.Add(Input_LVS);
            Controls.Add(buttonS_LVS);
            Controls.Add(buttonSave_LVS);
            Controls.Add(buttonExecute_LVS);
            Controls.Add(buttonOpen_LVS);
            Controls.Add(textUslovie_LVS);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelInput_LVS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 4";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)Input_LVS).EndInit();
            ((System.ComponentModel.ISupportInitialize)Output_LVS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelInput_LVS;
        private Label label1;
        private Label label2;
        private TextBox textUslovie_LVS;
        private Button buttonOpen_LVS;
        private Button buttonExecute_LVS;
        private Button buttonSave_LVS;
        private Button buttonS_LVS;
        private OpenFileDialog openFileDialogTask_LVS;
        private DataGridView Input_LVS;
        private DataGridView Output_LVS;
        private SaveFileDialog saveFileDialogMatrix_LVS;
    }
}
