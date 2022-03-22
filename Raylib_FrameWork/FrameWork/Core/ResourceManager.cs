using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public sealed class ResourceManager
    {
        private Dictionary<string, Texture2D> textures;
        private static readonly ResourceManager instance = new ResourceManager();
        public static ResourceManager Instance { get { return instance; } } 
        static ResourceManager()
        {

        }
        public ResourceManager()
        {

        }
        public Texture2D GetTexture(string fileName)
        {
            if (textures.ContainsKey(fileName))
            {
                return textures[fileName];
            }
            Texture2D texture = Raylib.LoadTexture(fileName);
            textures.Add(fileName, texture);
            return texture;
        }
    }
}
