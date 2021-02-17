using Kingmaker.Blueprints.Classes.Spells;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfTheWild
{
    static class _MyPersonalHacks
    {
        internal static void AddSpellsFromSpellbook(BlueprintSpellList destination, BlueprintSpellList source)
        {
            foreach (var spell_level_list in source.SpellsByLevel)
            {
                foreach (var spell in spell_level_list.Spells)
                {
                    if (!spell.IsInSpellList(destination))
                    {
                        ExtensionMethods.AddToSpellList(spell, destination, spell_level_list.SpellLevel);
                    }
                }
            }
        }

        internal static void AddPsychicSpells(BlueprintSpellList destination)
        {
            var spells = new Common.SpellId[]
            {
                new Common.SpellId( NewSpells.burst_of_adrenaline.AssetGuid, 1),
                new Common.SpellId( NewSpells.burst_of_insight.AssetGuid, 1),
                new Common.SpellId( Witch.hermean_potential.AssetGuid, 1),
                new Common.SpellId( Witch.ill_omen.AssetGuid, 1),

                new Common.SpellId( NewSpells.mind_thrust[0].AssetGuid, 1),
                new Common.SpellId( NewSpells.mind_thrust[1].AssetGuid, 2),
                new Common.SpellId( NewSpells.mind_thrust[2].AssetGuid, 3),
                new Common.SpellId( NewSpells.mind_thrust[3].AssetGuid, 4),
                new Common.SpellId( NewSpells.mind_thrust[4].AssetGuid, 5),
                new Common.SpellId( NewSpells.mind_thrust[5].AssetGuid, 6),

                new Common.SpellId( NewSpells.mental_barrier[0].AssetGuid, 2),
                new Common.SpellId( NewSpells.mental_barrier[1].AssetGuid, 3),
                new Common.SpellId( NewSpells.mental_barrier[2].AssetGuid, 4),
                new Common.SpellId( NewSpells.mental_barrier[3].AssetGuid, 5),
                new Common.SpellId( NewSpells.mental_barrier[4].AssetGuid, 6),

                new Common.SpellId( NewSpells.thought_shield[0].AssetGuid, 2),
                new Common.SpellId( NewSpells.thought_shield[1].AssetGuid, 3),
                new Common.SpellId( NewSpells.thought_shield[2].AssetGuid, 4),

                new Common.SpellId( NewSpells.psychic_crush[0].AssetGuid, 5),
                new Common.SpellId( NewSpells.psychic_crush[1].AssetGuid, 6),
                new Common.SpellId( NewSpells.psychic_crush[2].AssetGuid, 7),
                new Common.SpellId( NewSpells.psychic_crush[3].AssetGuid, 8),
                new Common.SpellId( NewSpells.psychic_crush[4].AssetGuid, 9),

                new Common.SpellId( NewSpells.synaptic_pulse.AssetGuid, 3),
                new Common.SpellId( NewSpells.synesthesia.AssetGuid, 3),
                new Common.SpellId( NewSpells.synaptic_pulse_greater.AssetGuid, 5),
                new Common.SpellId( NewSpells.synapse_overload.AssetGuid, 5),
                new Common.SpellId( NewSpells.intellect_fortress.AssetGuid, 4),
                new Common.SpellId( NewSpells.phantom_limbs.AssetGuid, 6),
                new Common.SpellId( NewSpells.psychic_surgery.AssetGuid, 6),
                new Common.SpellId( NewSpells.synesthesia_mass.AssetGuid, 7),
                new Common.SpellId( NewSpells.akashic_form.AssetGuid, 9),
                new Common.SpellId( NewSpells.divide_mind.AssetGuid, 9), //divide mind
                new Common.SpellId( NewSpells.telekinetic_storm.AssetGuid, 9),
            };

            var library = Main.library;
            foreach (var spell_id in spells)
                library.Get<BlueprintAbility>(spell_id.guid).AddToSpellList(destination, spell_id.level);
        }
    }
}
