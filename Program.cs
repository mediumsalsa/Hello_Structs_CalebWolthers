using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Structs_CalebWolthers
{
    internal class Program
    {

        struct Person
        {

            public string name;

            public int age;
        
        }



        static void Main(string[] args)
        {

            Console.WriteLine("Structs");
            Console.WriteLine("");

            Person person1 = new Person();

            person1.name = "john";
            person1.age = 28;


            Person person2 = person1;

            person2.name = "Drac";

            Console.WriteLine("Person Information");
            Console.WriteLine(person1.name);
            Console.WriteLine(person1.age);
            Console.WriteLine("");

            Console.WriteLine("Person Information");
            Console.WriteLine(person2.name);
            Console.WriteLine(person2.age);
            Console.WriteLine("");



            Console.WriteLine("");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
