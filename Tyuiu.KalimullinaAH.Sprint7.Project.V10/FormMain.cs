using CsvHelper;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KalimullinaAH.Sprint7.Project.V10.Lib;
using static Tyuiu.KalimullinaAH.Sprint7.Project.V10.Lib.DataService;


namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10
{
    public partial class FormMain : Form
    {
        public FormMain() 
        {
            InitializeComponent();
        }
       
        DataService ds = new DataService(); 
        string pathClients = @"C:\Users\boulevarovaalina\Desktop\Новая папка\Clients.csv";
        string pathOrders = @"C:\Users\boulevarovaalina\Desktop\Новая папка\Orders.csv";

        private void buttonOpenTable_KAH_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialogOrder_KAH.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string FileName = openFileDialogOrder_KAH.FileName;
                    string[,] DataMatrix = ds.GetData(FileName);
                    int rows = DataMatrix.GetLength(0); 
                    int columns = DataMatrix.GetLength(1);
                    string path = openFileDialogOrder_KAH.FileName;

                    dataGridViewOrder_KAH.RowCount = rows + 1;
                    dataGridViewOrder_KAH.ColumnCount = columns;
                    dataGridViewOrder_KAH.Columns[0].HeaderText = "Наименование товара";
                    dataGridViewOrder_KAH.Columns[1].HeaderText = "Стоимость";
                    dataGridViewOrder_KAH.Columns[2].HeaderText = "ФИО клиента";
                    dataGridViewOrder_KAH.Columns[3].HeaderText = "Номер телефона";
                    dataGridViewOrder_KAH.Columns[4].HeaderText = "Кол-во товара";
                    dataGridViewOrder_KAH.Columns[5].HeaderText = "Дата оформления заказа";
                    dataGridViewOrder_KAH.Columns[6].HeaderText = "Сумма товара";
                    dataGridViewOrder_KAH.Columns[7].HeaderText = "Артикул товара";

                    for (int i = 0; i < columns; i++)
                  
                    { 
                        dataGridViewOrder_KAH.Columns[i].Width = 150;
                    }
                    for (int r = 0; r < rows; r++)
                    
                    { for (int c = 0; c < columns; c++) 
                        dataGridViewOrder_KAH.Rows[r].Cells[c].Value = DataMatrix[r, c]; 
                    } 
                }
                
                else { throw new Exception("Файл не выбран!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        private void buttonAddData_KAH_Click_1(object sender, EventArgs e)
        {
            try
            {
                string[] row = new string[] { $"{textBoxNameProduct_KAH.Text}", $"{textBoxPrice_KAH.Text}", $"{textBoxFullName_KAH.Text}", $"{textBoxNumberOfMobile_KAH.Text}", $"{numericUpDownCount_KAH.Text}", $"{dateTimePicker_KAH.Value.ToString("dd.MM.yyyy")}", $"{textBoxSum_KAH.Text}", $"{textBoxArticul_KAH.Text}" };
                dataGridViewOrder_KAH.Rows.Add(row);
                bool completed = ds.AddNewData(pathOrders, row);
                if (completed)
                {
                    MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxNameProduct_KAH.Clear(); 
            textBoxPrice_KAH.Clear(); 
            textBoxFullName_KAH.Clear();
            textBoxNumberOfMobile_KAH.Clear(); 
            numericUpDownCount_KAH.Value = 0; 
            dateTimePicker_KAH.Value = DateTime.Now; 
            textBoxSum_KAH.Clear(); 
            textBoxArticul_KAH.Clear(); 
        }

        private void buttonFindClient_KAH_Click(object sender, EventArgs e)
        {
            string phoneNumber = textBoxNumberOfMobile_KAH.Text;
            try
            {
                using (StreamReader sr = new StreamReader(pathClients, Encoding.GetEncoding(1251))) 
                using (var parser = new TextFieldParser(sr))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(";");
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        if (fields.Length > 6) 
                        {
                            var clientName = fields[0];
                            var clientSurname = fields[1];
                            var clientPatronymic = fields[2];
                            var clientPhoneNumber = fields[4]; 
                            var clientDiscont = fields[6]; 

                            if (clientPhoneNumber.Equals(phoneNumber))
                            {
                                var clientFullName = $"{clientName} {clientSurname} {clientPatronymic}";
                                textBoxFullName_KAH.Text = clientFullName;
                                textBoxClientDiscont_KAH.Text = clientDiscont;
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Клиент не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buttonFindProduct_KAH_Click(object sender, EventArgs e)
        {
            string articul = textBoxArticul_KAH.Text;
            string productFilePath = @"C:\Users\boulevarovaalina\Desktop\Новая папка\Products.csv";

            using (var parser = new TextFieldParser(productFilePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields.Length >= 3)
                    {
                        var productArticul = fields[2];
                        var productName = fields[0];
                        var productPrice = fields[1];

                        if (productArticul.Equals(articul))
                        {
                            textBoxNameProduct_KAH.Text = productName;
                            textBoxPrice_KAH.Text = productPrice;
                            return;
                        }
                    }
                }
            }

            MessageBox.Show("Товар не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonCalculateOrder_KAH_Click(object sender, EventArgs e)
        {
            try
            {
                decimal productPrice = decimal.Parse(textBoxPrice_KAH.Text);
                int productCount = (int)numericUpDownCount_KAH.Value;
                decimal clientDiscount = decimal.Parse(textBoxClientDiscont_KAH.Text);

                decimal orderTotal = ds.CalculateOrderTotal(productPrice, productCount, clientDiscount);

                textBoxSum_KAH.Text = orderTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void buttonAddClient_KAH_Click(object sender, EventArgs e)
        {
            FormAddClient add = new FormAddClient();
            add.ShowDialog();
        }

        private void buttonEditClient_KAH_Click(object sender, EventArgs e)
        {
            FormEditClient edit = new FormEditClient();
            edit.ShowDialog();
        }

        private void buttonChart_KAH_Click(object sender, EventArgs e)
        {
            FormChart chart=   new FormChart();
            chart.ShowDialog(); 
        }

        private void buttonManual_KAH_Click(object sender, EventArgs e)
        {
            FormManual manual = new FormManual();
            manual.ShowDialog();
        }

        private void buttonInfo_KAH_Click(object sender, EventArgs e)
        {
            FormAbout about= new FormAbout();
            about.ShowDialog();
        }

        private void buttonOpenTable_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipOrder_KAH.ToolTipTitle = "Открыть файл";

        }

        private void buttonAddData_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipOrder_KAH.ToolTipTitle= "Сохранить в файл";
        }

        private void buttonInfo_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipOrder_KAH.ToolTipTitle = "Справка";
        }

        private void buttonManual_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipOrder_KAH.ToolTipTitle = "Справка";

        }

        private void buttonAddClient_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipOrder_KAH.ToolTipTitle = "Добавить";

        }

        private void buttonEditClient_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipOrder_KAH.ToolTipTitle = "Редактировать";

        }

        private void buttonChart_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipOrder_KAH.ToolTipTitle = "Открыть";

        }

      

        private void buttonCalculateOrder_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipOrder_KAH.ToolTipTitle = "Рассчитать";

        }

        private void buttonFindClient_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipOrder_KAH.ToolTipTitle = "Поиск";

        }

        private void buttonFindProduct_KAH_MouseEnter(object sender, EventArgs e)
        {
            toolTipOrder_KAH.ToolTipTitle = "Поиск";

        }

        private void textBoxSum_KAH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




    
