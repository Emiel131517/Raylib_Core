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
        RectButton rectButton;
        CircButton circButton;
        public TestScene()
        {
            // Entity1
            cat1ent = new Entity();
            Entities.Add(cat1ent);

            SpriteComponent cat1 = new SpriteComponent(cat1ent, "Assets/kat.png", Color.WHITE);
            PhysicsComponent physics = new PhysicsComponent(cat1ent);
            cat1ent.AddComponent(ComponentType.SPRITE, cat1);
            cat1ent.AddComponent(ComponentType.PHYSICS, physics);

            cat1ent.Transform.Position = new Vector2(1150, 200);
            cat1ent.Physics.Mass = 3;
            cat1ent.Physics.Gravity = new Vector2(0, 12.5f);


            // Buttons
            rectButton = new RectButton("Assets/ButtonRect.png", "Assets/retro.wav");
            circButton = new CircButton("Assets/circbutton.png", "Assets/retro.wav");
            Entities.Add(rectButton);
            Entities.Add(circButton);

            rectButton.Transform.Position = new Vector2(150f, 100f);
            circButton.Transform.Position = new Vector2(350f, 100f);

            // Entity2
            cat2ent = new Entity();
            Entities.Add(cat2ent);

            SpriteComponent cat2 = new SpriteComponent(cat2ent, "Assets/Kat2.png", Color.WHITE, 0, 0);
            cat2ent.AddComponent(ComponentType.SPRITE, cat2);

            cat2ent.Transform.Position = new Vector2(750, 400);
        }
        public override void Update(float deltaTime)
        {
            cat2ent.Transform.Rotation += 50 * deltaTime;

            if (cat1ent.Transform.Position.Y > 720)
            {
                cat1ent.Transform.Position.Y = 0;
            }
        }
    }
}
