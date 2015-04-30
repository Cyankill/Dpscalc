using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    public class RaceBonus
    {
        public double attackpowerFlat;
        //(Level*4)+2 = Attack power gained.
        public double spelldamageFlat;
        //(Level*2)+3 = Spell damage gained.

        public double percentOfManaPer5;
        public double energyPer5;
        public double runicPowerPer5;

        public int gunCritPercent;
        public int bowCritPercent;
        public int throwingCritPercent;

        public int maceExpertise;
        public int sword1HExpertise;
        public int sword2HExpertise;
        public int fistExpertise;
        public int axeExpertise;
        public int daggerExpertise;

        public int intelectPercent;
        public int spiritPercent;

        public HasteBuff hastePercent;

        public int hitFlatPercent;

        public int petDamagePercent;

        public int damagePercentAgainstBeast;

        public RaceBonus(double attackpowerFlat = 0,
                            double spelldamageFlat = 0,
                            double percentOfManaPer5 = 0,
                            double energyPer5 = 0,
                            double runicPowerPer5 = 0,
                            int gunCritPercent = 0,
                            int bowCritPercent = 0,
                            int throwingCritPercent = 0,
                            int maceExpertise = 0,
                            int sword1HExpertise = 0,
                            int sword2HExpertise = 0,
                            int fistExpertise = 0,
                            int axeExpertise = 0,
                            int daggerExpertise = 0,
                            int intelectPercent = 0,
                            int spiritPercent = 0,
                            HasteBuff hastePercent = default(HasteBuff),
                            int hitFlatPercent = 0,
                            int petDamagePercent = 0,
                            int damagePercentAgainstBeast = 0)
        {
            this.attackpowerFlat = attackpowerFlat;
            this.spelldamageFlat = spelldamageFlat;
            this.percentOfManaPer5 = percentOfManaPer5;
            this.energyPer5 = energyPer5;
            this.runicPowerPer5 = runicPowerPer5;
            this.gunCritPercent = gunCritPercent;
            this.bowCritPercent = bowCritPercent;
            this.throwingCritPercent = throwingCritPercent;
            this.maceExpertise = maceExpertise;
            this.sword1HExpertise = sword1HExpertise;
            this.sword2HExpertise = sword2HExpertise;
            this.fistExpertise = fistExpertise;
            this.axeExpertise = axeExpertise;
            this.daggerExpertise = daggerExpertise;
            this.intelectPercent = intelectPercent;
            this.spiritPercent = spiritPercent;
            this.hastePercent = hastePercent;
            this.hitFlatPercent = hitFlatPercent;
            this.petDamagePercent = petDamagePercent;
            this.damagePercentAgainstBeast = damagePercentAgainstBeast;
        }

        public static RaceBonus getBonus(Race.Name race){
            switch (race)
            {
                case Race.Name.None:
                    return new RaceBonus();
                case Race.Name.Human:
                    return new RaceBonus(spiritPercent: 3, maceExpertise: 3, sword1HExpertise: 3, sword2HExpertise: 3);
                case Race.Name.Dwarf:
                    return new RaceBonus(gunCritPercent: 1, maceExpertise: 3);
                case Race.Name.NightElf:
                    return new RaceBonus();
                case Race.Name.Gnome:
                    return new RaceBonus(intelectPercent: 5, sword1HExpertise: 3);
                case Race.Name.Draenei:
                    return new RaceBonus(hitFlatPercent: 1);
                case Race.Name.Orc:
                    return new RaceBonus(spelldamageFlat: 20.375, attackpowerFlat: 40.25, petDamagePercent: 5, fistExpertise: 5, axeExpertise: 5);
                case Race.Name.Undead:
                    return new RaceBonus();
                case Race.Name.Tauren:
                    return new RaceBonus();
                case Race.Name.Troll:
                    return new RaceBonus(hastePercent: new HasteBuff(10,180,20), damagePercentAgainstBeast: 5, throwingCritPercent: 1, bowCritPercent: 1);
                case Race.Name.BloodElf:
                    return new RaceBonus(percentOfManaPer5: 0.25);
            }
            return getBonus(Race.Name.None);
        }

    }
}
