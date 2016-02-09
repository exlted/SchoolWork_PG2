using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.InitialDirectory = Application.StartupPath;
            file.Filter = "CSV File (*.csv)|*.csv";
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(file.OpenFile());
                StringBuilder output = new StringBuilder();
                for (int i = 0; i < listStorage.Items.Count; i++)
                {
                    output.Append(listStorage.Items[i].ToString() + ',');
                }
                write.WriteLine(output);
                write.Close();
            }
            }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listStorage.Items.Clear();
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Application.StartupPath;
            file.Filter = "CSV File (*.csv)|*.csv";
            if(file.ShowDialog() == DialogResult.OK )
            {
                StreamReader read = new StreamReader(file.OpenFile());
                string input = read.ReadLine();
                string[] inputs = input.Split(',');
                foreach (string s in inputs)
                    listStorage.Items.Add(s);
                read.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            listStorage.Items.Clear();
            listStorage.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < inputBox.Text.Length; i++)
            {
                if (inputBox.Text[i].Equals(','))
                {
                    MessageBox.Show("Cannot include comma within title");
                    return;
                }
            }
            listStorage.Items.Add(inputBox.Text);
            inputBox.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listStorage.Items.Remove(listStorage.SelectedItem);
            listStorage.Refresh();
        }
    }
}
