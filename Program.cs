using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        #region Задача 1 "Анкета"
              Console.Write("Введите Ваше имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите Вашу Фамилию: ");
                string surName = Console.ReadLine();
                Console.Write("Укажите Ваш возраст: ");
                string age = Console.ReadLine();
                Console.Write("укажите Ваш рост: ");
                string height = Console.ReadLine();
                Console.Write("укажите Ваш вес: ");
                string weight = Console.ReadLine();
                Console.WriteLine("Ваши данные:" + " Имя - " + name + "; Фамилия - " + surName + "; возраст -  " + age + "; рост -  " + height + "; вес -  " + weight);
                Console.WriteLine("{0} {1} {2} {3} {4}", name, surName, age, height, weight);
                Console.WriteLine($"Мои данные: {name} {surName} {age} {height} {weight}");
            #endregion

            Console.Clear();

        #region Задача 2
            double m, h;
                Console.WriteLine("Введите Ваш вес в кг.");
                m = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите Ваш рост в м.");
                h = double.Parse(Console.ReadLine());
                double i = m/(h * h);
                i = Math.Round(i, 3);
                Console.WriteLine($"Индекс мыссы Вашего тела =  {i}  кг/кв. м");
                Console.ReadLine();
                #endregion

            Console.Clear();

        #region Задача 3 

            double x1, x2, y1, y2;
            Console.WriteLine("Введите значение x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y1");
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение x2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y2");
            y2 = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            r = Math.Round(r, 2);
            Console.WriteLine($"Расстояние между точками =  {r}");
            Console.ReadLine();
            #endregion

            Console.Clear();

        #region Задача 4 
            int a, b;
            a = 5; b = 10;
            Console.WriteLine($" {a} {b}");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($" {a} {b}");
            Console.ReadLine();
        
            Console.Clear();
            int d, e;
            d = 5; e = 10;
            Console.WriteLine($" {d} {e}");
            d = d+e;
            e = d-e;
            d = d - e;
            Console.WriteLine($" {d} {e}");
            Console.ReadLine();
            #endregion

            Console.Clear();

        #region Задача 5 

            string name1 = "Павел Зыкин";
            string city = "Калининград";

            Console.SetCursorPosition(50, 50);
            Console.WriteLine(name1);
            Console.SetCursorPosition(50, 70);
            Console.WriteLine(city);

            #endregion
        }



    }
        
        }

    

