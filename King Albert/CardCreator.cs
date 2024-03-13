using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_Albert
{
    public class CardCreator
    {
        Dictionary<char, Suit> keyValuePairs = new Dictionary<char, Suit>()
        {
            { 'c', Suit.Clubs },
            { 's', Suit.Spades },
            { 'd', Suit.Diamonds },
            { 'h', Suit.Hearts }
        };

        List<string> ranks = new()
        {   "2", "3","4","5","6","7","8","9", "10", "J", "Q", "K", "A"
        };

        public List<Card> CreateCards()
        {
            var cards = new List<Card>();

            var files = Directory.GetFiles("Cards");

            foreach (var fileStr in files)
            {
                string withoutExt = Path.GetFileNameWithoutExtension(fileStr);

                var suit = keyValuePairs[withoutExt[0]];
                int rank = ranks.IndexOf(fileStr[1..]);
                var image = Image.FromFile(fileStr);
                var card = new Card(suit, rank, image);

                cards.Add(card);
            }

            return cards;
        }
    }
}
