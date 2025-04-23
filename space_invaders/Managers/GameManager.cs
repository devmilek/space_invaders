using Raylib_cs;
using space_invaders.GameObjects;
using space_invaders.Utils;

namespace space_invaders.Managers;

public static class GameManager
{
    private static Player player;
    private static List<Bullet> bullets;
    private static GameState gameState = GameState.Playing;

    public static void Initialize()
    {
        player = new Player();
        bullets = new List<Bullet>();
    }

    public static void Update()
    {
        if (gameState == GameState.Playing)
        {
            InputManager.HandleInput(player, bullets);
            
            player.Update();

            foreach (var bulltet in bullets)
            {
                bulltet.Update();
            }
        }
    }

    public static void Draw()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.Black);
        
        player.Draw();
        foreach (var bullet in bullets)
        {
            bullet.Draw();
        }
        
        Raylib.EndDrawing();
    }
}