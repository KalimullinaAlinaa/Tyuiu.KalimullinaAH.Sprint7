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

namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        string filePath = @"C:\Users\boulevarovaalina\Desktop\Новая папка\Orders.csv";

        private void buttonChartMounth_KAH_Click(object sender, EventArgs e)
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
                .Select(row => new { Month = DateTime.Parse(row[7]).Month, ProductCount = int.Parse(row[6]) })
                .GroupBy(order => order.Month)
                .Select(group => new { Month = group.Key, OrderCount = group.Count(), ProductCount = group.Sum(order => order.ProductCount) })
                .OrderBy(order => order.Month)
                .ToList();

            // Устанавливаем палитру  
            chartOrder_KAH.Palette = ChartColorPalette.SeaGreen;

            // Заголовок графика  
            chartOrder_KAH.Titles.Add("Заказы по месяцам");

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

            // Добавляем последовательность  
            for (int i = 0; i < ordersByMonth.Count; i++)
            {
                Series series = chartOrder_KAH.Series.Add(legendNames[ordersByMonth[i].Month]);
                series.Points.AddXY("Заказы", ordersByMonth[i].OrderCount);
                series.Points.AddXY("Товары", ordersByMonth[i].ProductCount);
            }
        }


        private void checkBoxMonth_KAH_CheckedChanged(object sender, EventArgs e)
        {
            // Проверяем состояние чекбокса
            if (checkBoxMonth_KAH.Checked)
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
                    .Select(row => new { Month = DateTime.Parse(row[7]).Month, ProductCount = int.Parse(row[6]) })
                    .GroupBy(order => order.Month)
                    .Select(group => new { Month = group.Key, OrderCount = group.Count(), ProductCount = group.Sum(order => order.ProductCount) })
                    .OrderBy(order => order.Month)
                    .ToList();

                // Устанавливаем палитру
                chartOrder_KAH.Palette = ChartColorPalette.SeaGreen;

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
                    series.Points.AddXY("Заказы",  ordersByMonth[i].OrderCount);
                }
            }
            else
            {
                // Очищаем график, если чекбокс не выбран
                chartOrder_KAH.Series.Clear();
            }
        }

        private void checkBoxProducts_KAH_CheckedChanged(object sender, EventArgs e)
        {
            // Проверяем состояние чекбокса
            if (checkBoxProducts_KAH.Checked)
            {
                // Создаем список для хранения данных о товарах
                List<string[]> productsData = new List<string[]>();

                // Читаем данные из файла с правильной кодировкой
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] row = line.Split(';');
                        productsData.Add(row);
                    }
                }

                // Получаем названия товаров и подсчитываем количество заказов, в которых они были куплены
                var productsCount = productsData
                    .Skip(1) // Пропускаем заголовок
                    .GroupBy(product => product[0])
                    .Select(group => new { ProductName = group.Key, OrderCount = group.Count() })
                    .OrderByDescending(product => product.OrderCount)
                    .ToList();

                // Устанавливаем палитру
                chartOrder_KAH.Palette = ChartColorPalette.SeaGreen;


                // Очищаем график перед добавлением новых данных
                chartOrder_KAH.Series.Clear();

                // Добавляем последовательность
                for (int i = 0; i < productsCount.Count; i++)
                {
                    Series series = chartOrder_KAH.Series.Add(productsCount[i].ProductName);
                    series.Points.AddXY("Заказы", productsCount[i].OrderCount);
                }
            }
            else
            {
                // Очищаем график, если чекбокс не выбран
                chartOrder_KAH.Series.Clear();
            }


        }
    }

     
}