using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Tyuiu.VashumirskayaEV.Sprint7.Project.V10.Lib
{
    public class DataService
    {
        public List<string[]> LoadOrders(string path)
        {
            var result = new List<string[]>();

            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;

                reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    result.Add(parts);
                }
            }
            return result;
        }
    }
}
