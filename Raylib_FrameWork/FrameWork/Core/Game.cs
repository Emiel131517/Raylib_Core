using Raylib_cs;

namespace Raylib_FrameWork
{
    public class Game
    {
        Core core;
        Scene scene;
        public Game()
        {
            core = new Core(1280, 720, "Hello World");
            scene = new Scene();
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
