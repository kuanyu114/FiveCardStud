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
        List<CardsModel> Shuffing();
        string GetPokerHands(List<CardsModel> cards);
    }
}
