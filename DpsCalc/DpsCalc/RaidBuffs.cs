using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    public class RaidBuffs
    {
        //armor debuff
        //major - 20%
        bool acidSpit = false; 
        bool exposeArmor = false;        
        bool sunderArmor = false;        
        //minor - 5%
        bool faerieFire = false;            
        bool sting = false;                 
        public double targetArmorFactor()
        {
            double armorFactor = 1;
            if (acidSpit || exposeArmor || sunderArmor)
            {
                armorFactor *= 0.8;
            }
            if (faerieFire || sting)
            {
                armorFactor *= 0.95;
            }
            return armorFactor;
        }

        //phisical vulnerability
        int BloodFrenzy = 0;
        //phisical damage buff
        bool Hysteria = false;
        public double phisicalDamageFactor()
        {
            double vulnerabilityFactor = 1 + (0.02 * BloodFrenzy);
            double HysteriaFactor = 1 + ((30 / 180) * 0.2); //check
            return vulnerabilityFactor * HysteriaFactor;
        }

        //melee haste buff
        bool ImprovedIcyTalons = false;
        bool Windfury = false;
        int ImprovedWindfuryTotem = 0;
        public double meleeHastePercent()
        {
            double meleeHaste = allHastePercent();
            if (ImprovedIcyTalons)
            {
                meleeHaste += 20;
            }
            else if (Windfury)
            {
                meleeHaste += 16 + (2 * ImprovedWindfuryTotem);
            }
            return meleeHaste + allHastePercent();
        }

        //melee crit buff
        bool LeaderOfThePack = false;
        bool Rampage = false;
        public double phisicalCritPercent()
        {
            return ((LeaderOfThePack || Rampage) ? 5 : 0) + critPercent();
        }

        //AttackPowerFlatBuff
        bool GBOM = false;
        int ImprovedBlessingOfMight = 0;
        bool BattleShout = false;
        int CommandingPressence = 0;
        public double attackpower()
        {
            double gbomTalentFactor = 1;
            switch (ImprovedBlessingOfMight)
            {
                case 0: gbomTalentFactor = 1; break;
                case 1: gbomTalentFactor = 1.12; break;
                case 2: gbomTalentFactor = 1.25; break;
            }
            double GBOMAP = 550 * gbomTalentFactor * (GBOM ? 1 : 0);
            double bsTalentFactor = 1 + (0.05 * CommandingPressence);
            double BSAP = 548 * bsTalentFactor * (BattleShout ? 1 : 0);
            return Math.Max(GBOMAP, BSAP);
        }

        //AttackPowerMultiplier
        int UnleashedRage = 0;
        bool TrueshotAura = false;
        int AbominationsMight = 0;
        public double attackPowerFactor()
        {
            double unleashedRagePercent = UnleashedRage > 0 ? 1 + (3 * UnleashedRage) : 0;
            double trueshotAuraPercent = TrueshotAura ? 10 : 0;
            double abominationsMightPercent = 2 * AbominationsMight;
            double apPercent = Math.Max(UnleashedRage, trueshotAuraPercent);
            apPercent = Math.Max(apPercent, abominationsMightPercent);
            return 1 + (apPercent / 100);
        }

        //ranged attack power buff
        int ImprovedHuntersMark = 0;
        public double rangedAttackpower()
        {
            double talentFactor = 1 + (ImprovedHuntersMark * 0.1);
            double huntersMarkAP = talentFactor * 500;
            return huntersMarkAP;
        }

        //improved bleed damage debuff
        int trauma = 0;
        bool mangle = false;
        public double bleedDamageFactor()
        {
            double traumaPercentage = 15 * trauma;
            double manglePercentage = (mangle ? 30 : 0);
            return 1 + (Math.Max(traumaPercentage, manglePercentage) / 100);
        }

        //spell haste buff
        bool WrathOfAir = false;
        public double spellHastePercent()
        {
            return allHastePercent() + (WrathOfAir ? 5 : 0);
        }

        //spell crit buff
        bool MoonkinAura = false;
        int ElementalOath = 0;
        //one target spell crit buff
        bool FocusMagic = false;
        //spell crit debuff
        int ImprovedScorch = 0;
        int WintersChill = 0;
        int ImprovedShadowBolt = 0;
        public double spellCritPercent()
        {
            double FM = FocusMagic ? 3 : 0;

            double ImprovedShadowBoltCrit = ImprovedShadowBolt > 0 ? 5 : 0;
            double ImprovedScorchCrit = ImprovedScorch > 0 ? 5 : 0;
            double WintersChillCrit = WintersChill > 0 ? 5 : 0;
            double DebuffCrit = Math.Max(ImprovedShadowBoltCrit, ImprovedScorchCrit);
            DebuffCrit = Math.Max(DebuffCrit, WintersChillCrit);

            double elementalOathCrit = ElementalOath > 0 ? 1 + (2 * ElementalOath) : 0;
            double moonkinAuraCrit = MoonkinAura ? 5 : 0;
            double auraCrit = Math.Max(elementalOathCrit, moonkinAuraCrit);

            return FM + DebuffCrit + auraCrit + critPercent();
        }

        //increased spell damage debuff
        bool CurseOfElements = false;
        int EarthAndMoon = 0;
        int EbonPlaguebringer = 0;
        public double spellDamagePercent()
        {
            double curseOfElementsPercent = CurseOfElements ? 13 : 0;
            double EbonPlaguebringerEarthAndMoonPercent = 0;
            switch (Math.Max(EarthAndMoon, EbonPlaguebringer))
            {
                case 0: EbonPlaguebringerEarthAndMoonPercent = 0; break;
                case 1: EbonPlaguebringerEarthAndMoonPercent = 4; break;
                case 2: EbonPlaguebringerEarthAndMoonPercent = 9; break;
                case 3: EbonPlaguebringerEarthAndMoonPercent = 13; break;
            }
            double spellDamagePercent = Math.Max(curseOfElementsPercent, EbonPlaguebringerEarthAndMoonPercent);
            return spellDamagePercent;
        }

        //spellpower minor
        bool Flametongue = false;
        int EnhanncingTotems = 0;
        bool TotemOfWrath = false;
        //spellpower major
        int DemonicPact = 0;
        int DemonicPactSourceSP = 0;
        bool playerIsSource = false;
        public double spellpower()
        {
            double spellpower = 0;
            double demonicPactFactor = 0.02 * DemonicPact;
            double demonicPactSP = demonicPactFactor * DemonicPactSourceSP * (playerIsSource ? 0 : 1);
            spellpower += demonicPactSP;
            if (TotemOfWrath)
            {
                spellpower += 280;
            }
            else if (Flametongue)
            {
                double talentFactor = 1 + (0.05 * EnhanncingTotems);
                spellpower += 144 * talentFactor;
            }
            return spellpower;
        }

        //spell hit chance debuff
        int Misery = 0;
        int ImprovedFaerieFire = 0;
        bool DraneiRacial = false;
        public double spellHitPercent()
        {
            return Math.Max(Misery, ImprovedFaerieFire) + (DraneiRacial ? 1 : 0);
        }

        //haste all types
        int ImprovedMoonkinAura = 0;
        int SwiftRetribution = 0;
        private double allHastePercent()
        {
            return Math.Max(ImprovedMoonkinAura, SwiftRetribution);
        }

        //damage all types
        int ArcaneEmpowerment = 0;
        int FerociousInspiration = 0;
        bool SanctifiedRetribution = false;
        private double allDamageFactor()
        {
            double allDmgPercent = 0;
            allDmgPercent = Math.Max(allDmgPercent, ArcaneEmpowerment);
            allDmgPercent = Math.Max(allDmgPercent, FerociousInspiration);
            allDmgPercent = Math.Max(allDmgPercent, 3 * (SanctifiedRetribution ? 1 : 0));
            return 1 + (allDmgPercent / 100);
        }

        //crit all types
        int HeartOfTheCrusader = 0;
        //bool TotemOfWrath = false;
        private double critPercent()
        {
            double totemofWrathCrit = TotemOfWrath ? 3 : 0;
            double heartOfTheCrusaderCrit = HeartOfTheCrusader;
            return Math.Max(totemofWrathCrit, heartOfTheCrusaderCrit);
        }

        //stat multiplier
        bool DrumsOfForgottenKings = false;
        bool GBOK = false;
        bool GBOS = false;
        private double allAttributeFactor()
        {
            double gbokFactor = GBOK ? 1.1 : 1;
            double drumsFactor = DrumsOfForgottenKings ? 1.08 : 1;
            return Math.Max(gbokFactor, drumsFactor);
        }
        public double intelectFactor()
        {
            return allAttributeFactor();
        }
        public double staminaFactor()
        {
            double gbosFactor = GBOS ? 1.1 : 1;
            return Math.Max(allAttributeFactor(), gbosFactor);
        }
        public double spiritFactor()
        {
            return allAttributeFactor();
        }
        public double strengthFactor()
        {
            double gbosFactor = GBOS ? 1.1 : 1;
            return Math.Max(allAttributeFactor(), gbosFactor);
        }
        public double agilityFactor()
        {
            return allAttributeFactor();
        }

        //flat stat add
        bool GiftOfTheWild = false;
        int ImprovedMarkOfTheWild = 0;
        bool ArcaneIntelect = false;
        bool felIntelligence = false;
        int felIntelligenceTalent = 0;
        bool PrayerOfFortitude = false;
        int ImprovedPowerWordFortitude = 0;
        bool PrayerOfSpirit = false;
        bool StrengthOfEarth = false;
        bool ManaSpring = false;
        int RestorativeTotems = 0;
        bool GBOW = false;
        int ImprovedBlessingOfWisdom = 0;
        bool HornOfWinter = false;
        bool ScrollOfFortitude = false;
        bool DrumsOfTheWild = false;
        bool CommandingShout = false;
        int ImprovedImp = 0;
        private double allAttributes()
        {
            if (GiftOfTheWild)
            {
                double ImprovedMarkOfTheWildFactor = 1 + (0.2 * ImprovedMarkOfTheWild);
                return 37 * ImprovedMarkOfTheWildFactor;
            }
            else if (DrumsOfTheWild)
            {
                return 37;
            }
            return 0;
        }
        public double intelect()
        {
            double talentFactor = 1 + (0.05 * felIntelligenceTalent);
            double felIntelligenceIntelect = 48 * talentFactor * (felIntelligence ? 1 : 0);
            double intelect = Math.Max((ArcaneIntelect ? 60 : 0), felIntelligenceIntelect);
            intelect += allAttributes();
            return intelect;
        }
        public double stamina()
        {
            double stamina = allAttributes();
            if (PrayerOfFortitude)
            {
                double talentFactor = 1 + (0.15 * ImprovedPowerWordFortitude);
                stamina += 165 * talentFactor;
            }
            else if (ScrollOfFortitude)
            {
                stamina += 165;
            }
            return stamina;
        }
        public double spirit()
        {
            double talentFactor = 1 + (0.05 * felIntelligenceTalent);
            double felIntelligenceSpirit = 64 * talentFactor;
            double spirit = allAttributes();
            spirit += Math.Max((PrayerOfSpirit ? 80 : 0), felIntelligenceSpirit);
            return spirit;
        }
        public double strength()
        {
            double strength = allAttributes();
            if (StrengthOfEarth)
            {
                double talentFactor = 1 + (0.05 * EnhanncingTotems);
                strength += talentFactor * 155;
            }
            else if (HornOfWinter)
            {
                strength += 155;
            }
            return strength;
        }
        public double agility()
        {
            double agility = allAttributes();
            if (StrengthOfEarth)
            {
                double talentFactor = 1 + (0.05 * EnhanncingTotems);
                agility += talentFactor * 155;
            }
            else if (HornOfWinter)
            {
                agility += 155;
            }
            return agility;
        }
        public double health()
        {
            double shoutTalentFactor = 1 + (0.05 * CommandingPressence);
            double healthFromShout = 2255 * shoutTalentFactor * (CommandingShout ? 1 : 0);
            double bloodPactTalentFactor = 1 + (0.1 * ImprovedImp);
            double healthFromBloodPact = 1330 * bloodPactTalentFactor;
            return Math.Max(healthFromBloodPact, healthFromShout);
        }
        public double manaregen()
        {
            double GBOWTalentFactor = 1 + (0.1 * ImprovedBlessingOfWisdom);
            double GBOWregen = GBOW ? GBOWTalentFactor * 92 : 0;
            double totemTalentFactor = 0;
            switch (RestorativeTotems)
            {
                case 0: totemTalentFactor = 1; break;
                case 1: totemTalentFactor = 1.07; break;
                case 2: totemTalentFactor = 1.12; break;
                case 3: totemTalentFactor = 1.20; break;
            }
            double totemRegen = 91 * totemTalentFactor * (ManaSpring ? 1 : 0);
            return Math.Max(totemRegen, GBOWregen);
        }
        bool replenishment = false;
        public double percentualManaregen()
        {
            double replanishementUptimeFactor = 1;
            return replenishment ? 1 * replanishementUptimeFactor : 0;
        }
        //percentual manacost reduction
        bool PowerInfusion = false;
        public double manaCostFactor()
        {
            if (PowerInfusion)
            {
                return 1 - (0.2 * (15 / 120));
            }
            return 1;
        }

        //haste buffs
        bool Bloodlust = false;
        public List<HasteBuff> hasteBuffs()
        {
            List<HasteBuff> list = new List<HasteBuff>();
            if (Bloodlust)
                list.Add(new HasteBuff(40, 600, 30));
            if (PowerInfusion)
                list.Add(new HasteBuff(15, 120, 20));
            return list;
        }

        //pushback reduction
        bool concentrationAura = false;
        public double pushbackReductionPercent()
        {
            return concentrationAura ? 35 : 0;
        }
    }
}
