using Raylib_cs;

namespace Raylib_FrameWork
{
    public class Game
    {
        Core core;
        TestScene scene;
        public Game()
        {
            core = new Core(1280, 720, "Hello World");
            scene = new TestScene();
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
