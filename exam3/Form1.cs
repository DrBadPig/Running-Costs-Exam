using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam3
{
    public partial class Form1 : Form
    {
        List<string> categories;
        List<string> members;
        List<Operation> notes;

        public Form1()
        {
            InitializeComponent();

            categories = new List<string>();
            categories.Add("Products");
            categories.Add("Cafe");
            categories.Add("By-time");
            categories.Add("Transport");
            categories.Add("Family");
            categories.Add("Health");
            categories.Add("Shopping");
            categories.Add("Gifts");

            comboBoxCategories.Items.AddRange(categories.ToArray());

            foreach (var item in categories)
            {
                ListViewGroup group = new ListViewGroup(item);
                listExps.Groups.Add(group);
            }

            notes = new List<Operation>();

            listExps.Columns.Add("№", 30, HorizontalAlignment.Left);
            listExps.Columns.Add("Title", 100, HorizontalAlignment.Center);
            listExps.Columns.Add("Cost", 60, HorizontalAlignment.Center);
            listExps.Columns.Add("Date", 120, HorizontalAlignment.Center);
            listExps.Columns.Add("Description", 230, HorizontalAlignment.Center);
            listExps.Columns.Add("Member", 100, HorizontalAlignment.Right);

            members = new List<string>();
            
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (comboBoxMembers.Items.Count == 0) MessageBox.Show("Nothing to delete :(", "Damnn it!", MessageBoxButtons.OK);
            else if (comboBoxCategories.SelectedItem == null) MessageBox.Show("You chose nothing", "Damn it!", MessageBoxButtons.OK);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxCategories.Items.Count == 0) MessageBox.Show("Nothing to delete :(", "Damn it!", MessageBoxButtons.OK);
            else if (comboBoxCategories.SelectedItem == null) MessageBox.Show("You chose nothing", "Damn it!", MessageBoxButtons.OK);
            else
            {
                DialogResult res = MessageBox.Show($"Are you sure you want to delete {comboBoxCategories.SelectedItem} " +
                    $"category? It will delete all operations related to it", "Warning", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    categories.Remove(comboBoxCategories.SelectedItem.ToString());
                    comboBoxCategories.Items.Remove(comboBoxCategories.SelectedItem.ToString());

                    /*
                     
                    NEED TO DO SOME SHIT

                    */
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter category name:", "Add category", "Category name", 30, 30);
            bool createNew = true;

            foreach (var item in categories)
            {
                if (item == name)
                {
                    MessageBox.Show("This category already exists", "Damn it", MessageBoxButtons.OK);
                    createNew = false;
                }
            }

            if (createNew)
            {
                categories.Add(name);
                comboBoxCategories.Items.Add(name);
            }
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;

            listExps.BackColor = Color.White;
            listExps.ForeColor = Color.Black;

            menuStrip1.BackColor = Color.WhiteSmoke;
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.Black;
            }

            comboBoxSearch.BackColor = Color.White;
            comboBoxSearch.ForeColor = Color.Black;
            textBoxSearch.BackColor = Color.White;
            textBoxSearch.ForeColor = Color.Black;

            comboBoxCategories.BackColor = Color.White;
            comboBoxCategories.ForeColor = Color.Black;
            comboBoxMembers.BackColor = Color.White;
            comboBoxMembers.ForeColor = Color.Black;

            contextMenuCategories.BackColor = Color.WhiteSmoke;
            contextMenuCategories.ForeColor = Color.Black;
            contextMenuMembers.BackColor = Color.WhiteSmoke;
            contextMenuMembers.ForeColor = Color.Black;
            contextMenuListExps.BackColor = Color.WhiteSmoke;
            contextMenuListExps.ForeColor = Color.Black;

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;

            listExps.BackColor = Color.Gray;
            listExps.ForeColor = Color.WhiteSmoke;

            menuStrip1.BackColor = Color.DimGray;
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.WhiteSmoke;
            }

            comboBoxSearch.BackColor = Color.Gray;
            comboBoxSearch.ForeColor = Color.WhiteSmoke;
            textBoxSearch.BackColor = Color.Gray;
            textBoxSearch.ForeColor = Color.WhiteSmoke;

            comboBoxCategories.BackColor = Color.Gray;
            comboBoxCategories.ForeColor = Color.WhiteSmoke;
            comboBoxMembers.BackColor = Color.Gray;
            comboBoxMembers.ForeColor = Color.WhiteSmoke;

            contextMenuCategories.BackColor = Color.DimGray;
            contextMenuCategories.ForeColor = Color.WhiteSmoke;
            contextMenuMembers.BackColor = Color.DimGray;
            contextMenuMembers.ForeColor = Color.WhiteSmoke;
            contextMenuListExps.BackColor = Color.DimGray;
            contextMenuListExps.ForeColor = Color.WhiteSmoke;

            label1.ForeColor = Color.WhiteSmoke;
            label2.ForeColor = Color.WhiteSmoke;
        }

        private void glamorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;

            listExps.BackColor = Color.DarkMagenta;
            listExps.ForeColor = Color.Gold;

            menuStrip1.BackColor = Color.Purple;
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.Gold;
            }

            comboBoxSearch.BackColor = Color.DarkMagenta;
            comboBoxSearch.ForeColor = Color.Gold;
            textBoxSearch.BackColor = Color.DarkMagenta;
            textBoxSearch.ForeColor = Color.Gold;

            comboBoxCategories.BackColor = Color.DarkMagenta;
            comboBoxCategories.ForeColor = Color.Gold;
            comboBoxMembers.BackColor = Color.DarkMagenta;
            comboBoxMembers.ForeColor = Color.Gold;

            contextMenuCategories.BackColor = Color.Purple;
            contextMenuCategories.ForeColor = Color.Gold;
            contextMenuMembers.BackColor = Color.Purple;
            contextMenuMembers.ForeColor = Color.Gold;
            contextMenuListExps.BackColor = Color.Purple;
            contextMenuListExps.ForeColor = Color.Gold;

            label1.ForeColor = Color.Gold;
            label2.ForeColor = Color.Gold;
        }

        private void arcticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightCyan;

            listExps.BackColor = Color.Azure;
            listExps.ForeColor = Color.Black;

            menuStrip1.BackColor = Color.LightCyan;
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.Black;
            }

            comboBoxSearch.BackColor = Color.Azure;
            comboBoxSearch.ForeColor = Color.Black;
            textBoxSearch.BackColor = Color.Azure;
            textBoxSearch.ForeColor = Color.Black;

            comboBoxCategories.BackColor = Color.Azure;
            comboBoxCategories.ForeColor = Color.Black;
            comboBoxMembers.BackColor = Color.Azure;
            comboBoxMembers.ForeColor = Color.Black;

            contextMenuCategories.BackColor = Color.LightCyan;
            contextMenuCategories.ForeColor = Color.Black;
            contextMenuMembers.BackColor = Color.LightCyan;
            contextMenuMembers.ForeColor = Color.Black;
            contextMenuListExps.BackColor = Color.LightCyan;
            contextMenuListExps.ForeColor = Color.Black;

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
        }

        private void deepSeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Teal;

            listExps.BackColor = Color.DarkCyan;
            listExps.ForeColor = Color.MidnightBlue;

            menuStrip1.BackColor = Color.Teal;
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.MidnightBlue;
            }

            comboBoxSearch.BackColor = Color.DarkCyan;
            comboBoxSearch.ForeColor = Color.MidnightBlue;
            textBoxSearch.BackColor = Color.DarkCyan;
            textBoxSearch.ForeColor = Color.MidnightBlue;

            comboBoxCategories.BackColor = Color.DarkCyan;
            comboBoxCategories.ForeColor = Color.MidnightBlue;
            comboBoxMembers.BackColor = Color.DarkCyan;
            comboBoxMembers.ForeColor = Color.MidnightBlue;

            contextMenuCategories.BackColor = Color.Teal;
            contextMenuCategories.ForeColor = Color.MidnightBlue;
            contextMenuMembers.BackColor = Color.Teal;
            contextMenuMembers.ForeColor = Color.MidnightBlue;
            contextMenuListExps.BackColor = Color.Teal;
            contextMenuListExps.ForeColor = Color.MidnightBlue;

            label1.ForeColor = Color.MidnightBlue;
            label2.ForeColor = Color.MidnightBlue;
        }

        private void oliveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOliveGreen;

            listExps.BackColor = Color.OliveDrab;
            listExps.ForeColor = Color.YellowGreen;

            menuStrip1.BackColor = Color.DarkOliveGreen;
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.YellowGreen;
            }

            comboBoxSearch.BackColor = Color.OliveDrab;
            comboBoxSearch.ForeColor = Color.YellowGreen;
            textBoxSearch.BackColor = Color.OliveDrab;
            textBoxSearch.ForeColor = Color.YellowGreen;

            comboBoxCategories.BackColor = Color.OliveDrab;
            comboBoxCategories.ForeColor = Color.YellowGreen;
            comboBoxMembers.BackColor = Color.OliveDrab;
            comboBoxMembers.ForeColor = Color.YellowGreen;

            contextMenuCategories.BackColor = Color.DarkOliveGreen;
            contextMenuCategories.ForeColor = Color.YellowGreen;
            contextMenuMembers.BackColor = Color.DarkOliveGreen;
            contextMenuMembers.ForeColor = Color.YellowGreen;
            contextMenuListExps.BackColor = Color.DarkOliveGreen;
            contextMenuListExps.ForeColor = Color.YellowGreen;

            label1.ForeColor = Color.YellowGreen;
            label2.ForeColor = Color.YellowGreen;
        }
    }
}
