using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    //Start with the Customer and Order code shown above. Write a program that demonstrates the following requirements:

        //Customers have a property exposing their historic Orders
        //Customers expose a method for adding an Order
        //Trying to add a null Order should do nothing
        //Trying to add an Order with an existing OrderNumber should replace the existing Order(not add a duplicate)
        //Orders should expose an OrderDate(which can be read/write)
        //Trying to add an order with an OrderDate in the future should do nothing
    //When finished, you should have a console application that demonstrates(via Console.WriteLine) that each of these requirements is working correctly.


    public class Customer
    {
        public Customer(string name)
        {
            Name = name;
        }
        public string Name { get; }
        public List<Order> Orders { get; } = new List<Order>();
        int lastOrder = 0;

        public void addOrder(Order order)
        {
            if(order == null || (string.IsNullOrEmpty(order.OrderNumber))) /*DateTime cannot be null*/
            {
                return;
            }
            if(this.Orders.Where(x => x.OrderNumber == order.OrderNumber).Any())
            {
                int count = this.Orders.Count(x => x.OrderNumber == order.OrderNumber);
                this.Orders.RemoveAll(x => x.OrderNumber == order.OrderNumber);
                this.Orders.Add(order);
                lastOrder = lastOrder - count + 1;
            }
            else
            {
                this.Orders.Add(order);
                lastOrder++;
            }
        }
        public void addOrder(string orderInfo)
        {
            if (string.IsNullOrEmpty(orderInfo)) /*DateTime cannot be null*/
            {
                return;
            }
            this.Orders.Add(new Order((lastOrder + 1).ToString(), orderInfo));
            lastOrder++;
        }
    }

    public class Order
    {
        DateTime orderDate = DateTime.Now;
        public string OrderInfo { get; set; }
        public Order(string orderNumber, string orderInfo)
        {
            OrderNumber = orderNumber;
            this.OrderInfo = orderInfo;
        }
        public Order(string orderNumber, DateTime orderTime)
        {
            OrderNumber = orderNumber;
            this.orderDate = orderTime;
        }
        public string OrderNumber { get; }
        public DateTime OrderDate { get { return this.orderDate; } set { if (value < DateTime.Now) { this.orderDate = value; } } }
    }
}
