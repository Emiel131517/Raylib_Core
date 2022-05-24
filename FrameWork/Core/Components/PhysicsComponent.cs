using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class PhysicsComponent : Component
    {
        private Vector2 velocity;
        private Vector2 acceleration;
        private Vector2 gravity;
        private float mass;
        private bool useGravity;

        public Vector2 Velocity { get { return velocity; } set { velocity = value; } }
        public Vector2 Acceleration { get { return acceleration; } set { acceleration = value; } } 
        public Vector2 Gravity { get { return gravity; } set { gravity = value; } }
        public float Mass { get { return mass; } set { mass = value; } }
        private bool UseGravity { get { return useGravity; } set { useGravity = value; } }
        public PhysicsComponent(Entity o) : base(o)
        {
            Type = ComponentType.PHYSICS;
            velocity = new Vector2(0, 0);
            acceleration = new Vector2(0, 0);
            gravity = new Vector2(0, 0.8f);
            mass = 1;
            useGravity = true;
        }
        public override void UpdateComponent(float deltaTime)
        {
            if (useGravity)
            {
                ApplyGravity(deltaTime);
            }
            Motion101(deltaTime);
        }
        public void Motion101(float deltaTime)
        {
            velocity += acceleration * deltaTime;
            Owner.Transform.Position += velocity * deltaTime;
            
            // Reset acceleration
            acceleration *= 0;
        }
        public void AddForce(Vector2 force)
        {
            acceleration += force / mass;
        }
        private void ApplyGravity(float deltaTime)
        {
            velocity += (gravity * mass) * deltaTime;
        }
    }
}
