using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoInventory.Class
{
    public class Weapon : Item
    {
        public int Attack { get; set; }

        public Weapon(string name, double weight, decimal price, int attack) : base(name, weight, price)
        {
            Attack = attack;
        }

        public override string Display()
        {
            return base.Display() + $", {Attack} атаки";
        }
    }
}
