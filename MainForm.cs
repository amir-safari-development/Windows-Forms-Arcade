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
        Timer.Start();
    }

    private void SetupGame()
    {
        this.KeyDown += MainFormKeyDown;
        this.KeyUp += MainFormKeyUp;

        this.Paint += MainFormPaint;

        player = new Player(Properties.Resources.Player_1);

        // test
        Enemy.enemies.Add(new StandardEnemy(100));
        Enemy.enemies.Add(new TankEnemy(100, 50));
        Enemy.enemies.Add(new ShooterEnemy(30, 400));
        Enemy.enemies.Add(new ScoutEnemy(60, 60));
        Enemy.enemies.Add(new TerroristEnemy(100, 200));
        // test
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
                bullet.Dispose();
                Player.bullets.RemoveAt(i);

                continue;
            }
        }

        for (int i = Enemy.bullets.Count - 1; i >= 0; i--)
        {
            EnemyBullet bullet = Enemy.bullets[i];

            bullet.Move();

            if (bullet.IsOutOfBounds())
            {
                bullet.Dispose();
                Enemy.bullets.RemoveAt(i);

                continue;
            }

            if (bullet.Bounds.IntersectsWith(player.Bounds))
            {
                player.HealthPoint--;

                bullet.Dispose();
                Enemy.bullets.RemoveAt(i);

                continue;
            }
        }

        for (int i = Enemy.enemies.Count - 1; i >= 0; i--)
        {
            bool isEnemyDead = false;

            Enemy currentEnemy = Enemy.enemies[i];
            currentEnemy.Move();
            currentEnemy.Shoot();

            if (currentEnemy.Bounds.IntersectsWith(player.Bounds) && player.CanGetHitByImpact())
            {
                player.HealthPoint--;
                currentEnemy.HealthPoint--;

                if (currentEnemy.HealthPoint <= 0)
                {
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
                    currentBullet.Dispose();
                    Player.bullets.RemoveAt(j);

                    currentEnemy.HealthPoint--;

                    if (currentEnemy.HealthPoint <= 0)
                    {
                        isEnemyDead = true;
                        currentEnemy.Dispose();
                        Enemy.enemies.RemoveAt(i);
                    }
                }
            }
        }

        this.Invalidate();
    }

    private void MainFormKeyDown(object sender, KeyEventArgs e)
    {
        player.KeyDown(e);
    }

    private void MainFormKeyUp(object sender, KeyEventArgs e)
    {
        player.KeyUp(e);
    }

    private void MainFormPaint(object sender, PaintEventArgs e)
    {
        e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

        if (player != null && player.HealthPoint > 0)
            e.Graphics.DrawImage(player.Image, player.Bounds);

        foreach (var enemy in Enemy.enemies)
            e.Graphics.DrawImage(enemy.Image, enemy.Bounds);

        foreach (var bullet in Player.bullets)
            e.Graphics.DrawImage(bullet.Image, bullet.Bounds);

        foreach (var bullet in Enemy.bullets)
            e.Graphics.DrawImage(bullet.Image, bullet.Bounds);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }
}