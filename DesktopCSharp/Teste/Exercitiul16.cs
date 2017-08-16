using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    //Create two custom exceptions, MyMissingTokenException and MyInvalidTokenException, both inheriting from ArgumentException. 
    //The first should be thrown if the token is null or empty. The second should be thrown if the token exists, 
    //but doesn't meet some criteria of your choosing (for instance, minimum and/or maximum length).


    public class MyMissingTokenException : ArgumentException
    {
        public MyMissingTokenException(string memberName)
        : base($"Could not find member: {memberName}.")
        { }
    }

    public class MyInvalidTokenException : ArgumentException
    {
        public MyInvalidTokenException(string memberName)
        : base($"Invalid (trebuie sa fie > 3 si < 16): {memberName}.")
        { }
    }

    public class Exercitiul16
    {

        public static void main()
        {
            Console.WriteLine("Introdu parola, trebuie sa fie mai lunga decat 3 si mai scurta de 17");
            string pass = null;
            try
            {
                pass = GetAccessPermissions(Console.ReadLine());
            }
            catch (MyMissingTokenException e)
            {
                Console.WriteLine(e);
            }
            catch (MyInvalidTokenException e)
            {
                Console.WriteLine(e);
            }
            
        }



        private static string GetAccessPermissions(string token)
        {

            if (token == null || token == "")
            {
                throw new MyMissingTokenException(token);
            }

            if (token.Count() <= 3 || token.Count() > 16)
            {
                throw new MyInvalidTokenException(token);
            }

            return token;
        }
    }
}
