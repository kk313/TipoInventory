using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TipoInventory.Class;

namespace TipoInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory invent = new Inventory();

            invent.AddItem(new Weapon("Дубина", 3.5, 1050, 150));
            invent.AddItem(new Armor("Набор клоуна", 15, 10, 15));
            invent.AddItem(new Weapon("Меч", 5, 16000, 268));
            invent.AddItem(new Armor("Бронежилет Аврора", 2.8, 650, 60));
            invent.AddItem(new Weapon("Многострадальный пендель", 0.5, 0, 200));
            invent.AddItem(new Armor("Типо тряпка", 0.01, 5, 1));
            invent.AddItem(new Item("Сопля Фирамира", 0.5, 0));
            invent.AddItem(new Weapon("Сомомеч", 4, 9999, 450));

            int x = 0;
            while (x != 6)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Инвентарь");
                Console.WriteLine("2. Найти предмет");
                Console.WriteLine("3. Сортировка инвентаря");
                Console.WriteLine("4. Смена экипировки");
                Console.WriteLine("5. Фильтры");
                Console.WriteLine("6. Выйти");

                x = Int32.Parse(Console.ReadLine());
                switch(x)
                {
                    case 1:
                        {
                            Console.Clear();
                            invent.Display();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите название предмета: ");
                            string _char = Console.ReadLine();
                            if (invent.Find(_char) == null)
                            { Console.WriteLine("Ничего не найдено!"); }
                            else { Console.WriteLine(invent.Find(_char).Display()); }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 3:
                        {
                            int temp = 0;
                            while (temp != 4)
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите действие:");
                                Console.WriteLine("1. Отсортировать инвентарь по названию");
                                Console.WriteLine("2. Отсортировать инвентарь по весу");
                                Console.WriteLine("3. Отсортировать инвентарь по стоимости");
                                Console.WriteLine("4. Назад");
                                int temp2 = Int32.Parse(Console.ReadLine());
                                if (temp2 == 1) { Console.Clear(); invent.SortName(); temp = 4; }
                                else if (temp2 == 2) { Console.Clear(); invent.SortWeight(); temp = 4; }
                                else if (temp2 == 3) { Console.Clear(); invent.SortPrice(); temp = 4; }
                                else if (temp2 == 4) { temp = 4; }
                                else if (temp2 != 1 || temp2 != 2 || temp2 != 3) Console.WriteLine("Вы не выбрали никакое действие!");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 4:
                        {
                            int temp = 0;
                            while (temp != 3)
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите действие:");
                                Console.WriteLine("1. Сменить оружие");
                                Console.WriteLine("2. Сменить броню");
                                Console.WriteLine("3. Назад");

                                int temp2 = Int32.Parse(Console.ReadLine());
                                if (temp2 == 1)
                                {
                                    Console.WriteLine("Введите название предмета: ");
                                    string _char = Console.ReadLine();
                                    if (invent.Find(_char) is Weapon weapon)
                                    { Weapon w = (Weapon)invent.Find(_char); invent.EquipWeapon(w); temp = 3; Console.WriteLine("Вы успешно экипировали оружие!"); }
                                    else { Console.WriteLine("Тип предмета не соответствует экипированному типу!"); temp = 3; }
                                }
                                else if (temp2 == 2)
                                {
                                    Console.WriteLine("Введите название предмета: ");
                                    string _char = Console.ReadLine();
                                    if (invent.Find(_char) is Armor armor)
                                    { Armor a = (Armor)invent.Find(_char); invent.EquipArmor(a); temp = 3; Console.WriteLine("Вы успешно экипировали оружие!"); }
                                    else { Console.WriteLine("Тип предмета не соответствует экипированному типу!"); temp = 3; }
                                }
                                else if (temp2 == 3) temp = 3;
                                else if (temp2 != 1 || temp2 != 2 || temp2 != 3) Console.WriteLine("Некорректный ввод");

                                Console.ReadKey();
                            }
                            break;
                        }
                    case 5:
                        {
                            int temp = 0;
                            while (temp != 4)
                            {
                                Console.Clear();
                                Console.WriteLine("Выберите фильтр:");
                                Console.WriteLine("1. Оружия");
                                Console.WriteLine("2. Броня");
                                Console.WriteLine("3. Предметы");
                                Console.WriteLine("4. Назад");

                                int temp2 = Int32.Parse(Console.ReadLine());
                                if (temp2 == 1) { Console.Clear(); invent.DisplayFilter(temp2); }
                                else if (temp2 == 2) { Console.Clear(); invent.DisplayFilter(temp2); }
                                else if (temp2 == 3) { Console.Clear(); invent.DisplayFilter(temp2); }
                                else if (temp2 == 4) { temp = 4; }
                                else { Console.WriteLine("Некорректный ввод"); }

                                Console.ReadKey();
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("пока пока!");
                            Thread.Sleep(5000);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Некоррекетный выбор");
                            break;
                        }
                }
            }
            Console.ReadKey();
        }
    }
}
