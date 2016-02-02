namespace Project1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.raceBox = new System.Windows.Forms.ComboBox();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.strCount = new System.Windows.Forms.NumericUpDown();
            this.dexCount = new System.Windows.Forms.NumericUpDown();
            this.constCount = new System.Windows.Forms.NumericUpDown();
            this.intCount = new System.Windows.Forms.NumericUpDown();
            this.wisCount = new System.Windows.Forms.NumericUpDown();
            this.charCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCharacterToolStripMenuItem,
            this.editCharacterToolStripMenuItem,
            this.removeCharacterToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // addCharacterToolStripMenuItem
            // 
            this.addCharacterToolStripMenuItem.Name = "addCharacterToolStripMenuItem";
            this.addCharacterToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.addCharacterToolStripMenuItem.Text = "Add Character";
            // 
            // editCharacterToolStripMenuItem
            // 
            this.editCharacterToolStripMenuItem.Name = "editCharacterToolStripMenuItem";
            this.editCharacterToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.editCharacterToolStripMenuItem.Text = "Edit Character";
            // 
            // removeCharacterToolStripMenuItem
            // 
            this.removeCharacterToolStripMenuItem.Name = "removeCharacterToolStripMenuItem";
            this.removeCharacterToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.removeCharacterToolStripMenuItem.Text = "Remove Character";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.classBox);
            this.groupBox1.Controls.Add(this.raceBox);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.lastNameBox);
            this.groupBox1.Controls.Add(this.firstNameBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(81, 20);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameBox.TabIndex = 0;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(81, 48);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameBox.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(81, 76);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // raceBox
            // 
            this.raceBox.FormattingEnabled = true;
            this.raceBox.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Goblin",
            "Kobold",
            "Porc"});
            this.raceBox.Location = new System.Drawing.Point(81, 104);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(100, 24);
            this.raceBox.TabIndex = 3;
            // 
            // classBox
            // 
            this.classBox.FormattingEnabled = true;
            this.classBox.Items.AddRange(new object[] {
            "Bard",
            "Berserker",
            "Booty Raider",
            "Buccaneer",
            "Cabalist",
            "Lumberjack",
            "Magician",
            "Monk",
            "Paladin",
            "Puppeteer",
            "Rouge",
            "Sorcerer",
            "Swashbuckler",
            "Sun Cleric",
            "Thane",
            "Theurgist",
            "Warrior",
            "Wizard"});
            this.classBox.Location = new System.Drawing.Point(81, 134);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(100, 24);
            this.classBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Race";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Class";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rollButton);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.charCount);
            this.groupBox2.Controls.Add(this.wisCount);
            this.groupBox2.Controls.Add(this.intCount);
            this.groupBox2.Controls.Add(this.constCount);
            this.groupBox2.Controls.Add(this.dexCount);
            this.groupBox2.Controls.Add(this.strCount);
            this.groupBox2.Location = new System.Drawing.Point(13, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 219);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stats";
            // 
            // strCount
            // 
            this.strCount.Location = new System.Drawing.Point(81, 22);
            this.strCount.Name = "strCount";
            this.strCount.ReadOnly = true;
            this.strCount.Size = new System.Drawing.Size(100, 22);
            this.strCount.TabIndex = 0;
            // 
            // dexCount
            // 
            this.dexCount.Location = new System.Drawing.Point(81, 50);
            this.dexCount.Name = "dexCount";
            this.dexCount.ReadOnly = true;
            this.dexCount.Size = new System.Drawing.Size(100, 22);
            this.dexCount.TabIndex = 1;
            // 
            // constCount
            // 
            this.constCount.Location = new System.Drawing.Point(81, 78);
            this.constCount.Name = "constCount";
            this.constCount.ReadOnly = true;
            this.constCount.Size = new System.Drawing.Size(100, 22);
            this.constCount.TabIndex = 2;
            // 
            // intCount
            // 
            this.intCount.Location = new System.Drawing.Point(81, 106);
            this.intCount.Name = "intCount";
            this.intCount.ReadOnly = true;
            this.intCount.Size = new System.Drawing.Size(100, 22);
            this.intCount.TabIndex = 3;
            // 
            // wisCount
            // 
            this.wisCount.Location = new System.Drawing.Point(81, 134);
            this.wisCount.Name = "wisCount";
            this.wisCount.ReadOnly = true;
            this.wisCount.Size = new System.Drawing.Size(100, 22);
            this.wisCount.TabIndex = 4;
            // 
            // charCount
            // 
            this.charCount.Location = new System.Drawing.Point(81, 162);
            this.charCount.Name = "charCount";
            this.charCount.ReadOnly = true;
            this.charCount.Size = new System.Drawing.Size(100, 22);
            this.charCount.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Strength";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dexterity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Constitution";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Intelligence";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Wisdom";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Charisma";
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(47, 190);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 23);
            this.rollButton.TabIndex = 16;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(13, 435);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 111);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class Specific";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Character Builder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCharacterToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.ComboBox raceBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown charCount;
        private System.Windows.Forms.NumericUpDown wisCount;
        private System.Windows.Forms.NumericUpDown intCount;
        private System.Windows.Forms.NumericUpDown constCount;
        private System.Windows.Forms.NumericUpDown dexCount;
        private System.Windows.Forms.NumericUpDown strCount;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

