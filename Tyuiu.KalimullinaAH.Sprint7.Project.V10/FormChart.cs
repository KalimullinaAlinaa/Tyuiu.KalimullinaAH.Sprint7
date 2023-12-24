using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using static System.Windows.Forms.LinkLabel;
using DocumentFormat.OpenXml.ExtendedProperties;
using System.Globalization;
using DocumentFormat.OpenXml.Spreadsheet;
using CsvHelper;

namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form_Load);
        }
        string filePath = @"C:\Users\boulevarovaalina\source\repos\Tyuiu.KalimullinaAH.Sprint7\Заказы\Orders .csv";

        private void buttonOrdersOfAllMonth_KAH_Click(object sender, EventArgs e)
        {
            //  список для хранения данных о заказах
            List<string[]> ordersData = new List<string[]>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] row = line.Split(';');
                    ordersData.Add(row);
                }
            }

            var ordersByMonth = ordersData
                .Skip(1)
                .Select(row => new { Month = DateTime.Parse(row[5]).Month, ProductCount = int.Parse(row[4]) })
                .GroupBy(order => order.Month)
                .Select(group => new { Month = group.Key, OrderCount = group.Count(), ProductCount = group.Sum(order => order.ProductCount) })
                .OrderBy(order => order.Month)
                .ToList();

            chartOrder_KAH.Palette = ChartColorPalette.Excel;

            chartOrder_KAH.ChartAreas[0].AxisY.Title = "Кол-во в месяц";
            string[] legendNames = new string[]
            {
            "",
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"
            };

            chartOrder_KAH.Series.Clear();

            for (int i = 0; i < ordersByMonth.Count; i++)
            {
                Series series = chartOrder_KAH.Series.Add(legendNames[ordersByMonth[i].Month]);
                series.Points.AddXY("Заказы", ordersByMonth[i].OrderCount);
            }

        }
        // chartOrder_KAH.Series.Clear();

        private void Form_Load(object sender, EventArgs e)
        {
            comboBoxMonths_KAH.DataSource = new string[]
            {
            "Январь", "Февраль", "Март", "Апрель",
            "Май", "Июнь", "Июль", "Август",
            "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
            };
            comboBoxMonths_KAH.BringToFront(); 
        }


        private void buttonOrdersOfMonth_KAH_Click(object sender, EventArgs e)
        {
            int monthIndex = comboBoxMonths_KAH.SelectedIndex + 1;

            if (monthIndex < 1 || monthIndex > 12)
            {
                MessageBox.Show("Выберите месяц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string[]> ordersData = new List<string[]>();

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Неверный путь к файлу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] row = line.Split(';');
                        ordersData.Add(row);
                    }
                }

                var ordersByDay = ordersData
                    .Where(row => DateTime.TryParseExact(row[5], "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate) && parsedDate.Month == monthIndex)
                    .GroupBy(row => DateTime.ParseExact(row[5], "dd.MM.yyyy", null).Day)
                    .Select(group => new { Day = group.Key, OrderCount = group.Count() })
                    .OrderBy(order => order.Day)
                    .ToList();

                if (ordersByDay.Count == 0)
                {
                    MessageBox.Show("Данных за выбранный месяц нет", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information); 

                    return; 
                }

                chartOrder_KAH.Series.Clear();
                Series series = chartOrder_KAH.Series.Add("Заказы");
                series.ChartType = SeriesChartType.Column;

                foreach (var day in ordersByDay)
                {
                    series.Points.AddXY(day.Day, day.OrderCount);
                }

                chartOrder_KAH.ChartAreas[0].AxisX.Interval = 1;
                chartOrder_KAH.ChartAreas[0].AxisX.Title = "День";
                chartOrder_KAH.ChartAreas[0].AxisY.Title = "Количество в день";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBestProductsOfMonth_KAH_Click(object sender, EventArgs e)
        {
            int monthIndex = comboBoxMonths_KAH.SelectedIndex + 1;

            if (monthIndex < 1 || monthIndex > 12)
            {
                MessageBox.Show("Выберите месяц", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<string, int> productOrders = new Dictionary<string, int>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] row = line.Split(';');
                        if (DateTime.TryParseExact(row[5], "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date) && date.Month == monthIndex)
                        {
                            string productName = row[0];
                            int quantity = int.Parse(row[4]);

                            if (productOrders.ContainsKey(productName))
                            {
                                productOrders[productName] += quantity;
                            }
                            else
                            {
                                productOrders[productName] = quantity;
                            }
                        }
                    }
                }

                if (productOrders.Count == 0)
                {
                    MessageBox.Show("Нет данных о заказах в этом месяце", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                chartOrder_KAH.Series.Clear();
                Series series = chartOrder_KAH.Series.Add("Товары");
                series.ChartType = SeriesChartType.Pie;

                foreach (KeyValuePair<string, int> productOrder in productOrders)
                {
                    series.Points.AddXY(productOrder.Key, productOrder.Value);
                }

                chartOrder_KAH.ChartAreas[0].AxisX.Interval = 1;
                chartOrder_KAH.ChartAreas[0].AxisX.Title = "Название товара";
                chartOrder_KAH.ChartAreas[0].AxisY.Title = "Количество заказов";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


