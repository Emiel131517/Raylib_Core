Raylib
===

Raylib is a pretty advanced library for creating 2d and 3d scenes/games.
You can do alot with this library. 

for more information: https://www.raylib.com/

Raylib Core
===

Raylib Core is a c# framework made with and for Raylib!

This framework is a simple `component based` framework for making games with the use of Raylib.
There are not alot of fancy things in this framework just some basic components:
	
	Music component.
	Sound component.
	Physics component.
	Sprite component.
	Transform component.
	-------------------
	Circle button.
	Rectangle button.
	Entity.
	Resource manager.
	Scene.
	Game.


How to install
==

- download the project from github: https://github.com/Emiel131517/Raylib_Core/tree/Master
- link the dll to your projects dependencies in visual studio. The dll path: Raylib_Core\FrameWork\bin\Release\netcoreapp3.1

- To use it in your project just add the using for Raylib_FrameWork.


How to begin
==

- Make a new project.
- Create a main file (probably called program).
- Add the using for Raylib_FrameWork.
- Create a new scene (`Scene scene = new Scene()`).
- Create a game and give it your scene (`Game game = new Game(scene)`).
- or copy:

Program.cs:
-

	using Raylib_FrameWork;

	namespace test
	{
		public class Program
		{
			static void Main()
			{
				Scene scene = new Scene();
				Game game = new Game(scene);
			}
		}
	}