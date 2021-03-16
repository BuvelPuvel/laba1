using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР0_Проект
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Булах Павел Владимирович ПР01");
            firm();
        }


        static void firm()
        {
            int i;
            Firma firm = null;
            do
            {
                Console.Write("Меню:\n1) Создать новый объект \n2) Установить атрибуты текущего обьекта \n3) Вывести информацию о фирмах  \n\nВаше решение: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("\n1) Cоздать с помощью пользовательского конструктора \n2) Создать по умолчанию \n\nВаше решение: ");
                            int F = Convert.ToInt32(Console.ReadLine());
                            string nazvan = new string(' ', 20), adres = new string(' ', 20);
                            int god;
                            if (F == 1)
                            {
                                Console.Write("Введите название  ");
                                 nazvan= Console.ReadLine();
                                Console.Write("Введите адрес ");
                                adres = Console.ReadLine();
                                Console.Write("Введите год ");
                                god = Convert.ToInt32(Console.ReadLine());
                                firm = new Firma(nazvan, adres, god);
                                Console.WriteLine("Обьект создан");
                            }
                            else if (F == 2)
                            {
                                firm = new Firma();
                                Console.WriteLine("Обьект создан");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка");
                            }
                            break;
                        }
                    case 2:
                        {
                            if (firm != null)
                            {
                                string nazvan = new string(' ', 20), adres = new string(' ', 20);
                                int god;
                                Console.Write("Введите фирму ");
                                nazvan = Console.ReadLine();
                                Console.Write("Введите aдрес ");
                                adres = Console.ReadLine();
                                Console.Write("Введите год ");
                                god = Convert.ToInt32(Console.ReadLine());
                                firm.Nazvanie = nazvan;
                                firm.Adres = adres;
                                firm.GOD = god;
                                Console.WriteLine("Обьект успешно изменен");
                            }
                            else
                            {
                                Console.WriteLine("Вы забыли создать объект");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (firm != null)
                            {
                                firm.GetInfo();
                            }
                            else
                            {
                                Console.WriteLine("Вы забыли создать объект");
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Вы что-то другое нажали...");
                        break;
                }
                Console.Write("\n\nНажмите любую клавишу...");
                Console.ReadLine();
                Console.Clear();
            }
            while (i != 3);
        }
    }
}
