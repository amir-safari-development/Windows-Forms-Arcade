using System.ComponentModel;

namespace Arcade_Game;

internal abstract class Enemy : PictureBox
{
    public static List<Enemy> enemies = new();
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual int HealthPoint { get; set; } = 2;

    public static List<EnemyBullet> bullets = new();

    public Coin coin;

    private string coinKind;
    private int coinValue;

    public Enemy(string coinKind, int coinValue)
    {
        this.Size = new Size(60, 60);
        this.SizeMode = PictureBoxSizeMode.StretchImage;
        this.BackColor = Color.Transparent;
        this.coinKind = coinKind;
        this.coinValue = coinValue;
    }

    public new abstract void Move();

    public virtual void Shoot() { }

    public void DropCoin()
    {
        this.coin = new Coin(coinValue, coinKind, this);
        Coin.coins.Add(coin);
    }
}

class StandardEnemy : Enemy
{
    private int speed { get; set; } = 2;
    public StandardEnemy(string coinKind, int coinValue, int startX) : base(coinKind, coinValue)
    {
        this.Image = GameAssets.EnemyStandard;
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

    private DateTime lastTimeShot = DateTime.MinValue;
    private const int CoolDown = 2000;

    public ShooterEnemy(string coinKind, int coinValue, int startX, int startY) : base(coinKind, coinValue) { 
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
        this.Image = GameAssets.EnemyShooter;
    }

    public override void Move()
    {
        this.Top += speed;
    }

    public bool CanShoot()
    {
        if ((DateTime.Now - this.lastTimeShot).TotalMilliseconds >= CoolDown)
        {
            this.lastTimeShot = DateTime.Now;
            return true;
        }

        return false;
    }

    public override void Shoot()
    {
        if (!this.CanShoot()) return;

        EnemyBullet bullet = new(this, 0, -1, 5);
        bullets.Add(bullet);
    }
}

class ScoutEnemy : Enemy
{
    private int speed { get; set; } = 3;
    private int invert = 1;

    private static readonly Random rand = new();
    private DateTime lastInvertTime = DateTime.Now;

    public ScoutEnemy(string coinKind, int coinValue, int startX, int startY) : base(coinKind, coinValue)
    {
        this.Image = GameAssets.EnemyScout;
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
    }

    public override void Move()
    {
        if ((DateTime.Now - lastInvertTime).TotalMilliseconds >= 1000)
        {
            invert = rand.Next(0, 2) == 0 ? 1 : -1;
            lastInvertTime = DateTime.Now;
        }

        if (this.Right > MainForm.Instance.ClientSize.Width) invert = -1;
        else if (this.Left < 0) invert = 1;

        int step = (int)Math.Round(speed / Math.Sqrt(2));

        this.Top += step;
        this.Left += invert * step;
    }
}

class TerroristEnemy : Enemy
{
    private int speed { get; set; } = 2;
    public override int HealthPoint { get; set; } = 1;
    public TerroristEnemy(string coinKind, int coinValue, int startX, int startY) : base(coinKind, coinValue) {
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
        this.Image = GameAssets.EnemyTerrorist;
    }

    public override void Move()
    {
        int diffX = Player.Instance.Left - this.Left;
        int diffY = Player.Instance.Top - this.Top;

        double diagonal = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));

        if (diagonal == 0) return;

        double k = speed / diagonal;

        this.Left += (int)Math.Round(diffX * k);
        this.Top += (int)Math.Round(diffY * k);
    }
}

class TankEnemy : Enemy
{
    private int speed { get; set; } = 2;
    public override int HealthPoint { get; set; } = 6;

    private DateTime lastTimeShot = DateTime.MinValue;
    private const int CoolDown = 2000;

    private int invert = 1;
    public TankEnemy(string coinKind, int coinValue, int startX, int startY) : base(coinKind, coinValue)
    {
        this.Image = GameAssets.EnemyTank;
        this.Size = new Size(125, 75);
        this.Location = new Point(startX - this.Width / 2, startY - this.Height / 2);
    }

    public override void Move()
    {
        if (this.Right > MainForm.Instance.ClientSize.Width) invert = -1;
        else if (this.Left < 0) invert = 1;

        this.Left += speed * invert;
    }

    public bool CanShoot()
    {
        if ((DateTime.Now - this.lastTimeShot).TotalMilliseconds >= CoolDown)
        {
            this.lastTimeShot = DateTime.Now;
            return true;
        }

        return false;
    }

    public override void Shoot()
    {
        if (!this.CanShoot()) return;

        List<EnemyBullet> tankBullets = new List<EnemyBullet> {
            new EnemyBullet(this, 0, 1, 5),
            new EnemyBullet(this, 0, -1, 5),
            new EnemyBullet(this, 1, 0, 5),
            new EnemyBullet(this, -1, 0, 5),
            new EnemyBullet(this, 1, 1, 5),
            new EnemyBullet(this, 1, -1, 5),
            new EnemyBullet(this, -1, -1, 5),
            new EnemyBullet(this, -1, 1, 5)
        };

        foreach (var bullet in tankBullets) bullets.Add(bullet);
    }
}