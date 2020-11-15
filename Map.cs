using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Map
    {
        private List<GameObject> _objects = new List<GameObject>();

        public void Collide(GameObject snk, GameObject food, double x, double y)
        {
            _objects.Remove(food);
            (snk as Snake).AddLength(x, y); 
        }

        public bool HasCollided(Snake snk, Food food)
        {
            return (Math.Abs(snk.FirstX - food.FirstX) <= 15.0) && (Math.Abs(snk.FirstY - food.FirstY) <= 15.0);
        }
        
        public void Add(GameObject obj)
        {
            _objects.Add(obj);
        }

        public void Remove(GameObject obj)
        {
            _objects.Remove(obj);
        }

        public void Draw(double x, double y)
        {
            foreach (GameObject obj in _objects)
            {
                obj.Draw(x, y);
            }
        }

        public bool Lose(GameObject snk)
        {
            return (snk as Snake).SnakeOutOfMap();
        }
    }
}
