using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoInventory.Class
{
    public class Armor : Item
    {
        public int Defense { get; set; }

        public Armor(string name, double weight, decimal price, int defense) : base (name, weight, price)
        {
            Defense = defense;
        }

        public override string Display()
        {
            return base.Display() + $", {Defense} защиты";
        }
    }
}
