using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class SpriteComponent : Component
    {
        private string textureName;
        private Vector2 pivotPoint;

        public string TextureName { get { return textureName; } }
        public Vector2 PivotPoint { get { return pivotPoint; } }
        public SpriteComponent(Entity o, string name) : base(o)
        {
            Type = ComponentType.SPRITE;
            textureName = name;
            pivotPoint = new Vector2(0.5f, 0.5f);
        }
        public SpriteComponent(Entity o, string name, Vector2 pivot) : base(o)
        {
            Type = ComponentType.SPRITE;
            textureName = name;
            pivotPoint = pivot;
        }
        public override void UpdateComponent(float deltaTime)
        {
            Draw();
        }
        private void Draw()
        {
            
        }
    }
}
