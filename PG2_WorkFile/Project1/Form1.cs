using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public TextBox fNameBox, lNameBox;
        public NumericUpDown ageBox, strBox, dexBox, constBox, intBox, wisBox, charBox, classNumBox1;
        public ComboBox raceChoice, classChoice, classChoiceBox1, classChoiceBox2;
        public Label classLabel1, classLabel2;
        Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            fNameBox = firstNameBox;
            lNameBox = lastNameBox;
            ageBox = ageCount;
            strBox = strCount;
            dexBox = dexCount;
            constBox = constCount;
            intBox = intCount;
            wisBox = wisCount;
            charBox = charCount;
            raceChoice = raceBox;
            classChoice = classBox;
            classChoiceBox1 = comboBox1;
            classChoiceBox2 = comboBox2;
            classNumBox1 = classCount1;
            classLabel1 = classChoice1Label;
            classLabel2 = classChoice2Label;
            classLabel1.Visible = false;
            classLabel2.Visible = false;
            classNumBox1.Visible = false;
            classChoiceBox1.Visible = false;
            classChoiceBox2.Visible = false;
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            strCount.Value = random.Next(0, 100);
            dexCount.Value = random.Next(0, 100);
            charCount.Value = random.Next(0, 100);
            constCount.Value = random.Next(0, 100);
            intCount.Value = random.Next(0, 100);
            wisCount.Value = random.Next(0, 100);
        }

        private void addCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Objects.Class charClass;
            Objects.Class.classes classSelection = (Objects.Class.classes)classBox.SelectedIndex;
            Character.stats tempStats;
            switch (classSelection)
            {
                case Objects.Class.classes.Cleric:
                    charClass = new Objects.Cleric((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Druid:
                    charClass = new Objects.Druid((Objects.Druid.PetType)classChoiceBox1.SelectedIndex);
                    break;
                case Objects.Class.classes.Fighter:
                    charClass = new Objects.Fighter((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Monk:
                    charClass = new Objects.Monk((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Paladin:
                    charClass = new Objects.Paladin((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Ranger:
                    charClass = new Objects.Ranger(this);
                    break;
                case Objects.Class.classes.Rogue:
                    charClass = new Objects.Rogue((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Sorcerer:
                    charClass = new Objects.Sorcerer((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Wizard:
                    charClass = new Objects.Wizard(this);
                    break;
                default:
                    charClass = new Objects.Cleric((int)classNumBox1.Value);
                    break;
            }
            tempStats.strength = (int)strBox.Value;
            tempStats.wisdom = (int)wisBox.Value;
            tempStats.intelligence = (int)intBox.Value;
            tempStats.dexterity = (int)dexBox.Value;
            tempStats.constitution = (int)constBox.Value;
            tempStats.charisma = (int)charBox.Value;
            Character tempCharacter = new Character(fNameBox.Text, lNameBox.Text, (int)ageBox.Value, (Character.Race)raceBox.SelectedIndex, charClass, tempStats, this);
            charList.Items.Add(tempCharacter);
            fNameBox.Text = "";
            lNameBox.Text = "";
            ageBox.Value = 0;
            strBox.Value = 0;
            dexBox.Value = 0;
            constBox.Value = 0;
            intBox.Value = 0;
            wisBox.Value = 0;
            charBox.Value = 0;
            raceChoice.SelectedItem = null;
            classChoice.SelectedItem = null;
            classChoiceBox1.SelectedItem = null;
            classChoiceBox2.SelectedItem = null;
            classNumBox1.Visible = false;
            classNumBox1.Value = 0;
            classChoiceBox1.Visible = false;
            classChoiceBox1.SelectedIndex = -1;
            classChoiceBox2.Visible = false;
            classChoiceBox2.SelectedIndex = -1;
            classLabel1.Visible = false;
            classLabel2.Visible = false;
        }

        private void editCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            charList.Items.Remove(charList.SelectedItem);
            charList.Refresh();
            Objects.Class charClass;
            Objects.Class.classes classSelection = (Objects.Class.classes)classBox.SelectedIndex;
            Character.stats tempStats;
            switch (classSelection)
            {
                case Objects.Class.classes.Cleric:
                    charClass = new Objects.Cleric((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Druid:
                    charClass = new Objects.Druid((Objects.Druid.PetType)classChoiceBox1.SelectedIndex);
                    break;
                case Objects.Class.classes.Fighter:
                    charClass = new Objects.Fighter((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Monk:
                    charClass = new Objects.Monk((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Paladin:
                    charClass = new Objects.Paladin((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Ranger:
                    charClass = new Objects.Ranger(this);
                    break;
                case Objects.Class.classes.Rogue:
                    charClass = new Objects.Rogue((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Sorcerer:
                    charClass = new Objects.Sorcerer((int)classNumBox1.Value);
                    break;
                case Objects.Class.classes.Wizard:
                    charClass = new Objects.Wizard(this);
                    break;
                default:
                    charClass = new Objects.Cleric((int)classNumBox1.Value);
                    break;
            }
            tempStats.strength = (int)strBox.Value;
            tempStats.wisdom = (int)wisBox.Value;
            tempStats.intelligence = (int)intBox.Value;
            tempStats.dexterity = (int)dexBox.Value;
            tempStats.constitution = (int)constBox.Value;
            tempStats.charisma = (int)charBox.Value;
            Character tempCharacter = new Character(fNameBox.Text, lNameBox.Text, (int)ageBox.Value, (Character.Race)raceBox.SelectedIndex, charClass, tempStats, this);
            charList.Items.Add(tempCharacter);
            fNameBox.Text = "";
            lNameBox.Text = "";
            ageBox.Value = 0;
            strBox.Value = 0;
            dexBox.Value = 0;
            constBox.Value = 0;
            intBox.Value = 0;
            wisBox.Value = 0;
            charBox.Value = 0;
            raceChoice.SelectedItem = null;
            classChoice.SelectedItem = null;
            classChoiceBox1.SelectedItem = null;
            classChoiceBox2.SelectedItem = null;
            classNumBox1.Visible = false;
            classNumBox1.Value = 0;
            classChoiceBox1.Visible = false;
            classChoiceBox1.SelectedIndex = -1;
            classChoiceBox1.DataSource = null;
            classChoiceBox2.Visible = false;
            classChoiceBox2.SelectedIndex = -1;
            classChoiceBox2.DataSource = null;
            classLabel1.Visible = false;
            classLabel2.Visible = false;
        }

        private void removeCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            charList.Items.Remove(charList.SelectedItem);
            charList.Refresh();
            fNameBox.Text = "";
            lNameBox.Text = "";
            ageBox.Value = 0;
            strBox.Value = 0;
            dexBox.Value = 0;
            constBox.Value = 0;
            intBox.Value = 0;
            wisBox.Value = 0;
            charBox.Value = 0;
            raceChoice.SelectedItem = null;
            classChoice.SelectedItem = null;
            classChoiceBox1.SelectedItem = null;
            classChoiceBox2.SelectedItem = null;
            classNumBox1.Visible = false;
            classNumBox1.Value = 0;
            classChoiceBox1.Visible = false;
            classChoiceBox1.SelectedIndex = -1;
            classChoiceBox1.DataSource = null;
            classChoiceBox2.Visible = false;
            classChoiceBox2.SelectedIndex = -1;
            classChoiceBox2.DataSource = null;
            classLabel1.Visible = false;
            classLabel2.Visible = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < charList.Items.Count; i++)
            {
                charList.Items.Remove(charList.Items[i]);
            }
            charList.Refresh();
            fNameBox.Text = "";
            lNameBox.Text = "";
            ageBox.Value = 0;
            strBox.Value = 0;
            dexBox.Value = 0;
            constBox.Value = 0;
            intBox.Value = 0;
            wisBox.Value = 0;
            charBox.Value = 0;
            raceChoice.SelectedItem = null;
            classChoice.SelectedItem = null;
            classChoiceBox1.SelectedItem = null;
            classChoiceBox2.SelectedItem = null;
            classNumBox1.Visible = false;
            classNumBox1.Value = 0;
            classChoiceBox1.Visible = false;
            classChoiceBox1.SelectedIndex = -1;
            classChoiceBox2.Visible = false;
            classChoiceBox2.SelectedIndex = -1;
            classLabel1.Visible = false;
            classLabel2.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void charList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (charList.SelectedItem as Character).writeToForm();
            }
            catch (Exception)
            {
            }
        }

        private void classBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(classBox.SelectedIndex)
            {
                case 0:
                    //Cleric
                    classNumBox1.Visible = true;
                    classChoiceBox1.Visible = false;
                    classChoiceBox2.Visible = false;
                    classLabel1.Visible = true;
                    classLabel2.Visible = false;
                    classLabel1.Text = Objects.Cleric.Label1Text;
                    break;
                case 1:
                    //Fighter
                    classNumBox1.Visible = true;
                    classChoiceBox1.Visible = false;
                    classChoiceBox2.Visible = false;
                    classLabel1.Visible = true;
                    classLabel2.Visible = false;
                    classLabel1.Text = Objects.Fighter.Label1Text;
                    break;
                case 2:
                    //Monk
                    classNumBox1.Visible = true;
                    classChoiceBox1.Visible = false;
                    classChoiceBox2.Visible = false;
                    classLabel1.Visible = true;
                    classLabel2.Visible = false;
                    classLabel1.Text = Objects.Monk.Label1Text;
                    break;
                case 3:
                    //Paladin
                    classNumBox1.Visible = true;
                    classChoiceBox1.Visible = false;
                    classChoiceBox2.Visible = false;
                    classLabel1.Visible = true;
                    classLabel2.Visible = false;
                    classLabel1.Text = Objects.Paladin.Label1Text;
                    break;
                case 4:
                    //Rogue
                    classNumBox1.Visible = true;
                    classChoiceBox1.Visible = false;
                    classChoiceBox2.Visible = false;
                    classLabel1.Visible = true;
                    classLabel2.Visible = false;
                    classLabel1.Text = Objects.Rogue.Label1Text;
                    break;
                case 5:
                    //Sorcerer
                    classNumBox1.Visible = true;
                    classChoiceBox1.Visible = false;
                    classChoiceBox2.Visible = false;
                    classLabel1.Visible = true;
                    classLabel2.Visible = false;
                    classLabel1.Text = Objects.Sorcerer.Label1Text;
                    break;
                case 6:
                    //Druid
                    classNumBox1.Visible = false;
                    classChoiceBox1.Visible = true;
                    classChoiceBox1.DataSource = Enum.GetValues(typeof(Objects.Druid.PetType));
                    classChoiceBox2.Visible = false;
                    classChoiceBox2.DataSource = null;
                    classLabel1.Visible = true;
                    classLabel1.Text = Objects.Druid.Label1Text;
                    classLabel2.Visible = false;
                    break;
                case 7:
                    //Ranger
                    classNumBox1.Visible = false;
                    classChoiceBox1.Visible = true;
                    classChoiceBox1.DataSource = Enum.GetValues(typeof(Objects.Ranger.PetType));
                    classChoiceBox2.Visible = true;
                    classChoiceBox2.DataSource = Enum.GetValues(typeof(Objects.Ranger.PetSize));
                    classLabel1.Visible = true;
                    classLabel1.Text = Objects.Ranger.Label1Text;
                    classLabel2.Visible = true;
                    classLabel2.Text = Objects.Ranger.Label2Text;
                    break;
                case 8:
                    //Wizard
                    classNumBox1.Visible = true;
                    classChoiceBox1.Visible = false;
                    classChoiceBox1.DataSource = null;
                    classChoiceBox2.Visible = true;
                    classChoiceBox2.DataSource = Enum.GetValues(typeof(Objects.Wizard.PetType));
                    classLabel1.Visible = true;
                    classLabel1.Text = Objects.Wizard.Label1Text;
                    classLabel2.Visible = true;
                    classLabel2.Text = Objects.Wizard.Label2Text;
                    break;
            }
        }
    }
}
