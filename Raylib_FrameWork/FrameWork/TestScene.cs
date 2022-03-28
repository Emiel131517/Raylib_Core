using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class TestScene : Scene
    {
        Entity cat1ent;
        Entity cat2ent;
        public TestScene()
        {
            cat1ent = new Entity();
            cat2ent = new Entity();
            Entities.Add(cat1ent);
            Entities.Add(cat2ent);

            SpriteComponent cat1 = new SpriteComponent(cat1ent, "Assets/Kat.png", Color.WHITE);
            SpriteComponent cat2 = new SpriteComponent(cat2ent, "Assets/Kat2.png", Color.WHITE, 0, 0);

            cat1ent.AddComponent(ComponentType.SPRITE, cat1);
            cat2ent.AddComponent(ComponentType.SPRITE, cat2);

            cat1ent.Transform.Position = new Vector2(200, 200);
            cat2ent.Transform.Position = new Vector2(750, 400);
        }
        public override void Update(float deltaTime)
        {
            cat1ent.Transform.Rotation += 50 * deltaTime;
            cat2ent.Transform.Rotation += 50 * deltaTime;
        }
    }
}
