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

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "CSV file *.csv|*.csv";
            file.InitialDirectory = Application.StartupPath;
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader load = new StreamReader(file.FileName);
                string input = load.ReadLine();
                string[] inputs = input.Split(',');
                foreach (string item in inputs)
                    list.Items.Add(item);
                load.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "CSV file *.csv|*.csv";
            file.InitialDirectory = Application.StartupPath;
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamWriter save = new StreamWriter(file.FileName);
                foreach (string s in list.Items)
                {
                    save.Write(s + ",");
                }
                save.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < r.Next(50, 100); i++)
            {
                for (int j = 0; j < list.Items.Count; j++)
                {
                    object temp = list.Items[j];
                    int tempRand = r.Next(list.Items.Count);
                    list.Items[j] = list.Items[tempRand];
                    list.Items[tempRand] = temp;
                }
            }
            list.Refresh();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            if (bubble.Checked)
                bubbleSort();
            else if (selection.Checked)
                selectionSort();
            else if (insertion.Checked)
                insertionSort();
        }

        private void bubbleSort()
        {
            object temp;
            while (true)
            {
                bool isChanged = true;
                for (int i = 0; i < list.Items.Count - 1; i++)
                {
                    if ((list.Items[i] as string).CompareTo(list.Items[i + 1] as string) > 0)
                    {
                        isChanged = false;
                        temp = list.Items[i];
                        list.Items[i] = list.Items[i + 1];
                        list.Items[i + 1] = temp;
                        list.Refresh();
                    }
                }
                if (isChanged)
                {
                    break;
                }
            }
        }

        private void selectionSort()
        {
            int posMin;
            object temp;
            for (int i = 0; i < list.Items.Count; i++)
            {
                posMin = i;
                for (int j = i + 1; j < list.Items.Count; j++)
                {
                    if ((list.Items[j] as string).CompareTo(list.Items[posMin] as string) < 0)
                    {
                        posMin = j;
                    }
                }
                if (posMin != i)
                {
                    temp = list.Items[i];
                    list.Items[i] = list.Items[posMin];
                    list.Items[posMin] = temp;
                    list.Refresh();
                }
            }
        }

        private void insertionSort()
        {
            int j;

            for (int i = 1; i < list.Items.Count; i++)
            {
                object value = list.Items[i];
                j = i - 1;
                while ((list.Items[j] as string).CompareTo(value as string) > 0)
                {
                    list.Items[j + 1] = list.Items[j];
                    j--;
                    if (j < 0)
                    {
                        break;
                    }
                }
                list.Items[j + 1] = value;
                list.Refresh();
            }
        }
    }
}
