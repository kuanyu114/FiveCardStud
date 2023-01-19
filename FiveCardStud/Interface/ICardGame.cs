using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiveCardStud.Models;

namespace FiveCardStud.Interface
{
    public interface ICardGame
    {
        List<CardsModel> Shuffing(int number);
        List<CardsModel> ShuffingFullDeck();
        string GetPokerHands(List<CardsModel> cards);
    }
}
