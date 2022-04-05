using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class ButtonComponent : Component
    {
        public ButtonComponent(Entity o) : base(o)
        {
            Type = ComponentType.BUTTON;

        }
    }
}
