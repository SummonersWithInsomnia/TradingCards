namespace TradingCards
{
    public class Player
    {
        public string PlayerName { get; set; }
        public string TeamName { get; set; }
        public string CardColor { get; set; }
        public string NotableStat { get; set; }
        public int CardPrice { get; set; }
        public string CardType { get; set; }
        public int CardValue { get; set; }
        public string ImagePath { get; set; }

        public Player(string playerName, string teamName, string cardColor,
            string notableStat, int cardPrice, string cardType, int cardValue, string imagePath)
        {
            PlayerName = playerName;
            TeamName = teamName;
            CardColor = cardColor;
            NotableStat = notableStat;
            CardPrice = cardPrice;
            CardType = cardType;
            CardValue = cardValue;
            ImagePath = imagePath;
        }
    }
}