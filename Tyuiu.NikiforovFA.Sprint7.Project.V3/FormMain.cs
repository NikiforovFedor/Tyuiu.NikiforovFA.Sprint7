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
        List<DataGridViewRow> DeletedRows = new List<DataGridViewRow>();

        private void FormMain_Load(object sender, EventArgs e)
        {
            TabBarNavigation_NFA.SelectedIndex = 0;

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
                TabBarNavigation_NFA.SelectedIndex = 1;
            }
            catch
            {
                MessageBox.Show("������������ ����!", "������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAddRow_NFA_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridViewMainGrid_NFA);
            row.Cells[0].Value = "0";
            row.Cells[1].Value = "������� ��� ��������";
            row.Cells[2].Value = "0";
            row.Cells[3].Value = "����������";
            row.Cells[4].Value = "0";
            row.Cells[5].Value = "0";
            row.Cells[6].Value = "0";
            row.Cells[7].Value = "0";
            dataGridViewMainGrid_NFA.Rows.Insert(0, row);
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
                MessageBox.Show("����������, �������� ������ ��� ��������", "������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPageMain_NFA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
            catch
            {
                MessageBox.Show("������ �������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //toolTip_NFA.ToolTipTitle = "������� ������";
        }

        private void buttonAddRow_NFA_MouseHover(object sender, EventArgs e)
        {
            //toolTip_NFA.ToolTipTitle = "�������� ������";
        }

        private void buttonSearch_NFA_MouseHover(object sender, EventArgs e)
        {
            //toolTip_NFA.ToolTipTitle = "������ �����";
        }

        private void buttonImport_NFA_MouseHover(object sender, EventArgs e)
        {
            //toolTip_NFA.ToolTipTitle = "������������� ����";
        }

        private void buttonExport_NFA_MouseHover(object sender, EventArgs e)
        {
            //toolTip_NFA.ToolTipTitle = "������������� ����";
        }

        private void dataGridViewMainGrid_NFA_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridViewMainGrid_NFA.SelectedRows.Count > 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    buttonRemoveRow_NFA_Click(sender, e);
                }
            }
        }

        private void dataGridViewMainGrid_NFA_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridViewMainGrid_NFA.SelectedRows.Count > 0)
            {
                e.Cancel = true;
            }
        }

        private void buttonImport_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonExport_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonAddRow_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonRemoveRow_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonSearch_NFA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NFA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void dataGridViewMainGrid_NFA_SelectionChanged(object sender, EventArgs e)
        {
            labelSelected_NFA.Text = "�������: " + (dataGridViewMainGrid_NFA.SelectedCells.Count).ToString();
            labelSelected_NFA.Visible = true;

            //double sum = 0;

            //foreach (DataGridViewRow row in dataGridViewMainGrid_NFA.SelectedRows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        if (double.TryParse(cell.Value.ToString(), out double value))
            //        {
            //            sum += value;
            //        }
            //    }
                    
            //}
            //labelAvg_NFA.Text = "�������: " + (sum/(dataGridViewMainGrid_NFA.SelectedCells.Count)).ToString();
            //labelAvg_NFA.Visible = true;

        }

        private void dataGridViewMainGrid_NFA_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string col = "024567";
            if (col.Contains(e.ColumnIndex.ToString()) && !long.TryParse(e.FormattedValue.ToString(), out _))
            {
                e.Cancel = true;
                MessageBox.Show("����������, ������� ����� � ���� �������.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!(col.Contains(e.ColumnIndex.ToString())) && !char.IsLetter(e.FormattedValue.ToString().FirstOrDefault()))
            {
                e.Cancel = true;
                MessageBox.Show("����������, ������� ����� � ���� �������.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
