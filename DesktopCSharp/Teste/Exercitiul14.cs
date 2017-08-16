using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;

namespace Teste
{
    //Start with the Customer and Order code shown above. Write a program that demonstrates the following requirements:

        //Customers have a property exposing their historic Orders
        //Customers expose a method for adding an Order
        //Trying to add a null Order should do nothing
        //Trying to add an Order with an existing OrderNumber should replace the existing Order(not add a duplicate)
        //Orders should expose an OrderDate(which can be read/write)
        //Trying to add an order with an OrderDate in the future should do nothing
    //When finished, you should have a console application that demonstrates(via Console.WriteLine) that each of these requirements is working correctly.
    
    public class Exercitiul14
    {
        public static void main()
        {
            Console.WriteLine("Salut, te rog introdu-ti numele pentu a putea face o comanda ");
            Customer customer = new Customer(Console.ReadLine());

            int order = 0;
            check:
            Console.WriteLine($"Salut {customer.Name} te rog sa introduci comanda (text not used)");
            Console.ReadLine();

            customer.addOrder(new Order(order.ToString(), DateTime.Now));

            Console.WriteLine("Comenzile tale sunt:");
            foreach(var x in customer.Orders)
            {
                Console.WriteLine($"Order nr: {x.OrderNumber} | Order date: {x.OrderDate.ToShortDateString()}");
            }
            Console.WriteLine();
            Console.WriteLine("Daca vrei sa mai adaugi alte comenzi apas 1");
            if(int.Parse(Console.ReadLine()) == 1){
                order++;
                goto check;
            }
        }
    }
}
