using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    public class HasteBuff
    {
        public double duration = 0;
        public double cooldown = 0;
        public double percentage = 0;
        public double effectivePercentage = 0;
        public double uptime = 0;

        public HasteBuff(double duration = 0,
                            double cooldown = 0,
                            double percentage = 0)
        {
            this.duration = duration;
            this.cooldown = cooldown;
            this.percentage = percentage;
            this.effectivePercentage = percentage;
            this.uptime = Player.CalculateUptimeFactor(1, 1000, cooldown, duration);
        }

    }
}
