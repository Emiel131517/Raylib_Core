namespace Raylib_FrameWork
{
	class Program
	{
		static void Main()
		{
			Scene scene = new Scene();

			Game game = new Game(scene);
			game.Play();
		}
	}
}
