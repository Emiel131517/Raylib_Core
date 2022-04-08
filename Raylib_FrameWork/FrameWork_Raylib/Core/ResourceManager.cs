using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public sealed class ResourceManager
    {
        private static Dictionary<string, Texture2D> textures;
        private static Dictionary<string, Music> musicSongs;
        private static Dictionary<string, Sound> sounds;
        private static readonly ResourceManager instance;
        public static ResourceManager Instance { get { return instance; } } 
        static ResourceManager()
        {
            textures = new Dictionary<string, Texture2D>();
            musicSongs = new Dictionary<string, Music>();
            sounds = new Dictionary<string, Sound>();
            instance = new ResourceManager();
        }
        private ResourceManager()
        {
            
        }
        public Music GetMusic(string fileName)
        {
            if (musicSongs.ContainsKey(fileName))
            {
                return musicSongs[fileName];
            }
            Music music = Raylib.LoadMusicStream(fileName);
            musicSongs.Add(fileName, music);
            return music;
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
        public Sound GetSound(string fileName)
        {
            if (sounds.ContainsKey(fileName))
            {
                return sounds[fileName];
            }
            Sound sound = Raylib.LoadSound(fileName);
            sounds.Add(fileName, sound);
            return sound;
        }
        public void CleanUp()
        {
            foreach(var fileName in textures)
            {
                Raylib.UnloadTexture(fileName.Value);
            }
            foreach (var fileName in musicSongs)
            {
                Raylib.UnloadMusicStream(fileName.Value);
            }
            foreach (var fileName in sounds)
            {
                Raylib.UnloadSound(fileName.Value);
            }
        }
    }
}
