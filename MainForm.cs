namespace Arcade_Game;

public partial class MainForm : System.Windows.Forms.Form
{
    Player player;

    public MainForm()
    {
        InitializeComponent();
        this.DoubleBuffered = true;

        SetupGame();

        this.KeyDown += MainFormKeyDown;
        this.KeyUp += MainFormKeyUp;
    }

    private void SetupGame()
    {
        player = new(Properties.Resources.Player_1, this);
        this.Controls.Add(player);
    }

    private void TimerEvent(object sender, EventArgs e)
    {
        player.Move();

        for (int i = Player.bullets.Count - 1; i >=0; i--)
        {
            PlayerBullet bullet = Player.bullets[i];

            bullet.Move();

            if (bullet.IsOutofBounds(this))
            {
                this.Controls.Remove(bullet);
                bullet.Dispose();
                Player.bullets.RemoveAt(i);
                continue;
            }
        }
    }

    private void MainFormKeyDown(object sender, KeyEventArgs e)
    {
        player.KeyDown(e); 
    }

    private void MainFormKeyUp(object sender, KeyEventArgs e)
    {
        player.KeyUp(e);
    }
}