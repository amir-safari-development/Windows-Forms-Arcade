namespace Arcade_Game;

internal abstract class Bullet : PictureBox
{
    protected int speed;

    public Bullet(int speed, int startX, int startY)
    {
        this.speed = speed;
        this.Size = new Size(10, 35);
        this.Location = new Point(startX, startY);
        this.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    public new abstract void Move();
    public bool IsOutofBounds(Form mainForm)
    {
        if (this.Location.Y + this.Size.Height < 0 || this.Location.Y > mainForm.ClientSize.Height) return true;
        return false;
    }
}

class PlayerBullet : Bullet
{
    public PlayerBullet(int speed, int startX, int startY) : base(speed, startX, startY)
    {
        this.Image = Properties.Resources.Bullet_Player;
    }

    public override void Move()
    {
        this.Top -= this.speed;
    }
}

class EnemyBullet : Bullet
{
    public EnemyBullet(int speed, int startX, int startY) : base(speed, startX, startY)
    {
        this.Image = Properties.Resources.Bullet_Enemy;
    }

    public override void Move()
    {
        this.Top += this.speed;
    }
}