using System;
using System.Collections.Generic;
using System.Text;

namespace Raylib_FrameWork
{
    public class AudioComponent : Component
    {
        public AudioComponent(Entity o) : base(o)
        {
            Type = ComponentType.AUDIO;
        }
    }
}
