using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int a = 30;
            Turtle.Speed = 8;
            Turtle.Move(a);


            while (x < 4)
            {
                x++;
                Turtle.TurnRight();
                Turtle.Move(a);
                Turtle.TurnRight();
                Turtle.Move(a);

                Turtle.TurnLeft();
                Turtle.Move(a);
                Turtle.TurnLeft();
                Turtle.Move(a);
            }
        }
    }
}