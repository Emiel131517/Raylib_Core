using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class ButtonComponent : Component
    {
        private int buttonState; // 0 = normal, 1 = hover, 2 = clicked
        private bool buttonAction;
        private float buttonWidth;
        private float buttonHeight;
        private string buttonSound;

        private Rectangle buttonBounds;
        public ButtonComponent(Entity o, string soundName, float width, float height) : base(o)
        {
            Type = ComponentType.BUTTON;

            buttonState = 0;
            buttonAction = false;
            buttonWidth = width;
            buttonHeight = height;
            buttonSound = soundName;

            buttonBounds = new Rectangle(Owner.Transform.Position.X, Owner.Transform.Position.Y, buttonWidth, buttonHeight);
        }
        public override void UpdateComponent(float deltaTime)
        {
            Console.WriteLine(buttonState);
            buttonAction = false;
            Vector2 mousePos = Raylib.GetMousePosition();
            if (Raylib.CheckCollisionPointRec(mousePos, buttonBounds))
            {
                if (Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON))
                {
                    buttonState = 2;
                    if (Raylib.IsMouseButtonReleased(MouseButton.MOUSE_LEFT_BUTTON))
                    {
                        buttonAction = true;
                        Owner.Sound.PlaySound(buttonSound);
                    }
                }
                else
                {
                    buttonState = 1;
                }
            }
        }
    }
}
