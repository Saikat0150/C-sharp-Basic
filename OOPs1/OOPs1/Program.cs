using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs1
{
    class Person
    {
        public string name;
        public int age;

        public void PersonDetails()
        {
            Console.WriteLine("You are " + name + " and " + age + " years old");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Enter your name: ");
            p.name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            p.age = Convert.ToInt32(Console.ReadLine());
            p.PersonDetails();
            Console.Read();
        }
    }
}
