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
                    if ( j != (columns - 1))
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
        }
    }
}
