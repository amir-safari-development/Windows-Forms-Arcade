
using static System.Windows.Forms.AxHost;

namespace Arcade_Game;

internal abstract class Enemy : PictureBox
{
    public static List<Enemy> enemies = new();
    public Enemy(int startX)
    {
        this.Size = new Size(60, 60);
        this.SizeMode = PictureBoxSizeMode.StretchImage;
        this.BackColor = Color.Transparent;
        this.Location = new Point(startX - this.Width / 2, 100);
    }

    public new abstract void Move();
}

class StandardEnemy : Enemy
{
    public StandardEnemy(int startX): base(startX)
    {
        this.Image = Properties.Resources.Enemy_Standard;
        this.Tag = "EnemyShooter";
    }

    public override void Move()
    {
        this.Top += 5;
    }
}

//class ShooterEnemy : Enemy
//{

//}

//class ScoutEnemy : Enemy
//{

//}

//class TerroristEnemy : Enemy
//{

//}