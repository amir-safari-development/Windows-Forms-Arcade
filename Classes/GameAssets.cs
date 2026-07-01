using System.Media;
namespace Arcade_Game;

internal class GameAssets
{
    public static readonly SoundPlayer CoinPickup = new SoundPlayer(Properties.Resources.CoinPickup);
    public static readonly SoundPlayer Explosion = new SoundPlayer(Properties.Resources.Explosion);
    public static readonly SoundPlayer Shoot = new SoundPlayer(Properties.Resources.Shoot);
    public static readonly SoundPlayer TheTheme = new SoundPlayer(Properties.Resources.TheTheme);
    public static readonly SoundPlayer MenuMusic = new SoundPlayer(Properties.Resources.MenuMusic);
    public static readonly SoundPlayer GameMusic = new SoundPlayer(Properties.Resources.GameMusic);



    public static readonly Image gameTitle = Properties.Resources.gameTitle;
    public static readonly Image SpaceBackGround = Properties.Resources.SpaceBackGround;
    public static readonly byte[] GameIcon = Properties.Resources.GameIcon;



    public static readonly Image NormalSilver1Coin = Properties.Resources.NormalSilver1Coin;
    public static readonly Image NormalSilver5Coin = Properties.Resources.NormalSilver5Coin;
    public static readonly Image NormalGolden1Coin = Properties.Resources.NormalGolden1Coin;
    public static readonly Image NormalGolden5Coin = Properties.Resources.NormalGolden5Coin;

    public static readonly Image NormalEnemyStandard = Properties.Resources.NormalEnemyStandard;
    public static readonly Image NormalEnemyShooter = Properties.Resources.NormalEnemyShooter;
    public static readonly Image NormalEnemyScout = Properties.Resources.NormalEnemyScout;
    public static readonly Image NormalEnemyTerrorist = Properties.Resources.NormalEnemyTerrorist;
    public static readonly Image NormalEnemyTank = Properties.Resources.NormalEnemyTank;

    public static readonly Image NormalPlayer = Properties.Resources.NormalPlayer;
    public static readonly Image NormalSpecialPlayer = Properties.Resources.NormalSpecialPlayer;

    public static readonly Image NormalBulletPlayer = Properties.Resources.NormalBulletPlayer;
    public static readonly Image NormalBulletEnemy = Properties.Resources.NormalBulletEnemy;





    public static readonly Image PixelSilver1Coin = Properties.Resources.PixelSilver1Coin;
    public static readonly Image PixelSilver5Coin = Properties.Resources.PixelSilver5Coin;
    public static readonly Image PixelGolden1Coin = Properties.Resources.PixelGolden1Coin;
    public static readonly Image PixelGolden5Coin = Properties.Resources.PixelGolden5Coin;

    public static readonly Image PixelEnemyStandard = Properties.Resources.PixelEnemyStandard;
    public static readonly Image PixelEnemyShooter = Properties.Resources.PixelEnemyShooter;
    public static readonly Image PixelEnemyScout = Properties.Resources.PixelEnemyScout;
    public static readonly Image PixelEnemyTerrorist = Properties.Resources.PixelEnemyTerrorist;
    public static readonly Image PixelEnemyTank = Properties.Resources.PixelEnemyTank;

    public static readonly Image PixelPlayer = Properties.Resources.PixelPlayer;
    public static readonly Image PixelSpecialPlayer = Properties.Resources.PixelSpecialPlayer;

    public static readonly Image PixelBulletPlayer = Properties.Resources.PixelBulletPlayer;
    public static readonly Image PixelBulletEnemy = Properties.Resources.PixelBulletEnemy;




}