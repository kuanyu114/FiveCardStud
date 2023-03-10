using FiveCardStud.Common;
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
        /// <summary>
        /// 發牌
        /// </summary>
        /// <returns></returns>
        public CardsModel GetRandomCard()
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
        public List<CardsModel> GetFullDeck() {
            var deck = 52;
            var cards = new List<CardsModel>();
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    var cardResult = new CardsModel();
                    var cardRankResult = ((Rank)j).ToString();
                    var cardSuitResult = ((Suit)i).ToString();
                    cardResult.CardRank = cardRankResult;
                    cardResult.CardSuit = cardSuitResult;
                    cardResult.CardRankNum = j;
                    cardResult.CardSuitNum = i;
                    cards.Add(cardResult);
                }
            }
            for (int i = 0; i < deck; i++)
            {
                cards.Swap(i, random.Next(0, deck));
            }
            
            return cards;
        }
    }
}
