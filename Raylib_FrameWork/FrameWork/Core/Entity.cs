using System;
using System.Collections.Generic;
using System.Text;

namespace Raylib_FrameWork
{
    public class Entity
    {
        // get components
        private Dictionary<ComponentType, Component> components;
        public Dictionary<ComponentType, Component> Components { get { return components; } }

        // get individual components
        public TransformComponent Transform { get { return (TransformComponent)components[ComponentType.TRANSFORM]; } }
        public SpriteComponent Sprite { get { return (SpriteComponent)components[ComponentType.SPRITE]; } }
        public AudioComponent Audio { get { return (AudioComponent)components[ComponentType.AUDIO]; } }

        public Entity()
        {
            components = new Dictionary<ComponentType, Component>();

            TransformComponent transform = new TransformComponent(this);
            AddComponent(ComponentType.TRANSFORM, transform);
        }
        public virtual void Update(float deltaTime)
        {
            // base function.
        }
        public void AddComponent(ComponentType type, Component component)
        {
            components.Add(type, component);
        }
    }
}
