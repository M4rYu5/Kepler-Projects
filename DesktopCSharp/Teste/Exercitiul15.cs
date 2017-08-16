using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    //Starting with the Person class and the collection you used in this lesson, 
    //create a program that prints the name of each developer older than a specified age. 
    //Prompt the user with the Console.ReadLine() method to determine the age to use for filtering the collection.

    public class Person22
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
    }

    public class Exercitiul15
    {
        public static void main()
        {
            List<Person22> lista = new List<Person22> { new Person22() { FirstName = "Primul", LastName = "pr", Age = 15, Occupation = "Elev"},
                                                    new Person22() { FirstName = "Doi", LastName = "do", Age = 22, Occupation = "developer" },
                                                    new Person22() { FirstName = "Trei", LastName = "tr", Age = 21, Occupation = "Student"},
                                                    new Person22() { FirstName = "Patru", LastName = "pa", Age = 66, Occupation = "Developer"},
                                                    new Person22() { FirstName = "Cinci", LastName = "ci", Age = 43, Occupation = "Developer"},
                                                    new Person22() { FirstName = "Sase", LastName = "sa", Age = 33, Occupation = "Dentist"},
                                                    new Person22() { FirstName = "Sapte", LastName = "sap", Age = 23, Occupation = "Macelar"},
                                                    new Person22() { FirstName = "Opt", LastName = "op", Age = 32, Occupation = "Strungar"},
                                                    new Person22() { FirstName = "Noua", LastName = "no", Age = 47, Occupation = "developer"}};
            int olderThan = 33;
            string profesion = "developer";

            Console.WriteLine("Urmatorul program iti va afisa persoanele din lista in functie de:");
            Console.Write("profesie: ");
            profesion = Console.ReadLine();
            Console.Write("cu o varsta mai mare de: ");
            olderThan = int.Parse(Console.ReadLine());

            foreach (var x in lista.Where(x => x.Occupation.ToUpper() == profesion.ToUpper() && x.Age > olderThan)){
                Console.WriteLine($"{x.FirstName} {x.LastName}  varsta: {x.Age} profesie: {x.Occupation}");
            }
        }
    }
}
