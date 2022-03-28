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
            SpriteComponent test = new SpriteComponent(this, "test.png", Color.WHITE, 0.5f, 0.5f);
            AddComponent(ComponentType.SPRITE, test);

            test.Owner.Transform.Position = new System.Numerics.Vector2(500, 500);
        }
        public override void Update(float deltaTime)
        { 
            Raylib.ClearBackground(Color.WHITE);
            Raylib.DrawText("Hello World", 0, 0, 25, Color.BLACK);
        }
    }
}
