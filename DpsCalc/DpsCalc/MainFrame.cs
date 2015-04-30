using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using demo.Classes.Warlock;

namespace demo
{
    public partial class MainFrame : Form
    {
        Player player = new Player();

        //COMPARING
        bool OneForTwo = false;
        bool TwoForOne = false;

        int hitratingEquipped = 0;
        int hitratingNew = 0;
        int hitratingEquippedNew = 0;
        int critratingEquipped = 0;
        int critratingNew = 0;
        int critratingEquippedNew = 0;
        int hasteratingEquipped = 0;
        int hasteratingNew = 0;
        int hasteratingEquippedNew = 0;
        int strengthEquipped = 0;
        int strengthNew = 0;
        int strengthEquippedNew = 0;
        int agilityEquipped = 0;
        int agilityNew = 0;
        int agilityEquippedNew = 0;
        int staminaEquipped = 0;
        int staminaNew = 0;
        int staminaEquippedNew = 0;
        int intelectEquipped = 0;
        int intelectNew = 0;
        int intelectEquippedNew = 0;
        int spiritEquipped = 0;
        int spiritNew = 0;
        int spiritEquippedNew = 0;
        int armorpenetrationEquipped = 0;
        int armorpenetrationNew = 0;
        int armorpenetrationEquippedNew = 0;
        int baseSpeedEquipped = 0;
        int baseSpeedNew = 0;
        int baseSpeedEquippedNew = 0;
        int powerEquipped = 0;
        int powerNew = 0;
        int powerEquippedNew = 0;
        int expertiseratingEquipped = 0;
        int expertiseratingNew = 0;
        int expertiseratingEquippedNew = 0;
        int rangedPowerEquipped = 0;
        int rangedPowerNew = 0;
        int rangedPowerEquippedNew = 0;
        int spellpowerEquipped = 0;
        int spellpowerNew = 0;
        int spellpowerEquippedNew = 0;
        int manaregenEquipped = 0;
        int manaregenNew = 0;
        int manaregenEquippedNew = 0;


        public MainFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateDPSandIncreases();
            updateTabsContent();
            new testForm().Show();
        }

        public void updateDPSandIncreases()
        {
            if (player != null)
            {
                double dps = player.calculateDPS();
                this.Text = dps + "";

                labelHitratingDPSPerPoint.Text = player.calculateDPS(hitratingIncrease: 1) - dps + "";
                labelStaminaDPSPerPoint.Text = player.calculateDPS(staminaIncrease: 1) - dps + "";
                labelSpellPowerDPSPerPoint.Text = player.calculateDPS(spellpowerIncrease: 1) - dps + "";
                labelCritratingDPSPerPoint.Text = player.calculateDPS(critratingIncrease: 1) - dps + "";
                labelHasteratingDPSPerPoint.Text = player.calculateDPS(hasteratingIncrease: 1) - dps + "";
                labelIntelectDPSPerPoint.Text = player.calculateDPS(intelectIncrease: 1) - dps + "";
                labelSpiritDPSPerPoint.Text = player.calculateDPS(spiritIncrease: 1) - dps + "";
                labelManaregenDPSPerPoint.Text = player.calculateDPS(manaregenIncrease: 1) - dps + "";

                labelHitratingDPSPerGem.Text = player.calculateDPS(hitratingIncrease: 20) - dps + "";
                labelStaminaDPSPerGem.Text = player.calculateDPS(staminaIncrease: 30) - dps + "";
                labelSpellPowerDPSPerGem.Text = player.calculateDPS(spellpowerIncrease: 23) - dps + "";
                labelCritratingDPSPerGem.Text = player.calculateDPS(critratingIncrease: 20) - dps + "";
                labelHasteratingDPSPerGem.Text = player.calculateDPS(hasteratingIncrease: 20) - dps + "";
                labelIntelectDPSPerGem.Text = player.calculateDPS(intelectIncrease: 20) - dps + "";
                labelSpiritDPSPerGem.Text = player.calculateDPS(spiritIncrease: 20) - dps + "";
                labelManaregenDPSPerGem.Text = player.calculateDPS(manaregenIncrease: 20) - dps + "";

                updateDPSGain();
            }
        }



        public void updateDPSGain()
        {
            double gain = calculateDPSGain();
            textBoxDPSGain.ForeColor = gain >= 0 ? Color.Black : Color.Red;
            textBoxDPSGain.Text = gain + "";
        }

