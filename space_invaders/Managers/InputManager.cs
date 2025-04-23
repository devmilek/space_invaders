using Raylib_cs;
using space_invaders.GameObjects;

namespace space_invaders.Managers;

public class InputManager
{
    public static void HandleInput(Player player, List<Bullet> bullets)
    {
        if (Raylib.IsKeyDown(KeyboardKey.Left))
        {
            player.MoveLeft();
        }
        
        if (Raylib.IsKeyDown(KeyboardKey.Right))
        {
            player.MoveRight();
        }
        
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            bullets.Add(player.Shoot());
        }
    }
}