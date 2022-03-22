using System;
using System.Collections.Generic;
using System.Text;

namespace Raylib_FrameWork
{
    public enum ComponentType { NONE, TRANSFORM, SPRITE, AUDIO };
    public class Component
    {
        //fields
        private ComponentType type;
        private Entity owner;
        
        // Getters and setters
        public ComponentType Type { get { return type; } set { type = value; } }
        public Entity Owner { get { return owner; } }
        public Component(Entity o)
        {
            type = ComponentType.NONE;
            owner = o;
        }
        public virtual void UpdateComponent(float deltaTime)
        {

        }
    }
}
