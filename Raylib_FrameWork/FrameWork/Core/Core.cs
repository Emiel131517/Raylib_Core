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
            Raylib.InitAudioDevice();
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
                ResourceManager.Instance.CleanUp();
                Raylib.CloseAudioDevice();
                Raylib.CloseWindow();
                return false;
            }
            float deltaTime = Raylib.GetFrameTime();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            scene.UpdateComponents(deltaTime);
            for (int i = 0; i < scene.Entities.Count; i++)
            {
                scene.Entities[i].UpdateComponents(deltaTime);
            }

            scene.Update(deltaTime);

            Raylib.EndDrawing();

            return true;
        }

    }
}
