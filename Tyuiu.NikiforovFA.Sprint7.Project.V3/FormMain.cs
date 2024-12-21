using System.Windows.Forms;
using Tyuiu.NikiforovFA.Sprint7.Project.V3.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
        string OpenFilePath = "";

        private void AddRow_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            dataGridViewMainGrid_NFA.Rows.Add(row);
        }
        private void dataGridViewMainGrid_NFA_MouseDown(object sender, EventArgs e)
        {

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
                dataGridViewMainGrid_NFA.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                buttonExport_NFA.Enabled = true;
                buttonAddRow_NFA.Enabled = true;
                buttonRemoveRow_NFA.Enabled = true;
                textBoxSearch_NFA.Enabled = true;
                buttonSearch_NFA.Enabled = true;
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
            
        }

        private void buttonExport_NFA_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void buttonAddRow_NFA_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonAddRow_NFA_Click(object sender, EventArgs e)
        {
            dataGridViewMainGrid_NFA.Rows.Insert(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveRow_NFA_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonRemoveRow_NFA_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemoveRow_NFA_Click(object sender, EventArgs e)
        {
            if (dataGridViewMainGrid_NFA.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewMainGrid_NFA.SelectedRows)
                {
                    dataGridViewMainGrid_NFA.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void labelAddRow_NFA_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tabPageMain_NFA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string request = textBoxSearch_NFA.Text.ToLower();

            dataGridViewMainGrid_NFA.ClearSelection();

            foreach (DataGridViewRow row in dataGridViewMainGrid_NFA.Rows)
            {
                bool visible = false;

                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell Cell in row.Cells)
                    {
                        if (Cell.Value != null && Cell.Value.ToString().ToLower().Contains(request))
                        {
                            visible = true;
                            break;
                        }
                    }
                }

                row.Visible = visible;
            }
        }

        private void textBoxSearch_NFA_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch_NFA.TextLength == 0)
            {
                foreach (DataGridViewRow row in dataGridViewMainGrid_NFA.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void textBoxSearch_NFA_MultilineChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_NFA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);

            }
        }

        private void buttonRemoveRow_NFA_MouseHover(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipTitle = "Удалить строку";
        }

        private void buttonAddRow_NFA_MouseHover(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipTitle = "Добавить строку";
        }

        private void buttonSearch_NFA_MouseHover(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipTitle = "Начать поиск";
        }

        private void buttonImport_NFA_MouseHover(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipTitle = "Импортировать файл";
        }

        private void buttonExport_NFA_MouseHover(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipTitle = "Экпортировать файл";
        }
    }
}
