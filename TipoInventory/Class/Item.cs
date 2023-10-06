using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoInventory.Class
{
    public class Item
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public decimal Price { get; set; }

        public Item(string name, double weight, decimal price)
        {
            Name = name;
            Weight = weight;
            Price = price;
        }

        public virtual string Display()
        {
            return $"{Name} - {Price} серебрянных, {Weight} кг";
        }
    }
}
