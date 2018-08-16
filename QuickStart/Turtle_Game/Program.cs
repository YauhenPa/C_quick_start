using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Turtle_Game
{
    class Program
    {
        static void Control()
        {
            if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            }
            else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
            else if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }
            else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            }
        }
        static void Main(string[] args)
        {
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(20, 20);
          
            Turtle.X = 300;
            Turtle.Y = 300;

           

            
            Turtle.PenUp();
            GraphicsWindow.KeyDown += Control;

            while (true)
            {
                int eatX = Turtle.X;
                int eatY = Turtle.Y;
                Turtle.Move(10);
                Shapes.Move(eat, eatX, eatY);
                Control();
            }

      
        }
    }
}
