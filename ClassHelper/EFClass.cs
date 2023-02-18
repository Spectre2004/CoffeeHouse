using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeHouse.DB;

namespace CoffeeHouse.ClassHelper
{
    internal class EFClass
    {
        public static Entities2 Context { get; } = new Entities2();
    }
}
