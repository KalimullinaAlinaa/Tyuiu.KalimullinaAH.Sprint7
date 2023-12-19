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
            openFileDialogOrder_KAH.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*"; 
            saveFileDialogOrder_KAH.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            dateTimePicker_KAH.CustomFormat = "DD MM YYYY";
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
                    Encoding encoding = Encoding.UTF8;
                    string[,] DataMatrix = ds.GetData(FileName, encoding);
                    int rows = DataMatrix.GetLength(0); 
                    int columns = DataMatrix.GetLength(1);
                    string path = openFileDialogOrder_KAH.FileName;

                    dataGridViewOrder_KAH.RowCount = rows + 1; dataGridViewOrder_KAH.ColumnCount = columns; 
                    for (int i = 0; i < columns; i++)
                  
                    { 
                        dataGridViewOrder_KAH.Columns[i].Width = 100;
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
                string[] row = new string[] { $"{textBoxNameProduct_KAH.Text}", $"{textBoxPrice_KAH.Text}", $"{textBoxFullName_KAH.Text}", $"{textBoxNumberOfMobile_KAH.Text}", $"{numericUpDownCount_KAH.Text}", $"{dateTimePicker_KAH.Text}", $"{textBoxSum_KAH.Text}", $"{textBoxArticul_KAH.Text}" };

                dataGridViewOrder_KAH.Rows.Add(row); bool completed = ds.AddNewData(pathOrders, row);
                if (completed)
                { 
                    MessageBox.Show("Данные добавлены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void buttonFindClient_KAH_Click(object sender, EventArgs e)
        {
            string phoneNumber = textBoxNumberOfMobile_KAH.Text;


            using (var parser = new TextFieldParser(pathClients))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields.Length >= 4)
                    {
                        var clientPhoneNumber = fields[4];
                        var clientLastName = fields[0];
                        var clientFirstName = fields[1];
                        var clientMiddleName = fields[2];
                        var clientDiscont = fields[6];


                        if (clientPhoneNumber.Equals(phoneNumber))
                        {
                            var clientFullName = $"{clientLastName} {clientFirstName} {clientMiddleName}";
                            var clientDiscontTxt = $"{clientDiscont}";

                            textBoxFullName_KAH.Text = clientFullName;
                            textBoxClientDiscont_KAH.Text = clientDiscontTxt;
                            return;
                        }
                    }
                }
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
            decimal productPrice = decimal.Parse(textBoxPrice_KAH.Text);
            int productCount = (int)numericUpDownCount_KAH.Value;
            decimal clientDiscount = decimal.Parse(textBoxClientDiscont_KAH.Text);

            decimal orderTotal = ds.CalculateOrderTotal(productPrice, productCount, clientDiscount);

            textBoxSum_KAH.Text = orderTotal.ToString();
        }

        private void buttonSaveTable_KAH_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker_KAH.Value;
            string fullName = textBoxFullName_KAH.Text;
            string articul = textBoxArticul_KAH.Text;
            string numberOfMobile = textBoxNumberOfMobile_KAH.Text;
            string name = textBoxNameProduct_KAH.Text;
            decimal price = decimal.Parse(textBoxPrice_KAH.Text);
            int count = (int)numericUpDownCount_KAH.Value;
            decimal discount = decimal.Parse(textBoxClientDiscont_KAH.Text);
            decimal sum = decimal.Parse(textBoxSum_KAH.Text);

            // Создание строки данных
            string data = $"{dateTime},{fullName},{articul},{numberOfMobile},{name},{price},{count},{discount},{sum}";

            // Проверка наличия файла CSV
            if (!File.Exists(pathClients))
            {
                // Если файл не существует, создаем заголовки столбцов
                string headers = "Date,Full Name,Articul,Mobile Number,Product Name,Price,Count,Discount,Total Sum";
                File.WriteAllText(pathClients, headers + Environment.NewLine);
            }

            // Добавление данных в файл CSV
            File.AppendAllText(pathClients, data + Environment.NewLine);

            // Очистка текстовых полей
            textBoxNameProduct_KAH.Text = "";
            textBoxPrice_KAH.Text = "";
            numericUpDownCount_KAH.Value = 0;
            textBoxClientDiscont_KAH.Text = "";
            textBoxFullName_KAH.Text = "";
            textBoxArticul_KAH.Text = "";
            textBoxNumberOfMobile_KAH.Text = "";
            textBoxSum_KAH.Text = "";
        }


    }
}




    
