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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelMenu_NFA = new Panel();
            TabBarNavigation_NFA = new TabControl();
            tabPageFile_NFA = new TabPage();
            groupBoxFile_NFA = new GroupBox();
            buttonExport_NFA = new Button();
            labelExport_NFA = new Label();
            labelImport_NFA = new Label();
            buttonImport_NFA = new Button();
            tabPageMain_NFA = new TabPage();
            groupBoxSearch_NFA = new GroupBox();
            buttonSearch_NFA = new Button();
            textBoxSearch_NFA = new TextBox();
            groupBoxEdit_NFA = new GroupBox();
            labelRemoveRow_NFA = new Label();
            labelAddRow_NFA = new Label();
            buttonRemoveRow_NFA = new Button();
            buttonAddRow_NFA = new Button();
            tabPageInformation_NFA = new TabPage();
            groupBoxInformation_NFA = new GroupBox();
            buttonGuide_NFA = new Button();
            labelHelp_NFA = new Label();
            labelDevoleper_NFA = new Label();
            buttonВeveloper_NFA = new Button();
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
            buttonMore_NFA = new Button();
            labelSelected_NFA = new Label();
            panelStatistics_NFA = new Panel();
            panelMenu_NFA.SuspendLayout();
            TabBarNavigation_NFA.SuspendLayout();
            tabPageFile_NFA.SuspendLayout();
            groupBoxFile_NFA.SuspendLayout();
            tabPageMain_NFA.SuspendLayout();
            groupBoxSearch_NFA.SuspendLayout();
            groupBoxEdit_NFA.SuspendLayout();
            tabPageInformation_NFA.SuspendLayout();
            groupBoxInformation_NFA.SuspendLayout();
            panelGrid_NFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainGrid_NFA).BeginInit();
            panelStatistics_NFA.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu_NFA
            // 
            panelMenu_NFA.BackColor = Color.DarkGray;
            panelMenu_NFA.Controls.Add(TabBarNavigation_NFA);
            panelMenu_NFA.Dock = DockStyle.Top;
            panelMenu_NFA.Location = new Point(0, 0);
            panelMenu_NFA.Margin = new Padding(0);
            panelMenu_NFA.Name = "panelMenu_NFA";
            panelMenu_NFA.Size = new Size(884, 156);
            panelMenu_NFA.TabIndex = 0;
            // 
            // TabBarNavigation_NFA
            // 
            TabBarNavigation_NFA.Controls.Add(tabPageFile_NFA);
            TabBarNavigation_NFA.Controls.Add(tabPageMain_NFA);
            TabBarNavigation_NFA.Controls.Add(tabPageInformation_NFA);
            TabBarNavigation_NFA.Dock = DockStyle.Top;
            TabBarNavigation_NFA.Location = new Point(0, 0);
            TabBarNavigation_NFA.Name = "TabBarNavigation_NFA";
            TabBarNavigation_NFA.SelectedIndex = 0;
            TabBarNavigation_NFA.Size = new Size(884, 156);
            TabBarNavigation_NFA.TabIndex = 0;
            // 
            // tabPageFile_NFA
            // 
            tabPageFile_NFA.BackColor = Color.FromArgb(241, 241, 241);
            tabPageFile_NFA.Controls.Add(groupBoxFile_NFA);
            tabPageFile_NFA.Location = new Point(4, 24);
            tabPageFile_NFA.Name = "tabPageFile_NFA";
            tabPageFile_NFA.Padding = new Padding(3);
            tabPageFile_NFA.Size = new Size(876, 128);
            tabPageFile_NFA.TabIndex = 0;
            tabPageFile_NFA.Text = "Файл";
            // 
            // groupBoxFile_NFA
            // 
            groupBoxFile_NFA.BackColor = Color.FromArgb(241, 241, 241);
            groupBoxFile_NFA.Controls.Add(buttonExport_NFA);
            groupBoxFile_NFA.Controls.Add(labelExport_NFA);
            groupBoxFile_NFA.Controls.Add(labelImport_NFA);
            groupBoxFile_NFA.Controls.Add(buttonImport_NFA);
            groupBoxFile_NFA.Dock = DockStyle.Fill;
            groupBoxFile_NFA.Location = new Point(3, 3);
            groupBoxFile_NFA.Name = "groupBoxFile_NFA";
            groupBoxFile_NFA.Size = new Size(870, 122);
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
            toolTip_NFA.SetToolTip(buttonExport_NFA, "Экспортировать файл из программы");
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
            toolTip_NFA.SetToolTip(buttonImport_NFA, "Импортировать файл в программу");
            buttonImport_NFA.UseVisualStyleBackColor = false;
            buttonImport_NFA.Click += buttonImport_NFA_Click;
            buttonImport_NFA.MouseEnter += buttonImport_NFA_MouseEnter;
            // 
            // tabPageMain_NFA
            // 
            tabPageMain_NFA.BackColor = Color.FromArgb(241, 241, 241);
            tabPageMain_NFA.Controls.Add(groupBoxSearch_NFA);
            tabPageMain_NFA.Controls.Add(groupBoxEdit_NFA);
            tabPageMain_NFA.Location = new Point(4, 24);
            tabPageMain_NFA.Margin = new Padding(0);
            tabPageMain_NFA.Name = "tabPageMain_NFA";
            tabPageMain_NFA.Padding = new Padding(3);
            tabPageMain_NFA.Size = new Size(876, 128);
            tabPageMain_NFA.TabIndex = 1;
            tabPageMain_NFA.Text = "Главная";
            // 
            // groupBoxSearch_NFA
            // 
            groupBoxSearch_NFA.Controls.Add(buttonSearch_NFA);
            groupBoxSearch_NFA.Controls.Add(textBoxSearch_NFA);
            groupBoxSearch_NFA.Dock = DockStyle.Fill;
            groupBoxSearch_NFA.Location = new Point(150, 3);
            groupBoxSearch_NFA.Margin = new Padding(0);
            groupBoxSearch_NFA.Name = "groupBoxSearch_NFA";
            groupBoxSearch_NFA.Size = new Size(723, 122);
            groupBoxSearch_NFA.TabIndex = 1;
            groupBoxSearch_NFA.TabStop = false;
            groupBoxSearch_NFA.Text = "Поиск";
            // 
            // buttonSearch_NFA
            // 
            buttonSearch_NFA.BackColor = Color.White;
            buttonSearch_NFA.Cursor = Cursors.Hand;
            buttonSearch_NFA.Enabled = false;
            buttonSearch_NFA.FlatStyle = FlatStyle.Popup;
            buttonSearch_NFA.Image = Properties.Resources.search_icon;
            buttonSearch_NFA.Location = new Point(129, 37);
            buttonSearch_NFA.Name = "buttonSearch_NFA";
            buttonSearch_NFA.Size = new Size(34, 34);
            buttonSearch_NFA.TabIndex = 1;
            toolTip_NFA.SetToolTip(buttonSearch_NFA, "Поиск");
            buttonSearch_NFA.UseVisualStyleBackColor = false;
            buttonSearch_NFA.Click += buttonSearch_NFA_Click;
            buttonSearch_NFA.MouseEnter += buttonSearch_NFA_MouseEnter;
            // 
            // textBoxSearch_NFA
            // 
            textBoxSearch_NFA.Cursor = Cursors.IBeam;
            textBoxSearch_NFA.Enabled = false;
            textBoxSearch_NFA.Location = new Point(6, 44);
            textBoxSearch_NFA.Name = "textBoxSearch_NFA";
            textBoxSearch_NFA.Size = new Size(117, 23);
            textBoxSearch_NFA.TabIndex = 0;
            textBoxSearch_NFA.TextChanged += textBoxSearch_NFA_TextChanged;
            textBoxSearch_NFA.KeyDown += textBoxSearch_NFA_KeyDown;
            // 
            // groupBoxEdit_NFA
            // 
            groupBoxEdit_NFA.BackColor = Color.FromArgb(241, 241, 241);
            groupBoxEdit_NFA.Controls.Add(labelRemoveRow_NFA);
            groupBoxEdit_NFA.Controls.Add(labelAddRow_NFA);
            groupBoxEdit_NFA.Controls.Add(buttonRemoveRow_NFA);
            groupBoxEdit_NFA.Controls.Add(buttonAddRow_NFA);
            groupBoxEdit_NFA.Dock = DockStyle.Left;
            groupBoxEdit_NFA.Location = new Point(3, 3);
            groupBoxEdit_NFA.Margin = new Padding(0);
            groupBoxEdit_NFA.Name = "groupBoxEdit_NFA";
            groupBoxEdit_NFA.Size = new Size(147, 122);
            groupBoxEdit_NFA.TabIndex = 0;
            groupBoxEdit_NFA.TabStop = false;
            groupBoxEdit_NFA.Text = "Редактирование";
            // 
            // labelRemoveRow_NFA
            // 
            labelRemoveRow_NFA.AutoSize = true;
            labelRemoveRow_NFA.Location = new Point(82, 89);
            labelRemoveRow_NFA.Name = "labelRemoveRow_NFA";
            labelRemoveRow_NFA.Size = new Size(54, 30);
            labelRemoveRow_NFA.TabIndex = 3;
            labelRemoveRow_NFA.Text = "Удалить \r\nстроку";
            labelRemoveRow_NFA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAddRow_NFA
            // 
            labelAddRow_NFA.AutoSize = true;
            labelAddRow_NFA.Location = new Point(10, 89);
            labelAddRow_NFA.Name = "labelAddRow_NFA";
            labelAddRow_NFA.Size = new Size(62, 30);
            labelAddRow_NFA.TabIndex = 2;
            labelAddRow_NFA.Text = "Добавить \r\nстроку";
            labelAddRow_NFA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonRemoveRow_NFA
            // 
            buttonRemoveRow_NFA.BackColor = Color.White;
            buttonRemoveRow_NFA.BackgroundImageLayout = ImageLayout.None;
            buttonRemoveRow_NFA.Cursor = Cursors.Hand;
            buttonRemoveRow_NFA.Enabled = false;
            buttonRemoveRow_NFA.FlatStyle = FlatStyle.Popup;
            buttonRemoveRow_NFA.Image = (Image)resources.GetObject("buttonRemoveRow_NFA.Image");
            buttonRemoveRow_NFA.Location = new Point(76, 22);
            buttonRemoveRow_NFA.Name = "buttonRemoveRow_NFA";
            buttonRemoveRow_NFA.Size = new Size(64, 64);
            buttonRemoveRow_NFA.TabIndex = 1;
            toolTip_NFA.SetToolTip(buttonRemoveRow_NFA, "Удалить выбранную строку");
            buttonRemoveRow_NFA.UseVisualStyleBackColor = false;
            buttonRemoveRow_NFA.Click += buttonRemoveRow_NFA_Click;
            buttonRemoveRow_NFA.MouseEnter += buttonRemoveRow_NFA_MouseEnter;
            // 
            // buttonAddRow_NFA
            // 
            buttonAddRow_NFA.BackColor = Color.White;
            buttonAddRow_NFA.BackgroundImageLayout = ImageLayout.None;
            buttonAddRow_NFA.Cursor = Cursors.Hand;
            buttonAddRow_NFA.Enabled = false;
            buttonAddRow_NFA.FlatStyle = FlatStyle.Popup;
            buttonAddRow_NFA.Image = (Image)resources.GetObject("buttonAddRow_NFA.Image");
            buttonAddRow_NFA.Location = new Point(6, 22);
            buttonAddRow_NFA.Name = "buttonAddRow_NFA";
            buttonAddRow_NFA.Size = new Size(64, 64);
            buttonAddRow_NFA.TabIndex = 1;
            toolTip_NFA.SetToolTip(buttonAddRow_NFA, "Добавить новую строку");
            buttonAddRow_NFA.UseVisualStyleBackColor = false;
            buttonAddRow_NFA.Click += buttonAddRow_NFA_Click;
            buttonAddRow_NFA.MouseEnter += buttonAddRow_NFA_MouseEnter;
            // 
            // tabPageInformation_NFA
            // 
            tabPageInformation_NFA.BackColor = Color.FromArgb(241, 241, 241);
            tabPageInformation_NFA.Controls.Add(groupBoxInformation_NFA);
            tabPageInformation_NFA.Location = new Point(4, 24);
            tabPageInformation_NFA.Name = "tabPageInformation_NFA";
            tabPageInformation_NFA.Padding = new Padding(3);
            tabPageInformation_NFA.Size = new Size(876, 128);
            tabPageInformation_NFA.TabIndex = 2;
            tabPageInformation_NFA.Text = "О программе";
            // 
            // groupBoxInformation_NFA
            // 
            groupBoxInformation_NFA.Controls.Add(buttonGuide_NFA);
            groupBoxInformation_NFA.Controls.Add(labelHelp_NFA);
            groupBoxInformation_NFA.Controls.Add(labelDevoleper_NFA);
            groupBoxInformation_NFA.Controls.Add(buttonВeveloper_NFA);
            groupBoxInformation_NFA.Dock = DockStyle.Left;
            groupBoxInformation_NFA.Location = new Point(3, 3);
            groupBoxInformation_NFA.Name = "groupBoxInformation_NFA";
            groupBoxInformation_NFA.Size = new Size(157, 122);
            groupBoxInformation_NFA.TabIndex = 0;
            groupBoxInformation_NFA.TabStop = false;
            groupBoxInformation_NFA.Text = "О разработке";
            // 
            // buttonGuide_NFA
            // 
            buttonGuide_NFA.BackColor = Color.White;
            buttonGuide_NFA.BackgroundImageLayout = ImageLayout.None;
            buttonGuide_NFA.Cursor = Cursors.Hand;
            buttonGuide_NFA.FlatStyle = FlatStyle.Popup;
            buttonGuide_NFA.Image = (Image)resources.GetObject("buttonGuide_NFA.Image");
            buttonGuide_NFA.Location = new Point(76, 22);
            buttonGuide_NFA.Name = "buttonGuide_NFA";
            buttonGuide_NFA.Size = new Size(64, 64);
            buttonGuide_NFA.TabIndex = 2;
            buttonGuide_NFA.UseVisualStyleBackColor = false;
            buttonGuide_NFA.Click += buttonGuide_NFA_Click;
            // 
            // labelHelp_NFA
            // 
            labelHelp_NFA.Location = new Point(71, 89);
            labelHelp_NFA.Name = "labelHelp_NFA";
            labelHelp_NFA.Size = new Size(82, 30);
            labelHelp_NFA.TabIndex = 3;
            labelHelp_NFA.Text = "Руководство пользователя";
            labelHelp_NFA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDevoleper_NFA
            // 
            labelDevoleper_NFA.AutoSize = true;
            labelDevoleper_NFA.Font = new Font("Segoe UI", 8F);
            labelDevoleper_NFA.Location = new Point(0, 89);
            labelDevoleper_NFA.Name = "labelDevoleper_NFA";
            labelDevoleper_NFA.Size = new Size(76, 13);
            labelDevoleper_NFA.TabIndex = 3;
            labelDevoleper_NFA.Text = "Разработчик";
            labelDevoleper_NFA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonВeveloper_NFA
            // 
            buttonВeveloper_NFA.BackColor = Color.White;
            buttonВeveloper_NFA.BackgroundImageLayout = ImageLayout.None;
            buttonВeveloper_NFA.Cursor = Cursors.Hand;
            buttonВeveloper_NFA.FlatStyle = FlatStyle.Popup;
            buttonВeveloper_NFA.Image = (Image)resources.GetObject("buttonВeveloper_NFA.Image");
            buttonВeveloper_NFA.Location = new Point(6, 22);
            buttonВeveloper_NFA.Name = "buttonВeveloper_NFA";
            buttonВeveloper_NFA.Size = new Size(64, 64);
            buttonВeveloper_NFA.TabIndex = 2;
            toolTip_NFA.SetToolTip(buttonВeveloper_NFA, "Информация о разработчике");
            buttonВeveloper_NFA.UseVisualStyleBackColor = false;
            buttonВeveloper_NFA.Click += buttonВeveloper_NFA_Click;
            // 
            // panelGrid_NFA
            // 
            panelGrid_NFA.AutoScroll = true;
            panelGrid_NFA.Controls.Add(dataGridViewMainGrid_NFA);
            panelGrid_NFA.Dock = DockStyle.Fill;
            panelGrid_NFA.Location = new Point(0, 156);
            panelGrid_NFA.Name = "panelGrid_NFA";
            panelGrid_NFA.Size = new Size(884, 281);
            panelGrid_NFA.TabIndex = 1;
            // 
            // dataGridViewMainGrid_NFA
            // 
            dataGridViewMainGrid_NFA.AllowUserToAddRows = false;
            dataGridViewMainGrid_NFA.AllowUserToDeleteRows = false;
            dataGridViewMainGrid_NFA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewMainGrid_NFA.BackgroundColor = Color.White;
            dataGridViewMainGrid_NFA.BorderStyle = BorderStyle.None;
            dataGridViewMainGrid_NFA.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMainGrid_NFA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMainGrid_NFA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMainGrid_NFA.Columns.AddRange(new DataGridViewColumn[] { ColumnID_NFA, ColumnName_NFA, ColumnNumber_NFA, ColumnSubject_NFA, ColumnAge_NFA, ColumnAudienceNumber_NFA, ColumnExperience_NFA, ColumnHoursPerWeek_NFA });
            dataGridViewMainGrid_NFA.Dock = DockStyle.Fill;
            dataGridViewMainGrid_NFA.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewMainGrid_NFA.Location = new Point(0, 0);
            dataGridViewMainGrid_NFA.Name = "dataGridViewMainGrid_NFA";
            dataGridViewMainGrid_NFA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewMainGrid_NFA.Size = new Size(884, 281);
            dataGridViewMainGrid_NFA.TabIndex = 0;
            dataGridViewMainGrid_NFA.TabStop = false;
            dataGridViewMainGrid_NFA.CellBeginEdit += dataGridViewMainGrid_NFA_CellBeginEdit;
            dataGridViewMainGrid_NFA.DataError += dataGridViewMainGrid_NFA_DataError;
            dataGridViewMainGrid_NFA.SelectionChanged += dataGridViewMainGrid_NFA_SelectionChanged;
            dataGridViewMainGrid_NFA.KeyDown += dataGridViewMainGrid_NFA_KeyDown;
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
            toolTip_NFA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_NFA.ToolTipTitle = "Подсказка";
            // 
            // buttonMore_NFA
            // 
            buttonMore_NFA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMore_NFA.Cursor = Cursors.Hand;
            buttonMore_NFA.Enabled = false;
            buttonMore_NFA.FlatStyle = FlatStyle.Popup;
            buttonMore_NFA.Font = new Font("Segoe UI", 7F);
            buttonMore_NFA.Image = (Image)resources.GetObject("buttonMore_NFA.Image");
            buttonMore_NFA.Location = new Point(863, 0);
            buttonMore_NFA.Margin = new Padding(0);
            buttonMore_NFA.Name = "buttonMore_NFA";
            buttonMore_NFA.Size = new Size(21, 23);
            buttonMore_NFA.TabIndex = 1;
            toolTip_NFA.SetToolTip(buttonMore_NFA, "Дополнительные сведения");
            buttonMore_NFA.UseVisualStyleBackColor = true;
            buttonMore_NFA.Click += buttonMore_NFA_Click;
            // 
            // labelSelected_NFA
            // 
            labelSelected_NFA.Location = new Point(13, 3);
            labelSelected_NFA.Name = "labelSelected_NFA";
            labelSelected_NFA.Size = new Size(85, 15);
            labelSelected_NFA.TabIndex = 0;
            labelSelected_NFA.Text = "Выбрано: ";
            labelSelected_NFA.Visible = false;
            // 
            // panelStatistics_NFA
            // 
            panelStatistics_NFA.BackColor = Color.Gainsboro;
            panelStatistics_NFA.Controls.Add(buttonMore_NFA);
            panelStatistics_NFA.Controls.Add(labelSelected_NFA);
            panelStatistics_NFA.Dock = DockStyle.Bottom;
            panelStatistics_NFA.Location = new Point(0, 437);
            panelStatistics_NFA.Margin = new Padding(0);
            panelStatistics_NFA.Name = "panelStatistics_NFA";
            panelStatistics_NFA.Padding = new Padding(5);
            panelStatistics_NFA.Size = new Size(884, 24);
            panelStatistics_NFA.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(884, 461);
            Controls.Add(panelGrid_NFA);
            Controls.Add(panelMenu_NFA);
            Controls.Add(panelStatistics_NFA);
            MinimumSize = new Size(900, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Преподаватели Университета";
            Load += FormMain_Load;
            panelMenu_NFA.ResumeLayout(false);
            TabBarNavigation_NFA.ResumeLayout(false);
            tabPageFile_NFA.ResumeLayout(false);
            groupBoxFile_NFA.ResumeLayout(false);
            groupBoxFile_NFA.PerformLayout();
            tabPageMain_NFA.ResumeLayout(false);
            groupBoxSearch_NFA.ResumeLayout(false);
            groupBoxSearch_NFA.PerformLayout();
            groupBoxEdit_NFA.ResumeLayout(false);
            groupBoxEdit_NFA.PerformLayout();
            tabPageInformation_NFA.ResumeLayout(false);
            groupBoxInformation_NFA.ResumeLayout(false);
            groupBoxInformation_NFA.PerformLayout();
            panelGrid_NFA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMainGrid_NFA).EndInit();
            panelStatistics_NFA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu_NFA;
        private Panel panelGrid_NFA;
        private OpenFileDialog openFileDialogImport_NFA;
        private SaveFileDialog saveFileDialogExport_NFA;
        private DataGridView dataGridViewMainGrid_NFA;
        private DataGridViewTextBoxColumn ColumnID_NFA;
        private DataGridViewTextBoxColumn ColumnName_NFA;
        private DataGridViewTextBoxColumn ColumnNumber_NFA;
        private DataGridViewTextBoxColumn ColumnSubject_NFA;
        private DataGridViewTextBoxColumn ColumnAge_NFA;
        private DataGridViewTextBoxColumn ColumnAudienceNumber_NFA;
        private DataGridViewTextBoxColumn ColumnExperience_NFA;
        private DataGridViewTextBoxColumn ColumnHoursPerWeek_NFA;
        private ToolTip toolTip_NFA;
        private Label labelSelected_NFA;
        private Panel panelStatistics_NFA;
        private TabControl TabBarNavigation_NFA;
        private TabPage tabPageFile_NFA;
        private GroupBox groupBoxFile_NFA;
        private Button buttonExport_NFA;
        private Label labelExport_NFA;
        private Label labelImport_NFA;
        private Button buttonImport_NFA;
        private TabPage tabPageMain_NFA;
        private GroupBox groupBoxSearch_NFA;
        private Button buttonSearch_NFA;
        private TextBox textBoxSearch_NFA;
        private GroupBox groupBoxEdit_NFA;
        private Label labelRemoveRow_NFA;
        private Label labelAddRow_NFA;
        private Button buttonRemoveRow_NFA;
        private Button buttonAddRow_NFA;
        private TabPage tabPageInformation_NFA;
        private Button buttonMore_NFA;
        private GroupBox groupBoxInformation_NFA;
        private Label labelDevoleper_NFA;
        private Button buttonВeveloper_NFA;
        private Button buttonGuide_NFA;
        private Label labelHelp_NFA;
    }
}
