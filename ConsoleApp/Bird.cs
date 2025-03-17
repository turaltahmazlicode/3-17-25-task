using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Bird : Animal
    {
        public bool CanSwim { get; set; }
        public Bird(string Name, DateTime Age, bool CanSwim) : base(Name, Age)
        {
            this.CanSwim = CanSwim;
        }

        #region task1
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
        #endregion

        #region task2
        //public string Fly()
        //{
        //    return "Fly";
        //} 
        #endregion
    }
}
