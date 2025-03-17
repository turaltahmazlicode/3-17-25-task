using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Dog : Animal
    {
        public bool HasTail { get; set; }
        public Dog(string Name, DateTime Age,bool HasTail) : base(Name, Age)
        {
            this.HasTail = HasTail;
        }

        #region task1
        public void Bark()
        {
            Console.WriteLine("Dogs are barking");
        }
        #endregion

        #region task2
        //public string Bark()
        //{
        //    return "Dogs are barking";
        //} 
        #endregion
    }
}
