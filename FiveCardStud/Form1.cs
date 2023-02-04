using FiveCardStud.Enums;
using FiveCardStud.Models;
using FiveCardStud.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FiveCardStud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<ComboBox> SuitBox;
        List<ComboBox> RankBox;
        List<CardsModel> allCards;
        private void Form1_Load(object sender, EventArgs e)
        {
            SuitBox = new List<ComboBox>() { Suit1, Suit2, Suit3, Suit4, Suit5 };
            RankBox = new List<ComboBox>() { Rank1, Rank2, Rank3, Rank4, Rank5 };
            for (int i = 0; i < 5; i++)
            {
                List<string> list = new List<string>();
                foreach (var item in Enum.GetNames(typeof(Suit)))
                {
                    list.Add(item);
                }
                SuitBox[i].DataSource = list;
                SuitBox[i].SelectedIndex= -1;
            }
            for (int i = 0; i < 5; i++)
            {
                List<string> list = new List<string>();
                foreach (var item in Enum.GetNames(typeof(Rank)))
                {
                    list.Add(item);
                }
                RankBox[i].DataSource = list;
                RankBox[i].SelectedIndex = -1;
            }
            //allCards = new CardsModel().GetFullDeck();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var cards = CardsFactory.GetCardGame("FiveCardStudGame").Shuffing(5);
            var cards = new FiveCardStudGame().Shuffing(5);
            for (int i = 0; i < 5; i++)
            {
                SuitBox[i].SelectedItem = cards[i].CardSuit;
                RankBox[i].SelectedItem = cards[i].CardRank;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cards = new List<CardsModel>();
            for (int i = 0; i < 5; i++)
            {
                var item = new CardsModel();
                item.CardSuit = SuitBox[i].SelectedItem?.ToString();
                item.CardRank = RankBox[i].SelectedItem?.ToString();
                item.CardRankNum = RankBox[i].SelectedIndex + 1;
                item.CardSuitNum = SuitBox[i].SelectedIndex;
                cards.Add(item);
            }
            
            if (cards.GroupBy(n => new { n.CardSuitNum, n.CardRankNum }).Count() < 5)
            {
                MessageBox.Show("選擇的卡有重複");
                return;
            }
            if(SuitBox.Any(n=>n.SelectedIndex ==-1)|| RankBox.Any(n => n.SelectedIndex == -1))
            {
                MessageBox.Show("選擇的卡有空白");
                return;
            }
            //var cardsResult = CardsFactory.GetCardGame("FiveCardStudGame").GetPokerHands(cards);
            var cardsResult = new FiveCardStudGame().GetPokerHands(cards);
            MessageBox.Show("你手上的卡是"+cardsResult);
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (allCards.Count() <3)
            {
                MessageBox.Show("洗牌");
                //allCards = CardsFactory.GetCardGame("FiveCardStudGame").ShuffingFullDeck();
                allCards = new FiveCardStudGame().ShuffingFullDeck();
            }
            for (int i = 0; i < 5; i++)
            {
                SuitBox[i].SelectedItem = allCards[i].CardSuit;
                RankBox[i].SelectedItem = allCards[i].CardRank;
            }
            allCards.RemoveRange(0, 5);
        }
    }
}