using System;
using System.Collections.Generic;
using System.Text;

namespace Raylib_FrameWork
{
    public enum ButtonState { IDLE, HOVER, PRESSED };
    public class Button : Entity
    {
        private ButtonState state;
        public ButtonState State { get { return state; } set { state = value; } }
        public Button()
        {

        }
        public override void Update(float deltaTime)
        {
            base.Update(deltaTime);
        }
    }
}
