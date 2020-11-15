using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace Snake
{
    public class Food : GameObject
    {
        public Food() : base()
        { }

        public override void Draw(double x, double y)
        {
            SplashKit.FillRectangle(Color.Yellow, FirstX, FirstY, 15, 15);
        }
    }
}
