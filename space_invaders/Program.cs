using Raylib_cs;
using space_invaders.Managers;
using space_invaders.Utils;

namespace space_invaders;

class Program
{
    static void Main(string[] args)
    {
        Raylib.InitWindow(Constants.WINDOW_WIDTH, Constants.WINDOW_HEIGHT, "Space Invaders");
        Raylib.SetTargetFPS(60);
        
        GameManager.Initialize();

        while (!Raylib.WindowShouldClose())
        {
            GameManager.Update();
            GameManager.Draw();
        }
        
        Raylib.CloseWindow();
    }
}