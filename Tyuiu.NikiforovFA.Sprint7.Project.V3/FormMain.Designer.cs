namespace Tyuiu.NikiforovFA.Sprint7.Project.V3
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
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            TabBarNavigation_NFA = new TabControl();
            tabPageFile_NFA = new TabPage();
            tabPageMain_NFA = new TabPage();
            buttonImport_NFA = new Button();
            buttonExport_NFA = new Button();
            labelImport_NFA = new Label();
            labelExport_NFA = new Label();
            groupBoxEdit_NFA = new GroupBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            TabBarNavigation_NFA.SuspendLayout();
            tabPageFile_NFA.SuspendLayout();
            tabPageMain_NFA.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(TabBarNavigation_NFA);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 120);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(14, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 428);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(475, 428);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TabBarNavigation_NFA
            // 
            TabBarNavigation_NFA.Controls.Add(tabPageFile_NFA);
            TabBarNavigation_NFA.Controls.Add(tabPageMain_NFA);
            TabBarNavigation_NFA.Dock = DockStyle.Fill;
            TabBarNavigation_NFA.Location = new Point(0, 0);
            TabBarNavigation_NFA.Name = "TabBarNavigation_NFA";
            TabBarNavigation_NFA.SelectedIndex = 0;
            TabBarNavigation_NFA.Size = new Size(475, 120);
            TabBarNavigation_NFA.TabIndex = 0;
            // 
            // tabPageFile_NFA
            // 
            tabPageFile_NFA.Controls.Add(labelExport_NFA);
            tabPageFile_NFA.Controls.Add(labelImport_NFA);
            tabPageFile_NFA.Controls.Add(buttonExport_NFA);
            tabPageFile_NFA.Controls.Add(buttonImport_NFA);
            tabPageFile_NFA.Location = new Point(4, 24);
            tabPageFile_NFA.Name = "tabPageFile_NFA";
            tabPageFile_NFA.Padding = new Padding(3);
            tabPageFile_NFA.Size = new Size(467, 92);
            tabPageFile_NFA.TabIndex = 0;
            tabPageFile_NFA.Text = "Файл";
            tabPageFile_NFA.UseVisualStyleBackColor = true;
            // 
            // tabPageMain_NFA
            // 
            tabPageMain_NFA.Controls.Add(groupBoxEdit_NFA);
            tabPageMain_NFA.Location = new Point(4, 24);
            tabPageMain_NFA.Name = "tabPageMain_NFA";
            tabPageMain_NFA.Padding = new Padding(3);
            tabPageMain_NFA.Size = new Size(467, 92);
            tabPageMain_NFA.TabIndex = 1;
            tabPageMain_NFA.Text = "Главная";
            tabPageMain_NFA.UseVisualStyleBackColor = true;
            // 
            // buttonImport_NFA
            // 
            buttonImport_NFA.BackColor = Color.White;
            buttonImport_NFA.BackgroundImageLayout = ImageLayout.None;
            buttonImport_NFA.Cursor = Cursors.Hand;
            buttonImport_NFA.FlatStyle = FlatStyle.Flat;
            buttonImport_NFA.Image = Properties.Resources.import_file_icon;
            buttonImport_NFA.Location = new Point(16, 22);
            buttonImport_NFA.Name = "buttonImport_NFA";
            buttonImport_NFA.Size = new Size(64, 64);
            buttonImport_NFA.TabIndex = 0;
            buttonImport_NFA.UseVisualStyleBackColor = false;
            // 
            // buttonExport_NFA
            // 
            buttonExport_NFA.BackColor = Color.White;
            buttonExport_NFA.BackgroundImageLayout = ImageLayout.None;
            buttonExport_NFA.Cursor = Cursors.Hand;
            buttonExport_NFA.FlatStyle = FlatStyle.Flat;
            buttonExport_NFA.Image = (Image)resources.GetObject("buttonExport_NFA.Image");
            buttonExport_NFA.Location = new Point(124, 22);
            buttonExport_NFA.Name = "buttonExport_NFA";
            buttonExport_NFA.Size = new Size(64, 64);
            buttonExport_NFA.TabIndex = 0;
            buttonExport_NFA.UseVisualStyleBackColor = false;
            buttonExport_NFA.Click += buttonExport_NFA_Click;
            // 
            // labelImport_NFA
            // 
            labelImport_NFA.AutoSize = true;
            labelImport_NFA.Location = new Point(6, 4);
            labelImport_NFA.Name = "labelImport_NFA";
            labelImport_NFA.Size = new Size(89, 15);
            labelImport_NFA.TabIndex = 1;
            labelImport_NFA.Text = "Импорт файла";
            // 
            // labelExport_NFA
            // 
            labelExport_NFA.AutoSize = true;
            labelExport_NFA.Location = new Point(112, 4);
            labelExport_NFA.Name = "labelExport_NFA";
            labelExport_NFA.Size = new Size(90, 15);
            labelExport_NFA.TabIndex = 2;
            labelExport_NFA.Text = "Экспорт файла";
            // 
            // groupBoxEdit_NFA
            // 
            groupBoxEdit_NFA.Dock = DockStyle.Fill;
            groupBoxEdit_NFA.Location = new Point(3, 3);
            groupBoxEdit_NFA.Name = "groupBoxEdit_NFA";
            groupBoxEdit_NFA.Size = new Size(461, 86);
            groupBoxEdit_NFA.TabIndex = 0;
            groupBoxEdit_NFA.TabStop = false;
            groupBoxEdit_NFA.Text = "Редактирование";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 609);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Преподавтели Университета";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            TabBarNavigation_NFA.ResumeLayout(false);
            tabPageFile_NFA.ResumeLayout(false);
            tabPageFile_NFA.PerformLayout();
            tabPageMain_NFA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TabControl TabBarNavigation_NFA;
        private TabPage tabPageFile_NFA;
        private TabPage tabPageMain_NFA;
        private Button button2;
        private Button buttonImport_NFA;
        private Button buttonExport_NFA;
        private Label labelExport_NFA;
        private Label labelImport_NFA;
        private GroupBox groupBoxEdit_NFA;
    }
}
