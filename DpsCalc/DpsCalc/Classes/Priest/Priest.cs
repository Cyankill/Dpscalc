using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    class Priest : Player
    {
        public override double calculateDPS(int hitratingIncrease = 0,
                                            int critratingIncrease = 0,
                                            int hasteratingIncrease = 0,
                                            int strengthIncrease = 0,
                                            int agilityIncrease = 0,
                                            int staminaIncrease = 0,
                                            int intelectIncrease = 0,
                                            int spiritIncrease = 0,
                                            int armorpenetrationIncrease = 0,
                                            int baseSpeedIncrease = 0,
                                            int powerIncrease = 0,
                                            int expertiseratingIncrease = 0,
                                            int rangedPowerIncrease = 0,
                                            int spellpowerIncrease = 0,
                                            int manaregenIncrease = 0)
        {
            return 0;
        }

        public override bool statIsRelevant(Stat stat)
        {
            switch (stat)
            {
                case Stat.Intelect:
                case Stat.Spirit:
                case Stat.Spellpower:
                case Stat.Hitrating:
                case Stat.Critrating:
                case Stat.Hasterating:
                case Stat.Manaregen:
                    return true;
            }
            return false;
        }

        public override bool ClassPicked()
        {
            return true;
        }

        public override bool isValidRace()
        {
            switch (race.name)
            {
                case Race.Name.None:
                case Race.Name.Human:
                case Race.Name.Dwarf:
                case Race.Name.NightElf:
                case Race.Name.Draenei:
                case Race.Name.Undead:
                case Race.Name.Troll:
                case Race.Name.BloodElf:
                    return true;
            }
            return false;
        }
    }
}
