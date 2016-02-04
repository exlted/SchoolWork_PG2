using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Objects
{
    class Class
    {
        public enum classes{
            Cleric,
            Fighter,
            Monk,
            Paladin,
            Rogue,
            Sorcerer,
            Druid,
            Ranger,
            Wizard
        }

        public int getClass()
        {
            if (this is Cleric)
                return (int)classes.Cleric;
            else if (this is Fighter)
                return (int)classes.Fighter;
            else if (this is Monk)
                return (int)classes.Monk;
            else if (this is Paladin)
                return (int)classes.Paladin;
            else if (this is Rogue)
                return (int)classes.Rogue;
            else if (this is Sorcerer)
                return (int)classes.Sorcerer;
            else if (this is Druid)
                return (int)classes.Druid;
            else if (this is Ranger)
                return (int)classes.Ranger;
            else if (this is Wizard)
                return (int)classes.Wizard;
            else return 0;
        }
    }
    class Cleric : Class
    {

    }
    class Fighter : Class
    {

    }
    class Monk : Class
    {

    }
    class Paladin : Class
    {

    }
    class Rogue : Class
    {

    }
    class Sorcerer : Class
    {

    }
    class Druid : Class
    {

    }
    class Ranger : Class
    {

    }
    class Wizard : Class
    {

    }
}
