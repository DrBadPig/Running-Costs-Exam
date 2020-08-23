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
            listExps.Columns.Add("Title", 80, HorizontalAlignment.Center);
            listExps.Columns.Add("Cost", 50, HorizontalAlignment.Center);
            listExps.Columns.Add("Date", 100, HorizontalAlignment.Center);
            listExps.Columns.Add("Description", 200, HorizontalAlignment.Center);
            listExps.Columns.Add("Member", 80, HorizontalAlignment.Right);

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
    }
}
