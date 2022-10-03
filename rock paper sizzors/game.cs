using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace rock_paper_sizzors
{
    public class game
    {
        private Timer timer;
        public player Player1 { get; }
        public player Player2 { get; }

        public game(int money)
        {
            Player1 = new player(money);
            Player2 = new player(money);
            timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var p1 = Player1.GetState();
            var p2 = Player2.GetState();

            if(p1 != p2)
            {
                if (p1 == Playerstate.kámen)
                {
                   if(p2 == Playerstate.nůžky)
                   {
                        Player1.Win();
                        Player2.lose();
                   }
                    else
                    {
                        Player2.Win();
                        Player1.lose();
                    }
                       
                }
                else if (p1 == Playerstate.nůžky)
                {
                    if (p2 == Playerstate.kámen)
                    {
                        Player2.Win();
                        Player1.lose();
                    }
                    else
                    {
                        Player1.Win();
                        Player2.lose();
                    }

                }
                else
                {
                    if (p2 == Playerstate.nůžky)
                    {
                        Player2.Win();
                        Player1.lose();
                    }
                    else
                    {
                        Player1.Win();
                        Player2.lose();
                    }
                }
            }
            
        }

        public void Start()
        {
            timer.Start;
        }
    }
}
