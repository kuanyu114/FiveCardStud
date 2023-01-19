using FiveCardStud.Interface;
using FiveCardStud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveCardStud.Service
{
    public class FiveCardStudGame : ICardGame
    {
        private List<CardsModel> Cards { get; set; } = new List<CardsModel>();

        public List<CardsModel> Shuffing()
        {
            Cards.Clear();  
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    var newCard = new CardsModel().GetCard();
                    if (Cards.All(n => n.CardRank != newCard.CardRank || n.CardSuit != newCard.CardSuit))
                    {
                        Cards.Add(newCard);
                        break;
                    }
                };
            }
            return Cards;
        }
        public string GetPokerHands(List<CardsModel> cards)
        {
            cards = cards.OrderBy(n => n.CardRankNum).ToList();
            if (cards.GroupBy(n => n.CardSuitNum).Count() == 1)//同花 
            {
                if (CheckFlush(cards))
                    return "同花順";

                return "同花";
            }
            else//非同花
            {                
                

                var temp = cards.GroupBy(n => n.CardRankNum);
                var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });
                if (temp.Count() == 2)//兩種花色
                {                  
                    if (tempCount.Any(n=>n.Count==4))
                        return "四條";                                         
                    return "葫蘆";
                }
                if (temp.Count() == 3)
                {
                    if (tempCount.Any(n => n.Count == 3))
                        return "三條";
                    return "兩對";
                }
                if (tempCount.Any(n => n.Count == 2))
                    return "一對";
                else
                {
                    if (CheckFlush(cards))
                        return "順子";
                    return "散牌";
                }
            }
        }
        public bool CheckFlush(List<CardsModel> cards)
        {
            bool result = false;
        
            if (cards.Any(n => n.CardRankNum == 1) && cards.Any(n => n.CardRankNum == 13))//有A有K
            {
                int points = 47;
                if (cards.Sum(n => n.CardRankNum) == points)
                {
                    return true;
                }
            }
            else//沒有A
            {
                for (int i = 0; i < cards.Count()-1; i++)
                {
                    if ((cards[i].CardRankNum + 1) != cards[i + 1].CardRankNum)
                    {
                        return false;
                    }
                }
                result= true;
                
            }
            return result;
        }
    }

}
