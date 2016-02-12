namespace Lab6
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list = new System.Windows.Forms.ListBox();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.bubble = new System.Windows.Forms.RadioButton();
            this.selection = new System.Windows.Forms.RadioButton();
            this.insertion = new System.Windows.Forms.RadioButton();
            this.sort = new System.Windows.Forms.Button();
            this.Randomize = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(453, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 16;
            this.list.Location = new System.Drawing.Point(172, 31);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(269, 388);
            this.list.TabIndex = 1;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.sort);
            this.groupbox1.Controls.Add(this.insertion);
            this.groupbox1.Controls.Add(this.selection);
            this.groupbox1.Controls.Add(this.bubble);
            this.groupbox1.Location = new System.Drawing.Point(12, 31);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(154, 165);
            this.groupbox1.TabIndex = 2;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Sort Types";
            // 
            // bubble
            // 
            this.bubble.AutoSize = true;
            this.bubble.Location = new System.Drawing.Point(6, 21);
            this.bubble.Name = "bubble";
            this.bubble.Size = new System.Drawing.Size(103, 21);
            this.bubble.TabIndex = 0;
            this.bubble.TabStop = true;
            this.bubble.Text = "Bubble Sort";
            this.bubble.UseVisualStyleBackColor = true;
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Location = new System.Drawing.Point(6, 48);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(117, 21);
            this.selection.TabIndex = 1;
            this.selection.TabStop = true;
            this.selection.Text = "Selection Sort";
            this.selection.UseVisualStyleBackColor = true;
            // 
            // insertion
            // 
            this.insertion.AutoSize = true;
            this.insertion.Location = new System.Drawing.Point(6, 75);
            this.insertion.Name = "insertion";
            this.insertion.Size = new System.Drawing.Size(113, 21);
            this.insertion.TabIndex = 2;
            this.insertion.TabStop = true;
            this.insertion.Text = "Insertion Sort";
            this.insertion.UseVisualStyleBackColor = true;
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(41, 114);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(75, 23);
            this.sort.TabIndex = 3;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // Randomize
            // 
            this.Randomize.Location = new System.Drawing.Point(34, 202);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(94, 23);
            this.Randomize.TabIndex = 4;
            this.Randomize.Text = "Randomize";
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 438);
            this.Controls.Add(this.Randomize);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.RadioButton insertion;
        private System.Windows.Forms.RadioButton selection;
        private System.Windows.Forms.RadioButton bubble;
        private System.Windows.Forms.Button Randomize;
    }
}

