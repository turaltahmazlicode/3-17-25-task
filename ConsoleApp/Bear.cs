using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Bear : Animal
    {
        public bool IsWild { get; set; }
        public Bear(string Name, DateTime Age, bool IsWild) : base(Name, Age)
        {
            this.IsWild = IsWild;
        }
    }
}
