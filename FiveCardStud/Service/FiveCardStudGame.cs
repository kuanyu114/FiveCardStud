using FiveCardStud.Interface;
using FiveCardStud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveCardStud.Service
{
    public class FiveCardStudGame :ICardGame
    {
        private List<CardsModel> Cards { get; set; }
        /// <summary>
        /// 隨機發指定數量牌
        /// </summary>
        /// <returns></returns>
        public List<CardsModel> Shuffing(int number = 5)
        {
            Cards = new List<CardsModel>();

            for (int i = 0; i < number; i++)
            {
                while (true)
                {
                    var newCard = new CardsModel().GetRandomCard();

                    if (Cards.Any(n => n.CardRank == newCard.CardRank && n.CardSuit == newCard.CardSuit)) continue;

                    Cards.Add(newCard);
                    break;
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
            Cards = new List<CardsModel>();
            var newCard = new CardsModel().GetFullDeck();
            return Cards;
        }
        /// <summary>
        /// 確認牌型
        /// </summary>
        /// <returns></returns>
        public string GetPokerHands(List<CardsModel> cards )
        {
            if (cards != null)
                Cards = cards;
            string result = "";
            
            if (CheckCardSuit())//同花 
            {
                if (CheckFlush())
                    result = "同花順";

                result = "同花";
            }
            else//非同花
            {
                 if (CheckFlush())
                    result = "順子";
                
                if (CheckFullHouse())
                    result = "葫蘆";

                if (CheckThreeKind())
                    result = "三條";

                if (CheckTwoPair())
                    result = "兩對";

                if (CheckPair())
                    result = "一對";

                if (CheckFourKind())
                    result = "四條";

                result = result == ""? "散牌": result;
            }
            return result;
        }
        /// <summary>
        /// 檢查是不是同花
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool CheckCardSuit()
        {
            if (Cards == null) throw new ArgumentNullException("沒有牌");

            return (Cards.GroupBy(n => n.CardSuitNum).Count() == 1);//同花 

        }
        /// <summary>
        /// 檢查是不是順子
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool CheckFlush()
        {
            if (Cards == null) throw new ArgumentNullException("沒有牌");

            Cards = Cards.OrderBy(n => n.CardRankNum).ToList();

            bool result = false;
            if (Cards.Any(n => n.CardRankNum == 1) && Cards.Any(n => n.CardRankNum == 13))//有A有K
            {
                int points = 47;// Ace, 10, J, Q, K
                if (Cards.Sum(n => n.CardRankNum) == points)
                {
                    for (int i = 1; i < Cards.Count() - 2; i++)//檢查AK以外的數是否連貫
                    {
                        if ((Cards[i].CardRankNum + 1) != Cards[i + 1].CardRankNum)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            else//沒有同時存在AK
            {
                for (int i = 0; i < Cards.Count() - 1; i++)//檢查AK以外的數是否連貫
                {
                    if ((Cards[i].CardRankNum + 1) != Cards[i + 1].CardRankNum)
                    {
                        return false;
                    }
                }
                result = true;

            }
            return result;
        }
        /// <summary>
        /// 檢查是不是四條
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool CheckFourKind()
        {
            if (Cards == null) throw new ArgumentNullException("沒有牌");

            Cards = Cards.OrderBy(n => n.CardRankNum).ToList();

            var temp = Cards.GroupBy(n => n.CardRankNum);
            var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });
            if (temp.Count() == 2)//兩種花色 
            {
                return (tempCount.Any(n => n.Count == 4));// [{K, 4}, {Ace, 1}]

            }
            return false;

        }
        /// <summary>
        /// 檢查是不是葫蘆
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool CheckFullHouse()
        {
            if (Cards == null) throw new ArgumentNullException("沒有牌");

            Cards = Cards.OrderBy(n => n.CardRankNum).ToList();

            var temp = Cards.GroupBy(n => n.CardRankNum);
            var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });
            if (temp.Count() == 2)//兩種花色
            {
                return (tempCount.Any(n => n.Count == 3 || n.Count == 2));// [{K, 3}, {Ace, 2}]


            }
            return false;

        }
        /// <summary>
        /// 檢查是不是三條
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool CheckThreeKind()
        {
            if (Cards == null) throw new ArgumentNullException("沒有牌");

            Cards = Cards.OrderBy(n => n.CardRankNum).ToList();

            var temp = Cards.GroupBy(n => n.CardRankNum);
            var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });
            if (temp.Count() == 3)//3種花色
            {
                return (tempCount.Any(n => n.Count == 3 || n.Count != 2));// [{K, 3}, {Ace, 1}, {Eight, 1}]

            }
            return false;

        }
        /// <summary>
        /// 檢查是不是兩對
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool CheckTwoPair()
        {
            if (Cards == null) throw new ArgumentNullException("沒有牌");

            Cards = Cards.OrderBy(n => n.CardRankNum).ToList();

            var temp = Cards.GroupBy(n => n.CardRankNum);
            var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });
            if (temp.Count() == 3)//三種花色
            {
                return (tempCount.Any(n => n.Count == 2 || n.Count == 1));// [{K, 2}, {Ace, 2}, {Eight, 1}]

            }
            return false;

        }
        /// <summary>
        /// 檢查是不是一對
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public bool CheckPair()
        {
            if (Cards == null) throw new ArgumentNullException("沒有牌");

            Cards = Cards.OrderBy(n => n.CardRankNum).ToList();

            var temp = Cards.GroupBy(n => n.CardRankNum);
            var tempCount = temp.Select(n => new { CardRankNum = n.Key, Count = n.Count() });

            if (temp.Count() == 4)//四種花色
            {
                return tempCount.Any(n => n.Count == 2 || n.Count == 1);// [{K, 1}, {Ace, 2}, {Eight, 1}, {J, 1}]

            }
            return false;

        }
    }

}
