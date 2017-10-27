using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCryptic
{
    class Delay
    {
        private TimeSpan delayRate;
        private TimeSpan prevCallTime;

        public Delay(float rate)
        {
            delayRate = TimeSpan.FromSeconds(rate);
            prevCallTime = TimeSpan.FromSeconds(0.0f);
        }
        
        public void SetDelay(float rate)
        {
            delayRate = TimeSpan.FromSeconds(rate);
        }

        public  bool TimerDone(GameTime g)
        {
            if(g.TotalGameTime - prevCallTime > delayRate)
            {
                prevCallTime = g.TotalGameTime;
                return true;
            }
            return false;
        }   

    }
}
