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
        public string[,] GetData(string path)
        {
            string fileData = File.ReadAllText(path, Encoding.GetEncoding(1251));
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
            File.AppendAllText(path, str + Environment.NewLine, Encoding.GetEncoding(1251));
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
            public int Discount { get; set; }
            public string Address { get; set; }

        }


        }
    }

