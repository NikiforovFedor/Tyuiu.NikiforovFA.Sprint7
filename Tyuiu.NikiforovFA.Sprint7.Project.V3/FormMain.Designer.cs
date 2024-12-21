﻿namespace Tyuiu.NikiforovFA.Sprint7.Project.V3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelMenu_NFA = new Panel();
            TabBarNavigation_NFA = new TabControl();
            tabPageFile_NFA = new TabPage();
            groupBoxFile_NFA = new GroupBox();
            buttonExport_NFA = new Button();
            labelExport_NFA = new Label();
            labelImport_NFA = new Label();
            buttonImport_NFA = new Button();
            tabPageMain_NFA = new TabPage();
            groupBoxEdit_NFA = new GroupBox();
            buttonAddRow_NFA = new Button();
            tabPageInformation_NFA = new TabPage();
            panelGrid_NFA = new Panel();
            dataGridViewMainGrid_NFA = new DataGridView();
            ColumnID_NFA = new DataGridViewTextBoxColumn();
            ColumnName_NFA = new DataGridViewTextBoxColumn();
            ColumnNumber_NFA = new DataGridViewTextBoxColumn();
            ColumnSubject_NFA = new DataGridViewTextBoxColumn();
            ColumnAge_NFA = new DataGridViewTextBoxColumn();
            ColumnAudienceNumber_NFA = new DataGridViewTextBoxColumn();
            ColumnExperience_NFA = new DataGridViewTextBoxColumn();
            ColumnHoursPerWeek_NFA = new DataGridViewTextBoxColumn();
            openFileDialogImport_NFA = new OpenFileDialog();
            saveFileDialogExport_NFA = new SaveFileDialog();
            toolTip_NFA = new ToolTip(components);
            panelMenu_NFA.SuspendLayout();
            TabBarNavigation_NFA.SuspendLayout();
            tabPageFile_NFA.SuspendLayout();
            groupBoxFile_NFA.SuspendLayout();
            tabPageMain_NFA.SuspendLayout();
            groupBoxEdit_NFA.SuspendLayout();
            panelGrid_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainGrid_NFA).BeginInit();
            SuspendLayout();
            // 
            // panelMenu_NFA
            // 
            panelMenu_NFA.BackColor = Color.Gray;
            panelMenu_NFA.Controls.Add(TabBarNavigation_NFA);
            panelMenu_NFA.Dock = DockStyle.Top;
            panelMenu_NFA.Location = new Point(0, 0);
            panelMenu_NFA.Name = "panelMenu_NFA";
            panelMenu_NFA.Size = new Size(984, 150);
            panelMenu_NFA.TabIndex = 0;
            // 
            // TabBarNavigation_NFA
            // 
            TabBarNavigation_NFA.Controls.Add(tabPageFile_NFA);
            TabBarNavigation_NFA.Controls.Add(tabPageMain_NFA);
            TabBarNavigation_NFA.Controls.Add(tabPageInformation_NFA);
            TabBarNavigation_NFA.Dock = DockStyle.Fill;
            TabBarNavigation_NFA.Location = new Point(0, 0);
            TabBarNavigation_NFA.Name = "TabBarNavigation_NFA";
            TabBarNavigation_NFA.SelectedIndex = 0;
            TabBarNavigation_NFA.Size = new Size(984, 150);
            TabBarNavigation_NFA.TabIndex = 0;
            // 
            // tabPageFile_NFA
            // 
            tabPageFile_NFA.BackColor = Color.LightGray;
            tabPageFile_NFA.Controls.Add(groupBoxFile_NFA);
            tabPageFile_NFA.Location = new Point(4, 24);
            tabPageFile_NFA.Name = "tabPageFile_NFA";
            tabPageFile_NFA.Padding = new Padding(3);
            tabPageFile_NFA.Size = new Size(976, 122);
            tabPageFile_NFA.TabIndex = 0;
            tabPageFile_NFA.Text = "Файл";
            // 
            // groupBoxFile_NFA
            // 
            groupBoxFile_NFA.Controls.Add(buttonExport_NFA);
            groupBoxFile_NFA.Controls.Add(labelExport_NFA);
            groupBoxFile_NFA.Controls.Add(labelImport_NFA);
            groupBoxFile_NFA.Controls.Add(buttonImport_NFA);
            groupBoxFile_NFA.Dock = DockStyle.Fill;
            groupBoxFile_NFA.Location = new Point(3, 3);
            groupBoxFile_NFA.Name = "groupBoxFile_NFA";
            groupBoxFile_NFA.Size = new Size(970, 116);
            groupBoxFile_NFA.TabIndex = 3;
            groupBoxFile_NFA.TabStop = false;
            groupBoxFile_NFA.Text = "Работа с файлом";
            // 
            // buttonExport_NFA
            // 
            buttonExport_NFA.BackColor = Color.White;
            buttonExport_NFA.BackgroundImageLayout = ImageLayout.None;
            buttonExport_NFA.Cursor = Cursors.Hand;
            buttonExport_NFA.Enabled = false;
            buttonExport_NFA.FlatStyle = FlatStyle.Popup;
            buttonExport_NFA.Image = (Image)resources.GetObject("buttonExport_NFA.Image");
            buttonExport_NFA.Location = new Point(76, 22);
            buttonExport_NFA.Name = "buttonExport_NFA";
            buttonExport_NFA.Size = new Size(64, 64);
            buttonExport_NFA.TabIndex = 0;
            buttonExport_NFA.UseVisualStyleBackColor = false;
            buttonExport_NFA.Click += buttonExport_NFA_Click;
            buttonExport_NFA.MouseEnter += buttonExport_NFA_MouseEnter;
            // 
            // labelExport_NFA
            // 
            labelExport_NFA.AutoSize = true;
            labelExport_NFA.Location = new Point(83, 89);
            labelExport_NFA.Name = "labelExport_NFA";
            labelExport_NFA.Size = new Size(52, 15);
            labelExport_NFA.TabIndex = 2;
            labelExport_NFA.Text = "Экспорт";
            // 
            // labelImport_NFA
            // 
            labelImport_NFA.AutoSize = true;
            labelImport_NFA.Location = new Point(13, 89);
            labelImport_NFA.Name = "labelImport_NFA";
            labelImport_NFA.Size = new Size(51, 15);
            labelImport_NFA.TabIndex = 1;
            labelImport_NFA.Text = "Импорт";
            // 
            // buttonImport_NFA
            // 
            buttonImport_NFA.BackColor = Color.White;
            buttonImport_NFA.BackgroundImageLayout = ImageLayout.None;
            buttonImport_NFA.Cursor = Cursors.Hand;
            buttonImport_NFA.FlatStyle = FlatStyle.Popup;
            buttonImport_NFA.Image = Properties.Resources.import_file_icon;
            buttonImport_NFA.Location = new Point(6, 22);
            buttonImport_NFA.Name = "buttonImport_NFA";
            buttonImport_NFA.Size = new Size(64, 64);
            buttonImport_NFA.TabIndex = 0;
            buttonImport_NFA.UseVisualStyleBackColor = false;
            buttonImport_NFA.Click += buttonImport_NFA_Click;
            buttonImport_NFA.MouseEnter += buttonImport_NFA_MouseEnter;
            // 
            // tabPageMain_NFA
            // 
            tabPageMain_NFA.Controls.Add(groupBoxEdit_NFA);
            tabPageMain_NFA.Location = new Point(4, 24);
            tabPageMain_NFA.Name = "tabPageMain_NFA";
            tabPageMain_NFA.Padding = new Padding(3);
            tabPageMain_NFA.Size = new Size(976, 122);
            tabPageMain_NFA.TabIndex = 1;
            tabPageMain_NFA.Text = "Главная";
            tabPageMain_NFA.UseVisualStyleBackColor = true;
            // 
            // groupBoxEdit_NFA
            // 
            groupBoxEdit_NFA.BackColor = Color.LightGray;
            groupBoxEdit_NFA.Controls.Add(buttonAddRow_NFA);
            groupBoxEdit_NFA.Dock = DockStyle.Fill;
            groupBoxEdit_NFA.Location = new Point(3, 3);
            groupBoxEdit_NFA.Name = "groupBoxEdit_NFA";
            groupBoxEdit_NFA.Size = new Size(970, 116);
            groupBoxEdit_NFA.TabIndex = 0;
            groupBoxEdit_NFA.TabStop = false;
            groupBoxEdit_NFA.Text = "Редактирование";
            // 
            // buttonAddRow_NFA
            // 
            buttonAddRow_NFA.BackColor = Color.White;
            buttonAddRow_NFA.BackgroundImageLayout = ImageLayout.None;
            buttonAddRow_NFA.Cursor = Cursors.Hand;
            buttonAddRow_NFA.FlatStyle = FlatStyle.Popup;
            buttonAddRow_NFA.Image = (Image)resources.GetObject("buttonAddRow_NFA.Image");
            buttonAddRow_NFA.Location = new Point(17, 22);
            buttonAddRow_NFA.Name = "buttonAddRow_NFA";
            buttonAddRow_NFA.Size = new Size(64, 64);
            buttonAddRow_NFA.TabIndex = 1;
            buttonAddRow_NFA.UseVisualStyleBackColor = false;
            buttonAddRow_NFA.Click += buttonAddRow_NFA_Click;
            buttonAddRow_NFA.MouseEnter += buttonAddRow_NFA_MouseEnter;
            // 
            // tabPageInformation_NFA
            // 
            tabPageInformation_NFA.BackColor = Color.LightGray;
            tabPageInformation_NFA.Location = new Point(4, 24);
            tabPageInformation_NFA.Name = "tabPageInformation_NFA";
            tabPageInformation_NFA.Padding = new Padding(3);
            tabPageInformation_NFA.Size = new Size(976, 122);
            tabPageInformation_NFA.TabIndex = 2;
            tabPageInformation_NFA.Text = "О программе";
            // 
            // panelGrid_NFA
            // 
            panelGrid_NFA.AutoScroll = true;
            panelGrid_NFA.AutoSize = true;
            panelGrid_NFA.Controls.Add(dataGridViewMainGrid_NFA);
            panelGrid_NFA.Dock = DockStyle.Fill;
            panelGrid_NFA.Location = new Point(0, 150);
            panelGrid_NFA.Name = "panelGrid_NFA";
            panelGrid_NFA.Size = new Size(984, 511);
            panelGrid_NFA.TabIndex = 1;
            // 
            // dataGridViewMainGrid_NFA
            // 
            dataGridViewMainGrid_NFA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewMainGrid_NFA.BackgroundColor = Color.White;
            dataGridViewMainGrid_NFA.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMainGrid_NFA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMainGrid_NFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMainGrid_NFA.Columns.AddRange(new DataGridViewColumn[] { ColumnID_NFA, ColumnName_NFA, ColumnNumber_NFA, ColumnSubject_NFA, ColumnAge_NFA, ColumnAudienceNumber_NFA, ColumnExperience_NFA, ColumnHoursPerWeek_NFA });
            dataGridViewMainGrid_NFA.Dock = DockStyle.Fill;
            dataGridViewMainGrid_NFA.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewMainGrid_NFA.Location = new Point(0, 0);
            dataGridViewMainGrid_NFA.Name = "dataGridViewMainGrid_NFA";
            dataGridViewMainGrid_NFA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewMainGrid_NFA.Size = new Size(984, 511);
            dataGridViewMainGrid_NFA.TabIndex = 0;
            dataGridViewMainGrid_NFA.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnID_NFA
            // 
            ColumnID_NFA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnID_NFA.HeaderText = "ID";
            ColumnID_NFA.MinimumWidth = 30;
            ColumnID_NFA.Name = "ColumnID_NFA";
            ColumnID_NFA.Width = 30;
            // 
            // ColumnName_NFA
            // 
            ColumnName_NFA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnName_NFA.HeaderText = "ФИО";
            ColumnName_NFA.MinimumWidth = 45;
            ColumnName_NFA.Name = "ColumnName_NFA";
            ColumnName_NFA.Width = 45;
            // 
            // ColumnNumber_NFA
            // 
            ColumnNumber_NFA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnNumber_NFA.HeaderText = "Номер телефона";
            ColumnNumber_NFA.MinimumWidth = 80;
            ColumnNumber_NFA.Name = "ColumnNumber_NFA";
            ColumnNumber_NFA.Width = 80;
            // 
            // ColumnSubject_NFA
            // 
            ColumnSubject_NFA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnSubject_NFA.HeaderText = "Предмет";
            ColumnSubject_NFA.MinimumWidth = 60;
            ColumnSubject_NFA.Name = "ColumnSubject_NFA";
            ColumnSubject_NFA.Width = 60;
            // 
            // ColumnAge_NFA
            // 
            ColumnAge_NFA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnAge_NFA.HeaderText = "Возраст";
            ColumnAge_NFA.MinimumWidth = 60;
            ColumnAge_NFA.Name = "ColumnAge_NFA";
            ColumnAge_NFA.Width = 60;
            // 
            // ColumnAudienceNumber_NFA
            // 
            ColumnAudienceNumber_NFA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnAudienceNumber_NFA.HeaderText = "Номер аудитории";
            ColumnAudienceNumber_NFA.MinimumWidth = 80;
            ColumnAudienceNumber_NFA.Name = "ColumnAudienceNumber_NFA";
            ColumnAudienceNumber_NFA.Width = 80;
            // 
            // ColumnExperience_NFA
            // 
            ColumnExperience_NFA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnExperience_NFA.HeaderText = "Опыт работы";
            ColumnExperience_NFA.MinimumWidth = 60;
            ColumnExperience_NFA.Name = "ColumnExperience_NFA";
            ColumnExperience_NFA.Width = 60;
            // 
            // ColumnHoursPerWeek_NFA
            // 
            ColumnHoursPerWeek_NFA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            ColumnHoursPerWeek_NFA.HeaderText = "Количество часов в неделю";
            ColumnHoursPerWeek_NFA.MinimumWidth = 85;
            ColumnHoursPerWeek_NFA.Name = "ColumnHoursPerWeek_NFA";
            ColumnHoursPerWeek_NFA.Width = 85;
            // 
            // openFileDialogImport_NFA
            // 
            openFileDialogImport_NFA.FileName = "DataMain.csv";
            openFileDialogImport_NFA.InitialDirectory = "C:\\DataSprint7";
            // 
            // saveFileDialogExport_NFA
            // 
            saveFileDialogExport_NFA.FileName = "OutPutTask7.csv";
            saveFileDialogExport_NFA.InitialDirectory = "C:\\DataSprint7\\FileSave";
            // 
            // toolTip_NFA
            // 
            toolTip_NFA.IsBalloon = true;
            toolTip_NFA.Popup += toolTipImport_NFA_Popup;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(984, 661);
            Controls.Add(panelGrid_NFA);
            Controls.Add(panelMenu_NFA);
            MinimumSize = new Size(1000, 700);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Преподавтели Университета";
            Load += FormMain_Load;
            panelMenu_NFA.ResumeLayout(false);
            TabBarNavigation_NFA.ResumeLayout(false);
            tabPageFile_NFA.ResumeLayout(false);
            groupBoxFile_NFA.ResumeLayout(false);
            groupBoxFile_NFA.PerformLayout();
            tabPageMain_NFA.ResumeLayout(false);
            groupBoxEdit_NFA.ResumeLayout(false);
            panelGrid_NFA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainGrid_NFA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu_NFA;
        private Panel panelGrid_NFA;
        private DataGridView dataGridViewMainGrid_NFA;
        private TabControl TabBarNavigation_NFA;
        private TabPage tabPageFile_NFA;
        private TabPage tabPageMain_NFA;
        private Button button2;
        private Button buttonImport_NFA;
        private Button buttonExport_NFA;
        private Label labelExport_NFA;
        private Label labelImport_NFA;
        private GroupBox groupBoxEdit_NFA;
        private OpenFileDialog openFileDialogImport_NFA;
        private SaveFileDialog saveFileDialogExport_NFA;
        private TabPage tabPageInformation_NFA;
        private DataGridViewTextBoxColumn ColumnID_NFA;
        private DataGridViewTextBoxColumn ColumnName_NFA;
        private DataGridViewTextBoxColumn ColumnNumber_NFA;
        private DataGridViewTextBoxColumn ColumnSubject_NFA;
        private DataGridViewTextBoxColumn ColumnAge_NFA;
        private DataGridViewTextBoxColumn ColumnAudienceNumber_NFA;
        private DataGridViewTextBoxColumn ColumnExperience_NFA;
        private DataGridViewTextBoxColumn ColumnHoursPerWeek_NFA;
        private GroupBox groupBoxFile_NFA;
        private Button buttonAddRow_NFA;
        private ToolTip toolTip_NFA;
    }
}
