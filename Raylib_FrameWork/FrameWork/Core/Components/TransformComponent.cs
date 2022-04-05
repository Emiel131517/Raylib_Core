using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Raylib_FrameWork
{
    public class TransformComponent : Component
    {
        // Never do this!
        public Vector2 Position;
        private float rotation;
        public Vector2 Scale;

        // Getter and setter for rotation
        public float Rotation { get { return rotation; } set { rotation = value; } }
        public TransformComponent(Entity o) : base(o)
        {
            Type = ComponentType.TRANSFORM;
        }
    }
}
