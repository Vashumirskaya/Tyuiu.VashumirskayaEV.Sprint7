using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.VashumirskayaEV.Sprint7.Project.V10
{
    public partial class FormAnalytics_VEV : Form
    {
        private List<string[]> ordersData;

        public FormAnalytics_VEV(List<string[]> data)
        {
            InitializeComponent();
            ordersData = data;
            BuildChart();
        }

        private void BuildChart()
        {
            chartOrders_VEV.Series.Clear();

            var area = chartOrders_VEV.ChartAreas[0];
            area.AxisX.Interval = 1;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            Series series = new Series("Частота заказов");
            series.ChartType = SeriesChartType.Column;

            series.XValueType = ChartValueType.String;

            series.IsValueShownAsLabel = true;

            var grouped = ordersData
                .Where(row => row.Length > 4)
                .GroupBy(row => row[4].Trim())
                .Select(g => new
                {
                    Product = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(x => x.Count)
                .ToList();

            foreach (var item in grouped)
            {
                series.Points.AddXY(item.Product, item.Count);
            }

            chartOrders_VEV.Series.Add(series);
        }

        private void buttonClose_VEV_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}