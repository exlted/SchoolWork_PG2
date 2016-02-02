using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Character
    {
        struct stats
        {
            int strength;
            int dexterity;
            int constitution;
            int intelligence;
            int wisdom;
            int charisma;
        }

        enum Race{
            Dwarf,
            Elf,
            Gnome,
            Goblin,
            Kobold,
            Porc    }

        string fName;
        string lName;
        int age;
        Race race;
        Objects.Class charClass;
        stats charStats;
    }
}
