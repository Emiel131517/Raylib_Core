namespace Raylib_FrameWork
{
	class Program
	{
		static void Main()
		{
			TestScene scene = new TestScene();

			Game game = new Game(scene);
			game.Play();
		}
	}
}
