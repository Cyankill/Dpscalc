using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    public class Race
    {
        public Name name = Name.None;
        public enum Name
        {
            None,
            Human,
            Dwarf,
            NightElf,
            Gnome,
            Draenei,
            Orc,
            Undead,
            Tauren,
            Troll,
            BloodElf
        }

        public Race()
        {
            name = Name.None;
        }

        public RaceBonus getRaceBonus()
        {
            return RaceBonus.getBonus(name);
        }

    }
}
