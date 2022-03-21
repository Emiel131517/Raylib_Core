using System;
using System.Collections.Generic;
using System.Text;

namespace Raylib_FrameWork
{
    public class Component
    {
        private Entity owner;
        public Entity Owner { get { return owner; } }
        public Component(Entity o)
        {
            owner = o;
        }
        public virtual void UpdateComponent(float deltaTime)
        {

        }
    }
}
