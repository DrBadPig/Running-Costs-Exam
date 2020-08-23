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
    public partial class AddOperation : Form
    {
        string theme;
        Operation operation;
        public AddOperation(Operation op, string theme, List<string> members, List<string> categ)
        {
            InitializeComponent();
            this.theme = theme;
            operation = op;

            CategorycomboBox.Items.AddRange(categ.ToArray());
            MembercomboBox.Items.AddRange(members.ToArray());

            switch(theme)
            {
                case "dark":
                    this.BackColor = Color.DimGray;

                    TitletextBox.BackColor = Color.Gray;
                    PricetextBox.BackColor = Color.Gray;
                    DescriptiontextBox.BackColor = Color.Gray;
                    DatetextBox.BackColor = Color.Gray;

                    CategorycomboBox.BackColor = Color.Gray;
                    MembercomboBox.BackColor = Color.Gray;

                    label1.ForeColor = Color.WhiteSmoke;
                    label2.ForeColor = Color.WhiteSmoke;
                    label3.ForeColor = Color.WhiteSmoke;
                    label4.ForeColor = Color.WhiteSmoke;
                    label5.ForeColor = Color.WhiteSmoke;
                    label6.ForeColor = Color.WhiteSmoke;

                    break;
            }
        }
    }
}
