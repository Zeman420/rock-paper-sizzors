using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_sizzors
{
    public class player
    {
        private Random random = new Random();
        public int Money { get; internal set; }

        public player(int money)
        {
            Money = money;

        }
        public Playerstate GetState()
        {
            int value = random.Next(0, 3);
            return (Playerstate)value;
        }
        public void Win()
        {
            Money++;
        }
        public void lose()
        {
            Money--;
        }
    }
    public enum Playerstate
    {
        kámen,
        nůžky,
        papír,
    }
}
