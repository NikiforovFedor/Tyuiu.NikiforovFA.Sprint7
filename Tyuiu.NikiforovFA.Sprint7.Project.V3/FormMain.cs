using System.Windows.Forms;
using Tyuiu.NikiforovFA.Sprint7.Project.V3.Lib;
namespace Tyuiu.NikiforovFA.Sprint7.Project.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int rows;
        int columns;
        string OpenFilePath;

        private void AddRow_Click(object sender, EventArgs e)
        {
            // Создаем новую строку
            DataGridViewRow row = new DataGridViewRow();

            // Добавляем ячейки в строку
            row.Cells.Add(new DataGridViewTextBoxCell());
            row.Cells.Add(new DataGridViewTextBoxCell());
            row.Cells.Add(new DataGridViewTextBoxCell());

            // Устанавливаем значения ячеек
            row.Cells[0].Value = "Значение ячейки 1";
            row.Cells[1].Value = "Значение ячейки 2";
            row.Cells[2].Value = "Значение ячейки 3";

            // Добавляем строку в DataGridView
            dataGridViewMainGrid_NFA.Rows.Add(row);
        }
        private void dataGridViewMainGrid_NFA_MouseDown(object sender, EventArgs e)
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ContextMenuStrip.Items.Add("Добавить строку", null, new EventHandler(AddRow_Click));
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            TabBarNavigation_NFA.SelectedIndex = 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExport_NFA_Click(object sender, EventArgs e)
        {
            saveFileDialogExport_NFA.FileName = "OutputSprint7.csv";
            saveFileDialogExport_NFA.ShowDialog();

            string path = saveFileDialogExport_NFA.FileName;

            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {
                file.Delete();
            }

            string str = "";
            dataGridViewMainGrid_NFA.RowCount = rows;
            dataGridViewMainGrid_NFA.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != (columns - 1))
                    {
                        str += dataGridViewMainGrid_NFA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewMainGrid_NFA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonImport_NFA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMainGrid_NFA.Rows.Clear();
                openFileDialogImport_NFA.ShowDialog();
                OpenFilePath = openFileDialogImport_NFA.FileName;
                string[,] array = ds.OpenFile(OpenFilePath);
                dataGridViewMainGrid_NFA.Columns[0].ValueType = typeof(int);
                rows = array.GetLength(0);
                columns = array.GetLength(1);

                dataGridViewMainGrid_NFA.RowCount = rows;
                dataGridViewMainGrid_NFA.ColumnCount = columns;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if ((j == 0) || (4 <= j && j <= 7))
                        {
                            dataGridViewMainGrid_NFA.Rows[i].Cells[j].Value = Convert.ToInt32(array[i, j]);
                        }
                        else if (j == 2)
                        {
                            dataGridViewMainGrid_NFA.Rows[i].Cells[j].Value = Convert.ToInt64(array[i, j]);
                        }
                        else
                        {
                            dataGridViewMainGrid_NFA.Rows[i].Cells[j].Value = array[i, j];
                        }
                    }
                }
                array = ds.OpenFile(OpenFilePath);
                dataGridViewMainGrid_NFA.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                buttonExport_NFA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Некорректный файл!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTipImport_NFA_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonImport_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipTitle = "Импортировать файл";
        }

        private void buttonExport_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipTitle = "Экпортировать файл";
        }

        private void buttonAddRow_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipTitle = "Добавить строку";
        }

        private void buttonAddRow_NFA_Click(object sender, EventArgs e)
        {
            dataGridViewMainGrid_NFA.Rows.Insert(0);
        }
    }
}
