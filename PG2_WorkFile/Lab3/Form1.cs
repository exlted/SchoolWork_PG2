using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            Objects.Triangle temp = new Objects.Triangle((int)TBaseCount.Value, (int)THeightCount.Value);
            TOut.Text = temp.getArea().ToString();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            Objects.Circle temp = new Objects.Circle((int)CRadiusCount.Value);
            COut.Text = temp.getArea().ToString();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            Objects.Square temp = new Objects.Square((int)SWidthCount.Value, (int)SHeightCount.Value);
            SOut.Text = temp.getArea().ToString();
        }
    }
}
