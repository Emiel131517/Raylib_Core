using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class Button : Entity
    {
        private float buttonWidth;
        private float buttonHeight;
        public float Width { get { return buttonWidth; } set { buttonWidth = value; } }
        public float Height { get { return buttonHeight; } set { buttonHeight = value; } }
        public Button(string textureName, float width, float height)
        {
            SpriteComponent sprite = new SpriteComponent(this, textureName, Color.WHITE);
            AddComponent(ComponentType.SPRITE, sprite);

            buttonWidth = width;
            buttonHeight = height;
            /*SoundComponent sound = new SoundComponent(this);
            AddComponent(ComponentType.SOUND, sound);

            ButtonComponent button = new ButtonComponent(this, soundName, buttonWidth, buttonHeight);
            AddComponent(ComponentType.BUTTON, button);*/
        }
        public override void Update(float deltaTime)
        {
            
        }
    }
}
