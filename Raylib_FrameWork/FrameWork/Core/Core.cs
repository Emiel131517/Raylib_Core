using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class Core
    {
        private int height;
        private int width;
        private string windowName;
        public Core(int w, int h, string n)
        {
            width = w;
            height = h;
            windowName = n;

            Init();
        }
        private void Init()
        {
            Raylib.InitWindow(width, height, windowName);
        }
        public bool Run(Scene scene)
        {
            if (scene == null)
            {
                Console.WriteLine("Scene is null");
                return false;
            }
            if (Raylib.WindowShouldClose())
            {
                Raylib.CloseWindow();
                return false;
            }

            Raylib.BeginDrawing();

            scene.Update();

            Raylib.EndDrawing();

            return true;
        }

    }
}
