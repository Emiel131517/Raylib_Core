using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class MusicComponent : Component
    {
        private ResourceManager rsm = ResourceManager.Instance;
        private Music music;
        private string fileName;
        private float musicVolume;
        public float musicPitch;
        public string FileName { get { return fileName; } set { fileName = value; } }
        public float MusicVolume { get { return musicVolume; } set { musicVolume = value; } }
        public float MusicPitch { get { return musicPitch; } set { musicPitch = value; } }
        public MusicComponent(Entity o, string name) : base(o)
        {
            Type = ComponentType.MUSIC;
            fileName = name;
            musicVolume = 1f;
            musicPitch = 1f;

            music = rsm.GetMusic(fileName);
            PlayMusic();
        }
        public MusicComponent(Entity o, string name, float volume) : base(o)
        {
            Type = ComponentType.MUSIC;
            fileName = name;
            musicVolume = volume;
            musicPitch = 1f;

            music = rsm.GetMusic(fileName);
            PlayMusic();
        }
        public MusicComponent(Entity o, string name, float volume, float pitch) : base(o)
        {
            Type = ComponentType.MUSIC;
            fileName = name;
            musicVolume = volume;
            musicPitch = pitch;

            music = rsm.GetMusic(fileName);
            PlayMusic();
            
        }
        public override void UpdateComponent(float deltaTime)
        {
            Raylib.UpdateMusicStream(music);
        }
        private void PlayMusic()
        {
            Raylib.SetMusicVolume(music, musicVolume);
            Raylib.SetMusicPitch(music, musicPitch);
            Raylib.PlayMusicStream(music);
        }
    }
}
