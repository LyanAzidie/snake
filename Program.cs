using System;
using SplashKitSDK;

namespace Snake
{
    public class Program
    {
        public static void Main()
        {
            new Window("Snake-Remake", 800, 600);
            double x = 0.0, y = 0.0;
            double speed = 5.0;

            Map snakeMap = new Map();
            Snake mySnake = new Snake();
            snakeMap.Add(mySnake);
            Food food = new Food();
            snakeMap.Add(food);

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.Black);
                mySnake.Update(x, y);
                snakeMap.Draw(x, y);

                if (SplashKit.KeyTyped(KeyCode.UpKey))
                {
                    x = 0;
                    y = -1*speed;
                }

                if (SplashKit.KeyTyped(KeyCode.DownKey))
                {
                    x = 0;
                    y = speed;
                }

                if (SplashKit.KeyTyped(KeyCode.RightKey))
                {
                    x = speed;
                    y = 0;
                }

                if (SplashKit.KeyTyped(KeyCode.LeftKey))
                {
                    x = -1*speed;
                    y = 0;
                }

                if (snakeMap.HasCollided(mySnake, food))
                {
                    snakeMap.Collide(mySnake, food, x*150, y*150);
                    food = new Food();
                    snakeMap.Add(food);
                }

                SplashKit.Delay(10);
                SplashKit.RefreshScreen();
            } while (!snakeMap.Lose(mySnake) || !SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}