        public double calculateDPSGain()
        {
            double newDPS = 0;
            if (OneForTwo)
            {
                newDPS = player.calculateDPS(hitratingIncrease: (hitratingNew + hitratingEquippedNew)- hitratingEquipped,
                                                    critratingIncrease: (critratingNew + critratingEquippedNew) - critratingEquipped,
                                                    hasteratingIncrease: (hasteratingNew + hasteratingEquippedNew) - hasteratingEquipped,
                                                    strengthIncrease: (strengthNew + strengthEquippedNew) - strengthEquipped,
                                                    agilityIncrease: (agilityNew + agilityEquippedNew) - agilityEquipped,
                                                    staminaIncrease: (staminaNew + staminaEquippedNew) - staminaEquipped,
                                                    intelectIncrease: (intelectNew + intelectEquippedNew) - intelectEquipped,
                                                    spiritIncrease: (spiritNew + spiritEquippedNew) - spiritEquipped,
                                                    armorpenetrationIncrease: (armorpenetrationNew + armorpenetrationEquippedNew) - armorpenetrationEquipped,
                                                    baseSpeedIncrease: (baseSpeedNew + baseSpeedEquippedNew) - baseSpeedEquipped,
                                                    powerIncrease: (powerNew + powerEquippedNew) - powerEquipped,
                                                    expertiseratingIncrease: (expertiseratingNew + expertiseratingEquippedNew) - expertiseratingEquipped,
                                                    rangedPowerIncrease: (rangedPowerNew + rangedPowerEquippedNew) - rangedPowerEquipped,
                                                    spellpowerIncrease: (spellpowerNew + spellpowerEquippedNew) - spellpowerEquipped,
                                                    manaregenIncrease: (manaregenNew + manaregenEquippedNew) - manaregenEquipped
                                                    );
            }
            else if (TwoForOne)
            {
                newDPS = player.calculateDPS(hitratingIncrease: hitratingNew - (hitratingEquippedNew + hitratingEquipped),
                                                    critratingIncrease: critratingNew - (critratingEquippedNew + critratingEquipped),
                                                    hasteratingIncrease: hasteratingNew - (hasteratingEquippedNew + hasteratingEquipped),
                                                    strengthIncrease: strengthNew - (strengthEquippedNew + strengthEquipped),
                                                    agilityIncrease: agilityNew - (agilityEquippedNew + agilityEquipped),
                                                    staminaIncrease: staminaNew - (staminaEquippedNew + staminaEquipped),
                                                    intelectIncrease: intelectNew - (intelectEquippedNew + intelectEquipped),
                                                    spiritIncrease: spiritNew - (spiritEquippedNew + spiritEquipped),
                                                    armorpenetrationIncrease: armorpenetrationNew - (armorpenetrationEquippedNew + armorpenetrationEquipped),
                                                    baseSpeedIncrease: baseSpeedNew - (baseSpeedEquippedNew + baseSpeedEquipped),
                                                    powerIncrease: powerNew - (powerEquippedNew + powerEquipped),
                                                    expertiseratingIncrease: expertiseratingNew - (expertiseratingEquippedNew + expertiseratingEquipped),
                                                    rangedPowerIncrease: rangedPowerNew - (rangedPowerEquippedNew + rangedPowerEquipped),
                                                    spellpowerIncrease: spellpowerNew - (spellpowerEquippedNew + spellpowerEquipped),
                                                    manaregenIncrease: manaregenNew - (manaregenEquippedNew + manaregenEquipped)
                                                    );
            }
            else
            {
                newDPS = player.calculateDPS(hitratingIncrease: hitratingNew - hitratingEquipped,
                                                    critratingIncrease: critratingNew - critratingEquipped,
                                                    hasteratingIncrease: hasteratingNew - hasteratingEquipped,
                                                    strengthIncrease: strengthNew - strengthEquipped,
                                                    agilityIncrease: agilityNew - agilityEquipped,
                                                    staminaIncrease: staminaNew - staminaEquipped,
                                                    intelectIncrease: intelectNew - intelectEquipped,
                                                    spiritIncrease: spiritNew - spiritEquipped,
                                                    armorpenetrationIncrease: armorpenetrationNew - armorpenetrationEquipped,
                                                    baseSpeedIncrease: baseSpeedNew - baseSpeedEquipped,
                                                    powerIncrease: powerNew - powerEquipped,
                                                    expertiseratingIncrease: expertiseratingNew - expertiseratingEquipped,
                                                    rangedPowerIncrease: rangedPowerNew - rangedPowerEquipped,
                                                    spellpowerIncrease: spellpowerNew - spellpowerEquipped,
                                                    manaregenIncrease: manaregenNew - manaregenEquipped
                                                    );
            }
            double oldDPS = player.calculateDPS();
            return newDPS - oldDPS;
        }

