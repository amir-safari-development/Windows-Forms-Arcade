using System.ComponentModel;
using System.Numerics;

namespace Arcade_Game;

internal class Player : PictureBox
{
    static Form mainForm;
    public static List<PlayerBullet> bullets = new();

    private static DateTime lastTimeShot = DateTime.MinValue;
    private const int CoolDown = 500;

    bool goLeft;
    bool goRight;
    bool goUp;
    bool goDown;

    int windowWidth;
    int windowHeight;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Speed { get; set; } = 10;

    public Player(Image skin, Form mainForm)
    {
        Player.mainForm = mainForm;
        windowWidth = mainForm.ClientSize.Width;
        windowHeight = mainForm.ClientSize.Height;

        this.Image = skin;
        this.SizeMode = PictureBoxSizeMode.StretchImage;

        this.Size = new Size(90, 90);
        this.Location = new Point(windowWidth / 2 - 45, windowHeight - 90 - 15);
        this.BackColor = Color.Transparent;
        this.Name = "Player";
        this.Tag = "Player";
    }

    public void KeyDown(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left) goLeft = true;
        if (e.KeyCode == Keys.Right) goRight = true;
        if (e.KeyCode == Keys.Up) goUp = true;
        if (e.KeyCode == Keys.Down) goDown = true;
        if (e.KeyCode == Keys.Space && Player.CanShoot()) Shoot(0, 1);
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

    public static bool CanShoot()
    {
        if ((DateTime.Now - lastTimeShot).TotalMilliseconds >= CoolDown)
        {
            lastTimeShot = DateTime.Now;
            return true;
        }

        return false;
    }

    private void Shoot(int dirX, int dirY)
    {
        int startX = this.Location.X + this.Size.Width / 2 - 5;
        int startY = this.Location.Y - 35;

        PlayerBullet bullet = new(this, dirX, dirY, 15);
        mainForm.Controls.Add(bullet);
        bullets.Add(bullet);
    }
}