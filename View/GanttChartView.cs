using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleTask2;
using System.Windows.Forms;

namespace View
{
    public partial class GanttChartView : Form
    {
        public GanttChartView()
        {
            InitializeComponent();
        }

        public void ShowDataOnChart(List<List<Job>> chart)
        {
            GanttChart.Rows.Clear();
            GanttChart.Columns.Clear();
           
            for (int i = 0; i < chart[0].Count; i++)
            {
                var column = new DataGridViewTextBoxColumn();
                column.Width = 60;
                column.Name = $"column{i}";
                column.HeaderText = $"day {i + 1}";
                GanttChart.Columns.Add(column);
            }
            GanttChart.RowHeadersWidth = 100;
            GanttChart.Rows.Add(chart[0]);
            for (int i = 0; i < chart.Count; i++)
            {
                var currRow = (DataGridViewRow) GanttChart.Rows[0].Clone();
                currRow.HeaderCell.Value = $"employee {i+1}";
                var j = 0;
                foreach(var job in chart[i])
                {
                    currRow.Cells[j].Value = job.Name;
                    j++;
                }
                GanttChart.Rows.Add(currRow);
            }
            GanttChart.Rows.RemoveAt(0);
        }

        private void GanttChart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
