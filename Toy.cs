using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaWorkshop
{
    /// <summary>
    /// Single Responsibility Principle (SRP) - each class should have only one reason to change. The Toy class follows the Single Responsibility Principle because it has only one reason to change (the properties and constructor).
    /// </summary>
    public class Toy
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Toy(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
