using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1551_SeaAnimal_Game
{
    class PlayerGetSetScore : ParentUserAndPGSS
    {
        public int Score
        {
            set
            {
                score = value;
            }
            get
            {
                return score;
            }
        }
    }
}
