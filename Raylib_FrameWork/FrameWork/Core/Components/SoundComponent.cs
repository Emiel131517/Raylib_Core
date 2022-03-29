using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class SoundComponent : Component
    {
        private ResourceManager rsm = ResourceManager.Instance;
        private Sound sound;
        private string fileName;
        private float soundVolume;
        private float soundPitch;
        private Dictionary<string, Sound> sounds;
        public string FileName { get { return fileName; } set { fileName = value; } }
        public float SoundVolume { get { return soundVolume; } set { soundVolume = value; } }
        public float SoundPitch { get { return soundPitch; } set { soundPitch = value; } }
        public Dictionary<string, Sound> Sounds { get { return sounds; } set { sounds = value; } }  
        public SoundComponent(Entity o) : base(o)
        {
            Type = ComponentType.SOUND;
        }
        public void AddSound(string name, string soundName)
        {
            fileName = soundName;
            sound = rsm.GetSound(fileName);
            sounds.Add(name, sound);
        }
        public void PlaySound(string fileName)
        {
            soundVolume = 1f;
            soundPitch = 1f;
            
            Raylib.SetSoundPitch(sound, soundPitch);
            Raylib.SetSoundVolume(sound, soundVolume);

            if (sounds.ContainsKey(fileName))
            {
                Raylib.PlaySound(sound);
            }
        }
        public void PlaySoundWVolume(string fileName, float volume)
        {
            SoundVolume = volume;
            soundPitch = 1f;

            Raylib.SetSoundPitch(sound, soundPitch);
            Raylib.SetSoundVolume(sound, soundVolume);

            if (sounds.ContainsKey(fileName))
            {
                Raylib.PlaySound(sound);
            }
        }
        public void PlaySoundWPitch(string fileName, float volume, float pitch)
        {
            SoundVolume = volume;
            soundPitch = pitch;

            Raylib.SetSoundPitch(sound, soundPitch);
            Raylib.SetSoundVolume(sound, soundVolume);

            if (sounds.ContainsKey(fileName))
            {
                Raylib.PlaySound(sound);
            }
        }
        public void PlaySoundMulti(string fileName)
        {
            soundVolume = 1f;
            soundPitch = 1f;
            
            Raylib.SetSoundPitch(sound, soundPitch);
            Raylib.SetSoundVolume(sound, soundVolume);

            if (sounds.ContainsKey(fileName))
            {
                Raylib.PlaySoundMulti(sound);
            }
        }
        public void PlaySoundMultiWVolume(string fileName, float volume)
        {
            soundVolume = volume;
            soundPitch = 1f;

            Raylib.SetSoundPitch(sound, soundPitch);
            Raylib.SetSoundVolume(sound, soundVolume);

            if (sounds.ContainsKey(fileName))
            {
                Raylib.PlaySoundMulti(sound);
            }
        }
        public void PlaySoundMultiWPitch(string fileName, float volume, float pitch)
        {
            soundVolume = volume;
            soundPitch = pitch;

            Raylib.SetSoundPitch(sound, soundPitch);
            Raylib.SetSoundVolume(sound, soundVolume);

            if (sounds.ContainsKey(fileName))
            {
                Raylib.PlaySoundMulti(sound);
            }
        }
    }
}
