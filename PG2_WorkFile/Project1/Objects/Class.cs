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

        public virtual void getClassData(Form1 form)
        {

        }

        public virtual string getClassType()
        {
            return "";
        }
    }

    class Cleric : Class
    {
        public const string Label1Text = "Rebirth uses";
        int turnUndeadUses;

        public Cleric(int undeadUses)
        {
            turnUndeadUses = undeadUses;
        }

        public override void getClassData(Form1 form)
        {
            form.classNumBox1.Visible = true;
            form.classChoiceBox1.Visible = false;
            form.classChoiceBox2.Visible = false;
            form.classLabel1.Visible = true;
            form.classLabel2.Visible = false;
            form.classLabel1.Text = Label1Text;
            form.classNumBox1.Value = turnUndeadUses;
        }

        public override string getClassType()
        {
            return "Cleric";
        }
    }

    class Fighter : Class
    {
        public const string Label1Text = "Extra Feats";
        int extraFeats;

        public Fighter(int feats)
        {
            extraFeats = feats;
        }
        public override void getClassData(Form1 form)
        {
            form.classNumBox1.Visible = true;
            form.classChoiceBox1.Visible = false;
            form.classChoiceBox2.Visible = false;
            form.classLabel1.Visible = true;
            form.classLabel2.Visible = false;
            form.classLabel1.Text = Label1Text;
            form.classNumBox1.Value = extraFeats;
        }
        public override string getClassType()
        {
            return "Fighter";
        }
    }
    class Monk : Class
    {
        public const string Label1Text = "Extra Attacks";
        int extraAttacks;

        public Monk(int attacks)
        {
            extraAttacks = attacks;
        }
        public override void getClassData(Form1 form)
        {
            form.classNumBox1.Visible = true;
            form.classChoiceBox1.Visible = false;
            form.classChoiceBox2.Visible = false;
            form.classLabel1.Visible = true;
            form.classLabel2.Visible = false;
            form.classLabel1.Text = Label1Text;
            form.classNumBox1.Value = extraAttacks;
        }
        public override string getClassType()
        {
            return "Monk";
        }
    }
    class Paladin : Class
    {
        public const string Label1Text = "Heals";
        int layOnHands;

        public Paladin(int LayOnHands)
        {
            layOnHands = LayOnHands;
        }
        public override void getClassData(Form1 form)
        {
            form.classNumBox1.Visible = true;
            form.classChoiceBox1.Visible = false;
            form.classChoiceBox2.Visible = false;
            form.classLabel1.Visible = true;
            form.classLabel2.Visible = false;
            form.classLabel1.Text = Label1Text;
            form.classNumBox1.Value = layOnHands;
        }
        public override string getClassType()
        {
            return "Paladin";
        }

    }
    class Rogue : Class
    {
        public const string Label1Text = "Sneak Attacks";
        int sneakDice;

        public Rogue(int sneakyDice)
        {
            sneakDice = sneakyDice;
        }
        public override void getClassData(Form1 form)
        {
            form.classNumBox1.Visible = true;
            form.classChoiceBox1.Visible = false;
            form.classChoiceBox2.Visible = false;
            form.classLabel1.Visible = true;
            form.classLabel2.Visible = false;
            form.classLabel1.Text = Label1Text;
            form.classNumBox1.Value = sneakDice;
        }
        public override string getClassType()
        {
            return "Rogue";
        }
    }
    class Sorcerer : Class
    {
        public const string Label1Text = "Spell Slots";
        int spellCount;

        public Sorcerer(int spells)
        {
            spellCount = spells;
        }
        public override void getClassData(Form1 form)
        {
            form.classNumBox1.Visible = true;
            form.classChoiceBox1.Visible = false;
            form.classChoiceBox2.Visible = false;
            form.classLabel1.Visible = true;
            form.classLabel2.Visible = false;
            form.classLabel1.Text = Label1Text;
            form.classNumBox1.Value = spellCount;
        }
        public override string getClassType()
        {
            return "Sorcerer";
        }
    }
    class Druid : Class
    {
        class druidPet
        {
            PetType petType;

            public druidPet(PetType type)
            {
                petType = type;
            }

            public PetType getType()
            {
                return petType;
            }
        }
        public const string Label1Text = "Pet Race";
        public enum PetType { Wolf, Elk, Tree }
        druidPet pet;

        public Druid(PetType type)
        {
            pet = new druidPet(type);
        }
        public override void getClassData(Form1 form)
        {
            form.classNumBox1.Visible = false;
            form.classChoiceBox1.Visible = true;
            form.classChoiceBox1.DataSource = Enum.GetValues(typeof(PetType));
            form.classChoiceBox1.SelectedIndex = ((int)pet.getType());
            form.classChoiceBox2.Visible = false;
            form.classChoiceBox2.DataSource = null;
            form.classLabel1.Visible = true;
            form.classLabel1.Text = Label1Text;
            form.classLabel2.Visible = false;
        }
    }
    class Ranger : Class
    {
        class rangerPet
        {
            PetType petType;
            PetSize petSize;
            public rangerPet(PetType type, PetSize size)
            {
                petType = type;
                petSize = size;
            }
            public PetType getType()
            {
                return petType;
            }
            public PetSize getSize()
            {
                return petSize;
            }
        }
        public enum PetType { Dog, Cat, Elephant }
        public string[] Type = { "Dog", "Cat", "Elephant" };
        public enum PetSize { Tiny, Meduim, Huge }
        public string[] Size = {"Tiny", "Medium", "Huge"};
        public const string Label1Text = "Pet Race";
        public const string Label2Text = "Pet Size";
        rangerPet myPet;
        public Ranger(Form1 form)
        {
            myPet = new rangerPet((PetType)form.classChoiceBox1.SelectedIndex, (PetSize)form.classChoiceBox2.SelectedIndex);
        }
        public override void getClassData(Form1 form)
        {
            form.classNumBox1.Visible = false;
            form.classChoiceBox1.Visible = true;
            form.classChoiceBox1.DataSource = Enum.GetValues(typeof(PetType));
            form.classChoiceBox1.SelectedIndex = ((int)myPet.getType());
            form.classChoiceBox2.Visible = true;
            form.classChoiceBox2.DataSource = Enum.GetValues(typeof(PetSize));
            form.classChoiceBox2.SelectedIndex = ((int)myPet.getSize());
            form.classLabel1.Visible = true;
            form.classLabel1.Text = Label1Text;
            form.classLabel2.Visible = true;
            form.classLabel2.Text = Label2Text;
        }
    }
    class Wizard : Class
    {
        class wizardFamilar
        {
            PetType petType;

            public wizardFamilar(PetType type)
            {
                petType = type;
            }
            public PetType getType()
            {
                return petType;
            }
        }
        public const string Label1Text = "Spells Known";
        public const string Label2Text = "Familiar";
        public enum PetType { Owl, Lizard, Cat}
        int spells;
        wizardFamilar pet;

        public Wizard(Form1 form)
        {
            spells = (int)form.classNumBox1.Value;
            pet = new wizardFamilar((PetType)form.classChoiceBox2.SelectedIndex);
        }
        public override void getClassData(Form1 form)
        {
            form.classNumBox1.Visible = true;
            form.classNumBox1.Value = spells;
            form.classChoiceBox1.Visible = false;
            form.classChoiceBox1.DataSource = null;
            form.classChoiceBox2.Visible = true;
            form.classChoiceBox2.DataSource = Enum.GetValues(typeof(PetType));
            form.classChoiceBox2.SelectedIndex = ((int)pet.getType());
            form.classLabel1.Visible = true;
            form.classLabel1.Text = Label1Text;
            form.classLabel2.Visible = true;
            form.classLabel2.Text = Label2Text;
        }
    }
}
