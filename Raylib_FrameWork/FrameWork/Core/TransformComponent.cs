using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Raylib_FrameWork
{
    public class TransformComponent : Component
    {
        private Vector2 position;
        private float rotation;
        private Vector2 scale;

        // Getters for position, rotation, scale
        public Vector2 Position { get { return position; } set { position = value; } }
        public float Rotation { get { return rotation; } set { rotation = value; } }
        public Vector2 Scale { get { return scale; } set { scale = value; } }
        public TransformComponent(Entity o) : base(o)
        {

        }
    }
}
