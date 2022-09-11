using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            List<Customer> customers = new List<Customer>()
            {
                new Customer {ID=1,Name="Fatih" },
                new Customer { ID = 2, Name = "Fatih2" }
            };

            var count = customers.Count;
            var customer2 = new Customer
            {
                ID = 3,
                Name = "Fatih3"

            };


            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{ID=4 ,Name = "Ayşe"},
                new Customer{ID=5 ,Name = "Ali"}
            });


            //customers.Clear(); // tüm elemanları siler

            //Console.WriteLine(customers.Contains());  //true veya false döner

            //customers.Add(new Customer {ID=1,Name="Fatih" });
            //customers.Add(new Customer { ID = 2, Name = "Fatih2" });

            var index = customers.IndexOf(customer2); //baştan başlayarak elemanın indexini verir
            var index2 = customers.LastIndexOf(customer2); // sondan başlayarak elemanın indexini verir
            Console.WriteLine("Index  : {0}", index2);

            customers.Insert(0, customer2);

            customers.Remove(customer2); // bulduğu ilk değeri siler, sildiği anda aramayı bitirir
            customers.RemoveAll(c => c.Name == "Fatih"); // ismi fatih olan liste elemanlarının hepsini siler

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }

        private static void ArrayList()
        {
            //tip güvensiz koleksiyon
            ArrayList cities = new ArrayList(); //çalıştığımız nesnede veri tipi yoksa kullanabiliriz
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
