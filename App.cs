using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingCards
{
    public partial class App : Form
    {
        private Dictionary<string, Player> playerData;
        
        public App()
        {
            InitializeComponent();

            playerData = new Dictionary<string, Player>
            {
                {
                    "Kobe Bryant",
                    new Player("Kobe Bryant", "Los Angeles Lakers", "Gold", "5 NBA Championships", 50000,
                        "Rookie Card", 95, "player-images/player0.jpg")
                },
                {
                    "Michael Jordan",
                    new Player("Michael Jordan", "Chicago Bulls", "Gold", "6 NBA Championships", 200000,
                        "1986 Fleer Rookie", 100, "player-images/player1.jpg")
                },
                {
                    "LeBron James",
                    new Player("LeBron James", "Los Angeles Lakers", "LightSalmon", "4 NBA Championships", 70000,
                        "2003 Upper Deck SP Rookie", 90, "player-images/player2.jpg")
                },
                {
                    "Stephen Curry",
                    new Player("Stephen Curry", "Golden State Warriors", "LightSalmon", "3 NBA Championships", 30000,
                        "Autographed Panini", 85, "player-images/player3.jpg")
                },
                {
                    "Kevin Durant",
                    new Player("Kevin Durant", "Brooklyn Nets", "LightYellow", "2 NBA Championships", 15000,
                        "2007 Topps Chrome Rookie", 80, "player-images/player4.jpg")
                },
                {
                    "Giannis Antetokounmpo",
                    new Player("Giannis Antetokounmpo", "Milwaukee Bucks", "LightYellow", "1 NBA Championship", 12000,
                        "Panini Prizm Silver", 75, "player-images/player5.jpg")
                },
                {
                    "Kawhi Leonard",
                    new Player("Kawhi Leonard", "Los Angeles Clippers", "LightYellow", "2 NBA Championships", 10000,
                        "2012 Panini Prizm Rookie", 70, "player-images/player6.jpg")
                },
                {
                    "Luka Dončić",
                    new Player("Luka Dončić", "Dallas Mavericks", "LightSkyBlue", "0 NBA Championships", 5000,
                        "2018 Panini Prizm Rookie", 40, "player-images/player7.jpg")
                },
                {
                    "Nikola Jokić",
                    new Player("Nikola Jokić", "Denver Nuggets", "LightSkyBlue", "0 NBA Championships", 4000,
                        "Panini Prizm Silver", 50, "player-images/player8.jpg")
                },
                {
                    "Zion Williamson",
                    new Player("Zion Williamson", "New Orleans Pelicans", "LightSkyBlue", "0 NBA Championships", 3500,
                        "Panini National Treasures", 55, "player-images/player9.jpg")
                }
            };
            
            btnShowCard0.Click += (sender, e) => ShowCard("Kobe Bryant");
            btnShowCard1.Click += (sender, e) => ShowCard("LeBron James");
            btnShowCard2.Click += (sender, e) => ShowCard("Luka Dončić");
            btnShowCard3.Click += (sender, e) => ShowCard("Stephen Curry");
            btnShowCard4.Click += (sender, e) => ShowCard("Michael Jordan");
            btnShowCard5.Click += (sender, e) => ShowCard("Giannis Antetokounmpo");
            btnShowCard6.Click += (sender, e) => ShowCard("Kawhi Leonard");
            btnShowCard7.Click += (sender, e) => ShowCard("Nikola Jokić");
            btnShowCard8.Click += (sender, e) => ShowCard("Kevin Durant");
            btnShowCard9.Click += (sender, e) => ShowCard("Zion Williamson");
        }
        
        private void ShowCard(string playerName)
        {
            if (playerData.TryGetValue(playerName, out Player player))
            {
                PlayerCard playerCard = new PlayerCard(player);
                playerCard.TopLevel = false;
                playerCard.Parent = pCard;
                playerCard.Location = new Point(100, 30);

                pCard.Controls.Clear();
                pCard.Controls.Add(playerCard);
                playerCard.Show();
            }
            else
            {
                MessageBox.Show("Player not found");
            }
        }
    }
}