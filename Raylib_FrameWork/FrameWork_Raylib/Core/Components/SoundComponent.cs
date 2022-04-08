using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace Raylib_FrameWork
{
    public class SoundComponent : Component
    {
        private ResourceManager rsm = ResourceManager.Instance;
        private float soundVolume;
        private float soundPitch;
        public float SoundVolume { get { return soundVolume; } set { soundVolume = value; } }
        public float SoundPitch { get { return soundPitch; } set { soundPitch = value; } }  
        public SoundComponent(Entity o) : base(o)
        {
            Type = ComponentType.SOUND;
        }
        public void PlaySound(string fileName)
        {
            Sound s = rsm.GetSound(fileName);
            soundVolume = 1f;
            soundPitch = 1f;

            Raylib.SetSoundPitch(s, soundPitch);
            Raylib.SetSoundVolume(s, soundVolume);
            Raylib.PlaySound(s);
        }
        public void PlaySoundWVolume(string fileName, float volume)
        {
            Sound s = rsm.GetSound(fileName);
            SoundVolume = volume;
            soundPitch = 1f;

            Raylib.SetSoundPitch(s, soundPitch);
            Raylib.SetSoundVolume(s, soundVolume);
            Raylib.PlaySound(s);
        }
        public void PlaySoundWPitch(string fileName, float volume, float pitch)
        {
            Sound s = rsm.GetSound(fileName);
            SoundVolume = volume;
            soundPitch = pitch;

            Raylib.SetSoundPitch(s, soundPitch);
            Raylib.SetSoundVolume(s, soundVolume);
            Raylib.PlaySound(s);
        }
        public void PlaySoundMulti(string fileName)
        {
            Sound s = rsm.GetSound(fileName);
            soundVolume = 1f;
            soundPitch = 1f;

            Raylib.SetSoundPitch(s, soundPitch);
            Raylib.SetSoundVolume(s, soundVolume);
            Raylib.PlaySoundMulti(s);
        }
        public void PlaySoundMultiWVolume(string fileName, float volume)
        {
            Sound s = rsm.GetSound(fileName);
            soundVolume = volume;
            soundPitch = 1f;

            Raylib.SetSoundPitch(s, soundPitch);
            Raylib.SetSoundVolume(s, soundVolume);
            Raylib.PlaySoundMulti(s);
        }
        public void PlaySoundMultiWPitch(string fileName, float volume, float pitch)
        {
            Sound s = rsm.GetSound(fileName);
            soundVolume = volume;
            soundPitch = pitch;

            Raylib.SetSoundPitch(s, soundPitch);
            Raylib.SetSoundVolume(s, soundVolume);
            Raylib.PlaySoundMulti(s);
        }
    }
}
