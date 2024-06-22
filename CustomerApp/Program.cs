using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.firstName = "Tunde";
            customer1.lastName = "Omotayo";
            customer1.id = 1;

            Customer customer2 = new Customer();
            customer2.firstName = "Bolaji";
            customer2.lastName = "Daini";
            customer2.id = 2;

            Console.WriteLine("Please enter a number for what you want to do.");
            Console.WriteLine("1 Create a new customer");
            Console.WriteLine("2 Read all customers");
            Console.WriteLine("3 Update all customers");
            Console.WriteLine("4 Delete a customer");

            int outcome = Convert.ToInt32(Console.ReadLine());

            switch (outcome)

            {

                case 1:
                    Console.WriteLine("Please enter customer first name");
                    Customer customer3 = new Customer();
                    customer3.firstName = Console.ReadLine();
                    Console.WriteLine("Please enter customer last name");
                    customer3.lastName = Console.ReadLine();
                    customer3.id = 3;
                    Console.WriteLine("|  1d|    FirstName|   LastName|");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine($"|  {customer1.id}|  {customer1.firstName}|   {customer1.lastName}|");
                    Console.WriteLine($"|  {customer2.id}|  {customer2.firstName}|   {customer2.lastName}|");
                    Console.WriteLine($"|  {customer3.id}|  {customer3.firstName}|   {customer3.lastName}|");
                    break;

                case 2:

                    Console.WriteLine($"|  {customer1.id}|    {customer1.firstName}|   {customer1.lastName}|");
                    Console.WriteLine($"|  {customer2.id}|    {customer2.firstName}|   {customer2.lastName}|");
                    break;

                case 3:
                    Console.WriteLine("Please enter customer first and last name separated by a single space");
                    string name = Console.ReadLine();
                    Console.WriteLine("customer not found!");
                    break;

                case 4:
                    Console.WriteLine("Please enter customer first and last name separated by a single space");
                    name = Console.ReadLine();
                    Console.WriteLine("customer not found!");

                    break;
            }
        }
    }
}
