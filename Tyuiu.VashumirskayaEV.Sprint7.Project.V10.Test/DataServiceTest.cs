using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VashumirskayaEV.Sprint7.Project.V10.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint7.Project.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        public void ReadOrders_FromCsv_ReturnsData()
        {
            var service = new DataService();

            string path = "orders.csv";

            var orders = service.LoadOrders(path);

            Assert.IsNotNull(orders);
            Assert.IsTrue(orders.Count > 0);
        }
    }
}
