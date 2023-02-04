using FiveCardStud.Interface;
using FiveCardStud.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveCardStud
{
    public static class CardsFactory
    {
        private static readonly Dictionary<string, ICardGame> _CardGame;
        static CardsFactory() 
        {
            _CardGame = new Dictionary<string, ICardGame>();
            //_CardGame.Add("FiveCardStudGame", new FiveCardStudGame());
        }
        public static ICardGame GetCardGame(string gameName)
        {
            var game = _CardGame.Where(x => x.Key.Equals(gameName))
            .Select(x => x.Value)
            .FirstOrDefault();
            return game ?? throw new Exception("沒有這遊戲");
        }
    }
}
