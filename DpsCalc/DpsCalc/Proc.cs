using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    public class Proc
    {
        List<Proc> effects = new List<Proc>();
        Stat stat = Stat.None;
        public double amount = 0;
        public double uptimeFactor = 0;
        public double getIncrease(Stat checkStat)
        {
            if (stat == checkStat)
            {
                return uptimeFactor * amount;
            }
            else
            {
                double increase = 0;
                foreach (Proc p in effects)
                {
                    increase += p.getIncrease(checkStat);
                }
                return increase;
            }
        }
    }
}
