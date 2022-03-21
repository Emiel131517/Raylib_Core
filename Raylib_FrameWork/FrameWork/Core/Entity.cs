using System;
using System.Collections.Generic;
using System.Text;

namespace Raylib_FrameWork
{
    public class Entity
    {
        private Dictionary<string, Component> components;

        public Entity()
        {

        }
        public virtual void Update(float deltaTime)
        {
            //virtual, so must be override or base function will be called
        }
        public void AddComponent(string Name, Component component)
        {
            components.Add(Name, component);
        }
    }
}
