using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Animal
    {
        public string Name { get; set; }
        public DateTime Age { get; set; }

        public Animal(string Name, DateTime Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void Eat()
        {
            Console.WriteLine("Able to eat");
        }
    }
}
