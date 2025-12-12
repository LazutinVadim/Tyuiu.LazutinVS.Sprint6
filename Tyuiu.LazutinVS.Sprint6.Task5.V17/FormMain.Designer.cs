namespace Tyuiu.LazutinVS.Sprint6.Task5.V17
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
            chart_LVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button_LVS = new Button();
            dataGridView_LVS = new DataGridView();
            buttonChoose_LVS = new Button();
            ((System.ComponentModel.ISupportInitialize)chart_LVS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LVS).BeginInit();
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
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_LVS.Series.Add(series2);
            chart_LVS.Size = new Size(725, 476);
            chart_LVS.TabIndex = 0;
            chart_LVS.Text = "chart1";
            // 
            // button_LVS
            // 
            button_LVS.Location = new Point(766, 605);
            button_LVS.Name = "button_LVS";
            button_LVS.Size = new Size(314, 89);
            button_LVS.TabIndex = 2;
            button_LVS.Text = "Кнопка";
            button_LVS.UseVisualStyleBackColor = true;
            button_LVS.Click += button_LVS_Click;
            // 
            // dataGridView_LVS
            // 
            dataGridView_LVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_LVS.Location = new Point(767, 53);
            dataGridView_LVS.Name = "dataGridView_LVS";
            dataGridView_LVS.RowHeadersWidth = 62;
            dataGridView_LVS.Size = new Size(313, 295);
            dataGridView_LVS.TabIndex = 3;
            dataGridView_LVS.CellContentClick += dataGridView_LVS_CellContentClick;
            // 
            // buttonChoose_LVS
            // 
            buttonChoose_LVS.Location = new Point(487, 623);
            buttonChoose_LVS.Name = "buttonChoose_LVS";
            buttonChoose_LVS.Size = new Size(250, 71);
            buttonChoose_LVS.TabIndex = 4;
            buttonChoose_LVS.Text = "button1";
            buttonChoose_LVS.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 716);
            Controls.Add(buttonChoose_LVS);
            Controls.Add(dataGridView_LVS);
            Controls.Add(button_LVS);
            Controls.Add(chart_LVS);
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart_LVS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_LVS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_LVS;
        private Button button_LVS;
        private DataGridView dataGridView_LVS;
        private Button buttonChoose_LVS;
    }
}
