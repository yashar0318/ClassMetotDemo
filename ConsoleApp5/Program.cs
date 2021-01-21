using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FİN = 1;
            customer1.Name = "Yashar";
            customer1.Surname = "İsgenderov";
            
            Customer customer2 = new Customer();
            customer2.FİN = 2;
            customer2.Name = "Engin";
            customer2.Surname = "Demiroğ";

            Customer[] customers = new Customer[] { customer1, customer2 };

            ProductManager productManager = new ProductManager();

            Console.WriteLine("Yeni Customer elave etmek \n");

            productManager.Add(customer1);
            productManager.Add(customer2);

            Console.WriteLine("Yeni customer silmek \n");

            productManager.Delete(customer1);
            productManager.Delete(customer2);

            Console.WriteLine("Yeni customerleri listlemek \n");

            productManager.Lists(customers);
        }
    }
}
