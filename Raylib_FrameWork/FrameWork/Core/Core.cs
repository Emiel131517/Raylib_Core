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
        // initialize
        private void Init()
        {
            Raylib.InitWindow(width, height, windowName);
            Raylib.InitAudioDevice();
        }
        // Start running a scene
        public bool Run(Scene scene)
        {
            // Check if there is a scene
            if (scene == null)
            {
                Console.WriteLine("##ERROR## Scene is null");
                return false;
            }
            // Check if the game should close 
            if (Raylib.WindowShouldClose())
            {
                ResourceManager.Instance.CleanUp();
                Raylib.CloseAudioDevice();
                Raylib.CloseWindow();
                return false;
            }
            // Save deltaTime
            float deltaTime = Raylib.GetFrameTime();

            // Begin loading pixels
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            // Update all components
            for (int i = 0; i < scene.Entities.Count; i++)
            {
                scene.Entities[i].UpdateComponents(deltaTime);
            }

            // Update the scene
            scene.Update(deltaTime);

            Raylib.EndDrawing();

            return true;
        }

    }
}
