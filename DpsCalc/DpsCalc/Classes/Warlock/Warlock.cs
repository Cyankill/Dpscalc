using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace demo.Classes.Warlock
{
    class Warlock : Player
    {
        public int baseMana = 3856;
        //TALENTS
        //AFFLI
        public Talent improvedCurseOfAgony = new Talent(0,2);
        public Talent suppression = new Talent(0,3);
        public Talent improvedCorruption = new Talent(0,5);
        public Talent improvedCurseOfWeakness = new Talent(0,2);
        public Talent improvedDrainSoul = new Talent(0,2);
        public Talent improvedLifeTap = new Talent(0,2);
        public Talent soulSiphon = new Talent(0,2);
        public Talent improvedFear = new Talent(0,2);
        public Talent felConcentration = new Talent(0,3);
        public Talent amplifyCurse = new Talent(0, 1);
        public Talent nightfall = new Talent(0,2);           //not implemented yet
        public Talent empoweredCorruption = new Talent(0,3);
        public Talent shadowEmbrace = new Talent(0,5);
        public Talent siphonLife = new Talent(0,1);
        public Talent curseOfExhaustion = new Talent(0,1);
        public Talent improvedFelhunter = new Talent(0,2);
        public Talent shadowMastery = new Talent(0, 5);
        public Talent eradication = new Talent(0, 3);
        public Talent contagion = new Talent(0, 5);
        public Talent darkPact = new Talent(0, 1);
        public Talent improvedHowlOfTerror = new Talent(0, 2);
        public Talent malediction = new Talent(0, 3);
        public Talent deathsEmbrace = new Talent(0, 3);
        public Talent unstableAffliction = new Talent(0, 1);
        public Talent pandemic = new Talent(0, 1);
        public Talent everlastingAffliction = new Talent(0, 5);
        public Talent haunt = new Talent(0, 1);
        
        //DEMO
        public Talent improvedHealthstone = new Talent(0, 2);
        public Talent improvedImp = new Talent(0, 3);
        public Talent demonicEmbrace = new Talent(0, 3);
        public Talent felSynergy = new Talent(0, 2);
        public Talent improvedHealthFunnel = new Talent(0, 2);
        public Talent demonicBrutality = new Talent(0, 3);
        public Talent felVitality = new Talent(0, 3);
        public Talent improvedSuccubus = new Talent(0, 3);
        public Talent soulLink = new Talent(0, 1);
        public Talent felDomination = new Talent(0, 1);
        public Talent demonicAegis = new Talent(0, 3);
        public Talent unholyPower = new Talent(0, 5);
        public Talent masterSummoner = new Talent(0, 2);
        public Talent manaFeed = new Talent(0, 1);
        public Talent masterConjurer = new Talent(0, 2);
        public Talent masterDemonologist = new Talent(0,5);
        public Talent moltenCore = new Talent(0,3);
        public Talent demonicResilience = new Talent(0, 3);
        public Talent demonicEmpowerment = new Talent(0, 1);
        public Talent demonicKnowledge = new Talent(0, 3);
        public Talent demonicTactics = new Talent(0, 5);
        public Talent decimation = new Talent(0, 2);
        public Talent improvedDemonicTactics = new Talent(0, 3);
        public Talent summonFelguard = new Talent(0, 1);
        public Talent nemesis = new Talent(0, 3);
        public Talent demonicPact = new Talent(0, 5);
        public Talent metamorphosis = new Talent(0, 1);

        //DESTRO
        public Talent improvedShadowBolt = new Talent(0, 5);
        public Talent bane = new Talent(0, 5);
        public Talent aftermath = new Talent(0, 2);
        public Talent moltenSkin = new Talent(0, 3);
        public Talent cataclysm = new Talent(0, 3);
        public Talent demonicPower = new Talent(0, 2);
        public Talent shadowburn = new Talent(0, 1);
        public Talent ruin = new Talent(0, 5);
        public Talent intensity = new Talent(0, 2);
        public Talent destructiveReach = new Talent(0, 2);
        public Talent improvedSearingPain = new Talent(0, 3);
        public Talent backlash = new Talent(0, 3);            //yet to be implemented
        public Talent improvedImmolate = new Talent(0, 3);    //done
        public Talent devastation = new Talent(0, 1);         //done
        public Talent netherProtection = new Talent(0, 3);
        public Talent emberstorm = new Talent(0, 5);          //done TODO: calc if incin > SB and adjust the 100-35% dmg part
        public Talent conflagrate = new Talent(0, 1);         //60% of immo dmg + 40% of that over 6 sec, 10 sec cd. use asap
        public Talent soulLeech = new Talent(0, 3);
        public Talent pyroclasm = new Talent(0, 3);           //2/4/6% fire and shadow dmg increase after searing pain/confla crit. TODO: calc avg dmg increase
        public Talent shadowAndFlame = new Talent(0, 5);      //4/8/12/16/20% of bonus spell dmg -> SB, shadowburn, CB, incins
        public Talent improvedSoulLeech = new Talent(0, 2);
        public Talent backdraft = new Talent(0, 3);
        public Talent shadowfury = new Talent(0, 1);
        public Talent empoweredImp = new Talent(0, 3);
        public Talent fireAndBrimstone = new Talent(0, 5);
        public Talent chaosBolt = new Talent(0, 1);

        //GLYPHS
        //MAJOR
        public bool glyphOfChaosBolt = false;
        public bool glyphOfConflagrate = false;
        public bool glyphOfCorruption = false;
        public bool glyphOfCurseOfAgony = false;
        public bool glyphOfFelguard = false;
        public bool glyphOfHaunt = false;
        public bool glyphOfImmolate = false;
        public bool glyphOfImp = false;
        public bool glyphOfIncinerate = false;
        public bool glyphOfLifeTap = false;
        public bool glyphOfMetamorphosis = false;
        public bool glyphOfQuickDecay = false;
        public bool glyphOfSearingPain = false;
        public bool glyphOfShadowbolt = false;
        public bool glyphOfShadowburn = false;
        public bool glyphOfUnstableAffliction = false;
        public bool glyphOfVoidwalker = false;
        //MINOR
        public bool glyphOfDrainSoul = false;

        //WEAPONENCHANTS
        public WarlockWeaponEnchant stone = WarlockWeaponEnchant.None;

        //MINION
        //BASE STATS
        public static WarlockMinion none = new WarlockMinion(Minion.None, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1.00, 0, 0);
        public WarlockMinion imp = new WarlockMinion(Minion.Imp, 175, 54, 193, 448, 319, 208, 112, 163, 2.00, 68.6, 0, 3344);
        public WarlockMinion felhunter = new WarlockMinion(Minion.Felhunter, 179, 133, 403, 271, 206, 383, 143, 194, 2.00, 84.6, 0, 6319);
        public WarlockMinion voidwalker = new WarlockMinion(Minion.Voidwalker, 177, 134, 552, 231, 315, 387, 144, 195, 2.00, 84.6, 0, 13324);
        public WarlockMinion succubus = new WarlockMinion(Minion.Succubus, 178, 130, 404, 209, 150, 377, 142, 193, 2.00, 83.7, 0, 6509);
        public WarlockMinion felguard = new WarlockMinion(Minion.Felguard, 177, 130, 506, 321, 150, 390, 144, 195, 2.00, 84.8, 0, 11759);

        public WarlockMinion minion = none;


        //SPELLORDER
        public bool corruptionOverImmolate = true;
        public Curse curse = Curse.None;

        //SPELLPROPERTIES
        public SpellSchool Fire = new SpellSchool(SpellSchoolName.Fire);
        public SpellSchool Shadow = new SpellSchool(SpellSchoolName.Shadow);

        public SpellTalentSchool Affliction = new SpellTalentSchool(SpellTalentSchoolName.Affliction);
        public SpellTalentSchool Demonology = new SpellTalentSchool(SpellTalentSchoolName.Demonology);
        public SpellTalentSchool Destruction = new SpellTalentSchool(SpellTalentSchoolName.Destruction);

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
            //talents requiring talents
            curseOfExhaustion.requiredTalent = amplifyCurse;
            unstableAffliction.requiredTalent = contagion;
            pandemic.requiredTalent = unstableAffliction;

            unholyPower.requiredTalent = soulLink;
            masterSummoner.requiredTalent = felDomination;
            manaFeed.requiredTalent = unholyPower;
            masterDemonologist.requiredTalent = unholyPower;
            demonicEmpowerment.requiredTalent = masterDemonologist;
            improvedDemonicTactics.requiredTalent = demonicTactics;

            devastation.requiredTalent = ruin;
            conflagrate.requiredTalent = improvedImmolate;
            backdraft.requiredTalent = conflagrate;
            improvedSoulLeech.requiredTalent = soulLeech;
            //end of talents

            double _hitrating = hitrating + hitratingIncrease;
            double _stamina = stamina + staminaIncrease;
            double _spellpower = spellPower + spellpowerIncrease;
            double _critrating = critrating + critratingIncrease;
            double _hasterating = hasterating + hasteratingIncrease;
            double _intelect = intelect + intelectIncrease;
            double _spirit = spirit + spiritIncrease;
            double _manaregen = manaregen + manaregenIncrease;

            ///////////////////////////////////////////////////////////////////////////////////////
            //STATS CALC
            //Hitrating:
            double buffHitPercent = raidbuffs.spellHitPercent();
            double hitPercentBonus = suppression.pointsSpend + buffHitPercent;

            //Intelect:
            double intFromBuffs = raidbuffs.intelect();
            _intelect += intFromBuffs;
            _intelect *= raidbuffs.intelectFactor();

            updateMinionStats(intel: _intelect);

            //Critrating: 
            //TODO: move most of this to talent section/////////////////////////////
            double intCrit = _intelect / 166.666666;
            double stoneCritFlat = (stone == WarlockWeaponEnchant.Firestone ? 1 : 0) * (49 * (1 + (1.5 * masterConjurer.pointsSpend)));
            double CritFromCrit = (_critrating + stoneCritFlat) / 45.91;
            double improvedShadowBoltProcChance = 0.2 * improvedShadowBolt.pointsSpend;
            double improvedShadowBoltCritPercent = improvedShadowBolt.pointsSpend > 0 ? 5 : 0;
            double improvedShadowBoltUptimeFactor = 1 - (improvedShadowBolt.pointsSpend * .03);                                      //TODO: calculation
            double talentsCritPercent = (2 * demonicTactics.pointsSpend) + improvedShadowBoltCritPercent * improvedShadowBoltUptimeFactor + 5 * devastation.pointsSpend;
            double talentsShadowCritPercent = (minion.kind == Minion.Succubus ? masterDemonologist.pointsSpend : 0);
            double talentsFireCritPercent = (minion.kind == Minion.Imp ? masterDemonologist.pointsSpend : 0);                                                    

            double setPieceCritPercent = (t10_2PieceBonus ? 5 : 0);

            double CorruptionUptimeFactor = 1 /*Corruption.cooldown / Corruption.effectiveCooldown*/;
            double moltenCoreChance = 0.04 * moltenCore.pointsSpend * CorruptionUptimeFactor;
            double SFMoltenCoreCritIncreasePercent = 5 * moltenCore.pointsSpend;

            //double SBCritFactor = (((CritFromCrit) + talentsCritPercent + talentsShadowCritPercent + setPieceCritPercent + intCrit) * (0.005 * (1 + (0.2 * ruin)))) + 1;
            //double IncinerateCritFactor = (((CritFromCrit) + talentsCritPercent + talentsFireCritPercent + setPieceCritPercent + intCrit) * (0.005 * (1 + (0.2 * ruin)))) + 1;
            //double SFCritFactor = (((CritFromCrit) + talentsCritPercent + talentsFireCritPercent + setPieceCritPercent + (moltenCoreChance * SFMoltenCoreCritIncreasePercent) + intCrit) * (0.005 * (1 + (0.2 * ruin)))) + 1;
            //double immoCritFactor = (((CritFromCrit) + talentsCritPercent + talentsFireCritPercent + intCrit) * (0.005 * (1 + (0.2 * ruin)))) + 1;
            //double shadowCleaveCritFactor = (((CritFromCrit + talentsCritPercent + talentsShadowCritPercent + intCrit) * (0.005 * (1 + (0.2 * ruin)))) + 1;

            updateMinionStats(crit: ((intCrit + talentsCritPercent) * 45.91));
            
            //Hasterating:
            double stoneHasteFlat = (stone == WarlockWeaponEnchant.Spellstone ? 1 : 0) * (60 * (1 + (1.5 * masterConjurer.pointsSpend)));
            _hasterating += stoneHasteFlat;
            double buffHaste = raidbuffs.spellHastePercent() * 32.79;
            _hasterating += buffHaste;
            
            //Stamina:
            double demonicEmbraceFactor = demonicEmbrace.pointsSpend > 0 ? 1.01 + (0.03 * demonicEmbrace.pointsSpend) : 1;
            double stam = (_stamina + raidbuffs.stamina()) * demonicEmbraceFactor * raidbuffs.staminaFactor();

            updateMinionStats(stam: stam);

            //Spirit:
            _spirit += raidbuffs.spirit();
            _spirit *= raidbuffs.spiritFactor();

            //Spellpower:
            double demonicKnowledgeSP = demonicKnowledge.pointsSpend * 0.04 * (minion.getStamina() + minion.getIntelect());
            double setPieceSP = (PvP_2PieceBonus ? 29 : 0) + (PvP_4PieceBonus ? 88 : 0);
            double demonicAegisFactor = 1 + (0.1 * demonicAegis.pointsSpend);
            double demonicAegisSP = (180 * demonicAegisFactor) + ((0.3 * demonicAegisFactor) * _spirit);
            double glyphOfLifeTapSP = glyphOfLifeTap ? 0.2 * _spirit : 0; //asuming 100% uptime, 1 lifetap every 40 sec.
            double procBonusSP = procIncrease(Stat.Spellpower); //TODO: UI part
            double demonicPactSPFactor = 1 + (0.02 * demonicPact.pointsSpend);
            double raceSP = race.getRaceBonus().spelldamageFlat;
            double sp = (_spellpower + demonicAegisSP + glyphOfLifeTapSP + setPieceSP + procBonusSP + demonicKnowledgeSP + raceSP + raidbuffs.spellpower()) * demonicPactSPFactor;

            updateMinionStats(sp: sp);

            //Mana and manaregen:
            double mana = baseMana + ((_intelect - 20) * 15) + 20;
            double mp5FromReplenishment = raidbuffs.percentualManaregen() * (mana / 100);
            double mp5FromBuffs = raidbuffs.manaregen() + mp5FromReplenishment;
            double mp5 = _manaregen + mp5FromBuffs;
            double mps = mp5 / 5;
            
            ///////////////////////////////////////////////////////////////////////////////////////
            //Damage multipliers
            double setPieceImmoCorrUADmgFactor = (t9_4PieceBonus ? 1.1 : 1);
            double deviousMindsUptimeFactor = CalculateUptimeFactor(0.15, 1/3,0,10);
            double t10_4PieceBonusUptime = (t10_4PieceBonus ? deviousMindsUptimeFactor : 0);
            double setPieceAllDmgFactor = (t10_4PieceBonusUptime * 0.1) + 1.0;
            
            bool metamorphosisLearned = metamorphosis.pointsSpend == 1;
            double metamorphosisCD = 180 * (1 - (0.1 * nemesis.pointsSpend));
            double metamorphosisDuration = 30 + (glyphOfMetamorphosis ? 6 : 0);
            double metamorphosisDmgFactor = 1 + (metamorphosisLearned ? ((metamorphosisDuration / metamorphosisCD) * 0.2) : 0);

            double stoneDirectDmgFactor = (stone == WarlockWeaponEnchant.Firestone ? 1.01 : 1);
            double stoneDoTDmgFactor = (stone == WarlockWeaponEnchant.Spellstone ? 1.01 : 1);

            double improvedShadowBoltDamageFactor = 1 + (improvedShadowBolt.pointsSpend * 0.02);
            double glyphOfIncinerateFactor = glyphOfIncinerate ? 1.05 : 1;
            double glyphOfImmolateDoTFactor = glyphOfImmolate ? 1.1 : 1;
            double talentsShadowDamageFactor = (minion.kind == Minion.Succubus || minion.kind == Minion.Felguard ? 1 + (0.01 * masterDemonologist.pointsSpend) : 1);    //succubus or felguard
            double talentsFireDamageFactor = (minion.kind == Minion.Imp || minion.kind == Minion.Felguard ? 1 + (0.01 * masterDemonologist.pointsSpend) : 1);           //imp or felguar
            talentsFireDamageFactor *= (1 + 0.03 * emberstorm.pointsSpend);
            
            ////////CASTTIME//////////
            double hasteFactor = 1 + ((_hasterating / 32.79) / 100);
            double gcd = applyMinimumGCD(1.5 / hasteFactor);

            double backdraftFactor = 1 - (0.1 * backdraft.pointsSpend);
            double moltenCoreCastTimeFactor = 1 - (0.1 * moltenCore.pointsSpend);

            double pushbackReduction = raidbuffs.pushbackReductionPercent();
            double pushbackReductionDestro = (35 * intensity.pointsSpend) + pushbackReduction;
            double pushbackReductionAffli = (23.3 * felConcentration.pointsSpend) + pushbackReduction;
            double castTimeLostFactor = 1 + (0.2 / 3); //getting hit once every 7.5 sec
            double castTimeLostFactorDestro = castTimeLostFactor;
            double castTimeLostFactorAffli = castTimeLostFactor;
            
            if (pushbackReductionDestro > 100)
                castTimeLostFactorDestro = 1;
            else
                castTimeLostFactorDestro = ((castTimeLostFactorDestro - 1) * (1 - (pushbackReductionDestro / 100))) + 1;

            if (pushbackReductionAffli > 100)
                castTimeLostFactorAffli = 1;
            else
                castTimeLostFactorAffli = ((castTimeLostFactorAffli - 1) * (1 - (pushbackReductionAffli / 100))) + 1;

            ///////SPELLLIST///////
            List<Spell> spellList = new List<Spell>();
            //curses
            Spell CurseOfTheElements = new Spell(SpellName.CurseOfTheElements, Affliction,
                                                directSpellSchool: Shadow,
                                                duration: 300,
                                                manaCostOfBaseMana: 0.1
                                                );
            CurseOfTheElements.applyGCD(gcd);
            
            Spell CurseOfDoom = new Spell(SpellName.CurseOfDoom, Affliction,
                                                DoTSpellSchool: Shadow,
                                                duration: 60,
                                                cooldown: 60,
                                                manaCostOfBaseMana: 0.15,
                                                averageDoTBaseDamage: 7300,
                                                SPDoTScaling: 2);
            CurseOfDoom.applyGCD(gcd);
            
            Spell CurseOfAgony = new Spell(SpellName.CurseOfAgony, Affliction,
                                                DoTSpellSchool: Shadow,
                                                duration: 24 + (glyphOfCurseOfAgony ? 4 : 0),
                                                manaCostOfBaseMana: 0.1,
                                                averageDoTBaseDamage: 1740, //CHECK
                                                SPDoTScaling: 1.2);
            CurseOfAgony.applyGCD(gcd);
            
            Spell CurseOfWeakness = new Spell(SpellName.CurseOfWeakness, Affliction,
                                                directSpellSchool: Shadow,
                                                duration:120,
                                                manaCostOfBaseMana: 0.1);
            CurseOfWeakness.applyGCD(gcd);

            Spell CurseOfTongues = new Spell(SpellName.CurseOfTongues, Affliction,
                                                directSpellSchool: Shadow,
                                                duration: 30,
                                                manaCostOfBaseMana: 0.04);
            CurseOfTongues.applyGCD(gcd);

            //standard warlock spells
            Spell LifeTap = new Spell(SpellName.LifeTap, Affliction);   //prolly never using it
            LifeTap.applyGCD(gcd);
            
            Spell DrainLife = new Spell(SpellName.DrainLife, Affliction,
                                                DoTSpellSchool: Shadow,
                                                baseCasttime:5,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.17,
                                                averageDoTBaseDamage: 665,
                                                SPDoTScaling: 0.143,
                                                channeled: true,
                                                numOfTicks: 5);
            DrainLife.applyCastTimeFactor(castTimeLostFactorAffli);
            DrainLife.applyGCD(gcd);
            
            Spell DrainSoul = new Spell(SpellName.DrainSoul, Affliction,
                                                DoTSpellSchool: Shadow,
                                                baseCasttime: 15,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.14,
                                                requiredBuffUptimeFactor: 0.75,
                                                averageDoTBaseDamage: 710,
                                                SPDoTScaling: 0.429,
                                                channeled: true,
                                                numOfTicks: 5);
            DrainSoul.applyCastTimeFactor(castTimeLostFactorAffli);
            DrainSoul.applyGCD(gcd);
            
            Spell DrainSoulUnder25 = new Spell(SpellName.DrainSoul, Affliction,
                                                DoTSpellSchool: Shadow,
                                                baseCasttime: 15,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.14,
                                                requiredBuffUptimeFactor: 0.75,
                                                averageDoTBaseDamage: 710,
                                                SPDoTScaling: 0.429,
                                                channeled: true,
                                                numOfTicks: 5,
                                                DoTDamageFactor: 4);
            DrainSoulUnder25.applyCastTimeFactor(castTimeLostFactorAffli);
            DrainSoulUnder25.applyGCD(gcd);

            
            Spell Corruption = new Spell(SpellName.Corruption, Affliction,
                                                DoTSpellSchool: Shadow,
                                                duration:18,
                                                hasteAffectsDuration: glyphOfQuickDecay,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.14,
                                                averageDoTBaseDamage: 1080,
                                                SPDoTScaling: 0.2,
                                                numOfTicks: 6);
            Corruption.applyGCD(gcd);
            
            //asuming enough dps on target to never have seed of corruption tick
            Spell SeedOfCorruption = new Spell(SpellName.SeedOfCorruption, Affliction,
                                                directSpellSchool: Shadow,
                                                baseCasttime: 2,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.34,
                                                averageDirectBaseDamage: 1518,
                                                SPDirectScaling: 0.2129);
            SeedOfCorruption.applyCastTimeFactor(castTimeLostFactor);
            SeedOfCorruption.applyGCD(gcd);
            
            Spell Shadowflame = new Spell(SpellName.Shadowflame, Destruction,
                                                directSpellSchool: Shadow,
                                                DoTSpellSchool: Fire,
                                                duration: 8,
                                                cooldown: 15,
                                                manaCostOfBaseMana: 0.25,
                                                averageDirectBaseDamage: 643.5,
                                                averageDoTBaseDamage: 0,
                                                SPDirectScaling: 0.1064,
                                                SPDoTScaling: 0.0667,
                                                numOfTicks: 4);
            Shadowflame.applyGCD(gcd);

            Spell SearingPain = new Spell(SpellName.SearingPain, Destruction,
                                                directSpellSchool: Fire,
                                                baseCasttime: 1.5,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.08,
                                                averageDirectBaseDamage: 374.5,
                                                SPDirectScaling: 0.4293);
            SearingPain.applyCastTimeFactor(castTimeLostFactorDestro);
            SearingPain.applyGCD(gcd);

            Spell Immolate = new Spell(SpellName.Immolate, Destruction,
                                                directSpellSchool: Fire,
                                                DoTSpellSchool: Fire,
                                                duration: 15,
                                                baseCasttime: 2,
                                                flatCasttimeReduction: 0.1 * bane.pointsSpend,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.17,
                                                averageDirectBaseDamage: 460,
                                                averageDoTBaseDamage: 785,
                                                SPDirectScaling: 0.2,
                                                SPDoTScaling: 0.2,
                                                numOfTicks: 5);
            Immolate.applyCastTimeFactor(castTimeLostFactorDestro);
            Immolate.applyGCD(gcd);
            
            Spell Shadowbolt = new Spell(SpellName.ShadowBolt, Destruction,
                                                directSpellSchool: Shadow,
                                                baseCasttime: 3,
                                                flatCasttimeReduction: 0.1 * bane.pointsSpend,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.17,
                                                averageDirectBaseDamage: 803,
                                                SPDirectScaling: 0.8569);
            Shadowbolt.applyCastTimeFactor(castTimeLostFactorDestro);
            Shadowbolt.applyGCD(gcd);

            Spell ShadowBoltInstant = new Spell(SpellName.ShadowBoltInstant,Destruction,
                                                directSpellSchool: Shadow,
                                                manaCostOfBaseMana: 0.17,
                                                requiredBuffUptimeFactor: ((nightfall.pointsSpend * 0.02) + ((glyphOfCorruption ? 1 : 0) * 0.04)) * CorruptionUptimeFactor, // TEMP!
                                                averageDirectBaseDamage: 803,
                                                SPDirectScaling: 0.8569);
            ShadowBoltInstant.applyGCD(gcd);
            
            Spell Incinerate = new Spell(SpellName.Incinerate, Destruction,
                                                directSpellSchool: Fire,
                                                baseCasttime: 2.5,
                                                flatCasttimeReduction: 0.05 * emberstorm.pointsSpend,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.14,
                                                averageDirectBaseDamage: 629.5,
                                                SPDirectScaling: 0.7139);
            Incinerate.applyCastTimeFactor(castTimeLostFactorDestro);
            Incinerate.applyGCD(gcd);
            
            Spell Soulfire = new Spell(SpellName.Soulfire, Destruction,
                                                directSpellSchool: Fire,
                                                baseCasttime: 6,
                                                flatCasttimeReduction: 0.4 * bane.pointsSpend,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.09,
                                                reagent: Reagent.Soulshard,
                                                averageDirectBaseDamage: 1490.5,
                                                SPDirectScaling: 1.15);
            Soulfire.applyCastTimeFactor(castTimeLostFactorDestro);
            Soulfire.applyGCD(gcd);
            
            Spell SoulfireDecimation = new Spell(SpellName.SoulfireDecimation, Destruction,
                                                directSpellSchool: Fire,
                                                baseCasttime: 6,
                                                flatCasttimeReduction: 0.4 * bane.pointsSpend,
                                                percentualCasttimeReduction: 20 * decimation.pointsSpend,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.09,
                                                requiredBuffUptimeFactor: 0,
                                                reagent: Reagent.Soulshard,
                                                averageDirectBaseDamage: 1490.5,
                                                SPDirectScaling: 1.15);
            SoulfireDecimation.applyCastTimeFactor(castTimeLostFactorDestro);
            SoulfireDecimation.applyGCD(gcd);

            Spell DarkPact = new Spell(SpellName.DarkPact, Affliction);
            DarkPact.applyGCD(gcd);
            
            Spell UnstableAffliction = new Spell(SpellName.UnstableAffliction, Affliction,
                                                DoTSpellSchool: Shadow,
                                                duration: 15,
                                                baseCasttime: 1.5,
                                                flatCasttimeReduction: (glyphOfUnstableAffliction ? 0.2 : 0),
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.15,
                                                averageDoTBaseDamage: 1150,
                                                SPDoTScaling: 0.2,
                                                numOfTicks: 5);
            UnstableAffliction.applyCastTimeFactor(castTimeLostFactorAffli);
            UnstableAffliction.applyGCD(gcd);
            
            Spell Haunt = new Spell(SpellName.Haunt, Affliction,
                                                directSpellSchool: Shadow,
                                                DoTSpellSchool: Shadow,
                                                duration: 12,
                                                baseCasttime: 1.5,
                                                hasteFactor: hasteFactor,
                                                cooldown: 8,
                                                manaCostOfBaseMana: 0.12,
                                                
                                                averageDirectBaseDamage: 699,
                                                averageDoTBaseDamage: 0,
                                                SPDirectScaling: 0.4793,
                                                numOfTicks: 0);
            Haunt.applyCastTimeFactor(castTimeLostFactorAffli);
            Haunt.applyGCD(gcd);
            
            Spell IncinerateMoltenCore = new Spell(SpellName.IncinerateMoltenCore, Destruction,
                                                directSpellSchool: Fire,
                                                baseCasttime: 2.5,
                                                flatCasttimeReduction: 0.05 * emberstorm.pointsSpend,
                                                percentualCasttimeReduction: 10 * moltenCore.pointsSpend,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.14,
                                                requiredBuffUptimeFactor: 0,
                                                averageDirectBaseDamage: 629.5,
                                                SPDirectScaling: 0.7139,
                                                directDamageFactor: 1 + (0.06 * moltenCore.pointsSpend));
            IncinerateMoltenCore.applyCastTimeFactor(castTimeLostFactorDestro);
            IncinerateMoltenCore.applyGCD(gcd);
            
            Spell DemonicEmpowerment = new Spell(SpellName.DemonicEmpowerment, Demonology);
            
            Spell Metamorphosis = new Spell(SpellName.Metamorphosis, Demonology,
                                                duration: metamorphosis.pointsSpend > 0 ? (glyphOfMetamorphosis ? 36 : 30) : 0,
                                                cooldown: 180 * (1 - (0.1 * nemesis.pointsSpend)));

            
            Spell ImmolationAura = new Spell(SpellName.ImmolationAura, Demonology,
                                                DoTSpellSchool: Fire,
                                                duration: 15,
                                                hasteAffectsDuration: true,
                                                hasteFactor: hasteFactor,
                                                cooldown: 30,
                                                manaCostOfBaseMana: 0.64,
                                                requiredBuffUptimeFactor: Metamorphosis.uptimeFactor(),
                                                averageDoTBaseDamage: 251,
                                                SPDoTScaling: 0, //CHECK
                                                numOfTicks: 15);
            ImmolationAura.applyGCD(gcd);
            
            Spell ShadowCleave = new Spell(SpellName.ShadowCleave, Demonology,
                                                directSpellSchool: Shadow,
                                                cooldown: 6,
                                                manaCostOfBaseMana: 0.04,
                                                requiredBuffUptimeFactor: Metamorphosis.uptimeFactor(),
                                                averageDirectBaseDamage: 110,
                                                SPDirectScaling: 0); //CHECK seems to be 1, but prolly not exactly 1
            
            Spell Shadowburn = new Spell(SpellName.Shadowburn, Destruction,
                                                cooldown: 10, //CHECK!
                                                manaCostOfBaseMana: 0.2,
                                                requiredBuffUptimeFactor: 1,
                                                reagent: Reagent.Soulshard,
                                                averageDirectBaseDamage: 820.5,
                                                SPDirectScaling: 0.4293);
            Shadowburn.applyGCD(gcd);
            
            Spell ShadowburnGlyphed = new Spell(SpellName.ShadowburnGlyphed,Destruction,
                                                cooldown: 10, //CHECK!
                                                manaCostOfBaseMana: 0.2,
                                                requiredBuffUptimeFactor: 0,
                                                reagent: Reagent.Soulshard,
                                                averageDirectBaseDamage: 820.5,
                                                SPDirectScaling: 0.4293,
                                                directCritChance: 20); 
            ShadowburnGlyphed.applyGCD(gcd);

            Spell Conflagrate = new Spell(SpellName.Conflagrate, Destruction,
                                                directSpellSchool: Fire,
                                                DoTSpellSchool: Fire,
                                                duration: 6,
                                                cooldown: 10,
                                                manaCostOfBaseMana: 0.16,
                                                requiredBuffUptimeFactor: Immolate.uptimeFactor() / (glyphOfConflagrate ? 1 : 2),
                                                averageDirectBaseDamage: Immolate.totalDamagePerCast(_spellpower) * 0.6,
                                                averageDoTBaseDamage: Immolate.totalDamagePerCast(_spellpower) * 0.6 * 0.4,
                                                numOfTicks: 3); //CHECK
            Conflagrate.applyGCD(gcd);

            Spell IncinerateMoltenCoreBackdraft = new Spell(SpellName.IncinerateMoltenCoreBackdraft, Destruction,
                                                directSpellSchool: Fire,
                                                baseCasttime: 2.5,
                                                flatCasttimeReduction: 0.05 * emberstorm.pointsSpend,
                                                percentualCasttimeReduction: moltenCoreCastTimeFactor * backdraftFactor,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.14,
                                                requiredBuffUptimeFactor: 0 /* molten core uptime * (3 / confla cd) ofso.. */,
                                                averageDirectBaseDamage: 629.5,
                                                SPDirectScaling: 0.7139);
            IncinerateMoltenCoreBackdraft.applyCastTimeFactor(castTimeLostFactorDestro);
            IncinerateMoltenCoreBackdraft.applyGCD(gcd * backdraftFactor);
            
            Spell IncinerateBackdraft = new Spell(SpellName.IncinerateBackdraft, Destruction,
                                                directSpellSchool: Fire,
                                                baseCasttime: 2.5,
                                                flatCasttimeReduction: 0.05 * emberstorm.pointsSpend,
                                                percentualCasttimeReduction: backdraftFactor,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.14,
                                                requiredBuffUptimeFactor: 0 /* (3 / confla cd) ofso.. */,
                                                averageDirectBaseDamage: 629.5,
                                                SPDirectScaling: 0.7139);
            IncinerateBackdraft.applyGCD(gcd * backdraftFactor);
            

            Spell Shadowfury = new Spell(SpellName.Shadowfury, Destruction,
                                                directSpellSchool: Shadow,
                                                cooldown: 20,
                                                manaCostOfBaseMana: 0.27,
                                                averageDirectBaseDamage: 1060,
                                                SPDirectScaling: 0.1); //CHECK
            Shadowfury.applyGCD(0.5); //triggers a small gcd. CHECK
            
            Spell ChaosBolt = new Spell(SpellName.ChaosBolt, Destruction,
                                                directSpellSchool: Fire,
                                                baseCasttime: 2.5,
                                                flatCasttimeReduction: 0.1 * bane.pointsSpend,
                                                hasteFactor: hasteFactor,
                                                cooldown: glyphOfChaosBolt ? 10 : 12,
                                                manaCostOfBaseMana: 0.07,
                                                averageDirectBaseDamage: 1621,
                                                SPDirectScaling: 0.7139);
            ChaosBolt.applyCastTimeFactor(castTimeLostFactorDestro);
            ChaosBolt.applyGCD(gcd);
            
            Spell ChaosBoltBackdraft = new Spell(SpellName.ChaosBoltBackdraft, Destruction,
                                                directSpellSchool: Fire,
                                                baseCasttime: 2.5,
                                                flatCasttimeReduction: 0.1 * bane.pointsSpend,
                                                percentualCasttimeReduction: 10 * backdraft.pointsSpend,
                                                hasteFactor: hasteFactor,
                                                cooldown: glyphOfChaosBolt ? 10 : 12,
                                                manaCostOfBaseMana: 0.07,
                                                averageDirectBaseDamage: 1621,
                                                SPDirectScaling: 0.7139);
            ChaosBoltBackdraft.applyCastTimeFactor(castTimeLostFactorDestro);
            ChaosBoltBackdraft.applyGCD(gcd * backdraftFactor);

            Spell ShadowboltBackdraft = new Spell(SpellName.ShadowboltBackdraft, Destruction,
                                                directSpellSchool: Shadow,
                                                baseCasttime: 3,
                                                flatCasttimeReduction: 0.1 * bane.pointsSpend,
                                                percentualCasttimeReduction: 10 * backdraft.pointsSpend,
                                                hasteFactor: hasteFactor,
                                                manaCostOfBaseMana: 0.17,
                                                averageDirectBaseDamage: 803,
                                                SPDirectScaling: 0.8569);
            ShadowboltBackdraft.applyCastTimeFactor(castTimeLostFactorDestro);
            ShadowboltBackdraft.applyGCD(gcd * backdraftFactor);

            spellList.Add(Shadowflame);
            updateEffectiveSpellCooldown(spellList);

            double instaSBBuffUptimeFactor = 
            Shadowbolt.baseCasttime = (instaSBBuffUptimeFactor * gcd) + ((1 - instaSBBuffUptimeFactor) * Shadowbolt.baseCasttime);

            ///////////////////////////////////////////////////////////////////////////////////////
            //MANA USAGE
            double improvedLifeTapFactor = 1 + (0.1 * improvedLifeTap.pointsSpend);
            double manaFromLifeTap = (2000 + 0.5 * sp) * improvedLifeTapFactor;
            double manaFromDarkPact = 1200 + 0.96 * sp;

            double cataclysmFactor = 1 - (cataclysm.pointsSpend > 0 ? 0.01 + 0.03 * cataclysm.pointsSpend : 0);
            double suppressionManaCostFactor = 1 - (0.02 * suppression.pointsSpend);
            double manaFactor = raidbuffs.manaCostFactor();

            Shadowbolt.manaCostFactor *= glyphOfShadowbolt ? 0.9 : 1;
            ShadowboltBackdraft.manaCostFactor *= glyphOfShadowbolt ? 0.9 : 1;
            ShadowBoltInstant.manaCostFactor *= glyphOfShadowbolt ? 0.9 : 1;

            foreach(Spell s in spellList){
                if(s.talentSchool == Affliction)
                    s.manaCostFactor *= suppressionManaCostFactor;
                if(s.talentSchool == Destruction)
                    s.manaCostFactor *= cataclysmFactor;
                s.manaCostFactor *= manaFactor;

                s.effectiveCasttime += (s.manaCost(baseMana,mps)/manaFromLifeTap) * LifeTap.effectiveCasttime;
            }
           
            //TALENTS


            //affli
            UnstableAffliction.baseCasttime = (1.5 - (glyphOfUnstableAffliction ? 0.2 : 0)) / hasteFactor;
            Haunt.baseCasttime = 1.5 / hasteFactor;
            //demo
            IncinerateMoltenCore.baseCasttime = ((2.5 * moltenCoreCastTimeFactor) - (0.05 * emberstorm.pointsSpend)) / hasteFactor;
            //hybrid
            IncinerateMoltenCoreBackdraft.baseCasttime = ((2.5 * moltenCoreCastTimeFactor * backdraftFactor) - (0.05 * emberstorm.pointsSpend)) / hasteFactor;
            //destro
            Shadowfury.baseCasttime = 0.5 / hasteFactor;                                                                    //triggers small gcd, does haste apply?
            IncinerateBackdraft.baseCasttime = ((2.5 * backdraftFactor) - (0.05 * emberstorm.pointsSpend)) / hasteFactor;
            ChaosBolt.baseCasttime = (2.5 - (0.1 * bane.pointsSpend)) / hasteFactor;
            ChaosBoltBackdraft.baseCasttime = ((2.5 * backdraftFactor) - (0.1 * bane.pointsSpend)) / hasteFactor;



            double moltenCoreDamageFactor = 1 + (0.06 * moltenCore.pointsSpend);

            double ImprovedCorruptionDmgFactor = 1 + (improvedCorruption.pointsSpend * 0.02);
            double AftermathDmgFactor = 1 + (0.03 * aftermath.pointsSpend);
            double improvedImmolateDmgFactor = 1 + (0.1 * improvedImmolate.pointsSpend);

            double CorruptionDamageFactor = setPieceImmoCorrUADmgFactor * ImprovedCorruptionDmgFactor;

            double corrDPS = (((1080 / 6) + (0.2 * sp)) / CorruptionTickSpeed) * CorruptionDamageFactor * stoneDoTDmgFactor * CorruptionUptimeFactor;
            double immoDPS = ((((460 + 0.2 * sp) * stoneDirectDmgFactor) + ((((1256 / 8) + (0.2 * sp)) * 8) * stoneDoTDmgFactor * glyphOfImmolateDoTFactor * immolateUptimeFactor * AftermathDmgFactor)) / 24) * setPieceImmoCorrUADmgFactor * improvedImmolateDmgFactor;
            double SBDPS = ((((759 + 847) / 2) + (0.8569 * sp)) * improvedShadowBoltDamageFactor * talentsShadowDamageFactor * stoneDirectDmgFactor) / SBEffectiveCastTime;
            double IncinDPS = ((((611 + 710) / 2 + (152 + 178) / 2) + 0.7139 * sp) * glyphOfIncinerateFactor * moltenCoreDamageFactor * talentsFireDamageFactor * stoneDirectDmgFactor) / IncinMoltenCoreCastTime;
            double SFDPS = ((((1323 + 1657) / 2) + (1.15 * sp)) * talentsFireDamageFactor * stoneDirectDmgFactor) / SFDecimationCastTime;

            bool decimate = decimation.pointsSpend > 0;
            double SBIncinPart = decimate ? 0.65 : 1;
            double SFPart = decimate ? 0.35 : 0;

            double corruptionTicksPerSec = 1 / CorruptionTickSpeed;
            double chanceIncin = CalculateUptimeFactor(moltenCoreChance, corruptionTicksPerSec, 0, 3 * IncinMoltenCoreEffectiveTime);
            double chanceSB = 1 - chanceIncin;

            double chanceMoltenCoreWhileSF = ((SFDecimationCastTime / CorruptionTickSpeed) * moltenCoreChance) * 3;


            int numImmolationAuraTicks = metamorphosisLearned ? (glyphOfMetamorphosis ? 30 : 15) : 0;
            double immolationAuraDamage = numImmolationAuraTicks * (251 + (0.1714 * sp)) * stoneDoTDmgFactor * talentsFireDamageFactor * setPieceAllDmgFactor; //asuming all ticks are within demo form uptime
            double immolationAuraDPS = immolationAuraDamage / metamorphosisCD;

            int numShadowCleaves = metamorphosisLearned ? (glyphOfMetamorphosis ? 6 : 5) : 0;
            double shadowCleaveDamage = numShadowCleaves * (110 + (0.2571 * sp)) * stoneDirectDmgFactor * talentsShadowDamageFactor * shadowCleaveCritFactor * setPieceAllDmgFactor;
            double shadowCleaveDPS = shadowCleaveDamage / metamorphosisCD;



            double lockDPS = ((((immoDPS * immoCritFactor) + corrDPS + (SBIncinPart * ((chanceIncin * (IncinDPS * IncinerateCritFactor)) + (chanceSB * (SBDPS * SBCritFactor))) + SFPart * (SFDPS * SFCritFactor))) * (metamorphosisDmgFactor * setPieceAllDmgFactor))) + shadowCleaveDPS + immolationAuraDPS;
            lockDPS = applySpellHitrating(lockDPS, (int)_hitrating, hitPercentBonus);
            double minionDPS = minion.getDPS();
            minionDPS *= 1 + (race.getRaceBonus().petDamagePercent * 0.01);
            minionDPS = applySpellHitrating(minionDPS, 0, buffHitPercent);
            double dps = lockDPS + minionDPS;
            return dps;
        }

        private void updateMinionStats(double stam = -1, double sp = -1, double crit = -1, double intel = -1)
        {
            if(stam != -1) minion.masterStamina = stam;
            if(sp != -1) minion.masterSpellPower = sp;
            if(crit != -1) minion.masterCrit = crit;
            if(intel != -1) minion.masterIntelect = intel;
        }

        public override bool statIsRelevant(Stat stat)
        {
            switch (stat)
            {
                case Stat.Hitrating:
                case Stat.Critrating:
                case Stat.Hasterating:
                case Stat.Stamina:
                case Stat.Intelect:
                case Stat.Spirit:
                case Stat.Spellpower:
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
                case Race.Name.BloodElf:
                case Race.Name.Orc:
                case Race.Name.Undead:
                case Race.Name.Gnome:
                    return true;
            }
            return false;
        }

        public void setCurse(Curse curse)
        {
            this.curse = curse;
        }
    }
}
