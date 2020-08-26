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
    public partial class ViewAndEdit : Form
    {
        bool edit = false;
        Operation operation;

        public ViewAndEdit(Operation op, string theme, List<string> members, List<string> categ)
        {
            InitializeComponent();

            operation = op;

            MembercomboBox.Items.AddRange(members.ToArray());
            CategorycomboBox.Items.AddRange(categ.ToArray());

            TitletextBox.Text = op.Title;
            PricetextBox.Text = op.Price.ToString();
            DescriptiontextBox.Text = op.Description;
            dateTimePicker.Value = op.Date;
            MembercomboBox.SelectedItem = op.Member;
            CategorycomboBox.SelectedItem = op.Category;

            switch (theme)
            {
                case "dark":
                    this.BackColor = Color.DimGray;

                    TitletextBox.BackColor = Color.Gray;
                    PricetextBox.BackColor = Color.Gray;
                    DescriptiontextBox.BackColor = Color.Gray;

                    CategorycomboBox.BackColor = Color.Gray;
                    MembercomboBox.BackColor = Color.Gray;

                    TitletextBox.ForeColor = Color.WhiteSmoke;
                    PricetextBox.ForeColor = Color.WhiteSmoke;
                    DescriptiontextBox.ForeColor = Color.WhiteSmoke;

                    label1.ForeColor = Color.WhiteSmoke;
                    label2.ForeColor = Color.WhiteSmoke;
                    label3.ForeColor = Color.WhiteSmoke;
                    label4.ForeColor = Color.WhiteSmoke;
                    label5.ForeColor = Color.WhiteSmoke;
                    label6.ForeColor = Color.WhiteSmoke;

                    break;
                case "glamor":
                    this.BackColor = Color.Purple;

                    TitletextBox.BackColor = Color.DarkMagenta;
                    PricetextBox.BackColor = Color.DarkMagenta;
                    DescriptiontextBox.BackColor = Color.DarkMagenta;

                    CategorycomboBox.BackColor = Color.DarkMagenta;
                    MembercomboBox.BackColor = Color.DarkMagenta;

                    TitletextBox.ForeColor = Color.Gold;
                    PricetextBox.ForeColor = Color.Gold;
                    DescriptiontextBox.ForeColor = Color.Gold;

                    label1.ForeColor = Color.Gold;
                    label2.ForeColor = Color.Gold;
                    label3.ForeColor = Color.Gold;
                    label4.ForeColor = Color.Gold;
                    label5.ForeColor = Color.Gold;
                    label6.ForeColor = Color.Gold;

                    break;
                case "arctic":
                    this.BackColor = Color.LightCyan;

                    TitletextBox.BackColor = Color.Azure;
                    PricetextBox.BackColor = Color.Azure;
                    DescriptiontextBox.BackColor = Color.Azure;

                    CategorycomboBox.BackColor = Color.Azure;
                    MembercomboBox.BackColor = Color.Azure;

                    TitletextBox.ForeColor = Color.Black;
                    PricetextBox.ForeColor = Color.Black;
                    DescriptiontextBox.ForeColor = Color.Black;

                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;

                    break;
                case "deepsea":
                    this.BackColor = Color.Teal;

                    TitletextBox.BackColor = Color.DarkCyan;
                    PricetextBox.BackColor = Color.DarkCyan;
                    DescriptiontextBox.BackColor = Color.DarkCyan;

                    CategorycomboBox.BackColor = Color.DarkCyan;
                    MembercomboBox.BackColor = Color.DarkCyan;

                    TitletextBox.ForeColor = Color.MidnightBlue;
                    PricetextBox.ForeColor = Color.MidnightBlue;
                    DescriptiontextBox.ForeColor = Color.MidnightBlue;

                    label1.ForeColor = Color.MidnightBlue;
                    label2.ForeColor = Color.MidnightBlue;
                    label3.ForeColor = Color.MidnightBlue;
                    label4.ForeColor = Color.MidnightBlue;
                    label5.ForeColor = Color.MidnightBlue;
                    label6.ForeColor = Color.MidnightBlue;

                    break;
                case "olive":
                    this.BackColor = Color.DarkOliveGreen;

                    TitletextBox.BackColor = Color.OliveDrab;
                    PricetextBox.BackColor = Color.OliveDrab;
                    DescriptiontextBox.BackColor = Color.OliveDrab;

                    CategorycomboBox.BackColor = Color.OliveDrab;
                    MembercomboBox.BackColor = Color.OliveDrab;

                    TitletextBox.ForeColor = Color.YellowGreen;
                    PricetextBox.ForeColor = Color.YellowGreen;
                    DescriptiontextBox.ForeColor = Color.YellowGreen;

                    label1.ForeColor = Color.YellowGreen;
                    label2.ForeColor = Color.YellowGreen;
                    label3.ForeColor = Color.YellowGreen;
                    label4.ForeColor = Color.YellowGreen;
                    label5.ForeColor = Color.YellowGreen;
                    label6.ForeColor = Color.YellowGreen;

                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TitletextBox.Enabled = true;
            PricetextBox.Enabled = true;
            dateTimePicker.Enabled = true;
            DescriptiontextBox.Enabled = true;
            MembercomboBox.Enabled = true;
            CategorycomboBox.Enabled = true;

            edit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                if (TitletextBox.Text.Length != 0 && PricetextBox.Text.Length != 0
                && CategorycomboBox.SelectedItem != null && DescriptiontextBox.Text.Length != 0
                && MembercomboBox.SelectedItem != null)
                {
                    this.DialogResult = DialogResult.OK;

                    operation.Description = DescriptiontextBox.Text;
                    operation.Member = MembercomboBox.SelectedItem.ToString();
                    operation.Title = TitletextBox.Text;
                    operation.Price = Convert.ToDouble(PricetextBox.Text);
                    operation.Category = CategorycomboBox.SelectedItem.ToString();
                    operation.Date = dateTimePicker.Value;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Not all required fields are filled", "Warning", MessageBoxButtons.OK);
                }
            }
            this.Close();
        }

        private void PricetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            bool cancoma = true;

            foreach (var item in PricetextBox.Text)
            {
                if (item == ',')
                {
                    cancoma = false;
                    break;
                }
            }

            if (PricetextBox.TextLength == 0)
            {
                if (!Char.IsDigit(number) && number != 8)
                {
                    e.Handled = true;
                }
            }
            if (cancoma)
            {
                if (!Char.IsDigit(number) && number != 8 && number != 44)
                {
                    e.Handled = true;
                }
            }
            else if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
