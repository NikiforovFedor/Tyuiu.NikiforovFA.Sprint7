namespace Tyuiu.NikiforovFA.Sprint7.Project.V3
{
    partial class FormMore
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
            groupBoxData_NFA = new GroupBox();
            labelCount_NFA = new Label();
            labelExpAvg_NFA = new Label();
            labelAgeAvg_NFA = new Label();
            labelAgeMax_NFA = new Label();
            labelAgeMin_NFA = new Label();
            groupBoxData_NFA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxData_NFA
            // 
            groupBoxData_NFA.Controls.Add(labelCount_NFA);
            groupBoxData_NFA.Controls.Add(labelExpAvg_NFA);
            groupBoxData_NFA.Controls.Add(labelAgeAvg_NFA);
            groupBoxData_NFA.Controls.Add(labelAgeMax_NFA);
            groupBoxData_NFA.Controls.Add(labelAgeMin_NFA);
            groupBoxData_NFA.Location = new Point(12, 12);
            groupBoxData_NFA.Name = "groupBoxData_NFA";
            groupBoxData_NFA.Size = new Size(225, 387);
            groupBoxData_NFA.TabIndex = 0;
            groupBoxData_NFA.TabStop = false;
            groupBoxData_NFA.Text = "Данные";
            // 
            // labelCount_NFA
            // 
            labelCount_NFA.AutoSize = true;
            labelCount_NFA.Location = new Point(0, 27);
            labelCount_NFA.Name = "labelCount_NFA";
            labelCount_NFA.Size = new Size(170, 15);
            labelCount_NFA.TabIndex = 4;
            labelCount_NFA.Text = "Количество преподавателей: ";
            // 
            // labelExpAvg_NFA
            // 
            labelExpAvg_NFA.AutoSize = true;
            labelExpAvg_NFA.Location = new Point(0, 87);
            labelExpAvg_NFA.Name = "labelExpAvg_NFA";
            labelExpAvg_NFA.Size = new Size(90, 15);
            labelExpAvg_NFA.TabIndex = 3;
            labelExpAvg_NFA.Text = "Средний стаж: ";
            // 
            // labelAgeAvg_NFA
            // 
            labelAgeAvg_NFA.AutoSize = true;
            labelAgeAvg_NFA.Location = new Point(0, 72);
            labelAgeAvg_NFA.Name = "labelAgeAvg_NFA";
            labelAgeAvg_NFA.Size = new Size(106, 15);
            labelAgeAvg_NFA.TabIndex = 2;
            labelAgeAvg_NFA.Text = "Средний возраст: ";
            // 
            // labelAgeMax_NFA
            // 
            labelAgeMax_NFA.AutoSize = true;
            labelAgeMax_NFA.Location = new Point(0, 57);
            labelAgeMax_NFA.Name = "labelAgeMax_NFA";
            labelAgeMax_NFA.Size = new Size(145, 15);
            labelAgeMax_NFA.TabIndex = 1;
            labelAgeMax_NFA.Text = "Максимальный возраст: ";
            // 
            // labelAgeMin_NFA
            // 
            labelAgeMin_NFA.AutoSize = true;
            labelAgeMin_NFA.Location = new Point(0, 42);
            labelAgeMin_NFA.Name = "labelAgeMin_NFA";
            labelAgeMin_NFA.Size = new Size(141, 15);
            labelAgeMin_NFA.TabIndex = 0;
            labelAgeMin_NFA.Text = "Минимальный возраст: ";
            labelAgeMin_NFA.Click += label1_Click;
            // 
            // FormMore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 411);
            Controls.Add(groupBoxData_NFA);
            MaximumSize = new Size(730, 450);
            MinimumSize = new Size(730, 450);
            Name = "FormMore";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Статистика";
            Load += FormMore_Load_1;
            groupBoxData_NFA.ResumeLayout(false);
            groupBoxData_NFA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxData_NFA;
        private Label labelAgeMax_NFA;
        private Label labelAgeMin_NFA;
        private Label labelExpAvg_NFA;
        private Label labelAgeAvg_NFA;
        private Label labelCount_NFA;
    }
}