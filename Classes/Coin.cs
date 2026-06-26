namespace Arcade_Game;

internal class Coin : PictureBox
{
    public static List<Coin> coins = new();

    public string kind;
    public int value;
    public Coin(int value, string kind, Enemy enemy)
    {
        if (value == 1 && kind == "silver") this.Image = Properties.Resources.Coin_Silver_1;
        else if (value == 5 && kind == "silver") this.Image = Properties.Resources.Coin_Silver_5;
        else if (value == 1 && kind == "gold") this.Image = Properties.Resources.Coin_Gold_1;
        else if (value == 5 && kind == "gold") this.Image = Properties.Resources.Coin_Gold_5;

        this.value = value;
        this.kind = kind;

        this.Size = new Size(50, 50);

        this.Top = enemy.Top + enemy.Height / 2 - this.Height / 2;
        this.Left = enemy.Left + enemy.Width / 2 - this.Width / 2;

        this.SizeMode = PictureBoxSizeMode.StretchImage;
        this.BackColor = Color.Transparent;
    }
}