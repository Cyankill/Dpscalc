using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    public class Talent
    {
        public int pointsSpend = 0;
        public int maxPointsSpend = 0;
        public Talent requiredTalent = default(Talent);
        public Talent requiredFor = default(Talent);
        public Talent(int pointsSpend = 0, int maxPointsSpend = 0, Talent requiredTalent = default(Talent))
        {
            this.pointsSpend = pointsSpend;
            this.maxPointsSpend = maxPointsSpend;
            this.requiredTalent = requiredTalent;
            if (requiredTalent != default(Talent))
            {
                requiredTalent.requiredFor = this;
            }
        }

        public bool hasUsedPoints()
        {
            return pointsSpend > 0;
        }

        public bool hasMaxPoints(){
            return pointsSpend == maxPointsSpend;
        }

        public void addPoint()
        {
            if((requiredTalent != default(Talent) && requiredTalent.hasMaxPoints()) || requiredTalent == default(Talent))
            {
                pointsSpend++;
                if (pointsSpend > maxPointsSpend)
                    pointsSpend = maxPointsSpend;
            }
        }

        public void removePoint()
        {
            if ((requiredFor != default(Talent) && !requiredFor.hasUsedPoints()) || requiredFor == default(Talent))
            {
                pointsSpend--;
                if (pointsSpend < 0)
                    pointsSpend = 0;
            }
        }

    }
}
