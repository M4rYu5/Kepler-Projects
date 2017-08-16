using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TestLib;

namespace Teste
{
    //Up to this point you've written code as you went through each lesson, 
    //and at the end of those lessons you've gone through some excercises on your own. 
    //Go back to this code and add some unit tests to confirm it is all correct and complete!

    public class Exercitiul17
    {
        
        [Fact]
        public void TestCustomerAdd()
        {
            //Arrange
            Customer customer = new Customer("Nume");
            int expectedLenght = 10;

            //Act
            for(int i = 0; i < expectedLenght; i++)
            {
                customer.addOrder(new Order(i.ToString(), new DateTime(2000, 10, 22)));
            }
            for (int i = 0; i < expectedLenght; i++)
            {
                customer.addOrder(new Order(i.ToString(), new DateTime(2000, 10, 22)));
            }
            customer.addOrder(new Order(null, new DateTime(2000, 10, 22)));
            customer.addOrder(new Order("", new DateTime(2000, 10, 22)));


            //Assert
            Assert.Equal(expectedLenght, customer.Orders.Count);
           
        }
    }
}
