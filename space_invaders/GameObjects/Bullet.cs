using Raylib_cs;
using space_invaders.Utils;

namespace space_invaders.GameObjects;

public class Bullet : GameObject
{
    public bool IsPlayerBullet { get; }

    public Bullet(Vector2D position, bool isPlayerBullet) : base(position, Constants.BULLET_SIZE, Color.White)
    {
        IsPlayerBullet = isPlayerBullet;
    }

    public override void Update()
    {
        Move(new Vector2D(0, IsPlayerBullet ? -Constants.BULLET_SPEED : Constants.BULLET_SPEED));

        if (Position.Y < 0 || Position.Y > 600)
        {
            IsActive = false;
        }
    }
}