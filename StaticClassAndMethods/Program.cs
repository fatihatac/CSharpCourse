using System;

namespace StaticClassAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher.Number = 10;

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {

        }
        public static void Validate()
        {

            // iş kodları
            // 
            Console.WriteLine("Validation is done");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }


}
