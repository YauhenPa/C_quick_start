using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте. Как вас зовут?");
            string Name = Console.ReadLine();
            Console.WriteLine("Здаравствуйте " + Name + ". Здесь вы можете выбрать фильмы для просмотра.");
            Console.WriteLine("Какой жанр вы хотите увидеть? Ужасы, комедия, боевик или эротика?");
            string genre = Console.ReadLine();
            string greating = "Вашему вниманию представлены следующие фильмы:";
            if (genre == "Ужас")
            {
                Console.WriteLine(greating);
                Console.WriteLine("Хижина в лесу.");
                Console.WriteLine("Оно.");
            }
            else if (genre == "Комедия")
            {
                Console.WriteLine(greating);
                Console.WriteLine("Один дома.");
                Console.WriteLine("Тупой и еще тупее.");
            }
            else if (genre == "Боевик")
            {
                Console.WriteLine(greating);
                Console.WriteLine("Черепашки нинзя");
                Console.WriteLine("Бэтман");
            }
            else if (genre == "Эротика")
            {
                Console.WriteLine("Укажите ваш возраст");
                string yearString = Console.ReadLine();
                int yearInt = Int32.Parse(yearString);
                if (yearInt < 18)
                {
                    Console.WriteLine("Приходите через " + (18 - yearInt) + " лет.");
                }
                else
                {
                    Console.WriteLine(greating);
                    Console.WriteLine("В джазе только девушки");
                    Console.WriteLine("Красная шапочка");

                };
            }
            Console.ReadLine();
        }
    }
}