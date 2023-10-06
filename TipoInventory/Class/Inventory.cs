using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoInventory.Class
{
    public class Inventory
    {
        List<Item> _items = new List<Item>();
        public Armor eA;
        public Weapon eW;

        public int Capacity { get; } = 32;

        public void AddItem(Item item)
        {
            if (_items.Count < Capacity)
            {
                _items.Add(item);
            }
            else
            {
                Console.WriteLine("Место в инвентаре закончилось!");
            }
        }

        public void Display()
        {
            Console.WriteLine("Инвентарь: ");
            foreach (var item in _items)
            {
                Console.WriteLine(item.Display());
            }

            if (eW != null)
            { Console.WriteLine($"\nЭкипированное оружие: {eW.Display()}"); } else
            { Console.WriteLine($"\nЭкипированное оружие: нету"); }

            if (eA != null)
            { Console.WriteLine($"Экипированная броня: {eA.Display()}"); } else
            { Console.WriteLine($"Экипированная броня: нету"); }
        }

        public void DisplayFilter(int type)
        {
            Console.WriteLine("Инвентарь: ");
            foreach (var item in _items)
            {
                if (item is Weapon && type == 1)
                { Console.WriteLine(item.Display()); }
                else if (item is Armor && type == 2)
                { Console.WriteLine(item.Display()); }
                else if (!(item is Weapon || item is Armor) && type == 3)
                { Console.WriteLine(item.Display()); }
            }
        }

        public void EquipWeapon(Weapon weapon)
        {
            eW = weapon;
        }

        public void EquipArmor(Armor armor)
        {
            eA = armor;
        }

        public void SortName()
        {
            _items.Sort((x, y) => x.Name.CompareTo(y.Name));
        }

        public void SortPrice()
        {
            _items.Sort((x, y) => x.Price.CompareTo(y.Price));
        }

        public void SortWeight()
        {
            _items.Sort((x, y) => x.Weight.CompareTo(y.Weight));
        }

        public Item Find(string _char)
        {
            Item find = _items.Find(x => x.Name.Contains(_char));
            return find;
        }
    }
}
