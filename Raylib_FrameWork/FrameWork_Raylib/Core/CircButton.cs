using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class CircButton : Button
    {
        private string buttonSound;
        private float buttonRadius;
        private bool buttonAction;
        // private Circle buttonBounds;
        SpriteComponent sprite;
        SoundComponent sound;

        public bool ButtonAction { get { return buttonAction; } }
        public float ButtonRadius { get { return buttonRadius;} set { buttonRadius = value; } }
        // Basic button constructor
        public CircButton(string textureName, string soundName)
        {
            // Add components
            sprite = new SpriteComponent(this, textureName, Color.WHITE);
            sound = new SoundComponent(this);
            AddComponent(ComponentType.SPRITE, sprite);
            AddComponent(ComponentType.SOUND, sound);

            buttonSound = soundName;

            State = ButtonState.NORMAL;
        }
        public override void Update(float deltaTime)
        {
            CheckButton();
        }
        private void CheckButton()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_T))
            {
                Console.WriteLine(State);
            }
            if (buttonAction == true)
            {
                Console.WriteLine("Button is pressed");
            }
            buttonAction = false;
            Vector2 mousePos = Raylib.GetMousePosition();

            // Assign width and height of the texture to the width and height of the button
            if (buttonRadius == 0)
            {
                buttonRadius = sprite.Width * Transform.Scale.X / 2;
            }
            // Check if the mouse is hovering over the button
            if (Raylib.CheckCollisionPointCircle(mousePos, Transform.Position, buttonRadius))
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
                State = ButtonState.NORMAL;
            }
        }
    }
}
