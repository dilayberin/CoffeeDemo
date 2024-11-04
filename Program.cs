using CoffeeDemo.Abstract;
using CoffeeDemo.Concrete;
using CoffeeDemo.Entitites;

namespace CofeeDemo
{/// <summary>
/// /
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer {DateOfBirth =new DateTime(2004,6,15),FirstName="Dilay",LastName="Akkan",Id=1,NationalityId="554464158846" });
            Console.ReadLine();
        }
    }
}