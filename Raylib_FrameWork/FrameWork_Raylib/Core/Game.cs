// no usings

namespace Raylib_FrameWork
{
    public class Game
    {
        Core core;
        Scene scene;
        public Game(Scene scene)
        {
            core = new Core(1280, 720, "Hello World");
            this.scene = scene;
        }
        public void Play()
        {
            while (core.Run(scene))
            {
                ; 
            }
        }
    }
}
