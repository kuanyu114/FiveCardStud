using FiveCardStud.Models;
using FiveCardStud.Service;
using FiveCardStud.Enums;
namespace FiveCardStudTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckFlushWithAKTest()
        {
            var cards = new List<CardsModel>(); 
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 10,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 11,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 12,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 13,
                CardSuitNum = 1
            });

            bool result = new FiveCardStudGame().CheckFlush(cards);
            Assert.IsTrue(result);
        }
        [Test]
        public void CheckFlushWithAKFalseTest()
        {
            var cards = new List<CardsModel>();
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 9,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 11,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 12,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 13,
                CardSuitNum = 1
            });

            bool result = new FiveCardStudGame().CheckFlush(cards);
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckFlushTest()
        {
            var cards = new List<CardsModel>();
            cards.Add(new CardsModel()
            {
                CardRankNum = 9,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 10,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 11,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 12,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 13,
                CardSuitNum = 1
            });

            bool result = new FiveCardStudGame().CheckFlush(cards);
            Assert.IsTrue(result);
        }
        [Test]
        public void CheckFlushFalseTest()
        {
            var cards = new List<CardsModel>();
            cards.Add(new CardsModel()
            {
                CardRankNum = 6,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 6,
                CardSuitNum = 2
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 11,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 12,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 13,
                CardSuitNum = 1
            });

            bool result = new FiveCardStudGame().CheckFlush(cards);
            Assert.IsFalse(result);
        }
        [Test]
        public void GetPokerHands4kindTest()
        {
            var cards = new List<CardsModel>();
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 2
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 0
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 3
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 13,
                CardSuitNum = 1
            });

            string result = new FiveCardStudGame().GetPokerHands(cards);
            Assert.IsTrue(result == "�|��");
        }
        [Test]
        public void GetPokerHands3kindTest()
        {
            var cards = new List<CardsModel>();
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 2
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 0
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 5,
                CardSuitNum = 3
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 13,
                CardSuitNum = 1
            });

            string result = new FiveCardStudGame().GetPokerHands(cards);
            Assert.IsTrue(result == "�T��");
        }
        [Test]
        public void GetPokerHandsFullHouseTest()
        {
            var cards = new List<CardsModel>();
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 2
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 0
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 5,
                CardSuitNum = 3
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 5,
                CardSuitNum = 1
            });

            string result = new FiveCardStudGame().GetPokerHands(cards);
            Assert.IsTrue(result == "��Ī");
        }
        [Test]
        public void GetPokerHandsTwoPairsTest()
        {
            var cards = new List<CardsModel>();
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 2
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 13,
                CardSuitNum = 0
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 5,
                CardSuitNum = 3
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 5,
                CardSuitNum = 1
            });

            string result = new FiveCardStudGame().GetPokerHands(cards);
            Assert.IsTrue(result == "���");
        }
        [Test]
        public void GetPokerHandsOnePairsTest()
        {
            var cards = new List<CardsModel>();
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 2
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 13,
                CardSuitNum = 0
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 12,
                CardSuitNum = 3
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 10,
                CardSuitNum = 1
            });

            string result = new FiveCardStudGame().GetPokerHands(cards);
            Assert.IsTrue(result == "�@��");
        }
        [Test]
        public void GetPokerHandsHighCardTest()
        {
            var cards = new List<CardsModel>();
            cards.Add(new CardsModel()
            {
                CardRankNum = 1,
                CardSuitNum = 1
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 5,
                CardSuitNum = 2
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 13,
                CardSuitNum = 0
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 12,
                CardSuitNum = 3
            });
            cards.Add(new CardsModel()
            {
                CardRankNum = 10,
                CardSuitNum = 1
            });

            string result = new FiveCardStudGame().GetPokerHands(cards);
            Assert.IsTrue(result == "���P");
        }
    }
}