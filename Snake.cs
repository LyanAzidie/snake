using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace Snake
{
    public class Snake : GameObject
    {
        public Snake() : base()
        { }

        // draw
        public override void Draw(double x, double y)
        {
            for (int i = 0; i < Positions.Count; i++)
            {
                SplashKit.FillRectangle(Color.White, Positions[i].X, Positions[i].Y, 15.0, 15.0);
            }
        }

        // update
        public void Update(double x, double y)
        {
            for (int i = Positions.Count - 1; i > 0; i--)
            {
                Positions[i] = Positions[i - 1];
            }
            Positions[0] = SplashKit.PointAt(Positions[0].X + x, Positions[0].Y + y);
        }
        
        public void AddLength(double x, double y)
        { 
            Positions.Add(SplashKit.PointAt(FirstX - x * (Positions.Count + 1), FirstY - y * (Positions.Count + 1)));
        }

        public bool SnakeOutOfMap()
        {
            return FirstX > 800 || FirstX < 0 || FirstY > 600 || FirstY < 0;
        }
    }
}
