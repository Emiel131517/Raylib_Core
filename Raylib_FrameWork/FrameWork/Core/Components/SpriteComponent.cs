using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class SpriteComponent : Component
    {
        private string textureName;
        private Color textureColor;
        private Vector2 texturePivot;
        private float width;
        private float height;

        public string TextureName { get { return textureName; } }
        public Color TextureColor { get { return textureColor;} }
        public Vector2 TexturePivot { get { return texturePivot;} }
        public float Width { get { return width; } set { width = value; } }
        public float Height { get { return height; } set { height = value; } }
        public SpriteComponent(Entity o, string fileName, Color color) : base(o)
        {
            Type = ComponentType.SPRITE;
            textureName = fileName;
            textureColor = color;
            
            texturePivot = new Vector2(0.5f, 0.5f);
        }
        public SpriteComponent(Entity o, string fileName, Color color, float pivotx, float pivoty) : base(o)
        {
            Type = ComponentType.SPRITE;
            textureName = fileName;
            textureColor = color;
            texturePivot = new Vector2(pivotx, pivoty);
        }
        public override void UpdateComponent(float deltaTime)
        {
            Draw();
        }
        private void Draw()
        {
            ResourceManager rsm = ResourceManager.Instance;
            Texture2D texture = rsm.GetTexture(textureName);

            height = texture.height;
            width = texture.width;
            float rotation = Owner.Transform.Rotation;

            Rectangle sourceRec = new Rectangle(0.0f, 0.0f, height, width);
            Rectangle destRec = new Rectangle(Owner.Transform.Position.X, Owner.Transform.Position.Y, width * Owner.Transform.Scale.X, height * Owner.Transform.Scale.Y);
            Vector2 pivot = new Vector2(width * texturePivot.X * Owner.Transform.Scale.X, height * texturePivot.Y * Owner.Transform.Scale.Y);

            Raylib.DrawTexturePro(texture, sourceRec, destRec, pivot, rotation, textureColor);
        }
    }
}
