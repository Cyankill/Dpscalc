using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    public class Spell
    {
        public SpellName spellname = SpellName.None;
        public SpellTalentSchool talentSchool = new SpellTalentSchool(SpellTalentSchoolName.None);
        public SpellSchool directSpellSchool = new SpellSchool(SpellSchoolName.None);
        public SpellSchool DoTSpellSchool = new SpellSchool(SpellSchoolName.None);
        public double duration = 0;
        public bool hasteAffectsDuration = false;
        public double baseCasttime = 0;
        public double flatCasttimeReduction = 0;
        public double percentualCasttimeReduction = 0;
        public double hasteFactor = 1;
        public double effectiveCasttime = 0;
        public double cooldown = 0;
        public double effectiveCooldown = 0;
        public double manaCostOfBaseMana = 0;
        public double manaCostFactor = 1;
        public double requiredBuffUptimeFactor = 1;
        public Reagent reagent = Reagent.None;

        public double averageDirectBaseDamage = 0;
        public double averageDoTBaseDamage = 0;
        public double SPDirectScaling = 0;
        public double SPDoTScaling = 0;
        public double APDirectScaling = 0;
        public double APDoTScaling = 0;
        public bool channeled = false;
        public double numOfTicks = 1;

        public double directDamageFactor = 1;
        public double DoTDamageFactor = 1;

        public bool directCanCrit = true;
        public bool DoTCanCrit = false;
        public double directCritChance = 0;
        public double DoTCritChance = 0;
        public double directCritDamageFactor = 1.5;
        public double DoTCritDamageFactor = 1.5;
        
        public Spell(SpellName spellname,
                            SpellTalentSchool talentSchool,
                            SpellSchool directSpellSchool = default(SpellSchool),
                            SpellSchool DoTSpellSchool = default(SpellSchool),
                            double duration = 0,
                            bool hasteAffectsDuration = false,
                            double baseCasttime = 0,
                            double flatCasttimeReduction = 0,
                            double percentualCasttimeReduction = 0,
                            double hasteFactor = 1,
                            double cooldown = 0,
                            double manaCostOfBaseMana = 0,
                            double manaCostFactor = 1,
                            double requiredBuffUptimeFactor = 1,
                            Reagent reagent = Reagent.None,
                            double averageDirectBaseDamage = 0,
                            double averageDoTBaseDamage = 0,
                            double SPDirectScaling = 0,
                            double SPDoTScaling = 0,
                            double APDirectScaling = 0,
                            double APDoTScaling = 0,
                            bool channeled = false,
                            int numOfTicks = 1,
                            double directDamageFactor = 1,
                            double DoTDamageFactor = 1,
                            bool directCanCrit = true,
                            bool DoTCanCrit = false,
                            double directCritChance = 0,
                            double DoTCritChance = 0,
                            double directCritDamageFactor = 1.5,
                            double DoTCritDamageFactor = 1.5)
        {
            this.spellname = spellname;
            this.talentSchool = talentSchool;
            this.directSpellSchool = directSpellSchool;
            this.duration = duration;
            this.hasteAffectsDuration = hasteAffectsDuration;
            this.baseCasttime = baseCasttime;
            this.flatCasttimeReduction = flatCasttimeReduction;
            this.percentualCasttimeReduction = percentualCasttimeReduction;
            this.effectiveCasttime = ((baseCasttime * (1 - (percentualCasttimeReduction / 100))) - flatCasttimeReduction) / hasteFactor;
            this.hasteFactor = hasteFactor;
            this.cooldown = cooldown;
            this.effectiveCooldown = cooldown;
            this.manaCostOfBaseMana = manaCostOfBaseMana;
            this.manaCostFactor = manaCostFactor;
            this.requiredBuffUptimeFactor = requiredBuffUptimeFactor;
            this.averageDirectBaseDamage = averageDirectBaseDamage;
            this.averageDoTBaseDamage = averageDoTBaseDamage;
            this.SPDirectScaling = SPDirectScaling;
            this.SPDoTScaling = SPDoTScaling;
            this.APDirectScaling = APDirectScaling;
            this.APDoTScaling = APDoTScaling;
            this.reagent = reagent;
            this.channeled = channeled;
            this.numOfTicks = numOfTicks;
            this.directDamageFactor = directDamageFactor;
            this.DoTDamageFactor = DoTDamageFactor;
            this.directCanCrit = directCanCrit;
            this.DoTCanCrit = DoTCanCrit;
            this.directCritChance = directCritChance;
            this.DoTCritChance = DoTCritChance;
            this.directCritDamageFactor = directCritDamageFactor;
            this.DoTCritDamageFactor = DoTCritDamageFactor;
        }

        public void applyGCD(double gcd)
        {
            if (baseCasttime < gcd)
                baseCasttime = gcd;
        }

        public void applyCastTimeFactor(double factor)
        {
            if (channeled)
            {
                baseCasttime /= factor;
                numOfTicks /= factor;
            }
            else
            {
                baseCasttime *= factor;
            }
        }

        public double uptimeFactor()
        {
            if (effectiveCooldown <= duration)
                return 1;
            return duration / effectiveCooldown;
        }

        public double manaCost(double baseMana, double mps = 0)
        {
            return (manaCostOfBaseMana * baseMana * manaCostFactor) - (effectiveCasttime * mps);
        }

        public List<Spell> getFracturedCasts(double gcd)
        {
            List<Spell> list = new List<Spell>();
            if (!channeled)
            {
                list.Add(this);
            }
            else
            {
                for (int i = 1; i <= numOfTicks; i++)
                {
                    double durationFactor = i / numOfTicks;
                    double timeTakeForITicks = durationFactor * duration;
                    if (timeTakeForITicks >= gcd)
                    {
                        //list.Add(new Spell();
                    }
                }
            }
            return list;
        }

        public double totalDamagePerCast(double spellpower)
        {
            return totalDirectDamagePerCast(spellpower) + totalDoTDamagePerCast(spellpower);
        }

        public double totalDoTDamagePerCast(double spellpower)
        {
            double totalDamage = averageDoTBaseDamage + (numOfTicks * SPDoTScaling * spellpower);
            return totalDamage * DoTDamageFactor * calculateCritFactor(DoTCanCrit, DoTCritChance, DoTCritDamageFactor);
        }

        public double totalDirectDamagePerCast(double spellpower)
        {
            double totalDamage = averageDirectBaseDamage + (SPDirectScaling * spellpower);
            return totalDamage * directDamageFactor * calculateCritFactor(directCanCrit, directCritChance, directCritDamageFactor);
        }

        public static double calculateCritFactor(bool canCrit, double critChance, double critDamageFactor)
        {
            if(!canCrit)
                return 1;
            double noncritPart = 1 - ((100 - critChance) / 100);
            double critPart = (critChance / 100) * critDamageFactor;
            return noncritPart + critPart;
        }

        public double getDPS(double spellpower = 0)
        {
            double DoTDamagePerSec = (totalDoTDamagePerCast(spellpower) / duration) * Math.Min(1, duration / effectiveCooldown);
            //double Dire
            return 0;
        }
    }
}
