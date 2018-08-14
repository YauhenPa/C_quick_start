using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здаравствуйте. Здесь вы можете выбрать фильмы для просмотра.");
            Console.WriteLine("Какой жанр вы хотите увидеть? Ужасы или комедии?");
            string genre = Console.ReadLine();
            if (genre == "Ужасы")
            {
                Console.WriteLine("Хижина в лесу.");
                Console.WriteLine("Оно.");
            }
            else
            {
                Console.WriteLine("Один дома.");
                Console.WriteLine("Тупой и еще тупее.");
            };
            Console.ReadLine();
        }
    }
}