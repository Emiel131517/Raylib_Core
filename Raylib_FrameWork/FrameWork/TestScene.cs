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
        RectButton button;
        public TestScene()
        {
            cat1ent = new Entity();
            cat2ent = new Entity();
            button = new RectButton("Assets/ButtonRect.png", "Assets/kindhuilen.wav");
            Entities.Add(cat1ent);
            Entities.Add(cat2ent);
            Entities.Add(button);

            button.Transform.Position.X = 600;
            button.Transform.Position.Y = 500;
            button.Transform.Scale = new Vector2(1.5f, 1f);

            SpriteComponent cat1 = new SpriteComponent(cat1ent, "Assets/kat.png", Color.WHITE);
            SpriteComponent cat2 = new SpriteComponent(cat2ent, "Assets/Kat2.png", Color.WHITE, 0, 0);

            SoundComponent snd1 = new SoundComponent(cat1ent);
            cat1ent.AddComponent(ComponentType.SOUND, snd1);

            cat1ent.AddComponent(ComponentType.SPRITE, cat1);
            cat2ent.AddComponent(ComponentType.SPRITE, cat2);

            cat1ent.Transform.Position = new Vector2(200, 200);
            cat2ent.Transform.Position = new Vector2(750, 400);
        }
        public override void Update(float deltaTime)
        {
            cat1ent.Transform.Rotation += 50 * deltaTime;
            cat2ent.Transform.Rotation += 50 * deltaTime;

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
            {
                cat1ent.Sound.PlaySoundWPitch("Assets/kindhuilen.wav", 1.5f, 0.25f);
            }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
            {
                cat1ent.Sound.PlaySoundMultiWPitch("Assets/Best_Song_Ever.wav", 1f, 0.5f);
            }
        }
    }
}
