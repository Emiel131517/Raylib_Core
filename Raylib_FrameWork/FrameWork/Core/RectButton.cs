using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class RectButton : Button
    {
        private string buttonSound;
        private float buttonWidth;
        private float buttonHeight;
        private bool buttonAction;
        private Rectangle buttonBounds;
        SpriteComponent sprite;
        SoundComponent sound;

        public bool ButtonAction { get { return buttonAction; } }
        public float ButtonWidth { get { return buttonWidth; } }
        public bool ButtonHeight { get { return ButtonHeight; } }
        // Basic button constructor
        public RectButton(string textureName, string soundName)
        {
            // Add components
            sprite = new SpriteComponent(this, textureName, Color.WHITE);
            sound = new SoundComponent(this);
            AddComponent(ComponentType.SPRITE, sprite);
            AddComponent(ComponentType.SOUND, sound);

            buttonSound = soundName;

            State = ButtonState.IDLE;
        }
        public override void Update(float deltaTime)
        {
            CheckButton();
        }
        private void CheckButton()
        {
            buttonAction = false;
            Vector2 mousePos = Raylib.GetMousePosition();

            // Assign width and height of the texture to the width and height of the button
            if (buttonWidth == 0)
            {
                buttonWidth = sprite.Width * Transform.Scale.X;
                buttonHeight = sprite.Height * Transform.Scale.Y;
                buttonBounds = new Rectangle(Transform.Position.X - buttonWidth / 2, Transform.Position.Y - (buttonHeight * Transform.Scale.Y) / 2, buttonWidth, buttonHeight);
            }

            // Check if the mouse is hovering over the button
            if (Raylib.CheckCollisionPointRec(mousePos, buttonBounds))
            {
                State = ButtonState.HOVER;
                if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    State = ButtonState.PRESSED;
                }
                else
                {
                    State = ButtonState.HOVER;
                }
                if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    buttonAction = true;
                    sound.PlaySoundMulti(buttonSound);
                    // button clicked - do something.
                }
            }
            else
            {
                State = ButtonState.IDLE;
            }
        }
    }
}
