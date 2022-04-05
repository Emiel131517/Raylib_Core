using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class CircButton : Button
    {
        SpriteComponent sprite;
        private float buttonWidth;
        private float buttonHeight;
        private bool buttonAction;
        private Rectangle buttonBounds;
        // Basic button constructor
        public CircButton(string textureName, string soundName)
        {
            // Add components
            sprite = new SpriteComponent(this, textureName, Color.WHITE);
            SoundComponent sound = new SoundComponent(this);
            AddComponent(ComponentType.SPRITE, sprite);
            AddComponent(ComponentType.SOUND, sound);

            // Assign width and height of the texture to the width and height of the button
            buttonWidth = sprite.Width;
            buttonHeight = sprite.Height;
            buttonBounds = new Rectangle(Transform.Position.X, Transform.Position.Y, buttonWidth, buttonHeight);

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

            if (buttonWidth == 0)
            {
                buttonWidth = sprite.Width;
                buttonHeight = sprite.Height;
                buttonBounds = new Rectangle(Transform.Position.X, Transform.Position.Y, buttonWidth, buttonHeight);
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
