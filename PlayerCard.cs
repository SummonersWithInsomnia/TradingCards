using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class PlayerCard : Form
    {
        public PlayerCard(Player player)
        {
            InitializeComponent();
            
            BackColor = Color.FromName(player.CardColor);
            
            lbCardType.Text = player.CardType;

            pbCardImage.Image = File.Exists(player.ImagePath) ? Image.FromFile(player.ImagePath) : null;
            
            lbPlayerName.Text = player.PlayerName;
            lbTeamName.Text = player.TeamName;

            lbNotableStat.Text = player.NotableStat;
            lbCardPrice.Text = $"${player.CardPrice}";

            pbCardValue.Value = player.CardValue;
        }
    }
}