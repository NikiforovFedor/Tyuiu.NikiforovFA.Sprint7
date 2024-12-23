using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.NikiforovFA.Sprint7.Project.V3
{
    public partial class FormStatistics : Form
    {
        private DataGridView DataGridViewMainGrid_NFA;
        public FormStatistics(DataGridView dataGridViewMainGrid_NFA)
        {
            InitializeComponent();
            DataGridViewMainGrid_NFA = dataGridViewMainGrid_NFA;
        }

        private void FormStatistics_Load(object sender, EventArgs e)
        {
            int len = DataGridViewMainGrid_NFA.Rows.Count;
            if (len > 0)
            {
                double sum = 0, sumExp = 0;
                int[] age = new int[len];
                int[] exp = new int[len];
                for (int i = 0; i < len; i++)
                {
                    var cellValue = DataGridViewMainGrid_NFA.Rows[i].Cells[4].Value;
                    var cellValueExp = DataGridViewMainGrid_NFA.Rows[i].Cells[6].Value;
                    if (DataGridViewMainGrid_NFA.Rows[i].Cells[4] != null)
                    {
                        int intValue = Convert.ToInt32(cellValue);
                        int intValueExp = Convert.ToInt32(cellValueExp);
                        age[i] = intValue;
                        exp[i] = intValueExp;
                        sum += age[i];
                        sumExp += exp[i];
                    }
                    else
                    {
                        age[i] = 0;
                        exp[i] = 0;
                    }
                }
                labelCount_NFA.Text += len.ToString();
                labelMinAge_NFA.Text += age.Min().ToString();
                labelMaxAge_NFA.Text += age.Max().ToString();
                labelAvgAge_NFA.Text += Math.Round(sum / len, 2).ToString();
                labelExpAvg_NFA.Text += Math.Round(sumExp / len, 2).ToString();


                Array.Sort(age);
                Array.Sort(exp);
                this.chartExpAge_NFA.ChartAreas[0].AxisX.Title = "Возраст(лет)";
                this.chartExpAge_NFA.ChartAreas[0].AxisY.Title = "Стаж(лет)";
                for (int i = 0; i < len; i++)
                {
                    chartExpAge_NFA.Series[0].Points.AddXY(age[i], exp[i]);
                }
            }
        }

        private void chartExpAge_NFA_Click(object sender, EventArgs e)
        {

        }
    }
}
