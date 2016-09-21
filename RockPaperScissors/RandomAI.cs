using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer
    {
        public int NextMove()
        {
            //  0 for rock, 1 for paper, and 2 for scissors.
            //  Randomly generate response
            Random rand = new Random(); // calls built in Random method
            return rand.Next(3);        // calls overload of random for next
        }

        public void SaveResult(int myMove, int otherMove)
        {
            // no need to save result
        }
    }
}
