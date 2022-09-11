using System;

namespace Attiributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Ataç", Age = 21 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }

    }

    [ToTable("Customers")] // satır 44
    [ToTable("TblCustomers")] // satır 44
    class CustomerDal
    {
        [Obsolete("Don't use Add, instead use AddNew method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

    }

    //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)] 
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)] // sadece property'lere uygulanabilir, propertylere birden fazla uygulayabilirim demek 
    class RequiredPropertyAttribute : Attribute
    {

    }


    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

}
