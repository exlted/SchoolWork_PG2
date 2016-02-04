namespace Lab_2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deselectButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.shapeList = new System.Windows.Forms.ComboBox();
            this.dbp1 = new Lab_2.DBP();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 260);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // deselectButton
            // 
            this.deselectButton.Location = new System.Drawing.Point(32, 308);
            this.deselectButton.Name = "deselectButton";
            this.deselectButton.Size = new System.Drawing.Size(75, 23);
            this.deselectButton.TabIndex = 1;
            this.deselectButton.Text = "Deselect";
            this.deselectButton.UseVisualStyleBackColor = true;
            this.deselectButton.Click += new System.EventHandler(this.deselectButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(32, 337);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // shapeList
            // 
            this.shapeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shapeList.FormattingEnabled = true;
            this.shapeList.Items.AddRange(new object[] {
            "Circle",
            "Square"});
            this.shapeList.Location = new System.Drawing.Point(12, 278);
            this.shapeList.Name = "shapeList";
            this.shapeList.Size = new System.Drawing.Size(121, 24);
            this.shapeList.TabIndex = 3;
            // 
            // dbp1
            // 
            this.dbp1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dbp1.Location = new System.Drawing.Point(138, 12);
            this.dbp1.Name = "dbp1";
            this.dbp1.Size = new System.Drawing.Size(727, 505);
            this.dbp1.TabIndex = 0;
            this.dbp1.Paint += new System.Windows.Forms.PaintEventHandler(this.dbp1_Paint);
            this.dbp1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dbp1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 529);
            this.Controls.Add(this.shapeList);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.deselectButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dbp1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DBP dbp1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button deselectButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox shapeList;
    }
}

