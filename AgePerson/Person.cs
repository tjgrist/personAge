using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgePerson
{
    class Person
    {
        public string firstName;
        public string lastName;
        int _age;
        int birthyear;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public Person(int birthyear)
        {
            this.birthyear = birthyear;
            _age = 2016 - birthyear;
            Console.Write("Enter your name: ");
            string[] fullName = Console.ReadLine().Split(' ');
            firstName = fullName[0];
            lastName = fullName[1];
        }
        public static Person operator +(Person person, int number)
        {
            person._age += number;
            return person;
        }
    }
}
