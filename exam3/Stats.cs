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
    public partial class Stats : Form
    {
        List<Operation> notes;
        List<string> years = new List<string>();

        public Stats(List<Operation> notes, string theme)
        {
            InitializeComponent();

            this.notes = notes;

            foreach (var item in notes)
            {
                if (!years.Contains(item.Date.Year.ToString()))
                years.Add(item.Date.Year.ToString());
            }

            comboBox2.Items.AddRange(years.ToArray());

            switch (theme)
            {
                case "dark":
                    this.BackColor = Color.DimGray;

                    comboBox1.BackColor = Color.Gray;
                    comboBox2.BackColor = Color.Gray;

                    label1.ForeColor = Color.WhiteSmoke;
                    label2.ForeColor = Color.WhiteSmoke;
                    label3.ForeColor = Color.WhiteSmoke;
                    Dollar_label1.ForeColor = Color.WhiteSmoke;
                    Dollar_label2.ForeColor = Color.WhiteSmoke;
                    Dollar_label3.ForeColor = Color.WhiteSmoke;
                    labelActive1.ForeColor = Color.WhiteSmoke;
                    labelActive2.ForeColor = Color.WhiteSmoke;
                    labelActive3.ForeColor = Color.WhiteSmoke;

                    break;
                case "glamor":
                    this.BackColor = Color.Purple;

                    comboBox1.BackColor = Color.DarkMagenta;
                    comboBox2.BackColor = Color.DarkMagenta;

                    label1.ForeColor = Color.Gold;
                    label2.ForeColor = Color.Gold;
                    label3.ForeColor = Color.Gold;
                    Dollar_label1.ForeColor = Color.Gold;
                    Dollar_label2.ForeColor = Color.Gold;
                    Dollar_label3.ForeColor = Color.Gold;
                    labelActive1.ForeColor = Color.Gold;
                    labelActive2.ForeColor = Color.Gold;
                    labelActive3.ForeColor = Color.Gold;

                    break;
                case "arctic":
                    this.BackColor = Color.LightCyan;

                    comboBox1.BackColor = Color.Azure;
                    comboBox2.BackColor = Color.Azure;

                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    Dollar_label1.ForeColor = Color.Black;
                    Dollar_label2.ForeColor = Color.Black;
                    Dollar_label3.ForeColor = Color.Black;
                    labelActive1.ForeColor = Color.Black;
                    labelActive2.ForeColor = Color.Black;
                    labelActive3.ForeColor = Color.Black;

                    break;
                case "deepsea":
                    this.BackColor = Color.Teal;

                    comboBox1.BackColor = Color.DarkCyan;
                    comboBox2.BackColor = Color.DarkCyan;

                    label1.ForeColor = Color.MidnightBlue;
                    label2.ForeColor = Color.MidnightBlue;
                    label3.ForeColor = Color.MidnightBlue;
                    Dollar_label1.ForeColor = Color.MidnightBlue;
                    Dollar_label2.ForeColor = Color.MidnightBlue;
                    Dollar_label3.ForeColor = Color.MidnightBlue;
                    labelActive1.ForeColor = Color.MidnightBlue;
                    labelActive2.ForeColor = Color.MidnightBlue;
                    labelActive3.ForeColor = Color.MidnightBlue;

                    break;
                case "olive":
                    this.BackColor = Color.DarkOliveGreen;

                    comboBox1.BackColor = Color.OliveDrab;
                    comboBox2.BackColor = Color.OliveDrab;

                    label1.ForeColor = Color.YellowGreen;
                    label2.ForeColor = Color.YellowGreen;
                    label3.ForeColor = Color.YellowGreen;
                    Dollar_label1.ForeColor = Color.YellowGreen;
                    Dollar_label2.ForeColor = Color.YellowGreen;
                    Dollar_label3.ForeColor = Color.YellowGreen;
                    labelActive1.ForeColor = Color.YellowGreen;
                    labelActive2.ForeColor = Color.YellowGreen;
                    labelActive3.ForeColor = Color.YellowGreen;

                    break;
                default:
                    break;
            }

            double total = 0;

            foreach (var item in notes)
            {
                total += item.Price;
            }

            labelActive3.Text = total.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double total = 0;

            foreach (var item in notes)
            {
                if (item.Date.Year.ToString() == comboBox2.SelectedItem.ToString())
                {
                    if (item.Date.Month == comboBox1.SelectedIndex + 1)
                    {
                        total += item.Price;
                    }
                }
            }

            labelActive1.Text = total.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            double yearTotal = 0;

            foreach (var item in notes)
            {
                if (item.Date.Year.ToString() == comboBox2.SelectedItem.ToString())
                {
                    yearTotal += item.Price;
                }
            }

            labelActive2.Text = yearTotal.ToString();

            if (comboBox1.Enabled == true)
            {
                double total = 0;

                foreach (var item in notes)
                {
                    if (item.Date.Year.ToString() == comboBox2.SelectedItem.ToString())
                    {
                        if (item.Date.Month == comboBox1.SelectedIndex + 1)
                        {
                            total += item.Price;
                        }
                    }
                }

                labelActive1.Text = total.ToString();
            }
            else
                comboBox1.Enabled = true;

        }
    }
}
