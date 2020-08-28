using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam3
{
    public partial class Main : Form
    {
        List<string> categories;
        List<string> members;
        List<Operation> notes;

        int current = 0;

        string theme = "standart";

        public Main()
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
            listExps.Columns.Add("Cost, $", 80, HorizontalAlignment.Center);
            listExps.Columns.Add("Date", 120, HorizontalAlignment.Center);
            listExps.Columns.Add("Description", 230, HorizontalAlignment.Center);
            listExps.Columns.Add("Member", 100, HorizontalAlignment.Right);

            members = new List<string>();

            if (File.Exists("config.txt"))
            {
                StreamReader reader = new StreamReader("config.txt");

                theme = reader.ReadLine();

                reader.Close();
            }

            switch (theme)
            {
                case "standart":
                    standartToolStripMenuItem_Click(this, new EventArgs());
                    break;
                case "dark":
                    standartToolStripMenuItem_Click(this, new EventArgs());
                    break;
                case "glamor":
                    standartToolStripMenuItem_Click(this, new EventArgs());
                    break;
                case "arctic":
                    standartToolStripMenuItem_Click(this, new EventArgs());
                    break;
                case "deepsea":
                    standartToolStripMenuItem_Click(this, new EventArgs());
                    break;
                case "olive":
                    standartToolStripMenuItem_Click(this, new EventArgs());
                    break;
            }

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (comboBoxMembers.Items.Count == 0) MessageBox.Show("Nothing to delete :(", "Damnn it!", MessageBoxButtons.OK);
            else if (comboBoxMembers.SelectedItem == null) MessageBox.Show("You chose nothing", "Damn it!", MessageBoxButtons.OK);
            else
            {
                DialogResult res = MessageBox.Show($"Are you sure you want to delete {comboBoxMembers.SelectedItem} " +
                    $"member? It will delete all operations related to it", "Warning", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    for (int i = 0; i < notes.Count; i++)
                    {
                        if (notes[i].Member == comboBoxMembers.SelectedItem.ToString())
                        {
                            notes.Remove(notes[i]);
                            i--;
                        }
                    }

                    members.Remove(comboBoxMembers.SelectedItem.ToString());
                    comboBoxMembers.Items.Remove(comboBoxMembers.SelectedItem.ToString());

                    RedrawList();
                }
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter member name:", "Add member", "Member name", 30, 30);
            bool createNew = true;

            foreach (var item in members)
            {
                if (item == name)
                {
                    MessageBox.Show("This member already exists", "Damn it", MessageBoxButtons.OK);
                    createNew = false;
                }
            }

            if (createNew)
            {
                members.Add(name);
                comboBoxMembers.Items.Add(name);
            }
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
                    for (int i = 0; i < notes.Count; i++)
                    {
                        if (notes[i].Category == comboBoxCategories.SelectedItem.ToString())
                        {
                            notes.Remove(notes[i]);
                            i--;
                        }
                    }

                    int grIndex = 0;

                    for (int k = 0; k < listExps.Groups.Count; k++)
                    {
                        if (listExps.Groups[k].Header == comboBoxCategories.SelectedItem.ToString())
                        {
                            grIndex = k;
                            break;
                        }
                    }

                    ListViewGroup gr = listExps.Groups[grIndex];

                    listExps.Groups.Remove(gr);
                    categories.Remove(comboBoxCategories.SelectedItem.ToString());
                    comboBoxCategories.Items.Remove(comboBoxCategories.SelectedItem.ToString());

                    RedrawList();
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
            theme = "standart";

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
            theme = "dark";

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
            theme = "glamor";

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
            theme = "arctic";

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
            theme = "deepsea";

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
            theme = "olive";

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

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you wat to delete it?", "Hey you", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                foreach (ListViewItem item in listExps.SelectedItems)
                {
                    notes.Remove(notes[item.Index]);

                    item.Remove();
                }

                RedrawList();
            }
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (members.Count > 0 && categories.Count > 1)
            {
                Operation op = new Operation();
                AddOperation addOperation = new AddOperation(op, theme, members, categories);

                DialogResult res = addOperation.ShowDialog();

                if (res == DialogResult.OK)
                {
                    notes.Add(op);
                    ListViewItem item = new ListViewItem(Convert.ToString(current));

                    current++;

                    item.SubItems.Add(op.Title);
                    item.SubItems.Add(op.Price.ToString());
                    item.SubItems.Add(op.Date.ToString());
                    item.SubItems.Add(op.Description);
                    item.SubItems.Add(op.Member);

                    int grIndex = 0;

                    for (int k = 0; k < listExps.Groups.Count; k++)
                    {
                        if (listExps.Groups[k].Header == op.Category)
                        {
                            grIndex = k;
                            break;
                        }
                    }

                    ListViewGroup group = listExps.Groups[grIndex];

                    item.Group = group;

                    listExps.Items.Add(item);
                }
            }
            else MessageBox.Show("You must have at least 1 member or category", "Damn it!", MessageBoxButtons.OK);
        }

        private void listExps_ItemActivate(object sender, EventArgs e)
        {
            if (members.Count > 0 && categories.Count > 1)
            {
                Operation op = notes[Convert.ToInt32(listExps.FocusedItem.SubItems[0].Text)];
                ViewAndEdit viewAndEdit = new ViewAndEdit(op, theme, members, categories);

                DialogResult res = viewAndEdit.ShowDialog();

                if (res == DialogResult.OK)
                {
                    int grIndex = 0;

                    for (int k = 0; k < listExps.Groups.Count; k++)
                    {
                        if (listExps.Groups[k].Header == op.Category)
                        {
                            grIndex = k;
                            break;
                        }
                    }

                    ListViewGroup group = listExps.Groups[grIndex];

                    listExps.FocusedItem.Group = group;

                    listExps.FocusedItem.SubItems[1].Text = op.Title;
                    listExps.FocusedItem.SubItems[2].Text = Convert.ToString(op.Price);
                    listExps.FocusedItem.SubItems[3].Text = Convert.ToString(op.Date);
                    listExps.FocusedItem.SubItems[4].Text = op.Description;
                    listExps.FocusedItem.SubItems[5].Text = op.Member;

                }
            }
            else MessageBox.Show("You must have at least 1 member or category", "Damn it!", MessageBoxButtons.OK);
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats(notes, theme);

            DialogResult res = stats.ShowDialog();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            comboBoxCategories.SelectedItem = null;
            comboBoxMembers.SelectedItem = null;
            textBoxSearch.Text = null;
            comboBoxSearch.Text = null;

            RedrawList();
        }

        private void comboBoxMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMembers.SelectedItem != null)
                RedrawList("mem", comboBoxMembers.SelectedItem.ToString());
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategories.SelectedItem != null)
                RedrawList("cat", comboBoxCategories.SelectedItem.ToString());
        }

        /// <summary>
        /// Redrawing list again
        /// </summary>
        private void RedrawList()
        {
            foreach (ListViewItem item in listExps.Items)
            {
                item.Remove();
            }

            current = 0;

            foreach (var op in notes)
            {
                ListViewItem _item = new ListViewItem(Convert.ToString(current));

                current++;

                _item.SubItems.Add(op.Title);
                _item.SubItems.Add(op.Price.ToString());
                _item.SubItems.Add(op.Date.ToString());
                _item.SubItems.Add(op.Description);
                _item.SubItems.Add(op.Member);

                int grIndex = 0;

                for (int k = 0; k < listExps.Groups.Count; k++)
                {
                    if (listExps.Groups[k].Header == op.Category)
                    {
                        grIndex = k;
                        break;
                    }
                }

                ListViewGroup group = listExps.Groups[grIndex];

                _item.Group = group;

                listExps.Items.Add(_item);
            }
        }

        /// <summary>
        /// Sorting list by type ad title
        /// </summary>
        /// <param name="type">"mem" for members, "cat" for categories</param>
        /// <param name="title">string will redraw (sort) by</param>
        private void RedrawList(string type, string title)
        {
            foreach (ListViewItem item in listExps.Items)
            {
                item.Remove();
            }

            current = 0;

            foreach (var op in notes)
            {
                if (type == "mem")
                {
                    if (op.Member == title)
                    {
                        ListViewItem _item = new ListViewItem(Convert.ToString(current));

                        current++;

                        _item.SubItems.Add(op.Title);
                        _item.SubItems.Add(op.Price.ToString());
                        _item.SubItems.Add(op.Date.ToString());
                        _item.SubItems.Add(op.Description);
                        _item.SubItems.Add(op.Member);

                        int grIndex = 0;

                        for (int k = 0; k < listExps.Groups.Count; k++)
                        {
                            if (listExps.Groups[k].Header == op.Category)
                            {
                                grIndex = k;
                                break;
                            }
                        }

                        ListViewGroup group = listExps.Groups[grIndex];

                        _item.Group = group;

                        listExps.Items.Add(_item);
                    }
                }
                else if (type == "cat")
                {
                    if (op.Category == title)
                    {
                        ListViewItem _item = new ListViewItem(Convert.ToString(current));

                        current++;

                        _item.SubItems.Add(op.Title);
                        _item.SubItems.Add(op.Price.ToString());
                        _item.SubItems.Add(op.Date.ToString());
                        _item.SubItems.Add(op.Description);
                        _item.SubItems.Add(op.Member);

                        int grIndex = 0;

                        for (int k = 0; k < listExps.Groups.Count; k++)
                        {
                            if (listExps.Groups[k].Header == op.Category)
                            {
                                grIndex = k;
                                break;
                            }
                        }

                        ListViewGroup group = listExps.Groups[grIndex];

                        _item.Group = group;

                        listExps.Items.Add(_item);
                    }
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listExps.Items)
            {
                item.Remove();
            }

            current = 0;

            foreach (var item in notes)
            {
                if (comboBoxSearch.SelectedItem != null)
                {
                    switch (comboBoxSearch.SelectedItem.ToString())
                    {
                        case "Date":
                            if (item.Date.ToString().Contains(textBoxSearch.Text))
                            {
                                ListViewItem _item = new ListViewItem(Convert.ToString(current));

                                current++;

                                _item.SubItems.Add(item.Title);
                                _item.SubItems.Add(item.Price.ToString());
                                _item.SubItems.Add(item.Date.ToString());
                                _item.SubItems.Add(item.Description);
                                _item.SubItems.Add(item.Member);

                                int grIndex = 0;

                                for (int k = 0; k < listExps.Groups.Count; k++)
                                {
                                    if (listExps.Groups[k].Header == item.Category)
                                    {
                                        grIndex = k;
                                        break;
                                    }
                                }

                                ListViewGroup group = listExps.Groups[grIndex];

                                _item.Group = group;

                                listExps.Items.Add(_item);
                            }
                            break;
                        case "Description":
                            if (item.Description.Contains(textBoxSearch.Text))
                            {
                                ListViewItem _item = new ListViewItem(Convert.ToString(current));

                                current++;

                                _item.SubItems.Add(item.Title);
                                _item.SubItems.Add(item.Price.ToString());
                                _item.SubItems.Add(item.Date.ToString());
                                _item.SubItems.Add(item.Description);
                                _item.SubItems.Add(item.Member);

                                int grIndex = 0;

                                for (int k = 0; k < listExps.Groups.Count; k++)
                                {
                                    if (listExps.Groups[k].Header == item.Category)
                                    {
                                        grIndex = k;
                                        break;
                                    }
                                }

                                ListViewGroup group = listExps.Groups[grIndex];

                                _item.Group = group;

                                listExps.Items.Add(_item);
                            }
                            break;
                        case "Title":
                            if (item.Title.Contains(textBoxSearch.Text))
                            {
                                ListViewItem _item = new ListViewItem(Convert.ToString(current));

                                current++;

                                _item.SubItems.Add(item.Title);
                                _item.SubItems.Add(item.Price.ToString());
                                _item.SubItems.Add(item.Date.ToString());
                                _item.SubItems.Add(item.Description);
                                _item.SubItems.Add(item.Member);

                                int grIndex = 0;

                                for (int k = 0; k < listExps.Groups.Count; k++)
                                {
                                    if (listExps.Groups[k].Header == item.Category)
                                    {
                                        grIndex = k;
                                        break;
                                    }
                                }

                                ListViewGroup group = listExps.Groups[grIndex];

                                _item.Group = group;

                                listExps.Items.Add(_item);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("config.txt");

            //////////////////////////////////////////////////////////

            streamWriter.WriteLine(theme);

            streamWriter.Close();

            DialogResult res = MessageBox.Show("Are you sure about that?", "Hey you", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
