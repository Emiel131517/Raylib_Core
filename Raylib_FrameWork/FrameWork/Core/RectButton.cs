using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class RectButton : Button
    {
        private float buttonWidth;
        private float buttonHeight;
        private bool buttonAction;
        private Rectangle buttonBounds;
        // Basic button constructor
        public RectButton(string textureName, string soundName)
        {
            // Add components
            SpriteComponent sprite = new SpriteComponent(this, textureName, Color.WHITE);
            SoundComponent sound = new SoundComponent(this);
            AddComponent(ComponentType.SPRITE, sprite);
            AddComponent(ComponentType.SOUND, sound);

            State = ButtonState.NORMAL;
        }
        public override void Update(float deltaTime)
        {
            CheckButton();
        }
        private void CheckButton()
        {
            Console.WriteLine(State);
            buttonAction = false;
            Vector2 mousePos = Raylib.GetMousePosition();

            // Assign width and height of the texture to the width and height of the button
            if (buttonWidth == 0)
            {
                buttonWidth = Sprite.Width;
                buttonHeight = Sprite.Height;
                buttonBounds = new Rectangle(Transform.Position.X - buttonWidth / 2, Transform.Position.Y - (buttonHeight * Transform.Scale.Y) / 2, buttonWidth, buttonHeight);
            }

            // Check if the mouse is hovering over the button
            if (Raylib.CheckCollisionPointRec(mousePos, buttonBounds))
            {
                State = ButtonState.HOVER;
            }
            else
            {
                State = ButtonState.NORMAL;
            }
        }
    }
}
