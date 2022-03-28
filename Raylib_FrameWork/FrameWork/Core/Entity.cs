using System;
using System.Collections.Generic;
using System.Numerics;

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

            transform.Position = new Vector2(0.0f, 0.0f);
            transform.Rotation = 0.0f;
            transform.Scale = new Vector2(1.0f, 1.0f);
        }
        public virtual void Update(float deltaTime)
        {
            // base function.
        }
        public void UpdateComponents(float deltaTime)
        {
            foreach (var component in Components)
            {
                component.Value.UpdateComponent(deltaTime);
            }
        }
        public void AddComponent(ComponentType type, Component component)
        {
            if (!components.ContainsKey(ComponentType.SPRITE))
            {
                components.Add(type, component);
            }
        }
    }
}
