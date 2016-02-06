using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Character
    {
        public struct stats
        {
            public int strength;
            public int dexterity;
            public int constitution;
            public int intelligence;
            public int wisdom;
            public int charisma;
        }

        public enum Race{
            Dwarf,
            Elf,
            Gnome,
            Goblin,
            Kobold,
            Porc    }

        public string fName;
        public string lName;
        public int age;
        public Race race;
        public Objects.Class charClass;
        private stats charStats;
        readonly Form1 form;

        public Character(string FirstName, string LastName, int Age, Race Race, Objects.Class Class, stats Stats, Form1 Form)
        {
            fName = FirstName;
            lName = LastName;
            charClass = Class;
            age = Age;
            race = Race;
            charStats = Stats;
            form = Form;
        }

        public override string ToString()
        {
            return (fName + " " + lName);
        }

        public void writeToForm()
        {
            form.fNameBox.Text = fName;
            form.lNameBox.Text = lName;
            form.ageBox.Value = age;
            form.raceChoice.SelectedIndex = (int)race;
            form.classChoice.SelectedIndex = charClass.getClass();
            form.strBox.Value = charStats.strength;
            form.dexBox.Value = charStats.dexterity;
            form.wisBox.Value = charStats.wisdom;
            form.intBox.Value = charStats.intelligence;
            form.constBox.Value = charStats.constitution;
            form.charBox.Value = charStats.charisma;
            charClass.getClassData(form);
        }
    }
}
