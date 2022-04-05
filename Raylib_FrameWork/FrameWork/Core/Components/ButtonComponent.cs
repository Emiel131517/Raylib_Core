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

            // Setting the boundries of the button

        }
    }
}
