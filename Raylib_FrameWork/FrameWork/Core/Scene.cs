using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class Scene : Entity
    {
        public Scene()
        {

        }
        public override void Update(float deltaTime)
        {
            Raylib.ClearBackground(Color.WHITE);
            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);

            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                Console.WriteLine("Update!");
            }
        }
    }
}
