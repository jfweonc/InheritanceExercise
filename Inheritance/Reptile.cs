using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool ChangeColor { get; set; }
        public int NumberLegs { get; set; }
        public bool IfTail { get; set; }
        public bool IfBite { get; set; }
    }
}
