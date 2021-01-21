using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ProductManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer FINI ID: " + customer.FİN + "\n" + "Customer Adı: " + customer.Name + "\n" + "Customer Soyadı: " + customer.Surname + "\n");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer FINI ID: " + customer.FİN + "\n" + "Customer Adı: " + customer.Name + "\n" + "Customer Soyadı: " + customer.Surname + "\n");
        }
        public void Lists(Customer[] customers)
        {
                foreach (var customer in customers)
                {
                    Console.WriteLine("Customer FINI ID: " + customer.FİN + "\n" + "Customer Adı: " + customer.Name + "\n" + "Customer Soyadı: " + customer.Surname + "\n");
                }
        }
        
}   }
