using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    class Hunter : Player
    {
        //TALENTS
        //BEAST MASTERY
        public int improvedAspectOfTheHawk = 0;
        public int focusedFire = 0;
        public int aspectMastery = 0;
        public int unleasedFury = 0;
        public int ferocity = 0;
        public int bestialDiscipline = 0;
        public int animalHandler = 0;
        public int frenzy = 0;
        public int ferociousInspiration = 0;
        public int bestialWrath = 0;
        public int catlikeReflexes = 0;
        public int invigoration = 0;
        public int serpentsSwiftness = 0;
        public int longevity = 0;
        public int theBeastWithin = 0;
        public int CobraStrikes = 0;
        public int kindredSpirits = 0;
        public int beastMastery = 0;

        //MARKSMANSHIP
        public int focusedAim = 0;
        public int lethalShots = 0;
        public int carefulAim = 0;
        public int improvedHuntersMark = 0;
        public int MortalShots = 0;
        public int goForTheThroat = 0;
        public int improvedStings = 0;
        public int efficiency = 0;
        public int improvedArcaneShot = 0;
        public int aimedShot = 0;
        public int rapidKilling = 0;
        public int barrage = 0;
        public int combactExperience = 0;
        public int rangedWeaponSpecialization = 0;
        public int piercingShots = 0;
        public int trueshotAura = 0;
        public int improvedBarrage = 0;
        public int masterMarksman = 0;
        public int rapidRecuperation = 0;
        public int wildQuiver = 0;
        public int silencingShot = 0;
        public int improvedSteadyShot = 0;
        public int markedForDeath = 0;
        public int chimeraShot = 0;

        //SURVIVAL
        public int improvedTracking = 0;
        public int savageStrikes = 0;
        public int trapMastery = 0;
        public int survivalInstincts = 0;
        public int survivalist = 0;
        public int TNT = 0;
        public int lockAndLoad = 0;
        public int hunterVsWild = 0;
        public int killerInstinct = 0;
        public int lightningReflexes = 0;
        public int resourcefulness = 0;
        public int exposeWeakness = 0;
        public int wyvernSting = 0;
        public int thrillOfTheHunt = 0;
        public int masterTactician = 0;
        public int noxiousStings = 0;
        public int blackArrow = 0;
        public int sniperTraining = 0;
        public int huntingParty = 0;
        public int explosiveShot = 0;

        //GLYPHS
        public bool glyphOFAimedShot = false;           //Reduce cd by 2 sec
        public bool glyphOfArcaneShot = false;          //refund 20% man cost shot if a sting active
        public bool glyphOfTheBeast = false;            //2% ap bonus pet and owner for aspect of the beast
        public bool glyphOfBestialWrath = false;        //reduce cd by 20sec
        public bool glyphOfChimeraShot = false;         //reduce cd by 1 sec
        public bool glyphOfExplosiveShot = false;       //increase crit of shot by 4%
        public bool glyphOfExplosiveTrap = false;       //trap can crit
        public bool glyphOfHuntersMark = false;         //20% extra AP from hunter mark
        public bool glyphOfImmolationTrap = false;      //reduce duration by 6 sec, increase damage by 100%
        public bool glyphOfTheHawk = false;             //increase haste bonus of improved aspect of the hawk by 6%
        public bool glyphOfKillshot = false;            //reduce cd by 6 sec
        public bool glyphOfMultishot = false;           //reduce ced by 1 sec
        public bool glyphOfRapidFire = false;           //increase haste bonus by 8%
        public bool glyphOfSerpentSting = false;        //increase duration by 6 sec
        public bool glyphOfSteadyShot = false;          //incrtease damage dealt by 6% if sting active
        public bool glyphOfTrueshotAura = false;        //increase crit chance from aimed shot by 10% if trueshot aura active

        //PET
        //BASE STATS
        public static HunterPet none = new HunterPet(Pet.None, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1.00, 0, 0);
        public HunterPet Bat = new HunterPet(CunPet.Bat, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Bear = new HunterPet(TenaPet.Bear, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet BirdOfPrey = new HunterPet(CunPet.BirdOfPrey, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Boar = new HunterPet(TenaPet.Boar, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet CarrionBird = new HunterPet(FeroPet.CarrionBird, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Cat = new HunterPet(FeroPet.Cat, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Chimaera = new HunterPet(CunPet.Chimaera, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet CoreHound = new HunterPet(FeroPet.CoreHound, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Crab = new HunterPet(TenaPet.Crab, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Crocolisk = new HunterPet(TenaPet.Crocolisk, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Devilsaur = new HunterPet(FeroPet.Devilsaur, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Dragonhawk = new HunterPet(CunPet.Dragonhawk, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Gorillla = new HunterPet(TenaPet.Gorillla, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Hyena = new HunterPet(FeroPet.Hyena, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet NetherRay = new HunterPet(CunPet.NetherRay, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Moth = new HunterPet(FeroPet.Moth, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Raptor = new HunterPet(FeroPet.Raptor, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Ravager = new HunterPet(CunPet.Ravager, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Rhino = new HunterPet(TenaPet.Rhino, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Scorpid = new HunterPet(TenaPet.Scorpid, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet SpiritBeast = new HunterPet(FeroPet.SpiritBeast, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Serpent = new HunterPet(CunPet.Serpent, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Silithid = new HunterPet(CunPet.Silithid, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Spider = new HunterPet(CunPet.Spider, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Sporebat = new HunterPet(CunPet.Sporebat, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Tallstrider = new HunterPet(FeroPet.Tallstrider, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Turtle = new HunterPet(TenaPet.Turtle, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet WrapStalker = new HunterPet(TenaPet.WrapStalker, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Wasp = new HunterPet(FeroPet.Wasp, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet WindSerpent = new HunterPet(CunPet.WindSerpent, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Wolf = new HunterPet(FeroPet.Wolf, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);
        public HunterPet Worm = new HunterPet(TenaPet.Worm, 192, 158, 414, 70, 115, 503, 103, 136, 2, 59.8, 81, 10716);

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
                case Stat.Strength:
                case Stat.Agility:
                case Stat.Stamina:
                case Stat.Intelect:
                case Stat.BaseSpeed:
                case Stat.Power:
                case Stat.Armorpenetration:
                case Stat.Expertiserating:
                case Stat.RangedPower:
                case Stat.Hitrating:
                case Stat.Critrating:
                case Stat.Hasterating:
                case Stat.Manaregen:
                case Stat.Armor: //????
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
                case Race.Name.Dwarf:
                case Race.Name.NightElf:
                case Race.Name.Draenei:
                case Race.Name.Orc:
                case Race.Name.Tauren:
                case Race.Name.Troll:
                case Race.Name.BloodElf:
                    return true;
            }
            return false;
        }
    }
}
