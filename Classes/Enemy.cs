using System.ComponentModel;

namespace Arcade_Game;

internal abstract class Enemy : PictureBox
{
    public static List<Enemy> enemies = new();
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual int HealthPoint { get; set; } = 2;

    public Enemy()
    {
        this.Size = new Size(60, 60);
        this.SizeMode = PictureBoxSizeMode.StretchImage;
        this.BackColor = Color.Transparent;
    }

    public new abstract void Move();
}

class StandardEnemy : Enemy
{
    private int speed { get; set; } = 2;
    public StandardEnemy(int startX) : base()
    {
        this.Image = Properties.Resources.Enemy_Standard;
        this.Location = new Point(startX - this.Width / 2, 100);
    }

    public override void Move()
    {
        this.Top += speed;
    }
}

class ShooterEnemy : Enemy
{
    private int speed { get; set; } = 2;
    public ShooterEnemy(int startX, int startY) : base() { 
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
        this.Image = Properties.Resources.Enemy_Standard;
    }

    public override void Move()
    {
        this.Top += speed;
    }

    public void Shoot()
    {

    }
}

//class ScoutEnemy : Enemy
//{

//}

class TerroristEnemy : Enemy
{
    Player player;
    private int speed { get; set; } = 2;
    public override int HealthPoint { get; set; } = 1;
    public TerroristEnemy(int startX, int startY, Player player) : base() {
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
        this.Image = Properties.Resources.Enemy_Terrorist;
        this.player = player;
    }

    public override void Move()
    {
        int diffX = player.Left - this.Left;
        int diffY = player.Top - this.Top;

        double diagonal = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
        double k = speed / diagonal;

        this.Left += (int)Math.Round(diffX * k);
        this.Top += (int)Math.Round(diffY * k);
    }
}

class TankEnemy : Enemy
{
    private int speed { get; set; } = 2;
    public override int HealthPoint { get; set; } = 6;

    private int invert = 1;
    public TankEnemy(int startX, int startY) : base()
    {
        this.Image = Properties.Resources.Enemy_Tank;
        this.Size = new Size(125, 75);
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
    }

    public override void Move()
    {
        if (this.Right > MainForm.Instance.ClientSize.Width) invert = -1;
        else if (this.Left < 0) invert = 1;

        this.Left += speed * invert;
    }

    public void Shoot()
    {

    }
}