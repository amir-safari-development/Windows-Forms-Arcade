namespace Arcade_Game;

public enum CoinKind { Silver, Gold }

public record CoinSpecification(int Value, CoinKind Kind);

internal class Coin : PictureBox
{
    public static List<Coin> coins = new();

    public CoinKind kind;
    public int value;

    public Coin(int value, CoinKind kind, int startX, int startY)
    {
        if (value == 1 && kind == CoinKind.Silver) this.Image = GameAssets.CoinSilver1;
        else if (value == 5 && kind == CoinKind.Silver) this.Image = GameAssets.CoinSilver5;
        else if (value == 1 && kind == CoinKind.Gold) this.Image = GameAssets.CoinGold1;
        else if (value == 5 && kind == CoinKind.Gold) this.Image = GameAssets.CoinGold5;

        this.value = value;
        this.kind = kind;

        this.Size = new Size(50, 50);
        this.Left = startX - this.Width / 2;
        this.Top = startY - this.Height / 2;

        this.SizeMode = PictureBoxSizeMode.StretchImage;
        this.BackColor = Color.Transparent;
    }
}