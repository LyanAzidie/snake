using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace Snake
{
    public class GameObject
    {
        private List<Point2D> _positions = new List<Point2D>();

        public GameObject()
        {
            _positions.Add(SplashKit.PointAt(SplashKit.Rnd(800), SplashKit.Rnd(600)));
        }

        public List<Point2D> Positions
        {
            get => _positions;
        }

        public double FirstX
        {
            get => _positions[0].X;
        }

        public double FirstY
        {
            get => _positions[0].Y;
        }

        // draw objects
        public virtual void Draw(double x, double y)
        { }
    }
}
