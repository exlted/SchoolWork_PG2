namespace Lab1
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
            this.entryButton = new System.Windows.Forms.Button();
            this.classList1 = new System.Windows.Forms.ListBox();
            this.classList2 = new System.Windows.Forms.ListBox();
            this.classList3 = new System.Windows.Forms.ListBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classroomCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.classroomCount)).BeginInit();
            this.SuspendLayout();
            //
            // entryButton
            //
            this.entryButton.Location = new System.Drawing.Point(273, 345);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(75, 23);
            this.entryButton.TabIndex = 4;
            this.entryButton.Text = "Enter";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            //
            // classList1
            //
            this.classList1.FormattingEnabled = true;
            this.classList1.ItemHeight = 16;
            this.classList1.Location = new System.Drawing.Point(12, 12);
            this.classList1.Name = "classList1";
            this.classList1.Size = new System.Drawing.Size(200, 228);
            this.classList1.TabIndex = 2;
            this.classList1.TabStop = false;
            //
            // classList2
            //
            this.classList2.FormattingEnabled = true;
            this.classList2.ItemHeight = 16;
            this.classList2.Location = new System.Drawing.Point(224, 12);
            this.classList2.Name = "classList2";
            this.classList2.Size = new System.Drawing.Size(200, 228);
            this.classList2.TabIndex = 3;
            this.classList2.TabStop = false;
            //
            // classList3
            //
            this.classList3.FormattingEnabled = true;
            this.classList3.ItemHeight = 16;
            this.classList3.Location = new System.Drawing.Point(436, 12);
            this.classList3.Name = "classList3";
            this.classList3.Size = new System.Drawing.Size(200, 228);
            this.classList3.TabIndex = 4;
            this.classList3.TabStop = false;
            //
            // lastNameBox
            //
            this.lastNameBox.Location = new System.Drawing.Point(273, 287);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameBox.TabIndex = 2;
            //
            // firstNameBox
            //
            this.firstNameBox.Location = new System.Drawing.Point(273, 259);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameBox.TabIndex = 1;
            //
            // label1
            //
            this.label1.Location = new System.Drawing.Point(188, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            //
            // label2
            //
            this.label2.Location = new System.Drawing.Point(188, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            //
            // label3
            //
            this.label3.Location = new System.Drawing.Point(188, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Classroom";
            //
            // classroomCount
            //
            this.classroomCount.Location = new System.Drawing.Point(273, 316);
            this.classroomCount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.classroomCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.classroomCount.Name = "classroomCount";
            this.classroomCount.Size = new System.Drawing.Size(100, 22);
            this.classroomCount.TabIndex = 3;
            this.classroomCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 380);
            this.Controls.Add(this.classroomCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.classList3);
            this.Controls.Add(this.classList2);
            this.Controls.Add(this.classList1);
            this.Controls.Add(this.entryButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.classroomCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.ListBox classList1;
        private System.Windows.Forms.ListBox classList2;
        private System.Windows.Forms.ListBox classList3;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown classroomCount;
    }
}

