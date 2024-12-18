﻿using System;
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
        private Dictionary<string, bool> myCardCollection;
        
        public App()
        {
            InitializeComponent();

            // Players information and attributes dictionary
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
                        "1986 Fleer Rookie", 100, "player-images/player4.jpg")
                },
                {
                    "LeBron James",
                    new Player("LeBron James", "Los Angeles Lakers", "LightSalmon", "4 NBA Championships", 70000,
                        "2003 Upper Deck SP Rookie", 90, "player-images/player1.jpg")
                },
                {
                    "Stephen Curry",
                    new Player("Stephen Curry", "Golden State Warriors", "LightSalmon", "3 NBA Championships", 30000,
                        "Autographed Panini", 85, "player-images/player3.jpg")
                },
                {
                    "Kevin Durant",
                    new Player("Kevin Durant", "Brooklyn Nets", "LightYellow", "2 NBA Championships", 15000,
                        "2007 Topps Chrome Rookie", 80, "player-images/player8.jpg")
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
                        "2018 Panini Prizm Rookie", 40, "player-images/player2.jpg")
                },
                {
                    "Nikola Jokić",
                    new Player("Nikola Jokić", "Denver Nuggets", "LightSkyBlue", "0 NBA Championships", 4000,
                        "Panini Prizm Silver", 50, "player-images/player7.jpg")
                },
                {
                    "Zion Williamson",
                    new Player("Zion Williamson", "New Orleans Pelicans", "LightSkyBlue", "0 NBA Championships", 3500,
                        "Panini National Treasures", 55, "player-images/player9.jpg")
                }
            };

            //Dictionary for cards added to the collection
            myCardCollection = new Dictionary<string, bool>
            {
                {"Kobe Bryant", false},
                {"Michael Jordan", false},
                {"LeBron James", false},
                {"Stephen Curry", false},
                {"Kevin Durant", false},
                {"Giannis Antetokounmpo", false},
                {"Kawhi Leonard", false},
                {"Luka Dončić", false},
                {"Nikola Jokić", false},
                {"Zion Williamson", false}
            };

            //Events to buttons for displaying player cards
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

            btnAction.Click += btnAction_Click;
        }
        
        //Displays the card of the specific player
        //If player is found, PlayerCard control is created and added to the UI
        //If not found, a message alert is prompted to the user
        private void ShowCard(string playerName)
        {
            //Try finding the player in thhe dictionary
            if (playerData.TryGetValue(playerName, out Player player))
            {
                PlayerCard playerCard = new PlayerCard(player);
                playerCard.TopLevel = false;
                playerCard.Parent = pCard;
                playerCard.Location = new Point(100, 30); //Dock bleeding solved, need to use Location for correct positioning

                pCard.Controls.Clear();
                pCard.Controls.Add(playerCard);
                playerCard.Show();

                if (myCardCollection[playerName])
                {
                    lbCardOwnership.Text = "Owned";
                    btnAction.Text = "Remove Card";
                    pCard.Controls.Add(lbCardOwnership);
                    pCard.Controls.Add(btnAction);
                }
                else
                {
                    lbCardOwnership.Text = "Not owned";
                    btnAction.Text = "Add Card";
                    pCard.Controls.Add(lbCardOwnership);
                    pCard.Controls.Add(btnAction);
                }
            }
            else
            {
                MessageBox.Show("Player not found");
            }
        }

        // Add and remove button for cards in the collection
        private void btnAction_Click(object sender, EventArgs e)
        {
            if (pCard.Controls.Contains(lbCardOwnership) && pCard.Controls.Contains(btnAction))
            {
                string playerName = pCard.Controls.OfType<PlayerCard>().First().PlayerName;
                if (myCardCollection[playerName])
                {
                    myCardCollection[playerName] = false;
                    lbCardOwnership.Text = "Not owned"; //Update the label text
                    btnAction.Text = "Add Card"; //Change the button text
                }
                else
                {
                    myCardCollection[playerName] = true;
                    lbCardOwnership.Text = "Owned";  //Update the label text
                    btnAction.Text = "Remove Card";//Change the button text
                }
            }
        }

        // Opens a new form (Collection List Form) that displays the player's current card collection
        private void btnMyCardCollection_Click(object sender, EventArgs e)
        {
            MyCardCollection mcc = new MyCardCollection(myCardCollection);
            mcc.ShowDialog();
        }
    }
}