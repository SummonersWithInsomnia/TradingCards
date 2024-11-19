using System;
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

            pbCardValue.ValueChanged += CardValueBar_ValueChanged;
            pbCardValue.Value = player.CardValue;
        }

        private void CardValueBar_ValueChanged(object sender, EventArgs e)
        {
            if (pbCardValue.Value < 60)
            {
                pbCardValue.ProgressBarColor = Color.Red;
            }
            else
            {
                pbCardValue.ProgressBarColor = Color.Green;
            }
        }
    }
}