using Kingmaker.Blueprints.Classes.Spells;
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
    }
}
