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
            var Rx = 30;
            var Ry = 30;
            var eat = Shapes.AddEllipse(Rx, Ry);
          
            Turtle.X = 100;
            Turtle.Y = 100;
            int eatX = 200;
            int eatY = 200;
            
            Turtle.PenUp();
            GraphicsWindow.KeyDown += Control;

            while (true)
            {
                Turtle.Move(5);
                int deltaX = eatX - Turtle.X + Rx/2;
                int deltaY = eatY - Turtle.Y + Ry/2;
                if (-Rx/2 < deltaX && deltaX < Rx/2 && Ry/4 < deltaY && deltaY < Ry/2)
                {
                    eatY = eatY + 5;   
                }
                if (Rx/4 < deltaX && deltaX < Rx/2 && -Ry/2 < deltaY && deltaY < Ry/2)
                {
                    eatX = eatX + 5;   
                }
                if (-Rx/2 < deltaX && deltaX < Rx/2 && -Ry/2 < deltaY && deltaY < -Ry/4)
                {
                    eatY = eatY - 5;    
                }
                if (-Rx/2< deltaX && deltaX < -Rx/4 && -Ry/2< deltaY && deltaY < Ry/2)
                {
                    eatX = eatX - 5;  
                }
                Control();
                Shapes.Move(eat, eatX, eatY);
            }
        }
    }
}
