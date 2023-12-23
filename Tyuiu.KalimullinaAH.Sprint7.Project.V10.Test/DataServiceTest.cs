using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KalimullinaAH.Sprint7.Project.V10.Lib;
namespace Tyuiu.KalimullinaAH.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetData()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\boulevarovaalina\Desktop\Новая папка\Products.csv";
            string[,] res = ds.GetData(path);

            string[,] wait = {
                { "IPhone", "1000", "123" },
                { "Samsung", "2000", "321" },
                { "Poco", "3000", "331" },
                { "Pixcel", "3500", "431" },
                { "Nokia", "1000", "521" },
                { "Xiaomi", "1500", "645" }


            };

            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            decimal productPrice = 2500;
            int productCount = 4;
            decimal clientDiscount = 10;
            var res = ds.CalculateOrderTotal(productPrice, productCount, clientDiscount);
            var wait = 9000;
            Assert.AreEqual(wait, res);


        }
        [TestMethod]
        public void ValidAddData()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\boulevarovaalina\Desktop\Новая папка\Products.csv";

            string[] wait = { "IPhone", "1000", "123" };

            bool expected = true;

            bool actual = ds.AddNewData(path, wait);

            Assert.AreEqual(expected, actual);
        }
    }
}
