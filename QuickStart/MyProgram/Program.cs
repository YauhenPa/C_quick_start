using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining_Tort
{

    class Program
    {
        private static readonly Primitive kerning = 10;

       
        static void charO(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 90;
            Turtle.Move(size / 2);
            Turtle.Angle = 180;
            Turtle.Move(size);
            Turtle.Angle = 270;
            Turtle.Move(size / 2);
            Turtle.X = Turtle.X + size / 2 + kerning;
        }
        static void charT(int size)
        {
            Turtle.X = Turtle.X + size * 2 / 6;
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.X = Turtle.X - size/3;
            Turtle.Angle = 90;
            Turtle.Move(size*2/3);
            if (size > 60)
            {
                Turtle.X = Turtle.X - size / 4 + kerning;
            }
            else {
                Turtle.X = Turtle.X + kerning;

            }
            
            Turtle.Y = Turtle.Y + size;

        }
        static void charR(int size)
        {
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 90;
            Turtle.Move(size / 2);
            Turtle.Angle = 180;
            Turtle.Move(size / 2);
            Turtle.Angle = 270;
            Turtle.Move(size / 2);
            Turtle.X = Turtle.X + size / 2 + kerning;
            Turtle.Y = Turtle.Y + size / 2;
        }
        static void Coord(int x, int y)
        {
            Turtle.X = x;
            Turtle.Y = y;
        }
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            Coord(80, 200);
            charT(90);
            charO(60);
            charR(60);
            charT(60);

            Turtle.X = Turtle.X + 30;
            charT(60);
            charO(60);
            charR(60);
            charT(60);

        }
    }
}