using FiveCardStud.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveCardStud.Models
{
    public class CardsModel
    {
        public string CardRank { get; set; } = string.Empty;
        public string CardSuit { get; set; } = string.Empty;
        public int CardRankNum { get; set; }
        public int CardSuitNum { get; set; }
        public CardsModel GetCard()
        {
            Random random = new Random();
            var cardResult = new CardsModel();
            var cardRankNumResult = random.Next(1, 13);
            var cardSuitNumResult = random.Next(0, 3);
            var cardRankResult = ((Rank)cardRankNumResult).ToString();
            var cardSuitResult = ((Suit)cardSuitNumResult).ToString();
            cardResult.CardRank = cardRankResult;
            cardResult.CardSuit = cardSuitResult;
            cardResult.CardRankNum = cardRankNumResult;
            cardResult.CardSuitNum = cardSuitNumResult;
            return cardResult;
        }
    }
}
