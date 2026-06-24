namespace Arcade_Game;

using System;
using System.Drawing;
using System.Windows.Forms;

internal abstract class Bullet : PictureBox
{
    protected double exactX;
    protected double exactY;
    protected double moveSpeedX;
    protected double moveSpeedY;

    public Bullet(Control shooter, int dirX, int dirY, int speed)
    {
        this.Size = new Size(15, 15);
        this.SizeMode = PictureBoxSizeMode.StretchImage;
        this.BackColor = Color.Transparent;

        double actualSpeed = (dirX != 0 && dirY != 0) ? (speed / Math.Sqrt(2)) : speed;

        this.moveSpeedX = dirX * actualSpeed;
        this.moveSpeedY = -dirY * actualSpeed;

        double shooterCenterX = shooter.Left + (shooter.Width / 2.0);
        double shooterCenterY = shooter.Top + (shooter.Height / 2.0);

        this.exactX = shooterCenterX + ((shooter.Width / 2.0) * dirX) - (this.Width / 2.0);
        this.exactY = shooterCenterY - ((shooter.Height / 2.0) * dirY) - (this.Height / 2.0);

        this.Left = (int)Math.Round(this.exactX);
        this.Top = (int)Math.Round(this.exactY);
    }

    public void Move()
    {
        this.exactX += moveSpeedX;
        this.exactY += moveSpeedY;

        this.Left = (int)Math.Round(this.exactX);
        this.Top = (int)Math.Round(this.exactY);
    }

    public bool IsOutOfBounds()
    {
        return (this.Right < 0 ||
                this.Left > MainForm.Instance.ClientSize.Width ||
                this.Bottom < 0 ||
                this.Top > MainForm.Instance.ClientSize.Height);
    }
}

class PlayerBullet : Bullet
{
    public PlayerBullet(Control playerShip, int dirX, int dirY, int speed)
        : base(playerShip, dirX, dirY, speed)
    {
        this.Image = Properties.Resources.Bullet_Player;
    }
}

class EnemyBullet : Bullet
{
    public EnemyBullet(Control enemyShip, int dirX, int dirY, int speed)
        : base(enemyShip, dirX, dirY, speed)
    {
        this.Image = Properties.Resources.Bullet_Enemy;
    }
}