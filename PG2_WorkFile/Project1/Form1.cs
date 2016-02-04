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
        public NumericUpDown ageBox, strBox, dexBox, constBox, intBox, wisBox, charBox;
        public ComboBox raceChoice, classChoice, classChoice1, classChoice2;
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
            classChoice1 = comboBox1;
            classChoice2 = comboBox2;

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
                    charClass = new Objects.Cleric();
                    break;
                case Objects.Class.classes.Druid:
                    charClass = new Objects.Druid();
                    break;
                case Objects.Class.classes.Fighter:
                    charClass = new Objects.Fighter();
                    break;
                case Objects.Class.classes.Monk:
                    charClass = new Objects.Monk();
                    break;
                case Objects.Class.classes.Paladin:
                    charClass = new Objects.Paladin();
                    break;
                case Objects.Class.classes.Ranger:
                    charClass = new Objects.Ranger();
                    break;
                case Objects.Class.classes.Rogue:
                    charClass = new Objects.Rogue();
                    break;
                case Objects.Class.classes.Sorcerer:
                    charClass = new Objects.Sorcerer();
                    break;
                case Objects.Class.classes.Wizard:
                    charClass = new Objects.Wizard();
                    break;
                default:
                    charClass = new Objects.Cleric();
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
            classChoice1.SelectedItem = null;
            classChoice2.SelectedItem = null;
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
                    charClass = new Objects.Cleric();
                    break;
                case Objects.Class.classes.Druid:
                    charClass = new Objects.Druid();
                    break;
                case Objects.Class.classes.Fighter:
                    charClass = new Objects.Fighter();
                    break;
                case Objects.Class.classes.Monk:
                    charClass = new Objects.Monk();
                    break;
                case Objects.Class.classes.Paladin:
                    charClass = new Objects.Paladin();
                    break;
                case Objects.Class.classes.Ranger:
                    charClass = new Objects.Ranger();
                    break;
                case Objects.Class.classes.Rogue:
                    charClass = new Objects.Rogue();
                    break;
                case Objects.Class.classes.Sorcerer:
                    charClass = new Objects.Sorcerer();
                    break;
                case Objects.Class.classes.Wizard:
                    charClass = new Objects.Wizard();
                    break;
                default:
                    charClass = new Objects.Cleric();
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
            classChoice1.SelectedItem = null;
            classChoice2.SelectedItem = null;
        }

        private void removeCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            charList.Items.Remove(charList.SelectedItem);
            charList.Refresh();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
