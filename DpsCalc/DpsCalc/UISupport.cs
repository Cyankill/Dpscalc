using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{
    public static class UISupport
    {
        public static String toString(SpellName spellname){
            switch (spellname)
            {
                case SpellName.None: return "<<NO SPELL>>";

                    //WARLOCK
                case SpellName.ChaosBolt: return "Chaos Bolt";
                case SpellName.ChaosBoltBackdraft: return "Chaos Bolt with Backdraft up";
                case SpellName.Conflagrate: return "Conflagrate";
                case SpellName.Corruption: return "Corruption";
                case SpellName.CurseOfAgony: return "Curse of Agony";
                case SpellName.CurseOfDoom: return "Curse of Doom";
                case SpellName.CurseOfTheElements: return "Curse of the Elements";
                case SpellName.CurseOfTongues: return "Curse of Tongues";
                case SpellName.CurseOfWeakness: return "Curse of Weakness";
                case SpellName.DarkPact: return "Dark Pact";
                case SpellName.DemonicEmpowerment: return "Demonic Empowerment";
                case SpellName.DrainLife: return "Drain Life";
                case SpellName.DrainSoul: return "Drain Soul";
                case SpellName.DrainSoulUnder25: return "Drain Soul, target under 25%";
                case SpellName.Haunt: return "Haunt";
                case SpellName.Immolate: return "Immolate";
                case SpellName.ImmolationAura: return "Metamorphosis: Immolation Aura";
                case SpellName.Incinerate: return "Incinerate";
                case SpellName.IncinerateBackdraft: return "Incinerate with Backdraft up";
                case SpellName.IncinerateMoltenCore: return "Incinerate with Molten Core up";
                case SpellName.IncinerateMoltenCoreBackdraft: return "Incinerate with Molten Core and Backdraft up";
                case SpellName.LifeTap: return "Life Tap";
                case SpellName.Metamorphosis: return "Metamorphosis";
                case SpellName.SearingPain: return "Searing Pain";
                case SpellName.SeedOfCorruption: return "Seed of Corruption";
                case SpellName.ShadowBolt: return "Shadow Bolt";
                case SpellName.ShadowboltBackdraft: return "Shadow Bolt with Backdraft up";
                case SpellName.Shadowburn: return "Shadowburn";
                case SpellName.ShadowburnGlyphed: return "Shadowburn with Glyph of Shadowburn";
                case SpellName.ShadowCleave: return "Metamorphosis: Shadow Cleave";
                case SpellName.Shadowflame: return "Shadowflame";
                case SpellName.Shadowfury: return "Shadowfury";
                case SpellName.Soulfire: return "Soulfire";
                case SpellName.SoulfireDecimation: return "Soulfire with Decimation";
                case SpellName.UnstableAffliction: return "Unstable Affliction";
            }
            return "";
        }
    }
}
