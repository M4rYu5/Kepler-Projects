using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    //Write a program that prints out addresses for people and companies. 

    public class Address
    {
        public Address(string streetAddress, string city, string state, string postalCode, string country)
        {
            this.StreetAddress = streetAddress;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.Country = country;
        }

        public string StreetAddress { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string State { get; set; } = String.Empty;
        public string PostalCode { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;

        public string getFullAdress()
        {
            return StreetAddress + ", " + City + ", " + State + ", " + PostalCode + ", " + Country;
        }
    }

    public class Person : Address
    {
        private string firstName;
        private string lastName;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string FirstName, string LastName, string streetAddress, string city, string state, string postalCode, string country) 
            : base( streetAddress, city, state, postalCode, country)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }
        public override string ToString()
        {
            return $@"Person name: {firstName} {lastName} 
Company address {getFullAdress()}";
        }
    }

    public class Company : Address
    {
        private string name;

        public Company(string name, string streetAddress, string city, string state, string postalCode, string country) 
            : base( streetAddress, city, state, postalCode, country)
        {
            this.name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $@"Company name: {name} 
Company address {getFullAdress()}";
        }
    }

    public class Exercitiul12
    {
        public static void main()
        {
            List<Address> lista = new List<Address>();
            lista.Add(new Person("prenume1", "nume1", "street1", "city1", "regiune1", "postalcode1", "tara1"));
            lista.Add(new Person("prenume2", "nume2", "street2", "city2", "regiune2", "postalcode2", "tara2"));
            lista.Add(new Person("prenume3", "nume3", "street3", "city3", "regiune3", "postalcode3", "tara3"));
            lista.Add(new Company("nume1", "street1", "city3", "regiune2", "postalcode2", "tara22"));
            lista.Add(new Company("nume2", "street1", "city2", "regiune2", "postalcode2", "tara22"));
            lista.Add(new Company("nume3", "street2", "city1", "regiune2", "postalcode2", "tara22"));
            lista.Add(new Company("nume4", "street2", "city1", "regiune2", "postalcode2", "tara2"));
            lista.Add(new Company("nume5", "street3", "city1", "regiune1", "postalcode2", "tara11"));
            lista.Add(new Person("prenume4", "nume44", "street", "city", "regiune", "postalcode", "tara"));
            lista.Add(new Person("prenume5", "nume44", "street", "city", "regiune", "postalcode", "tara"));
            lista.Add(new Person("prenume6", "nume22", "street", "city", "regiune", "postalcode", "tara"));
            Console.WriteLine();
            foreach(var x in lista)
            {
                Console.WriteLine(x.ToString());
                Console.WriteLine();
            }
        }
    }
}
