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

namespace Lab5
{
    public partial class Form1 : Form
    {
        struct data
        {
            public string name;
            public string size;

            public override string ToString()
            {
                return name + " - " + size;
            }
        }
        Dictionary<string, string> dict = new Dictionary<string, string>();
        List<data> dataList = new List<data>();
        public Form1()
        {
            InitializeComponent();
            StreamReader read = new StreamReader(Application.StartupPath + @"\variableTypes.txt");
            while (true)
            {
                string[] strings = new string[2];
                data temp = new data();
                string input = read.ReadLine();
                if (input == null)
                {
                    break;
                }
                strings = input.Split('|');
                dict.Add(strings[0], strings[1]);
                temp.name = strings[0];
                temp.size = strings[1];
                dataList.Add(temp);
            }
            foreach (data s in dataList)
                outputBox.AppendText(s + "\n");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (dictionary.Checked)
            {
                if (dict[searchBox.Text] != null)
                {
                    outputBox.Clear();
                    outputBox.AppendText(searchBox.Text + " - " + dict[searchBox.Text] + "\n");
                }
            }
            else
            {
                foreach (data s in dataList)
                {
                    if (s.name == searchBox.Text)
                    {
                        outputBox.Clear();
                        outputBox.AppendText(s + "\n");
                    }
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            //if (searchBox.Text == "")
            //{
            //    outputBox.Clear();
            //    foreach (data s in dataList)
            //        outputBox.AppendText(s + "\n");
            //}
            outputBox.Clear();
            foreach (data s in dataList)
            {
                if (s.name.Contains(searchBox.Text) || s.size.Contains(searchBox.Text))
                {
                    outputBox.AppendText(s + "\n");
                }
            }
        }
    }
}
