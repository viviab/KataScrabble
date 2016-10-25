using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    public class Bag
    {

        public Dictionary<char, int> Letters = new Dictionary<char, int>()
            {
                {'A', 9},
                {'B', 2},
                {'C', 2},
                {'D', 4},
                {'E', 12},
                {'F', 2},
                {'G', 3},
                {'H', 2},
                {'I', 9},
                {'J', 1},
                {'K', 1},
                {'L', 4},
                {'M', 2},
                {'N', 6},
                {'O', 8},
                {'P', 2},
                {'Q', 1},
                {'R', 6},
                {'S', 4},
                {'T', 6},
                {'U', 4},
                {'V', 2},
                {'W', 2},
                {'X', 1},
                {'Y', 2},
                {'Z', 1},
                {'_', 2}
                
            };

        public string GetRemaining()
        {
            var str = Letters
                    .OrderByDescending(s => s.Value)
                    .ThenBy(s => s.Key)
                    .GroupBy(p=> p.Value, p=> p.Key)
                    .Select(s => string.Format("{0}: {1}", s.Key, string.Join(", " , s)));

            return string.Join("\n", str);

        }

        public void GetLetter(char letter)
        {
            if (Letters[letter]==0)
                throw new Exception(string.Format("Invalid input. More {0}'s have been taken from the bag than possible.", letter));

            Letters[letter]--;
        }

    
    }
}
