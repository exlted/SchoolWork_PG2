namespace Lab3
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
            this.SOut = new System.Windows.Forms.TextBox();
            this.TOut = new System.Windows.Forms.TextBox();
            this.COut = new System.Windows.Forms.TextBox();
            this.TBaseCount = new System.Windows.Forms.NumericUpDown();
            this.THeightCount = new System.Windows.Forms.NumericUpDown();
            this.CRadiusCount = new System.Windows.Forms.NumericUpDown();
            this.SWidthCount = new System.Windows.Forms.NumericUpDown();
            this.SHeightCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Square = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TBaseCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THeightCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRadiusCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SWidthCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHeightCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SOut
            // 
            this.SOut.Enabled = false;
            this.SOut.Location = new System.Drawing.Point(471, 147);
            this.SOut.Name = "SOut";
            this.SOut.Size = new System.Drawing.Size(100, 22);
            this.SOut.TabIndex = 0;
            this.SOut.TabStop = false;
            // 
            // TOut
            // 
            this.TOut.Enabled = false;
            this.TOut.Location = new System.Drawing.Point(63, 147);
            this.TOut.Name = "TOut";
            this.TOut.Size = new System.Drawing.Size(100, 22);
            this.TOut.TabIndex = 1;
            this.TOut.TabStop = false;
            // 
            // COut
            // 
            this.COut.Enabled = false;
            this.COut.Location = new System.Drawing.Point(265, 147);
            this.COut.Name = "COut";
            this.COut.Size = new System.Drawing.Size(100, 22);
            this.COut.TabIndex = 2;
            this.COut.TabStop = false;
            // 
            // TBaseCount
            // 
            this.TBaseCount.Location = new System.Drawing.Point(74, 21);
            this.TBaseCount.Name = "TBaseCount";
            this.TBaseCount.Size = new System.Drawing.Size(120, 22);
            this.TBaseCount.TabIndex = 3;
            // 
            // THeightCount
            // 
            this.THeightCount.Location = new System.Drawing.Point(74, 49);
            this.THeightCount.Name = "THeightCount";
            this.THeightCount.Size = new System.Drawing.Size(120, 22);
            this.THeightCount.TabIndex = 4;
            // 
            // CRadiusCount
            // 
            this.CRadiusCount.Location = new System.Drawing.Point(74, 21);
            this.CRadiusCount.Name = "CRadiusCount";
            this.CRadiusCount.Size = new System.Drawing.Size(120, 22);
            this.CRadiusCount.TabIndex = 5;
            // 
            // SWidthCount
            // 
            this.SWidthCount.Location = new System.Drawing.Point(74, 21);
            this.SWidthCount.Name = "SWidthCount";
            this.SWidthCount.Size = new System.Drawing.Size(120, 22);
            this.SWidthCount.TabIndex = 6;
            // 
            // SHeightCount
            // 
            this.SHeightCount.Location = new System.Drawing.Point(74, 49);
            this.SHeightCount.Name = "SHeightCount";
            this.SHeightCount.Size = new System.Drawing.Size(120, 22);
            this.SHeightCount.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBaseCount);
            this.groupBox1.Controls.Add(this.THeightCount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triangle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CRadiusCount);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Circle";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.SWidthCount);
            this.groupBox3.Controls.Add(this.SHeightCount);
            this.groupBox3.Location = new System.Drawing.Point(424, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Square";
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(483, 118);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(75, 23);
            this.Square.TabIndex = 9;
            this.Square.Text = "Calculate";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(75, 118);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(75, 23);
            this.Triangle.TabIndex = 10;
            this.Triangle.Text = "Calculate";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(275, 118);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(75, 23);
            this.Circle.TabIndex = 11;
            this.Circle.Text = "Calculate";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Width";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 186);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.COut);
            this.Controls.Add(this.TOut);
            this.Controls.Add(this.SOut);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TBaseCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THeightCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRadiusCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SWidthCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SHeightCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SOut;
        private System.Windows.Forms.TextBox TOut;
        private System.Windows.Forms.TextBox COut;
        private System.Windows.Forms.NumericUpDown TBaseCount;
        private System.Windows.Forms.NumericUpDown THeightCount;
        private System.Windows.Forms.NumericUpDown CRadiusCount;
        private System.Windows.Forms.NumericUpDown SWidthCount;
        private System.Windows.Forms.NumericUpDown SHeightCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

