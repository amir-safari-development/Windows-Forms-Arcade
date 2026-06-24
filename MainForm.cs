namespace Arcade_Game;

public partial class MainForm : System.Windows.Forms.Form
{
    Player player;

    public MainForm()
    {
        InitializeComponent();
        this.DoubleBuffered = true;

        SetupGame();
    }

    private void SetupGame()
    {
        this.KeyDown += MainFormKeyDown;
        this.KeyUp += MainFormKeyUp;

        player = new(Properties.Resources.Player_1, this);
        this.Controls.Add(player);

        Enemy enemy = new StandardEnemy(100);
        this.Controls.Add(enemy);
        Enemy.enemies.Add(enemy);
    }

    private void TimerEvent(object sender, EventArgs e)
    {
        player.Move();

        for (int i = Player.bullets.Count - 1; i >= 0; i--)
        {
            PlayerBullet bullet = Player.bullets[i];

            bullet.Move();

            if (bullet.IsOutOfBounds(this))
            {
                this.Controls.Remove(bullet);
                bullet.Dispose();
                Player.bullets.RemoveAt(i);

                continue;
            }
        }

        for (int i = Enemy.enemies.Count - 1; i >= 0;i--)
        {
            Enemy currentEnemy = Enemy.enemies[i];

            if (currentEnemy.Bounds.IntersectsWith(player.Bounds))
            {
                player.HealthPoint--;

                if (player.HealthPoint <= 0)
                {
                    // game-over
                    timer.Stop();
                    break;
                }

                this.Controls.Remove(currentEnemy);
                Enemy.enemies.RemoveAt(i);
                currentEnemy.Dispose();

                continue;
            }

            for (int j = Player.bullets.Count - 1; j >= 0; j--)
            {
                Bullet currentBullet = Player.bullets[j];

                if (currentBullet.Bounds.IntersectsWith(currentEnemy.Bounds))
                {
                    this.Controls.Remove(currentBullet);
                    Player.bullets.RemoveAt(j);
                    currentBullet.Dispose();

                    break;
                }
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