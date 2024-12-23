using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace Tyuiu.NikiforovFA.Sprint7.Project.V3
{
    public partial class FormMore : Form
    {
        private FormMain _formMain;
        public FormMore(FormMain formMain)
        {
            InitializeComponent();
            _formMain = formMain;
        }


        private void FormMore_Load_1(object sender, EventArgs e)
        {
            DataGridView DataGridViewMainGrid_NFA = _formMain.GetDataGridView();
            int len = DataGridViewMainGrid_NFA.Rows.Count;

            int sum = 0;
            int[] age = new int[len];
            for (int i = 0; i < len; i++)
            {
                age[i] = Convert.ToInt32(DataGridViewMainGrid_NFA.Rows[i].Cells[4]);
                sum += age[i];
            }
            labelCount_NFA.Text += len.ToString();
            labelAgeMin_NFA.Text += age.Min().ToString();
            labelAgeMax_NFA.Text += age.Max().ToString();
            labelAgeAvg_NFA.Text += (sum / len).ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
