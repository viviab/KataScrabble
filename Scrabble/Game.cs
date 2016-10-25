using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    public class Game
    {

        public string Play(string words)
        {
            var bag = new Bag();

            foreach (var word in words)
            {
                bag.GetLetter(word);    
            }
            
            return bag.GetRemaining();
        }
    }
}
