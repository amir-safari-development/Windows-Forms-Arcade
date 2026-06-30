using System.ComponentModel;

namespace Arcade_Game;

internal class Player : PictureBox
{
    public static List<PlayerBullet> bullets = new();

    public static int TotalSilverCoinValues = 0;
    public static int TotalGoldCoinValues = 0;

    public static Player Instance { get; private set; }

    private DateTime lastTimeShot = DateTime.MinValue;
    private const int CoolDown = 500;

    private DateTime lastTimeImpactWithEnemy = DateTime.MinValue;
    private const int DelayAfterImpact = 500;

    bool goLeft;
    bool goRight;
    bool goUp;
    bool goDown;

    int windowWidth;
    int windowHeight;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Speed { get; set; } = 10;

    private int _HP = 3;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int HealthPoint
    {
        get => _HP;
        set
        {
            _HP = value;

            if (_HP <= 0)
            {
                _HP = 0;

                MainForm.Instance.Timer.Stop();
                this.Dispose();
            }
        }
    }

    public Player(Image skin)
    {
        Instance = this;
        windowWidth = MainForm.Instance.ClientSize.Width;
        windowHeight = MainForm.Instance.ClientSize.Height;

        this.Image = skin;
        this.SizeMode = PictureBoxSizeMode.StretchImage;
        this.BackColor = Color.Transparent;

        this.Size = new Size(90, 90);
        this.Location = new Point(windowWidth / 2 - 45, windowHeight - 90 - 15);
    }

    public void KeyDown(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left) goLeft = true;
        if (e.KeyCode == Keys.Right) goRight = true;
        if (e.KeyCode == Keys.Up) goUp = true;
        if (e.KeyCode == Keys.Down) goDown = true;
        if (e.KeyCode == Keys.Space) Shoot(0, 1);
    }

    public void KeyUp(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left) goLeft = false;
        if (e.KeyCode == Keys.Right) goRight = false;
        if (e.KeyCode == Keys.Up) goUp = false;
        if (e.KeyCode == Keys.Down) goDown = false;
    }

    public new void Move()
    {
        if (goLeft && this.Location.X >= 15) this.Left -= Speed;
        if (goRight && this.Location.X <= windowWidth - 90 - 15 ) this.Left += Speed;
        if (goUp && this.Location.Y >= 15) this.Top -= Speed;
        if (goDown && this.Location.Y <= windowHeight - 90 - 15) this.Top += Speed;
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

    public bool CanGetHitByImpact()
    {
        if ((DateTime.Now - this.lastTimeImpactWithEnemy).TotalMilliseconds >= DelayAfterImpact)
        {
            this.lastTimeImpactWithEnemy = DateTime.Now;
            return true;
        }

        return false;
    }

    private void Shoot(int dirX, int dirY)
    {
        if (!this.CanShoot()) return;

        PlayerBullet bullet = new(this, dirX, dirY, 15);
        bullets.Add(bullet);
    }
}