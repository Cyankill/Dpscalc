using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    public class SpellTalentSchool
    {
        SpellTalentSchoolName name = SpellTalentSchoolName.None;
        public double damageFactor = 1;

        public SpellTalentSchool(SpellTalentSchoolName name)
        {
            this.name = name;
        }
    }
}
