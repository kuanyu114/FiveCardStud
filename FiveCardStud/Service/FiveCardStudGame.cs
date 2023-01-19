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
        /// <summary>
        /// 隨機發指定數量牌
        /// </summary>
        /// <returns></returns>
        public List<CardsModel> Shuffing(int number)
        {
            Cards.Clear();  
            for (int i = 0; i < number; i++)
            {
                while (true)
                {
                    var newCard = new CardsModel().GetRandomCard();
                    if (Cards.All(n => n.CardRank != newCard.CardRank || n.CardSuit != newCard.CardSuit))
                    {
                        Cards.Add(newCard);
                        break;
                    }
                };
            }
            return Cards;
        }
        /// <summary>
        /// 洗牌+發52張牌
        /// </summary>
        /// <returns></returns>
        public List<CardsModel> ShuffingFullDeck()
        {
            Cards.Clear();
            var newCard = new CardsModel().GetFullDeck();
            return Cards;
        }
        /// <summary>
        /// 確認牌型
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
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
                //var temp = cards.GroupBy(n => n.CardRankNum);
                //var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });
                //if (temp.Count() == 2)//兩種花色
                //{                  
                //    if (tempCount.Any(n=>n.Count==4))
                //        return "四條";                                         
                //    return "葫蘆";
                //}
                //if (temp.Count() == 3)
                //{
                //    if (tempCount.Any(n => n.Count == 3))
                //        return "三條";
                //    return "兩對";
                //}
                //if (tempCount.Any(n => n.Count == 2))
                //    return "一對";
                //else
                //{
                //    if (CheckFlush(cards))
                //        return "順子";
                //    return "散牌";
                //}
                if (CheckFourKind(cards))
                    return "四條";
                if (CheckFullHouse(cards))
                    return "葫蘆";
                if (CheckThreeKind(cards))
                    return "三條";
                if (CheckTwoPair(cards))
                    return "兩對";
                if (CheckPair(cards))
                    return "一對";
                if (CheckFlush(cards))
                    return "順子";
                return "散牌";
            }
        }
        /// <summary>
        /// 檢查是不是順子
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 檢查是不是四條
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public bool CheckFourKind(List<CardsModel> cards)
        {
            var temp = cards.GroupBy(n => n.CardRankNum);
            var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });
            if (temp.Count() == 2)//兩種花色
            {
                if (tempCount.Any(n => n.Count == 4))
                    return true;
                
            }
            return false;
            
        }
        /// <summary>
        /// 檢查是不是葫蘆
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public bool CheckFullHouse(List<CardsModel> cards)
        {
            var temp = cards.GroupBy(n => n.CardRankNum);
            var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });
            if (temp.Count() == 2)//兩種花色
            {
                if (tempCount.Any(n => n.Count != 4))
                    return true;

            }
            return false;

        }
        /// <summary>
        /// 檢查是不是三條
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public bool CheckThreeKind(List<CardsModel> cards)
        {
            var temp = cards.GroupBy(n => n.CardRankNum);
            var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });
            if (temp.Count() == 3)
            {
                if (tempCount.Any(n => n.Count == 3))
                    return true;               
            }
            return false;

        }
        /// <summary>
        /// 檢查是不是兩對
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public bool CheckTwoPair(List<CardsModel> cards)
        {
            var temp = cards.GroupBy(n => n.CardRankNum);
            var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });
            if (temp.Count() == 3)
            {
                if (tempCount.Any(n => n.Count != 3))
                    return true;
            }
            return false;

        }
        /// <summary>
        /// 檢查是不是一對
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public bool CheckPair(List<CardsModel> cards)
        {
            var temp = cards.GroupBy(n => n.CardRankNum);
            var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });
            if (tempCount.Any(n => n.Count == 2))
                return true;
            return false;

        }
    }

}
