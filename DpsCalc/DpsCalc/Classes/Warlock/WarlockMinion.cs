using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    class WarlockMinion
    {
        public Minion kind = Minion.None;

        public double masterStamina = 0;
        public double masterIntelect = 0;
        public double masterSpellPower = 0;
        public double masterCrit = 0;
        public double masterArmor = 0;

        //talents
        //affli
        public int improvedFelhunter = 0;
        //demo
        public int improvedImp = 0;
        public int felSynergy = 0;
        public int demonicBrutality = 0;
        public int felVitality = 0;
        public int unholyPower = 0;
        public int manaFeed = 0;
        public int masterDemonologist = 0;
        public int demonicEmpowerment = 0;
        public int demonicTactics = 0;
        public int improvedDemonicTactics = 0;
        public int summonFelguard = 0;
        public int nemesis = 0;

        //destro
        public int demonicPower = 0;
        public int ruin = 0;

        public bool glyphOfFelguard = false;
        public bool glyphOfVoidwalker = false;
        public bool glyphOfImp = false;

        //stats
        int baseStamina = 0;
        int baseIntelect = 0;
        int baseAttackPower = 0;
        int baseSpellPower = 0;
        int baseArmor = 0;

        public int stamina = 0;
        public int intelect = 0;
        public int attackPower = 0;
        public int spellPower = 0;
        public int armor = 0;           //scaling: 35% of lock armor

        int strength;
        int agility;
        int spirit;
        int damageMin;
        int damageMax;
        double attackSpeed;
        double dmgpersec;

        public WarlockMinion(Minion k = Minion.None, int str = 0, int agi = 0, int sta = 0, int intel = 0, int spi = 0, int ap = 0, int dmgMin = 0, int dmgMax = 0, double atkspeed = 1.00, double dps = 0, int sp = 0, int ar = 0)
        {
            kind = k;
            strength = str;
            agility = agi;
            baseStamina = sta;
            baseIntelect = intel;
            spirit = spi;
            baseAttackPower = ap;
            damageMin = dmgMin;
            damageMax = dmgMax;
            attackSpeed = atkspeed;
            dmgpersec = dps;
            baseSpellPower = sp;
            baseArmor = ar;
        }

        public void change(WarlockMinion p)
        {
            kind = p.kind;
            strength = p.strength;
            agility = p.agility;
            baseStamina = p.baseStamina;
            baseIntelect = p.baseIntelect;
            spirit = p.spirit;
            baseAttackPower = p.baseAttackPower;
            damageMin = p.damageMin;
            damageMax = p.damageMax;
            attackSpeed = p.attackSpeed;
            dmgpersec = p.dmgpersec;
            baseSpellPower = p.baseSpellPower;
            baseArmor = p.baseArmor;
        }

        public double getDPS(){
            if (felSynergy == 0)
                return 0;
            double unholyPowerFactor = 1 + (0.04 * unholyPower);
            double critDamageIncreaseFactor = 0.5 + (0.1 * ruin);
            double talentsCritChance = (2 * demonicTactics) + ((improvedDemonicTactics * 0.1 * masterCrit)/45.91);
            double meleeCritChance = (intelect / 144) + talentsCritChance;
            double spellCritChance = (intelect / 144) + ((kind == Minion.Imp || kind == Minion.Succubus) ? 5 : 0) + talentsCritChance;
            double demonicEmpowermentCD = 60 * (1 - (0.1 * nemesis));
            double demonicEmpowermentImpCritIncrease = demonicEmpowerment > 0 ? (30 / demonicEmpowermentCD) * 20 : 0;
            spellCritChance += kind == Minion.Imp ? demonicEmpowermentImpCritIncrease : 0;
            double demonicEmpowermentFelguardASIncrease = demonicEmpowerment > 0 ? (15 / demonicEmpowermentCD) * 20 : 0;
            double demonicEmpowermentFelguardASFactor = 1 - (demonicEmpowermentFelguardASIncrease / 100);
            double masterDemonologistCritIncrease = masterDemonologist;
            double masterDemonologistDamageFactor = 1 + (0.01 * masterDemonologist);
            double meleeCritFactor = 1 + ((meleeCritChance / 100) * critDamageIncreaseFactor);
            double spellCritFactor = 1 + ((spellCritChance / 100) * critDamageIncreaseFactor);
            
            
            if (manaFeed > 0)
            {
                switch (kind)
                {
                    case Minion.Imp:
                        double glyphOfImpFactor = glyphOfImp ? 1.2 : 1;
                        double improvedImpFactor = 1 + (0.1 * improvedImp);
                        double fireboltCastTime = 2.5 - (0.25 * demonicPower);
                        return ((((277 + 310) / 2) + (0.7142 * getSpellPower())) * glyphOfImpFactor * improvedImpFactor * unholyPowerFactor * masterDemonologistDamageFactor * spellCritFactor) / fireboltCastTime;
                    case Minion.Felhunter:
                        return (((((98 + 138) / 2) + (0.4290 * getSpellPower())) * 1.3 * spellCritFactor) / (6 - (2 * improvedFelhunter))) + ((0.0571 * getAttackPower() * unholyPowerFactor * meleeCritFactor) / attackSpeed);
                    case Minion.Voidwalker:
                        return (0.0614 * getAttackPower() * unholyPowerFactor * meleeCritFactor) / attackSpeed;
                    case Minion.Succubus:
                        double lashOfPainCD = 12 - (3 * demonicPower);
                        return (((((248 + 249) / 2) + (0.4290 * getSpellPower())) / lashOfPainCD) * masterDemonologistDamageFactor * spellCritFactor) + ((0.075 * getAttackPower() * unholyPowerFactor * meleeCritFactor) / attackSpeed);
                    case Minion.Felguard:
                        return ((((256 + (0.1429 * getAttackPower())) / 6) * spellCritFactor) + ((0.0714 * getAttackPower() * unholyPowerFactor * meleeCritFactor) / (attackSpeed * demonicEmpowermentFelguardASFactor))) * masterDemonologistDamageFactor;
                    case Minion.None:
                        return 0;
                }
            }
            else
            {
                switch (kind)
                {
                    case Minion.Imp: 
                        return 0;
                    case Minion.Felhunter:
                        return (0.0571 * getAttackPower() * unholyPowerFactor) / attackSpeed;
                    case Minion.Voidwalker:
                        return (0.0614 * getAttackPower() * unholyPowerFactor) / attackSpeed;
                    case Minion.Succubus:
                        return (0.075 * getAttackPower() * unholyPowerFactor) / attackSpeed;
                    case Minion.Felguard:
                        return (0.0714 * getAttackPower() * unholyPowerFactor) / attackSpeed;
                    case Minion.None:
                        return 0;
                }
            }
            return 0;
        }

        public int getStamina()
        {
            if (kind == Minion.None)
            {
                return 0;
            }
            else
            {
                double stam = baseStamina + (0.3 * masterStamina);
                //apply raidwide buffs
                double felVitalityFactor = 1 + (felVitality * 0.05);
                stam *= felVitalityFactor;
                if(kind == Minion.Voidwalker && glyphOfVoidwalker)
                    stam *= 1.2; //TODO: check percentage
                return (int) stam;
            }
        }

        public int getIntelect()
        {
            if (kind == Minion.None)
            {
                return 0;
            }
            else
            {
                double intel = baseIntelect + (0.3 * masterIntelect);
                //apply raidwide buffs
                double felVitalityFactor = 1 + (felVitality * 0.05);
                intel *= felVitalityFactor;
                return (int) intel;
            }
        }

        public int getAttackPower()
        {
            if(kind == Minion.None)
                return 0;
            double ap = (baseAttackPower + (0.57 * masterSpellPower));
            if (kind == Minion.Felguard)
            {
                double demonicBrutalityFactor = 1.5 + (0.1 * demonicBrutality);
                ap *= demonicBrutalityFactor;
                double demonicFrenzyFactor = glyphOfFelguard ? 1.2 : 1;
                ap *= demonicFrenzyFactor;
            }
            //apply raidwide buffs
            return (int)ap;
        }
        public int getSpellPower()
        {
            if(kind==Minion.None)
                return 0;
            double sp = (baseSpellPower + (0.15 * masterSpellPower));
            //apply raidwide buffs
            return (int)sp;
        }
    }
}
