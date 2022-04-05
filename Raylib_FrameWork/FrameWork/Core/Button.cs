using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class Button : Entity
    {
        private enum buttonState { NORMAL, HOVER, PRESSED };
        private float buttonWidth;
        private float buttonHeight;
        private bool buttonAction;
        private Rectangle buttonBounds;
        public float Width { get { return buttonWidth; } set { buttonWidth = value; } }
        public float Height { get { return buttonHeight; } set { buttonHeight = value; } }
        // Basic button constructor
        public Button(string textureName, string soundName)
        {
            // Add components
            SpriteComponent sprite = new SpriteComponent(this, textureName, Color.WHITE);
            SoundComponent sound = new SoundComponent(this);
            ButtonComponent button = new ButtonComponent(this, soundName, buttonWidth, buttonHeight);
            AddComponent(ComponentType.SPRITE, sprite);
            AddComponent(ComponentType.SOUND, sound);
            AddComponent(ComponentType.BUTTON, button);

            // Assign width and height of the texture to the width and height of the button
            buttonWidth = sprite.Width;
            buttonHeight = sprite.Height;

            buttonState = 0;
        }
        // Button constructor with custom width and height
        public Button(string textureName, string soundName, float width, float height)
        {
            // Add components
            SpriteComponent sprite = new SpriteComponent(this, textureName, Color.WHITE);
            SoundComponent sound = new SoundComponent(this);
            ButtonComponent button = new ButtonComponent(this, soundName, buttonWidth, buttonHeight);
            AddComponent(ComponentType.SOUND, sound);
            AddComponent(ComponentType.SPRITE, sprite);
            AddComponent(ComponentType.BUTTON, button);

            // Assign width and height of the button to the widht and height of the texture
            buttonWidth = width;
            buttonHeight = height;

            sprite.Height = buttonHeight;
            sprite.Width = buttonWidth;
        }
        public override void Update(float deltaTime)
        {
            CheckButton();
        }
        private void CheckButton()
        {
            buttonBounds = new Rectangle(Transform.Position.X, Transform.Position.Y, buttonWidth, buttonHeight);
            buttonAction = false;
            Vector2 mousePos = Raylib.GetMousePosition();

            // Check if the mouse is hovering over the button
            if (Raylib.CheckCollisionPointRec(mousePos, buttonBounds))
            {
                buttonState = 1;
            }
            else
            {
                buttonState = 0;
            }
        }
    }
}
