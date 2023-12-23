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
        }
        string filePath = @"C:\Users\boulevarovaalina\Desktop\Новая папка\Orders.csv";

        private void buttonOrdersOfAllMonth_KAH_Click(object sender, EventArgs e)
        {
            // Создаем список для хранения данных о заказах
            List<string[]> ordersData = new List<string[]>();

            // Читаем данные из файла
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] row = line.Split(';');
                    ordersData.Add(row);
                }
            }

            // Получаем месяцы из столбца 7 и подсчитываем количество заказов и купленных товаров в каждом месяце
            var ordersByMonth = ordersData
                .Skip(1) // Пропускаем заголовок
                .Select(row => new { Month = DateTime.Parse(row[5]).Month, ProductCount = int.Parse(row[4]) })
                .GroupBy(order => order.Month)
                .Select(group => new { Month = group.Key, OrderCount = group.Count(), ProductCount = group.Sum(order => order.ProductCount) })
                .OrderBy(order => order.Month)
                .ToList();

            // Устанавливаем палитру
            chartOrder_KAH.Palette = ChartColorPalette.Excel;

            // Заголовок графика
            chartOrder_KAH.ChartAreas[0].AxisY.Title = "Кол-во в месяц";
            // Названия месяцев
            string[] legendNames = new string[]
            {
            "", // Используем пустую строку для пропуска индекса 0
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

            // Очищаем график перед добавлением новых данных
            chartOrder_KAH.Series.Clear();

            // Добавляем последовательность
            for (int i = 0; i < ordersByMonth.Count; i++)
            {
                Series series = chartOrder_KAH.Series.Add(legendNames[ordersByMonth[i].Month]);
                series.Points.AddXY("Заказы", ordersByMonth[i].OrderCount);
            }


            // Очищаем график, если чекбокс не выбран
            // chartOrder_KAH.Series.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMonths_KAH.Items.AddRange(new object[] {
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
    });
        }

        private void buttonOrdersOfMonth_KAH_Click(object sender, EventArgs e)
        {
            // Получаем выбранный месяц
            int monthIndex = comboBoxMonths_KAH.SelectedIndex + 1; // ComboBox индексы начинаются с 0

            // Проверяем, что месяц был выбран
            if (monthIndex < 1 || monthIndex > 12)
            {
                MessageBox.Show("Выберите месяц");
                return;
            }

            // Создаем список для хранения данных о заказах
            List<string[]> ordersData = new List<string[]>();

            // Читаем данные из файла
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] row = line.Split(';');
                    ordersData.Add(row);
                }
            }

            // Отфильтровываем данные за выбранный месяц
            var ordersByDay = ordersData
                .Skip(1) // Пропускаем заголовок
                .Select(row => new { Date = DateTime.Parse(row[5]), ProductCount = int.Parse(row[4]) })
                .Where(order => order.Date.Month == monthIndex)
                .GroupBy(order => order.Date.Day)
                .Select(group => new { Day = group.Key, OrderCount = group.Count(), ProductCount = group.Sum(order => order.ProductCount) })
                .OrderBy(order => order.Day)
                .ToList();

            // Задаем тип графика - сплайн
            Series series = new Series
            {
                Name = "Orders",
                ChartType = SeriesChartType.Spline,
                XValueType = ChartValueType.Int32
            };

            // Очищаем старые данные с графика
            chartOrder_KAH.Series.Clear();

            // Добавляем данные в серию
            foreach (var order in ordersByDay)
            {
                series.Points.AddXY(order.Day, order.OrderCount);
            }

            // Добавляем серию в график
            chartOrder_KAH.Series.Add(series);

            // Обновляем легенду
            chartOrder_KAH.Legends.Clear();
            chartOrder_KAH.Legends.Add(new Legend("Months") { DockedToChartArea = "ChartArea1" });

            // Настройка осей графика
            chartOrder_KAH.ChartAreas[0].AxisX.Title = "День";
            chartOrder_KAH.ChartAreas[0].AxisX.Interval = 1; // Устанавливаем интервал в 1 день
            chartOrder_KAH.ChartAreas[0].AxisY.Title = "Заказы";
        }

        private void comboBoxMonths_KAH_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMonths_KAH.Items.AddRange(new object[] {
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
        });
    }

    }
}





