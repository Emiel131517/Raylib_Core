using System;
using System.Collections.Generic;
using System.Text;

namespace Raylib_FrameWork
{
    public class Entity
    {
        // get components
        private Dictionary<string, Component> components;
        public Dictionary<string, Component> Components { get { return components; } }

        // get individual components
        public TransformComponent Transform { get { return (TransformComponent)components["Transform"]; } }
        public SpriteComponent Sprite { get { return (SpriteComponent)components["Sprite"]; } }
        public AudioComponent Audio { get { return (AudioComponent)components["Audio"]; } }

        public Entity()
        {
            components = new Dictionary<string, Component>();

            TransformComponent transform = new TransformComponent(this);
            AddComponent("Transform", transform);
        }
        public virtual void Update(float deltaTime)
        {
            // base function.
        }
        public void AddComponent(string Name, Component component)
        {
            components.Add(Name, component);
        }
    }
}
