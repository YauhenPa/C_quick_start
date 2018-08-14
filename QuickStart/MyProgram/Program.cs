using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurleTraining_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 8;
            int x = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите расстояние на которое пойдет черепашка");
            Console.ForegroundColor = ConsoleColor.Magenta;
            int a = Int32.Parse(Console.ReadLine());
            while (x < 6)
            {
                x++;
                Turtle.Move(a);
                Turtle.Turn(60);
            }
        }
    }
}