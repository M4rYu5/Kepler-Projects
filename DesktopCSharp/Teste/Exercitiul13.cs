using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{

    //Expand upon the Person and Student example seen above by creating a Course class with a List<Student> to 
    //keep track of whom is enrolled. Make sure code using Course can't get access to the Student objects directly.

    //Create two methods on the Course class one which provides its name and another which provides a list of the 
    //RosterNames of the enrolled students.Use these methods to print out the information for the course rather 
    //than accessing the collection of enrolled student objects directly.While writing this, try accessing some 
    //of the code restricted by the access modifiers and notice the error messages you receive when trying.

    public class Person13
    {
        public Person13(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        protected string FirstName { get; private set; }
        protected string LastName { get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

        public bool IsAnAdult()
        {
            var eighteenYearsAgo = DateTime.Today.AddYears(-18);
            return this.DateOfBirth < eighteenYearsAgo;
        }
    }

    public class Student : Person13
    {
        public Student(string firstName, string lastName, DateTime dateOfBirth)
            : base(firstName, lastName, dateOfBirth)
        { }
        public string SchoolName { get; set; }

        public string RosterName { get { return $"{this.LastName}, {this.FirstName}"; } }
    }

    public class Course
    {
        public Course(string nume)
        {
            NumeCurs = nume;
        }

        private List<Student> lista = new List<Student>() { new Student("firstName", "lastName", new DateTime(2000, 3, 2)),
                                                            new Student("firstName2", "lastName2", new DateTime(1995, 3, 2)),
                                                            new Student("firstName3", "lastName4", new DateTime(1996, 3, 2))};
        public string NumeCurs { get; set; }
        public List<string> getListaStudenti()
        {
            List<string> listaStr = new List<string>();
            foreach(var x in lista)
            {
                listaStr.Add(x.RosterName);
            }
            return listaStr;
        }
    }

    public class Exercitiul13
    {
        
        public static void main()
        {
            Course curs = new Course("numeCurs");
            Console.WriteLine("Cursul: " + curs.NumeCurs);
            Console.WriteLine("Are studentii " + String.Join(", ", curs.getListaStudenti()));
        }
    }
}
