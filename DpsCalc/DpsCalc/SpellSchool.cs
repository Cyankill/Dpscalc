using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    public class SpellSchool
    {
        SpellSchoolName name = SpellSchoolName.None;
        public double damageFactor = 1;

        public SpellSchool()
        {
            this.name = SpellSchoolName.None;
        }

        public SpellSchool(SpellSchoolName name = SpellSchoolName.None)
        {
            this.name = name;
        }
    }
}
