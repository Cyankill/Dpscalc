using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    public class Player
    {
        public int baseMana = 0;
        public Race race = new Race();
        //STATS
        //RAIDBUFFS
        public RaidBuffs raidbuffs = new RaidBuffs();
        //PROCS
        public List<Proc> procs = new List<Proc>();
        //GENERAL STAST
        public double hitrating = 0;
        public double critrating = 0;
        public double hasterating = 0;

        //BASE STATS
        public double strength = 0;
        public double agility = 0;
        public double stamina = 0;
        public double intelect = 0;
        public double spirit = 0;

        //PHYSICAL
        public double armorpenetration = 0;
        public double baseSpeed = 1.00;
        //MELEE
        public double power = 0;
        public double expertiserating = 0;
        //RANGED
        public double rangedPower = 0;

        //SPELL
        public double spellPower = 0;
        public double manaregen = 0;

        //DEFENCES
        public double armor = 0;
        public double defence = 0;
        public double dodgerating = 0;
        public double parryrating = 0;
        public double blockrating = 0;
        public double blockvalue = 0;
        public double resillience = 0;

        //SETBONUSSES
        public bool t9_2PieceBonus = false; //10% pet crit. useless, already asuming 100% demonic pact buff uptime
        public bool t9_4PieceBonus = false; //10% immo, corr and UA dmg
        public bool t10_2PieceBonus = false; //5% SB, incin, SF and corr crit chance
        public bool t10_4PieceBonus = false; //15% chance on UA or immo tick to get 10% dmg for 15 sec
        public bool PvP_2PieceBonus = false; //100 resil +  29 sp
        public bool PvP_4PieceBonus = false; //-0.2 fear casttime + 88 sp

        //TARGET
        public int targetLevel = 83;
        public bool targetIsBeast = false;

        //TALENTS
        public Talent[, ,] talentTree = new Talent[3, 4, 11];

        public virtual double calculateDPS(int hitratingIncrease = 0,
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

        public double applyMinimumGCD(double gcd, double minimum = 1)
        {
            if (gcd < minimum)
                return minimum;
            return gcd;
        }

        public double applySpellHitrating(double dps, double hitrating, double hitPercentBonus)
        {
            double chanceToHit = 96; //asuming lv 80 target to start with
            switch (targetLevel)
            {
                case 76:
                    chanceToHit = 100;
                    break;
                case 77:
                    chanceToHit = 99;
                    break;
                case 78:
                    chanceToHit = 98;
                    break;
                case 79:
                    chanceToHit = 97;
                    break;
                case 80:
                    chanceToHit = 96;
                    break;
                case 81:
                    chanceToHit = 95;
                    break;
                case 82:
                    chanceToHit = 94;
                    break;
                case 83:
                    chanceToHit = 83;
                    break;
                case 84:
                    chanceToHit = 72;
                    break;
                case 85:
                    chanceToHit = 61;
                    break;
            }
            chanceToHit += hitrating / 26.23;
            chanceToHit += hitPercentBonus;
            if (chanceToHit >= 100) return dps;
            return dps * (chanceToHit / 100);
        }

        public virtual bool statIsRelevant(Stat stat)
        {
            return false;
        }

        public virtual bool ClassPicked()
        {
            return false;
        }

        public virtual void addTalentPoint(int tree, int x, int y)
        {
            talentTree[tree,x,y].addPoint();
        }

        public virtual bool isValidRace()
        {
            return true;
        }

        public static double KGD(double x, double y, double gcd)
        {
            double max = x * y;
            for (double i = gcd; i * x < max; i += gcd)
            {
                if ((i * x) % y < gcd || (i * x) % y > -gcd)
                {
                    return i * x;
                }
            }
            return max;
        }

        //objects in the list have to be the same as the currentSpell object
        //cd of a dot = duration + refresh time
        public void updateEffectiveSpellCooldown(List<Spell> spellPriorityList, double gcd = 1.5)
        {
            double maxTime = listKGDCD(spellPriorityList, gcd);
            double timeLeft = maxTime;
            foreach (Spell s in spellPriorityList)
            {
                double timeTakenFactor = gcd / s.cooldown;
                double timeTaken = timeTakenFactor * timeLeft * (s.baseCasttime > gcd ? s.baseCasttime : gcd);
                if (timeLeft == 0)
                    break;
                double effectiveCDFactor = maxTime / timeLeft;
                s.effectiveCooldown = s.cooldown * effectiveCDFactor;
                timeLeft -= timeTaken;
            }
        }

        public double listKGDCD(List<Spell> spellList, double gcd = 1.5)
        {
            double max = 1;
            foreach (Spell s in spellList)
            {
                max *= s.cooldown;
            }
            for (double i = gcd; i < max; i += gcd)
            {
                bool found = true;

                foreach (Spell s in spellList)
                {
                    if (!(i % s.cooldown < 0.5 * gcd && i % s.cooldown - s.cooldown > 0.5 * -gcd))
                    {
                        found = false;
                    }
                }

                if (found)
                {
                    return i;
                }
            }
            return max;
        }

        public static double CalculateUptimeFactor(double procChance = 0.0, double procChancesPerSec = 0, double internalCooldown = 0, double buffDuration = 0)
        {
            double procsPerSec = procChance * procChancesPerSec;
            double secsPerProc = 1 / procsPerSec;
            double timeBetweenProcs = internalCooldown + secsPerProc;
            if (internalCooldown >= buffDuration)
            {
                double uptimeFactor = buffDuration / timeBetweenProcs;
                return uptimeFactor;
            }
            else
            {
                double chanceNoProcPerSec = (1 - procsPerSec);
                if (internalCooldown > 0)
                    chanceNoProcPerSec *= (internalCooldown + 1 / buffDuration + 1);
                double chanceNoProcPerDuration = Math.Pow(chanceNoProcPerSec, buffDuration);
                double uptime = 1 - chanceNoProcPerDuration;
                return uptime;
            }
        }

        public void updateEffectiveHastePercentage(List<HasteBuff> hasteBuffList, List<Spell> spellList) //needs some refining
        {
            double totalEffectiveHaste = 0;
            foreach (HasteBuff hastebuff in hasteBuffList)
            {
                foreach (Spell spell in spellList)
                {
                    totalEffectiveHaste += ((1 / spell.effectiveCooldown) * getEffectiveHastePercentageForSpell(hasteBuffList, hastebuff, spell));
                }
                double effectiveHaste = (hastebuff.uptime * totalEffectiveHaste) + ((1 - hastebuff.uptime) * hastebuff.percentage);
                hastebuff.effectivePercentage = effectiveHaste;
            }
        }

        public double getEffectiveHastePercentageForSpell(List<HasteBuff> hasteBuffList, HasteBuff current, Spell spell)
        {
            double maxPercentage = hasteToGCD(spell);
            double totalPercentage = 0;
            foreach (HasteBuff hastebuff in hasteBuffList)
            {
                totalPercentage += hastebuff.percentage;
            }
            if (maxPercentage > totalPercentage)
                return current.percentage;
            else
                return (maxPercentage / totalPercentage) * current.percentage;
        }

        public double hasteToGCD(Spell spell)
        {
            return (32.79 * 100) * ((spell.baseCasttime / 1) - 1);
        }

        public double procIncrease(Stat checkStat)
        {
            double increase = 0;
            foreach (Proc p in procs)
            {
                increase += p.getIncrease(checkStat);
            }
            return increase;
        }
    }
}
