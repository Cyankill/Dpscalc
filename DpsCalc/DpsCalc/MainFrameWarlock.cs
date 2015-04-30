using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using demo.Classes.Warlock;

namespace demo
{
    public partial class MainFrame
    {
        //TALENTS
        //AFFLI
        private void numSuppression_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).suppression = (int)numSuppression.Value;
            updateDPSandIncreases();
        }

        private void numImprovedCorruption_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).improvedCorruption = (int)numImprovedCorruption.Value;
            updateDPSandIncreases();
        }

        private void numImprovedLifeTap_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).improvedLifeTap = (int)numImprovedLifeTap.Value;
            updateDPSandIncreases();
        }

        private void numNightfall_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).nightfall = (int)numNightfall.Value;
            updateDPSandIncreases();
        }

        private void numEmpoweredCorruption_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).demonicEmpowerment = (int)numEmpoweredCorruption.Value;
            updateDPSandIncreases();
        }

        private void numShadowEmbrace_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).shadowEmbrace = (int)numShadowEmbrace.Value;
            updateDPSandIncreases();
        }

        private void numSiphonLife_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).siphonLife = (int)numSiphonLife.Value;
            updateDPSandIncreases();
        }

        //DEMO
        private void numImprovedImp_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).improvedImp = (int)numImprovedImp.Value;
            //((Warlock)player).minion.improvedImp = ((Warlock)player).improvedImp;
            updateDPSandIncreases();
        }

        private void numDemonicEmbrace_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).demonicEmbrace = (int)numDemonicEmbrace.Value;
            updateDPSandIncreases();
        }

        private void numFelSynergy_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).felSynergy = (int)numFelSynergy.Value;
            //((Warlock)player).minion.felSynergy = ((Warlock)player).felSynergy;
            updateDPSandIncreases();
        }

        private void numDemonicBrutality_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).demonicBrutality = (int)numDemonicBrutality.Value;
            //((Warlock)player).minion.demonicBrutality = ((Warlock)player).demonicBrutality;
            updateDPSandIncreases();
        }

        private void numFelVitality_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).felVitality = (int)numFelVitality.Value;
            //((Warlock)player).minion.felVitality = ((Warlock)player).felVitality;
            updateDPSandIncreases();
        }

        private void numUnholyPower_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).unholyPower = (int)numUnholyPower.Value;
            //((Warlock)player).minion.unholyPower = ((Warlock)player).unholyPower;
            updateDPSandIncreases();
        }

        private void numDemonicAegis_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).demonicAegis = (int)numDemonicAegis.Value;
            updateDPSandIncreases();
        }

        private void numManaFeed_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).manaFeed = (int)numManaFeed.Value;
            //((Warlock)player).minion.manaFeed = ((Warlock)player).manaFeed;
            updateDPSandIncreases();
        }

        private void numMasterConjurer_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).masterConjurer = (int)numMasterConjurer.Value;
            updateDPSandIncreases();
        }

        private void numMasterDemonologist_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).masterDemonologist = (int)numMasterDemonologist.Value;
            updateDPSandIncreases();
        }

        private void numMoltenCore_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).moltenCore = (int)numMoltenCore.Value;
            updateDPSandIncreases();
        }

        private void numDemonicEmpowerment_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).demonicEmpowerment = (int)numDemonicEmpowerment.Value;
            //((Warlock)player).minion.demonicEmpowerment = ((Warlock)player).demonicEmpowerment;
            updateDPSandIncreases();
        }

        private void numDemonicKnowledge_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).demonicKnowledge = (int)numDemonicKnowledge.Value;
            updateDPSandIncreases();
        }

        private void numDemonicTactics_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).demonicTactics = (int)numDemonicTactics.Value;
            updateDPSandIncreases();
        }

        private void numDecimation_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).decimation = (int)numDecimation.Value;
            updateDPSandIncreases();
        }

        private void numImprovedDemonicTactics_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).improvedDemonicTactics = (int)numImprovedDemonicTactics.Value;
            //((Warlock)player).minion.improvedDemonicTactics = ((Warlock)player).demonicTactics;
            updateDPSandIncreases();
        }

        private void numSummonFelguard_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).summonFelguard = (int)numSummonFelguard.Value;
            //((Warlock)player).minion.summonFelguard = ((Warlock)player).summonFelguard;
            setMinionWarningVisibility();
            updateDPSandIncreases();
        }

        private void numNemesis_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).nemesis = (int)numNemesis.Value;
            //((Warlock)player).minion.nemesis = ((Warlock)player).nemesis;
            updateDPSandIncreases();
        }

        private void numDemonicPact_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).demonicPact = (int)numDemonicPact.Value;
            updateDPSandIncreases();
        }

        private void numMetamorphosis_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).metamorphosis = (int)numMetamorphosis.Value;
            updateDPSandIncreases();
        }

        //DESTRO
        private void numImprovedShadowBolt_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).improvedShadowBolt = (int)numImprovedShadowBolt.Value;
            updateDPSandIncreases();
        }

        private void numBane_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).bane = (int)numBane.Value;
            updateDPSandIncreases();
        }

        private void numAftermath_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).aftermath = (int)numAftermath.Value;
            updateDPSandIncreases();
        }

        private void numCataclysm_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).cataclysm = (int)numCataclysm.Value;
            updateDPSandIncreases();
        }

        private void numDemonicPower_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).demonicPower = (int)numDemonicPower.Value;
            //((Warlock)player).minion.demonicPower = ((Warlock)player).demonicPower;
            updateDPSandIncreases();
        }

        private void numRuin_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).ruin = (int)numRuin.Value;
            //((Warlock)player).minion.ruin = ((Warlock)player).ruin;
            updateDPSandIncreases();
        }

        private void numIntensity_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).intensity = (int)numIntensity.Value;
            updateDPSandIncreases();
        }

        private void numBacklash_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).backlash = (int)numBacklash.Value;
            updateDPSandIncreases();
        }

        private void numImprovedImmolate_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).improvedImmolate = (int)numImprovedImmolate.Value;
            updateDPSandIncreases();
        }

        private void numDevastation_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).devastation = (int)numDevastation.Value;
            updateDPSandIncreases();
        }


        private void numEmberstorm_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).emberstorm = (int)numEmberstorm.Value;
            updateDPSandIncreases();
        }

        private void numConflagrate_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).conflagrate = (int)numConflagrate.Value;
            updateDPSandIncreases();
        }

        private void numPyroclasm_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).pyroclasm = (int)numPyroclasm.Value;
            updateDPSandIncreases();
        }

        private void numShadowAndFlame_ValueChanged(object sender, EventArgs e)
        {
            //((Warlock)player).shadowAndFlame = (int)numShadowAndFlame.Value;
            updateDPSandIncreases();
        }
        
        //GLYPHS
        private void checkBoxGlyphOfLifeTap_CheckedChanged(object sender, EventArgs e)
        {
            ((Warlock)player).glyphOfLifeTap = checkBoxGlyphOfLifeTap.Checked;
            setWarlockGlyphWarningVisibility();
            updateDPSandIncreases();
        }

        private void checkBoxGlyphOfMetamorphosis_CheckedChanged(object sender, EventArgs e)
        {
            ((Warlock)player).glyphOfMetamorphosis = checkBoxGlyphOfMetamorphosis.Checked;
            setWarlockGlyphWarningVisibility();
            updateDPSandIncreases();
        }

        private void checkBoxGlyphOfImmolate_CheckedChanged(object sender, EventArgs e)
        {
            ((Warlock)player).glyphOfImmolate = checkBoxGlyphOfImmolate.Checked;
            setWarlockGlyphWarningVisibility();
            updateDPSandIncreases();
        }

        private void checkBoxGlyphOfQuickDecay_CheckedChanged(object sender, EventArgs e)
        {
            ((Warlock)player).glyphOfQuickDecay = checkBoxGlyphOfQuickDecay.Checked;
            setWarlockGlyphWarningVisibility();
            updateDPSandIncreases();
        }

        private void checkBoxGlyphOfIncinerate_CheckedChanged(object sender, EventArgs e)
        {
            ((Warlock)player).glyphOfIncinerate = checkBoxGlyphOfIncinerate.Checked;
            setWarlockGlyphWarningVisibility();
            updateDPSandIncreases();
        }

        private void checkBoxGlyphOfShadowbolt_CheckedChanged(object sender, EventArgs e)
        {
            ((Warlock)player).glyphOfShadowbolt = checkBoxGlyphOfShadowbolt.Checked;
            setWarlockGlyphWarningVisibility();
            updateDPSandIncreases();
        }

        private void checkBoxGlyphOfCorruption_CheckedChanged(object sender, EventArgs e)
        {
            ((Warlock)player).glyphOfCorruption = checkBoxGlyphOfCorruption.Checked;
            setWarlockGlyphWarningVisibility();
            updateDPSandIncreases();
        }

        private void checkBoxGlyphOfFelguard_CheckedChanged(object sender, EventArgs e)
        {
            ((Warlock)player).glyphOfFelguard = checkBoxGlyphOfFelguard.Checked;
            ((Warlock)player).minion.glyphOfFelguard = ((Warlock)player).glyphOfFelguard;
            setWarlockGlyphWarningVisibility();
            updateDPSandIncreases();
        }

        private void checkBoxGlyphOfVoidwalker_CheckedChanged(object sender, EventArgs e)
        {
            ((Warlock)player).glyphOfVoidwalker = checkBoxGlyphOfVoidwalker.Checked;
            ((Warlock)player).minion.glyphOfVoidwalker = ((Warlock)player).glyphOfVoidwalker;
            setWarlockGlyphWarningVisibility();
            updateDPSandIncreases();
        }

        private void checkBoxGlyphOfImp_CheckedChanged(object sender, EventArgs e)
        {
            ((Warlock)player).glyphOfImp = checkBoxGlyphOfImp.Checked;
            ((Warlock)player).minion.glyphOfImp = ((Warlock)player).glyphOfImp;
            setWarlockGlyphWarningVisibility();
            updateDPSandIncreases();
        }

        private void checkBoxGlyphOfConflagrate_CheckedChanged(object sender, EventArgs e)
        {
            ((Warlock)player).glyphOfConflagrate = checkBoxGlyphOfConflagrate.Checked;
            updateDPSandIncreases();
        }

        public void setWarlockGlyphWarningVisibility()
        {
            int glyphCount = 0;
            glyphCount += ((Warlock)player).glyphOfLifeTap ? 1 : 0;
            glyphCount += ((Warlock)player).glyphOfMetamorphosis ? 1 : 0;
            glyphCount += ((Warlock)player).glyphOfImmolate ? 1 : 0;
            glyphCount += ((Warlock)player).glyphOfQuickDecay ? 1 : 0;
            glyphCount += ((Warlock)player).glyphOfIncinerate ? 1 : 0;
            glyphCount += ((Warlock)player).glyphOfShadowbolt ? 1 : 0;
            glyphCount += ((Warlock)player).glyphOfCorruption ? 1 : 0;
            glyphCount += ((Warlock)player).glyphOfFelguard ? 1 : 0;
            glyphCount += ((Warlock)player).glyphOfVoidwalker ? 1 : 0;
            glyphCount += ((Warlock)player).glyphOfImp ? 1 : 0;
            glyphCount += ((Warlock)player).glyphOfConflagrate ? 1 : 0;
            labelGlyphWarning.Visible = glyphCount > 3;
        }

        //OTHER WARLOCK UI PARTS
        private void comboBoxStone_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxStone.SelectedIndex)
            {
                case 0:
                    ((Warlock)player).stone = WarlockWeaponEnchant.Spellstone;
                    break;
                case 1:
                    ((Warlock)player).stone = WarlockWeaponEnchant.Firestone;
                    break;
            }
            updateDPSandIncreases();
        }

        private void comboBoxMinion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMinion.SelectedIndex)
            {
                case 0:
                    ((Warlock)player).minion.change(((Warlock)player).imp);
                    break;
                case 1:
                    ((Warlock)player).minion.change(((Warlock)player).felhunter);
                    break;
                case 2:
                    ((Warlock)player).minion.change(((Warlock)player).voidwalker);
                    break;
                case 3:
                    ((Warlock)player).minion.change(((Warlock)player).succubus);
                    break;
                case 4:
                    ((Warlock)player).minion.change(((Warlock)player).felguard);
                    break;
            }
            setMinionWarningVisibility();
            updateDPSandIncreases();
        }

        public void setMinionWarningVisibility()
        {
            bool fg = ((Warlock)player).minion.kind == Minion.Felguard && ((Warlock)player).summonFelguard.pointsSpend == 0;
            labelMinionWarning.Visible = fg;
            if (fg) ((Warlock)player).minion = Warlock.none;
        }

        private void comboxSpellOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((Warlock)player).corruptionOverImmolate = comboxSpellOrder.SelectedIndex == 0;
            updateDPSandIncreases();
        }
    }
}
