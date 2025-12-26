using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tyuiu.VashumirskayaEV.Sprint7.Project.V10
{
    public partial class FormAnalytics_VEV : Form
    {
        private readonly List<string[]> ordersData;

        public FormAnalytics_VEV(List<string[]> data)
        {
            InitializeComponent();
            ordersData = data;
            DrawHistogram();
        }

        private void DrawHistogram()
        {
            panelChart_VEV.Controls.Clear();

            var grouped = ordersData
                .Where(r => r.Length > 4)
                .GroupBy(r => r[4].Trim())
                .Select(g => new
                {
                    Product = g.Key,
                    Count = g.Count()
                })
                .OrderBy(x => x.Count)
                .ToList();

            int maxCount = grouped.Max(g => g.Count);

            int barWidth = 60;
            int spacing = 20;
            int chartHeight = panelChart_VEV.Height - 60;

            for (int i = 0; i < grouped.Count; i++)
            {
                var item = grouped[i];

                int barHeight = (int)((item.Count / (double)maxCount) * chartHeight);

                Panel bar = new Panel();
                bar.Width = barWidth;
                bar.Height = barHeight;
                bar.BackColor = Color.LightPink;
                bar.Left = i * (barWidth + spacing) + 40;
                bar.Top = panelChart_VEV.Height - barHeight - 40;

                Label value = new Label();
                value.Text = item.Count.ToString();
                value.AutoSize = true;
                value.Left = bar.Left + 15;
                value.Top = bar.Top - 20;

                Label label = new Label();
                label.Text = item.Product;
                label.Width = barWidth + 20;
                label.TextAlign = ContentAlignment.TopCenter;
                label.Left = bar.Left - 10;
                label.Top = panelChart_VEV.Height - 35;

                panelChart_VEV.Controls.Add(bar);
                panelChart_VEV.Controls.Add(value);
                panelChart_VEV.Controls.Add(label);
            }
        }

        private void buttonClose_VEV_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}