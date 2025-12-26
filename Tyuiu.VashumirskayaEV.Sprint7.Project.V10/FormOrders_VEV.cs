using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tyuiu.VashumirskayaEV.Sprint7.Project.V10.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint7.Project.V10
{
    public partial class FormOrders_VEV : Form
    {
        private List<string[]> ordersData = new List<string[]>();

        public FormOrders_VEV()
        {
            InitializeComponent();
        }

        // ЗАГРУЗКА CSV
        private void buttonRun_VEV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "CSV files (*.csv)|*.csv";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var service = new DataService();
                    ordersData = service.LoadOrders(dialog.FileName);

                    DataGridViewOrders_VEV.Rows.Clear();
                    DataGridViewOrders_VEV.Columns.Clear();

                    DataGridViewOrders_VEV.Columns.Add("LastName", "Фамилия");
                    DataGridViewOrders_VEV.Columns.Add("FirstName", "Имя");
                    DataGridViewOrders_VEV.Columns.Add("OrderId", "Номер заказа");
                    DataGridViewOrders_VEV.Columns.Add("Price", "Стоимость");
                    DataGridViewOrders_VEV.Columns.Add("Product", "Товар");

                    foreach (var row in ordersData)
                    {
                        DataGridViewOrders_VEV.Rows.Add(row);
                    }
                }
            }
        }

        // ПОИСК
        private void textBoxSearch_VEV_TextChanged(object sender, EventArgs e)
        {
            string filter = textBoxSearch_VEV.Text.ToLower();

            foreach (DataGridViewRow row in DataGridViewOrders_VEV.Rows)
            {
                if (row.IsNewRow) continue;

                row.Visible = row.Cells
                    .Cast<DataGridViewCell>()
                    .Any(c => c.Value != null &&
                              c.Value.ToString().ToLower().Contains(filter));
            }
        }

        // СОХРАНЕНИЕ
        private void buttonSave_VEV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    // заголовки
                    for (int i = 0; i < DataGridViewOrders_VEV.Columns.Count; i++)
                    {
                        writer.Write(DataGridViewOrders_VEV.Columns[i].HeaderText);
                        if (i < DataGridViewOrders_VEV.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();

                    // строки
                    foreach (DataGridViewRow row in DataGridViewOrders_VEV.Rows)
                    {
                        if (row.IsNewRow) continue;

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            writer.Write(row.Cells[i].Value);
                            if (i < row.Cells.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Файл сохранён");
            }
        }

        // АНАЛИТИКА
        private void buttonAnalytics_VEV_Click(object sender, EventArgs e)
        {
            if (ordersData == null || ordersData.Count == 0)
            {
                MessageBox.Show("Сначала загрузите данные", "Внимание");
                return;
            }

            FormAnalytics_VEV analyticsForm = new FormAnalytics_VEV(ordersData);
            analyticsForm.ShowDialog();
        }

        // ЗАКРЫТЬ
        private void buttonClose_VEV_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridViewOrders_VEV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}