        private void TextBoxSpellPower_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.spellPower = Convert.ToInt32(textBoxSpellPower.Text);
            }
            catch (FormatException)
            {
                player.spellPower = 0;
            }
            updateDPSandIncreases();
        }

        private void TextBoxCritRating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.critrating = Convert.ToInt32(textBoxCritrating.Text);
            }
            catch (FormatException)
            {
                player.critrating = 0;
            }
            updateDPSandIncreases();
        }

        private void TextBoxHasteRating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.hasterating = Convert.ToInt32(textBoxHasterating.Text);
            }
            catch (FormatException)
            {
                player.hasterating = 0;
            }
            updateDPSandIncreases();
        }

        private void TextBoxInt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.intelect = Convert.ToInt32(textBoxIntelect.Text);
            }
            catch (FormatException)
            {
                player.intelect = 0;
            }
            updateDPSandIncreases();
        }

        private void TextBoxSpirit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.spirit = Convert.ToInt32(textBoxSpirit.Text);
            }
            catch (FormatException)
            {
                player.spirit = 0;
            }
            updateDPSandIncreases();
        }

        private void numT9_ValueChanged(object sender, EventArgs e)
        {
            player.t9_2PieceBonus = numT9.Value >= 2;
            player.t9_4PieceBonus = numT9.Value >= 4;
            setSetpieceWarningVisibility();
            updateDPSandIncreases();
        }

        private void numT10_ValueChanged(object sender, EventArgs e)
        {
            player.t10_2PieceBonus = numT10.Value >= 2;
            player.t10_4PieceBonus = numT10.Value >= 4;
            setSetpieceWarningVisibility();
            updateDPSandIncreases();
        }

        private void numPvP_ValueChanged(object sender, EventArgs e)
        {
            player.PvP_2PieceBonus = numPvP.Value >= 2;
            player.PvP_4PieceBonus = numPvP.Value >= 4;
            setSetpieceWarningVisibility();
            updateDPSandIncreases();
        }

        public void setSetpieceWarningVisibility()
        {
            labelSetpieceWarning.Visible = (numT9.Value + numT10.Value + numPvP.Value) > 5;
        }


        private void TextBoxStamina_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.stamina = Convert.ToInt32(textBoxStamina.Text);
            }
            catch (FormatException)
            {
                player.stamina = 0;
            }
            updateDPSandIncreases();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            labelSave3.Text = labelSave2.Text;
            labelSave2.Text = labelSave1.Text;
            labelSave1.Text = textBoxSave.Text + " - " + this.Text;
        }

        private void numTargetLevel_ValueChanged(object sender, EventArgs e)
        {
            player.targetLevel = (int)numTargetLevel.Value;
            updateDPSandIncreases();
        }

        private void textBoxStaminaEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                staminaEquipped = Convert.ToInt32(textBoxStaminaEquipped.Text);
            }
            catch (FormatException)
            {
                staminaEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxSpellpowerEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spellpowerEquipped = Convert.ToInt32(textBoxSpellPowerEquipped.Text);
            }
            catch (FormatException)
            {
                spellpowerEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxCritEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                critratingEquipped = Convert.ToInt32(textBoxCritratingEquipped.Text);
            }
            catch (FormatException)
            {
                critratingEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxHasteEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hasteratingEquipped = Convert.ToInt32(textBoxHasteratingEquipped.Text);
            }
            catch (FormatException)
            {
                hasteratingEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxIntEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                intelectEquipped = Convert.ToInt32(textBoxIntelectEquipped.Text);
            }
            catch (FormatException)
            {
                intelectEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxSpiritEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spiritEquipped = Convert.ToInt32(textBoxSpiritEquipped.Text);
            }
            catch (FormatException)
            {
                spiritEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxStaminaNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                staminaNew = Convert.ToInt32(textBoxStaminaNew.Text);
            }
            catch (FormatException)
            {
                staminaNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxSpellpowerNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spellpowerNew = Convert.ToInt32(textBoxSpellPowerNew.Text);
            }
            catch (FormatException)
            {
                spellpowerNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxCritNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                critratingNew = Convert.ToInt32(textBoxCritratingNew.Text);
            }
            catch (FormatException)
            {
                critratingNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxHasteNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hasteratingNew = Convert.ToInt32(textBoxHasteratingNew.Text);
            }
            catch (FormatException)
            {
                hasteratingNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxIntNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                intelectNew = Convert.ToInt32(textBoxIntelectNew.Text);
            }
            catch (FormatException)
            {
                intelectNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxSpiritNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spiritNew = Convert.ToInt32(textBoxSpiritNew.Text);
            }
            catch (FormatException)
            {
                spiritNew = 0;
            }
            updateDPSGain();
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxClass.SelectedIndex)
            {
                case 0:
                    player = new Deathknight();
                    break;
                case 1:
                    player = new Druid();
                    break;
                case 2:
                    player = new Hunter();
                    break;
                case 3:
                    player = new Mage();
                    break;
                case 4:
                    player = new Paladin();
                    break;
                case 5:
                    player = new Priest();
                    break;
                case 6:
                    player = new Rogue();
                    break;
                case 7:
                    player = new Shaman();
                    break;
                case 8:
                    player = new Warlock();
                    break;
                case 9:
                    player = new Warrior();
                    break;
            }
            updateDPSandIncreases();
            updateTabsContent();
            updateRaceClassWarning();
        }

        private void comboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxRace.SelectedIndex)
            {
                case 0:
                    player.race.name = Race.Name.Human;
                    break;
                case 1:
                    player.race.name = Race.Name.Dwarf;
                    break;
                case 2:
                    player.race.name = Race.Name.NightElf;
                    break;
                case 3:
                    player.race.name = Race.Name.Gnome;
                    break;
                case 4:
                    player.race.name = Race.Name.Draenei;
                    break;
                case 5:
                    player.race.name = Race.Name.Orc;
                    break;
                case 6:
                    player.race.name = Race.Name.Undead;
                    break;
                case 7:
                    player.race.name = Race.Name.Tauren;
                    break;
                case 8:
                    player.race.name = Race.Name.Troll;
                    break;
                case 9:
                    player.race.name = Race.Name.BloodElf;
                    break;
            }
            updateRaceClassWarning();
            updateDPSandIncreases();
        }

        public void updateRaceClassWarning()
        {
            labelRaceClassWarning.Visible = !player.isValidRace();
        }

        public void updateTabsContent()
        {
            updateStatsTabContentEnabled();
            updateTalentsTabContentVisible();
        }

        public void initializeTalentsTabContent()
        {
            groupBoxWarlockTalents.Location = new Point(6, 6);
            groupBoxHunterTalents.Location = new Point(6, 6);
        }

        public void updateTalentsTabContentVisible()
        {
            groupBoxHunterTalents.Visible = player is Hunter;
            groupBoxHunterTalents.Size = new Size(1181, 689);
            groupBoxHunterTalents.Location = new Point(6, 6);
            groupBoxWarlockTalents.Visible = player is Warlock;
            groupBoxWarlockTalents.Size = new Size(983, 573);
            groupBoxWarlockTalents.Location = new Point(6, 6);
            //groupBoxDeathknightTalents.Visible = player is Deathknight;
            //groupBoxDeathknightTalents.Size = new Size(1000, 600);
            //groupBoxDeathknightTalents.Location = new Point(6, 6);
            //groupBoxDruidTalents.Visible = player is Druid;
            //groupBoxDruidTalents.Size = new Size(1000, 600);
            //groupBoxDruidTalents.Location = new Point(6, 6);
            //groupBoxMageTalents.Visible = player is Mage;
            //groupBoxMageTalents.Size = new Size(1000, 600);
            //groupBoxMageTalents.Location = new Point(6, 6);
            //groupBoxPaladinTalents.Visible = player is Paladin;
            //groupBoxPaladinTalents.Size = new Size(1000, 600);
            //groupBoxPaladinTalents.Location = new Point(6, 6);
            //groupBoxPriestTalents.Visible = player is Priest;
            //groupBoxPriestTalents.Size = new Size(1000, 600);
            //groupBoxPriestTalents.Location = new Point(6, 6);
            //groupBoxRogueTalents.Visible = player is Rogue;
            //groupBoxRogueTalents.Size = new Size(1000, 600);
            //groupBoxRogueTalents.Location = new Point(6, 6);
            //groupBoxShamanTalents.Visible = player is Shaman;
            //groupBoxShamanTalents.Size = new Size(1000, 600);
            //groupBoxShamanTalents.Location = new Point(6, 6);
            //groupBoxWarriorTalents.Visible = player is Warrior;
            //groupBoxWarriorTalents.Size = new Size(1000, 600);
            //groupBoxWarriorTalents.Location = new Point(6, 6);
        }

        public void updateStatsTabContentEnabled()
        {
            updateStatsEnabled();
            groupBoxGear.Enabled = player.ClassPicked();
        }

        public void updateStatsEnabled()
        {
            bool strength = player.statIsRelevant(Stat.Strength);
            bool agility = player.statIsRelevant(Stat.Agility);
            bool stamina = player.statIsRelevant(Stat.Stamina);
            bool intelect = player.statIsRelevant(Stat.Intelect);
            bool spirit = player.statIsRelevant(Stat.Spirit);
            bool speed = player.statIsRelevant(Stat.BaseSpeed);
            bool power = player.statIsRelevant(Stat.Power);
            bool arp = player.statIsRelevant(Stat.Armorpenetration);
            bool exp = player.statIsRelevant(Stat.Expertiserating);
            bool rangedPower = player.statIsRelevant(Stat.RangedPower);
            bool spellpower = player.statIsRelevant(Stat.Spellpower);
            bool hitrating = player.statIsRelevant(Stat.Hitrating);
            bool critrating = player.statIsRelevant(Stat.Critrating);
            bool hasterating = player.statIsRelevant(Stat.Hasterating);
            bool manaregen = player.statIsRelevant(Stat.Manaregen);
            //bool armor = player.statIsRelevant(Stat.Armor);
            //bool defence = player.statIsRelevant(Stat.Defence);
            //bool dodgerating = player.statIsRelevant(Stat.Dodgerating);
            //bool parryrating = player.statIsRelevant(Stat.Parryrating);
            //bool blockrating = player.statIsRelevant(Stat.Blockrating);
            //bool blockvalue = player.statIsRelevant(Stat.Blockvalue);
            //bool resillience = player.statIsRelevant(Stat.Resillience);

            labelStrength.Enabled = strength;
            textBoxStrength.Enabled = strength;
            labelStrengthDPSPerPoint.Enabled = strength;
            labelStrengthDPSPerGem.Enabled = strength;
            textBoxStrengthEquipped.Enabled = strength;
            textBoxStrengthNew.Enabled = strength;
            textBoxStrengthEquippedNew.Enabled = strength;

            labelAgility.Enabled = agility;
            textBoxAgility.Enabled = agility;
            labelAgilityDPSPerPoint.Enabled = agility;
            labelAgilityDPSPerGem.Enabled = agility;
            textBoxAgilityEquipped.Enabled = agility;
            textBoxAgilityNew.Enabled = agility;
            textBoxAgilityEquippedNew.Enabled = agility;

            labelStamina.Enabled = stamina;
            textBoxStamina.Enabled = stamina;
            labelStaminaDPSPerPoint.Enabled = stamina;
            labelStaminaDPSPerGem.Enabled = stamina;
            textBoxStaminaEquipped.Enabled = stamina;
            textBoxStaminaNew.Enabled = stamina;
            textBoxStaminaEquippedNew.Enabled = stamina;

            labelIntelect.Enabled = intelect;
            textBoxIntelect.Enabled = intelect;
            labelIntelectDPSPerPoint.Enabled = intelect;
            labelIntelectDPSPerGem.Enabled = intelect;
            textBoxIntelectEquipped.Enabled = intelect;
            textBoxIntelectNew.Enabled = intelect;
            textBoxIntelectEquippedNew.Enabled = intelect;

            labelSpirit.Enabled = spirit;
            textBoxSpirit.Enabled = spirit;
            labelSpiritDPSPerPoint.Enabled = spirit;
            labelSpiritDPSPerGem.Enabled = spirit;
            textBoxSpiritEquipped.Enabled = spirit;
            textBoxSpiritNew.Enabled = spirit;
            textBoxSpiritEquippedNew.Enabled = spirit;

            labelSpeed.Enabled = speed;
            textBoxSpeed.Enabled = speed;
            labelSpeedDPSPerPoint.Enabled = speed;
            labelSpeedDPSPerGem.Enabled = speed;
            textBoxBaseSpeedEquipped.Enabled = speed;
            textBoxBaseSpeedNew.Enabled = speed;
            textBoxBaseSpeedEquippedNew.Enabled = speed;

            labelPower.Enabled = power;
            textBoxPower.Enabled = power;
            labelPowerDPSPerPoint.Enabled = power;
            labelPowerDPSPerGem.Enabled = power;
            textBoxPowerEquipped.Enabled = power;
            textBoxPowerNew.Enabled = power;
            textBoxPowerEquippedNew.Enabled = power;

            labelArp.Enabled = arp;
            textBoxArp.Enabled = arp;
            labelArpDPSPerPoint.Enabled = arp;
            labelArpDPSPerGem.Enabled = arp;
            textBoxArmorpenetrationEquipped.Enabled = arp;
            textBoxArmorpenetrationNew.Enabled = arp;
            textBoxArmorpenetrationEquippedNew.Enabled = arp;

            labelExp.Enabled = exp;
            textBoxExp.Enabled = exp;
            labelExpDPSPerPoint.Enabled = exp;
            labelExpDPSPerGem.Enabled = exp;
            textBoxExpertiseratingEquipped.Enabled = exp;
            textBoxExpertiseratingNew.Enabled = exp;
            textBoxExpertiseratingEquippedNew.Enabled = exp;

            labelRangedPower.Enabled = rangedPower;
            textBoxRangedPower.Enabled = rangedPower;
            labelRangedPowerDPSPerPoint.Enabled = rangedPower;
            labelRangedPowerDPSPerGem.Enabled = rangedPower;
            textBoxRangedPowerEquipped.Enabled = rangedPower;
            textBoxRangedPowerNew.Enabled = rangedPower;
            textBoxRangedPowerEquippedNew.Enabled = rangedPower;

            labelSpellPower.Enabled = spellpower;
            textBoxSpellPower.Enabled = spellpower;
            labelSpellPowerDPSPerPoint.Enabled = spellpower;
            labelSpellPowerDPSPerGem.Enabled = spellpower;
            textBoxSpellPowerEquipped.Enabled = spellpower;
            textBoxSpellPowerNew.Enabled = spellpower;
            textBoxSpellPowerEquippedNew.Enabled = spellpower;

            labelHitrating.Enabled = hitrating;
            textBoxHitrating.Enabled = hitrating;
            labelHitratingDPSPerPoint.Enabled = hitrating;
            labelHitratingDPSPerGem.Enabled = hitrating;
            textBoxHitratingEquipped.Enabled = hitrating;
            textBoxHitratingNew.Enabled = hitrating;
            textBoxHitratingEquippedNew.Enabled = hitrating;

            labelCritrating.Enabled = critrating;
            textBoxCritrating.Enabled = critrating;
            labelCritratingDPSPerPoint.Enabled = critrating;
            labelCritratingDPSPerGem.Enabled = critrating;
            textBoxCritratingEquipped.Enabled = critrating;
            textBoxCritratingNew.Enabled = critrating;
            textBoxCritratingEquippedNew.Enabled = critrating;

            labelHasterating.Enabled = hasterating;
            textBoxHasterating.Enabled = hasterating;
            labelHasteratingDPSPerPoint.Enabled = hasterating;
            labelHasteratingDPSPerGem.Enabled = hasterating;
            textBoxHasteratingEquipped.Enabled = hasterating;
            textBoxHasteratingNew.Enabled = hasterating;
            textBoxHasteratingEquippedNew.Enabled = hasterating;

            LabelManaregen.Enabled = manaregen;
            textBoxManaregen.Enabled = manaregen;
            labelManaregenDPSPerPoint.Enabled = manaregen;
            labelManaregenDPSPerGem.Enabled = manaregen;
            textBoxManaregenEquipped.Enabled = manaregen;
            textBoxManaregenNew.Enabled = manaregen;
            textBoxManaregenEquippedNew.Enabled = manaregen;

            //labelArmor.Enabled = armor;
            //textBoxArmor.Enabled = armor;
            //labelArmorDPSPerPoint.Enabled = armor;
            //labelArmorDPSPerGem.Enabled = armor;
            //labelArmorEquipped.Enabled = armor;
            //textBoxArmorEquipped.Enabled = armor;
            //labelArmorNew.Enabled = armor;
            //textBoxArmorNew.Enabled = armor;

            //labelDefence.Enabled = defence;
            //textBoxDefence.Enabled = defence;
            //labelDefenceDPSPerPoint.Enabled = defence;
            //labelDefenceDPSPerGem.Enabled = defence;
            //labelDefenceEquipped.Enabled = defence;
            //textBoxDefenceEquipped.Enabled = defence;
            //labelDefenceNew.Enabled = defence;
            //textBoxDefenceNew.Enabled = defence;

            //labelDodgerating.Enabled = dodgerating;
            //textBoxDodgerating.Enabled = dodgerating;
            //labelDodgeratingDPSPerPoint.Enabled = dodgerating;
            //labelDodgeratingDPSPerGem.Enabled = dodgerating;
            //labelDodgeratingEquipped.Enabled = dodgerating;
            //textBoxDodgeratingEquipped.Enabled = dodgerating;
            //labelDodgeratingNew.Enabled = dodgerating;
            //textBoxDodgeratingNew.Enabled = dodgerating;

            //labelParryrating.Enabled = parryrating;
            //textBoxParryrating.Enabled = parryrating;
            //labelParryratingDPSPerPoint.Enabled = parryrating;
            //labelParryratingDPSPerGem.Enabled = parryrating;
            //labelParryratingEquipped.Enabled = parryrating;
            //textBoxParryratingEquipped.Enabled = parryrating;
            //labelParryratingNew.Enabled = parryrating;
            //textBoxParryratingNew.Enabled = parryrating;

            //labelBlockrating.Enabled = blockrating;
            //textBoxBlockrating.Enabled = blockrating;
            //labelBlockratingDPSPerPoint.Enabled = blockrating;
            //labelBlockratingDPSPerGem.Enabled = blockrating;
            //labelBlockratingEquipped.Enabled = blockrating;
            //textBoxBlockratingEquipped.Enabled = blockrating;
            //labelBlockratingNew.Enabled = blockrating;
            //textBoxBlockratingNew.Enabled = blockrating;

            //labelBlockValue.Enabled = blockValue;
            //textBoxBlockValue.Enabled = blockValue;
            //labelBlockValueDPSPerPoint.Enabled = blockValue;
            //labelBlockValueDPSPerGem.Enabled = blockValue;
            //labelBlockValueEquipped.Enabled = blockValue;
            //textBoxBlockValueEquipped.Enabled = blockValue;
            //labelBlockValueNew.Enabled = blockValue;
            //textBoxBlockValueNew.Enabled = blockValue;

            //labelResillience.Enabled = resillience;
            //textBoxResillience.Enabled = resillience;
            //labelResillienceDPSPerPoint.Enabled = resillience;
            //labelResillienceDPSPerGem.Enabled = resillience;
            //labelResillienceEquipped.Enabled = resillience;
            //textBoxResillienceEquipped.Enabled = resillience;
            //labelResillienceNew.Enabled = resillience;
            //textBoxResillienceNew.Enabled = resillience;
        }

        private void textBoxHitrating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.hitrating = Convert.ToInt32(textBoxHitrating.Text);
            }
            catch (FormatException)
            {
                player.hitrating = 0;
            }
            updateDPSandIncreases();
        }

        private void textBoxStrength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.strength = Convert.ToInt32(textBoxStrength.Text);
            }
            catch (FormatException)
            {
                player.strength = 0;
            }
            updateDPSandIncreases();
        }

        private void textBoxAgility_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.agility = Convert.ToInt32(textBoxAgility.Text);
            }
            catch (FormatException)
            {
                player.agility = 0;
            }
            updateDPSandIncreases();
        }

        private void textBoxManaregen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.manaregen = Convert.ToInt32(textBoxManaregen.Text);
            }
            catch (FormatException)
            {
                player.manaregen = 0;
            }
            updateDPSandIncreases();
        }

        private void textBoxArp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.armorpenetration = Convert.ToInt32(textBoxArp.Text);
            }
            catch (FormatException)
            {
                player.armorpenetration = 0;
            }
            updateDPSandIncreases();
        }

        private void textBoxExp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.expertiserating = Convert.ToInt32(textBoxExp.Text);
            }
            catch (FormatException)
            {
                player.expertiserating = 0;
            }
            updateDPSandIncreases();
        }

        private void textBoxSpeed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.baseSpeed = Convert.ToInt32(textBoxSpeed.Text);
            }
            catch (FormatException)
            {
                player.baseSpeed = 0;
            }
            updateDPSandIncreases();
        }

        private void textBoxPower_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.power = Convert.ToInt32(textBoxPower.Text);
            }
            catch (FormatException)
            {
                player.power = 0;
            }
            updateDPSandIncreases();
        }

        private void textBoxRangedPower_TextChanged(object sender, EventArgs e)
        {
            try
            {
                player.rangedPower = Convert.ToInt32(textBoxRangedPower.Text);
            }
            catch (FormatException)
            {
                player.rangedPower = 0;
            }
            updateDPSandIncreases();
        }

        private void textBoxHitratingEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hitratingEquipped = Convert.ToInt32(textBoxHitratingEquipped.Text);
            }
            catch (FormatException)
            {
                hitratingEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxStrengthEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                strengthEquipped = Convert.ToInt32(textBoxStrengthEquipped.Text);
            }
            catch (FormatException)
            {
                strengthEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxAgilityEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                agilityEquipped = Convert.ToInt32(textBoxAgilityEquipped.Text);
            }
            catch (FormatException)
            {
                agilityEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxManaregenEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                manaregenEquipped = Convert.ToInt32(textBoxManaregenEquipped.Text);
            }
            catch (FormatException)
            {
                manaregenEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxArpEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                armorpenetrationEquipped = Convert.ToInt32(textBoxArmorpenetrationEquipped.Text);
            }
            catch (FormatException)
            {
                armorpenetrationEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxSpeedEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baseSpeedEquipped = Convert.ToInt32(textBoxBaseSpeedEquipped.Text);
            }
            catch (FormatException)
            {
                baseSpeedEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxPowerEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                powerEquipped = Convert.ToInt32(textBoxPowerEquipped.Text);
            }
            catch (FormatException)
            {
                powerEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxExpEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                expertiseratingEquipped = Convert.ToInt32(textBoxExpertiseratingEquipped.Text);
            }
            catch (FormatException)
            {
                expertiseratingEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxRangedPowerEquipped_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rangedPowerEquipped = Convert.ToInt32(textBoxRangedPowerEquipped.Text);
            }
            catch (FormatException)
            {
                rangedPowerEquipped = 0;
            }
            updateDPSGain();
        }

        private void textBoxHitratingNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hitratingNew = Convert.ToInt32(textBoxHitratingNew.Text);
            }
            catch (FormatException)
            {
                hitratingNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxStrengthNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                strengthNew = Convert.ToInt32(textBoxStrengthNew.Text);
            }
            catch (FormatException)
            {
                strengthNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxAgilityNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                agilityNew = Convert.ToInt32(textBoxAgilityNew.Text);
            }
            catch (FormatException)
            {
                agilityNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxArpNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                armorpenetrationNew = Convert.ToInt32(textBoxArmorpenetrationNew.Text);
            }
            catch (FormatException)
            {
                armorpenetrationNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxSpeedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baseSpeedNew = Convert.ToInt32(textBoxBaseSpeedNew.Text);
            }
            catch (FormatException)
            {
                baseSpeedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxPowerNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                powerNew = Convert.ToInt32(textBoxPowerNew.Text);
            }
            catch (FormatException)
            {
                powerNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxExpNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                expertiseratingNew = Convert.ToInt32(textBoxExpertiseratingNew.Text);
            }
            catch (FormatException)
            {
                expertiseratingNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxRangedPowerNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rangedPowerNew = Convert.ToInt32(textBoxRangedPowerNew.Text);
            }
            catch (FormatException)
            {
                rangedPowerNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxManaregenNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                manaregenNew = Convert.ToInt32(textBoxManaregenNew.Text);
            }
            catch (FormatException)
            {
                manaregenNew = 0;
            }
            updateDPSGain();
        }

        private void comboBoxNumOfItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNumOfItems.SelectedIndex){
                case 0:
                    OneForTwo = false;
                    TwoForOne = false;
                    groupBoxEquippedNew.Text = "Secondary Item";
                    break;
                case 1:
                    OneForTwo = true;
                    TwoForOne = false;
                    groupBoxEquippedNew.Text = "New Item";
                    break;
                case 2:
                    OneForTwo = false;
                    TwoForOne = true;
                    groupBoxEquippedNew.Text = "Equipped Item";
                    break;
            }
            groupBoxEquippedNew.Enabled = OneForTwo || TwoForOne;
            updateDPSGain();
        }

        private void textBoxHitratingEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hitratingEquippedNew = Convert.ToInt32(textBoxHitratingEquippedNew.Text);
            }
            catch (FormatException)
            {
                hitratingEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxCritratingEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                critratingEquippedNew = Convert.ToInt32(textBoxCritratingEquippedNew.Text);
            }
            catch (FormatException)
            {
                critratingEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxHasteratingEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hasteratingEquippedNew = Convert.ToInt32(textBoxHasteratingEquippedNew.Text);
            }
            catch (FormatException)
            {
                hasteratingEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxStrengthEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                strengthEquippedNew = Convert.ToInt32(textBoxStrengthEquippedNew.Text);
            }
            catch (FormatException)
            {
                strengthEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxAgilityEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                agilityEquippedNew = Convert.ToInt32(textBoxAgilityEquippedNew.Text);
            }
            catch (FormatException)
            {
                agilityEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxStaminaEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                staminaEquippedNew = Convert.ToInt32(textBoxStaminaEquippedNew.Text);
            }
            catch (FormatException)
            {
                staminaEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxIntelectEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                intelectEquippedNew = Convert.ToInt32(textBoxIntelectEquippedNew.Text);
            }
            catch (FormatException)
            {
                intelectEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxSpiritEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spiritEquippedNew = Convert.ToInt32(textBoxSpiritEquippedNew.Text);
            }
            catch (FormatException)
            {
                spiritEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxSpellPowerEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spellpowerEquippedNew = Convert.ToInt32(textBoxSpellPowerEquippedNew.Text);
            }
            catch (FormatException)
            {
                spellpowerEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxManaregenEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                manaregenEquippedNew = Convert.ToInt32(textBoxManaregenEquippedNew.Text);
            }
            catch (FormatException)
            {
                manaregenEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxArmorpenetrationEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                armorpenetrationEquippedNew = Convert.ToInt32(textBoxArmorpenetrationEquippedNew.Text);
            }
            catch (FormatException)
            {
                armorpenetrationEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxBaseSpeedEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baseSpeedEquippedNew = Convert.ToInt32(textBoxBaseSpeedEquippedNew.Text);
            }
            catch (FormatException)
            {
                baseSpeedEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxPowerEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                powerEquippedNew = Convert.ToInt32(textBoxPowerEquippedNew.Text);
            }
            catch (FormatException)
            {
                powerEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxExpertiseratingEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                expertiseratingEquippedNew = Convert.ToInt32(textBoxExpertiseratingEquippedNew.Text);
            }
            catch (FormatException)
            {
                expertiseratingEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void textBoxRangedPowerEquippedNew_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rangedPowerEquippedNew = Convert.ToInt32(textBoxRangedPowerEquippedNew.Text);
            }
            catch (FormatException)
            {
                rangedPowerEquippedNew = 0;
            }
            updateDPSGain();
        }

        private void comboBoxCurse_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxCurse.SelectedIndex){
                case 0: ((Warlock)player).curse = Curse.CurseOfTheElements; break;
                case 1: ((Warlock)player).curse = Curse.CurseOfDoom; break;
                case 2: ((Warlock)player).curse = Curse.CurseOfAgony; break;
                case 3: ((Warlock)player).curse = Curse.CurseOfWeakness; break;
                case 4: ((Warlock)player).curse = Curse.CurseOfTongues; break;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ((Warlock)player).demonicKnowledge.addPoint();
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ((Warlock)player).demonicKnowledge.removePoint();
            }
        }
    }
}
