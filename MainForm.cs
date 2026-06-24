namespace Arcade_Game;

public partial class MainForm : System.Windows.Forms.Form
{
    Player player;
    public static MainForm Instance { get; private set; }

    public MainForm()
    {
        Instance = this;
        InitializeComponent();
        this.DoubleBuffered = true;

        SetupGame();
    }

    private void SetupGame()
    {
        this.KeyDown += MainFormKeyDown;
        this.KeyUp += MainFormKeyUp;

        player = new Player(Properties.Resources.Player_1);
        this.Controls.Add(player);

        // test
        Enemy enemy1 = new StandardEnemy(100);
        this.Controls.Add(enemy1);
        Enemy.enemies.Add(enemy1);

        Enemy enemy2 = new TankEnemy(100, 50);
        this.Controls.Add(enemy2);
        Enemy.enemies.Add(enemy2);
    }

    private void TimerEvent(object sender, EventArgs e)
    {
        player.Move();

        for (int i = Player.bullets.Count - 1; i >= 0; i--)
        {
            PlayerBullet bullet = Player.bullets[i];

            bullet.Move();

            if (bullet.IsOutOfBounds())
            {
                this.Controls.Remove(bullet);
                bullet.Dispose();
                Player.bullets.RemoveAt(i);

                continue;
            }
        }

        for (int i = Enemy.enemies.Count - 1; i >= 0;i--)
        {
            bool isEnemyDead = false;

            Enemy currentEnemy = Enemy.enemies[i];
            currentEnemy.Move();

            if (currentEnemy.Bounds.IntersectsWith(player.Bounds) && player.CanGetHitByImpact())
            {
                player.HealthPoint--;
                currentEnemy.HealthPoint--;

                if (player.HealthPoint <= 0)
                {
                    // game-over
                    Timer.Stop();
                    break;
                }

                if (currentEnemy.HealthPoint <= 0)
                {
                    this.Controls.Remove(currentEnemy);
                    Enemy.enemies.RemoveAt(i);
                    currentEnemy.Dispose();

                    continue;
                }
                    
            }

            for (int j = Player.bullets.Count - 1; j >= 0; j--)
            {
                if (isEnemyDead) break;

                Bullet currentBullet = Player.bullets[j];

                if (currentBullet.Bounds.IntersectsWith(currentEnemy.Bounds))
                {
                    this.Controls.Remove(currentBullet);
                    currentBullet.Dispose();
                    Player.bullets.RemoveAt(j);
                    currentEnemy.HealthPoint--;

                    if (currentEnemy.HealthPoint <= 0)
                    {
                        isEnemyDead = true;
                        this.Controls.Remove(currentEnemy);
                        currentEnemy.Dispose();
                        Enemy.enemies.RemoveAt(i);
                    }
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