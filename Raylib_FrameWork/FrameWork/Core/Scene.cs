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
        public void Update()
        {
            Raylib.ClearBackground(Color.WHITE);

            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);
        }
    }
}
