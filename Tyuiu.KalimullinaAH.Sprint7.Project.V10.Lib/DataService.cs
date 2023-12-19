using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10.Lib
{
    public class DataService
    {
        public string[,] GetData(string path, Encoding encoding)
        {
            string fileData = File.ReadAllText(path, encoding);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

    

    public void SaveDataToCSV(DateTime dateTime, string fullName, string articul, string numberOfMobile,string name, decimal price, int count, decimal discount, decimal sum,string path)
        {
            string[] data = { dateTime.ToString(), fullName, articul, numberOfMobile, name, price.ToString(), count.ToString(), discount.ToString(), sum.ToString() };
            string csvLine = string.Join(",", data);

            // Сохранение строки в файл CSV
            File.AppendAllText(path, csvLine + Environment.NewLine);
        }


        public bool AddNewData(string path, string[] line)
            {
                bool completed = false;

                string str = "";

                for (int i = 0; i < line.Length; i++)
                {
                    if (i != line.Length - 1)
                    {
                        str = str + line[i] + ";";
                    }
                    else
                    {
                        str = str + line[i];
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                completed = true;
                return completed;
            }

        public decimal CalculateOrderTotal(decimal productPrice, int productCount, decimal clientDiscount)
        {
            decimal orderTotal = (productPrice * productCount) * (1 - (clientDiscount / 100));



            return orderTotal;
        
        }
        public class Client
        {
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public DateTime Birthdate { get; set; }
            public string PhoneNumber { get; set; }
            public string City { get; set; }
        }

        public class ClientMap : ClassMap<Client>
        {
            public ClientMap()
            {
                Map(m => m.LastName).Index(0);
                Map(m => m.FirstName).Index(1);
                Map(m => m.MiddleName).Index(2);
                Map(m => m.Birthdate).Index(3).TypeConverterOption.Format("dd.MM.yyyy");
                Map(m => m.PhoneNumber).Index(4);
                Map(m => m.City).Index(5);
            }
        }
    }
}
