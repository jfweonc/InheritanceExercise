using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool IfFly { get; set; }
        public bool HasWing { get; set; }
        public string Origin { get; set; }
        public int NumberLegs { get; set; }
    }
}
