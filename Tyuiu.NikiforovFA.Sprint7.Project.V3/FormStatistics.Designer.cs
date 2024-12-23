namespace Tyuiu.NikiforovFA.Sprint7.Project.V3
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxData_NFA = new GroupBox();
            labelExpAvg_NFA = new Label();
            labelAvgAge_NFA = new Label();
            labelMinAge_NFA = new Label();
            labelMaxAge_NFA = new Label();
            labelCount_NFA = new Label();
            chartExpAge_NFA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxData_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartExpAge_NFA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxData_NFA
            // 
            groupBoxData_NFA.Controls.Add(labelExpAvg_NFA);
            groupBoxData_NFA.Controls.Add(labelAvgAge_NFA);
            groupBoxData_NFA.Controls.Add(labelMinAge_NFA);
            groupBoxData_NFA.Controls.Add(labelMaxAge_NFA);
            groupBoxData_NFA.Controls.Add(labelCount_NFA);
            groupBoxData_NFA.Location = new Point(12, 12);
            groupBoxData_NFA.Name = "groupBoxData_NFA";
            groupBoxData_NFA.Size = new Size(201, 367);
            groupBoxData_NFA.TabIndex = 0;
            groupBoxData_NFA.TabStop = false;
            groupBoxData_NFA.Text = "Данные";
            // 
            // labelExpAvg_NFA
            // 
            labelExpAvg_NFA.AutoSize = true;
            labelExpAvg_NFA.Location = new Point(6, 79);
            labelExpAvg_NFA.Name = "labelExpAvg_NFA";
            labelExpAvg_NFA.Size = new Size(90, 15);
            labelExpAvg_NFA.TabIndex = 0;
            labelExpAvg_NFA.Text = "Средний стаж: ";
            // 
            // labelAvgAge_NFA
            // 
            labelAvgAge_NFA.AutoSize = true;
            labelAvgAge_NFA.Location = new Point(6, 64);
            labelAvgAge_NFA.Name = "labelAvgAge_NFA";
            labelAvgAge_NFA.Size = new Size(106, 15);
            labelAvgAge_NFA.TabIndex = 0;
            labelAvgAge_NFA.Text = "Средний возраст: ";
            // 
            // labelMinAge_NFA
            // 
            labelMinAge_NFA.AutoSize = true;
            labelMinAge_NFA.Location = new Point(6, 49);
            labelMinAge_NFA.Name = "labelMinAge_NFA";
            labelMinAge_NFA.Size = new Size(141, 15);
            labelMinAge_NFA.TabIndex = 0;
            labelMinAge_NFA.Text = "Минимальный возраст: ";
            // 
            // labelMaxAge_NFA
            // 
            labelMaxAge_NFA.AutoSize = true;
            labelMaxAge_NFA.Location = new Point(6, 34);
            labelMaxAge_NFA.Name = "labelMaxAge_NFA";
            labelMaxAge_NFA.Size = new Size(145, 15);
            labelMaxAge_NFA.TabIndex = 0;
            labelMaxAge_NFA.Text = "Максимальный возраст: ";
            // 
            // labelCount_NFA
            // 
            labelCount_NFA.AutoSize = true;
            labelCount_NFA.Location = new Point(6, 19);
            labelCount_NFA.Name = "labelCount_NFA";
            labelCount_NFA.Size = new Size(170, 15);
            labelCount_NFA.TabIndex = 0;
            labelCount_NFA.Text = "Количество преподавателей: ";
            // 
            // chartExpAge_NFA
            // 
            chartArea1.Name = "ChartArea1";
            chartExpAge_NFA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartExpAge_NFA.Legends.Add(legend1);
            chartExpAge_NFA.Location = new Point(219, 12);
            chartExpAge_NFA.Name = "chartExpAge_NFA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartExpAge_NFA.Series.Add(series1);
            chartExpAge_NFA.Size = new Size(353, 367);
            chartExpAge_NFA.TabIndex = 1;
            chartExpAge_NFA.Text = "Зависимость стажа от возраста";
            chartExpAge_NFA.Click += chartExpAge_NFA_Click;
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 391);
            Controls.Add(chartExpAge_NFA);
            Controls.Add(groupBoxData_NFA);
            MaximizeBox = false;
            MaximumSize = new Size(600, 430);
            MinimumSize = new Size(600, 430);
            Name = "FormStatistics";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Статистика";
            Load += FormStatistics_Load;
            groupBoxData_NFA.ResumeLayout(false);
            groupBoxData_NFA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartExpAge_NFA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxData_NFA;
        private Label labelExpAvg_NFA;
        private Label labelAvgAge_NFA;
        private Label labelMinAge_NFA;
        private Label labelMaxAge_NFA;
        private Label labelCount_NFA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpAge_NFA;
    }
}