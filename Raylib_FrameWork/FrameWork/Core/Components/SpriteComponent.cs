using System.Numerics;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class SpriteComponent : Component
    {
        private string textureName;
        private Color textureColor;
        private Vector2 texturePivot;

        public string TextureName { get { return textureName; } }
        public Color TextureColor { get { return textureColor;} }
        public Vector2 TexturePivot { get { return texturePivot;} }
        public SpriteComponent(Entity o, string name, Color color) : base(o)
        {
            Type = ComponentType.SPRITE;
            textureName = name;
            textureColor = color;
            texturePivot = new Vector2(0.5f, 0.5f);
        }
        public SpriteComponent(Entity o, string name, Color color, float pivotx, float pivoty) : base(o)
        {
            Type = ComponentType.SPRITE;
            textureName = name;
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

            float rot = Owner.Transform.Rotation;

            Rectangle sourceRec = new Rectangle(0.0f, 0.0f, texture.height, texture.width);
            Rectangle destRec = new Rectangle(Owner.Transform.Position.X, Owner.Transform.Position.Y, texture.width * Owner.Transform.Scale.X, texture.height * Owner.Transform.Scale.Y);
            Vector2 pivot = new Vector2(texture.width * texturePivot.X * Owner.Transform.Scale.X, texture.height * texturePivot.Y * Owner.Transform.Scale.Y);

            Raylib.DrawTexturePro(texture, sourceRec, destRec, pivot, rot, textureColor);
        }
    }
}
