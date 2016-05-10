using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgePerson
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("What year were you born?");
            int birthyear = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(birthyear);
            person = person + 35; //this is overloading the + operator 
            Console.WriteLine("{0} {1} will be {2} in 2051.", person.firstName, person.lastName, person.Age);
            Console.ReadKey();
        }
    }
}
