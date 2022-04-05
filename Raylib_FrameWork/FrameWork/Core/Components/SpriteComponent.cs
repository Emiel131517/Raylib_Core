using System;
using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class SpriteComponent : Component
    {
        private string textureName;
        private Color textureColor;
        private Vector2 texturePivot;
        private int width;
        private int height;

        public string TextureName { get { return textureName; } }
        public Color TextureColor { get { return textureColor;} }
        public Vector2 TexturePivot { get { return texturePivot;} }
        public int Width { get { return width; } set { width = value; } }
        public int Height { get { return height; } set { height = value; } }
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

            float rotation = Owner.Transform.Rotation;
            width = texture.width;
            height = texture.height;

            Rectangle sourceRec = new Rectangle(0, 0, width, height);
            Rectangle destRec = new Rectangle(Owner.Transform.Position.X, Owner.Transform.Position.Y, width * Owner.Transform.Scale.X, height * Owner.Transform.Scale.Y);
            Vector2 pivot = new Vector2(width * texturePivot.X * Owner.Transform.Scale.X, height * texturePivot.Y * Owner.Transform.Scale.Y);

            Raylib.DrawTexturePro(texture, sourceRec, destRec, pivot, rotation, textureColor);
        }
    }
}
