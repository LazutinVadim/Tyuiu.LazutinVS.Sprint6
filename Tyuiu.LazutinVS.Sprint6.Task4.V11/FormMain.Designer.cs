namespace Tyuiu.LazutinVS.Sprint6.Task4.V11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chart_LVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button_LVS = new Button();
            textBoxEnd_LVS = new TextBox();
            textBoxStart_LVS = new TextBox();
            textBox3_LVS = new TextBox();
            labelStart_LVS = new Label();
            labelEnd_LVS = new Label();
            ((System.ComponentModel.ISupportInitialize)chart_LVS).BeginInit();
            SuspendLayout();
            // 
            // chart_LVS
            // 
            chartArea2.Name = "ChartArea1";
            chart_LVS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_LVS.Legends.Add(legend2);
            chart_LVS.Location = new Point(12, 12);
            chart_LVS.Name = "chart_LVS";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            chart_LVS.Series.Add(series2);
            chart_LVS.Size = new Size(715, 450);
            chart_LVS.TabIndex = 0;
            chart_LVS.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Function";
            chart_LVS.Titles.Add(title2);
            // 
            // button_LVS
            // 
            button_LVS.Location = new Point(762, 602);
            button_LVS.Name = "button_LVS";
            button_LVS.Size = new Size(291, 60);
            button_LVS.TabIndex = 1;
            button_LVS.Text = "button_LVS";
            button_LVS.UseVisualStyleBackColor = true;
            button_LVS.Click += button1_Click;
            // 
            // textBoxEnd_LVS
            // 
            textBoxEnd_LVS.Location = new Point(226, 555);
            textBoxEnd_LVS.Name = "textBoxEnd_LVS";
            textBoxEnd_LVS.Size = new Size(150, 31);
            textBoxEnd_LVS.TabIndex = 2;
            textBoxEnd_LVS.TextChanged += textBox1_TextChanged;
            // 
            // textBoxStart_LVS
            // 
            textBoxStart_LVS.Location = new Point(12, 555);
            textBoxStart_LVS.Name = "textBoxStart_LVS";
            textBoxStart_LVS.Size = new Size(150, 31);
            textBoxStart_LVS.TabIndex = 3;
            // 
            // textBox3_LVS
            // 
            textBox3_LVS.Location = new Point(790, 12);
            textBox3_LVS.Multiline = true;
            textBox3_LVS.Name = "textBox3_LVS";
            textBox3_LVS.Size = new Size(263, 538);
            textBox3_LVS.TabIndex = 4;
            // 
            // labelStart_LVS
            // 
            labelStart_LVS.AutoSize = true;
            labelStart_LVS.Location = new Point(12, 527);
            labelStart_LVS.Name = "labelStart_LVS";
            labelStart_LVS.Size = new Size(48, 25);
            labelStart_LVS.TabIndex = 5;
            labelStart_LVS.Text = "Start";
            // 
            // labelEnd_LVS
            // 
            labelEnd_LVS.AutoSize = true;
            labelEnd_LVS.Location = new Point(226, 527);
            labelEnd_LVS.Name = "labelEnd_LVS";
            labelEnd_LVS.Size = new Size(42, 25);
            labelEnd_LVS.TabIndex = 6;
            labelEnd_LVS.Text = "End";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 674);
            Controls.Add(labelEnd_LVS);
            Controls.Add(labelStart_LVS);
            Controls.Add(textBox3_LVS);
            Controls.Add(textBoxStart_LVS);
            Controls.Add(textBoxEnd_LVS);
            Controls.Add(button_LVS);
            Controls.Add(chart_LVS);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart_LVS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_LVS;
        private Button button_LVS;
        private TextBox textBoxEnd_LVS;
        private TextBox textBoxStart_LVS;
        private TextBox textBox3_LVS;
        private Label labelStart_LVS;
        private Label labelEnd_LVS;
    }
}
