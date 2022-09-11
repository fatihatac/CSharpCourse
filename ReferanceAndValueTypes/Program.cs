using System;
using System.Data;

namespace ReferanceAndValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities = new string[] { "Ankara", "Aydın", "Afyon" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities;
            cities[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            DataTable dataTable1;
            DataTable dataTable2 = new DataTable();
            dataTable1 = dataTable2;
            
        }
    }
}
