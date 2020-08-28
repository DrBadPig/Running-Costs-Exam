namespace exam3
{
    partial class Stats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dollar_label1 = new System.Windows.Forms.Label();
            this.Dollar_label2 = new System.Windows.Forms.Label();
            this.labelActive1 = new System.Windows.Forms.Label();
            this.labelActive2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelActive3 = new System.Windows.Forms.Label();
            this.Dollar_label3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "January",
            "February",
            "March ",
            "April ",
            "May",
            "June ",
            "July ",
            "August",
            "September ",
            "October",
            "November ",
            "December "});
            this.comboBox1.Location = new System.Drawing.Point(98, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Spent this month:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Spent this year:";
            // 
            // Dollar_label1
            // 
            this.Dollar_label1.AutoSize = true;
            this.Dollar_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dollar_label1.Location = new System.Drawing.Point(137, 55);
            this.Dollar_label1.Name = "Dollar_label1";
            this.Dollar_label1.Size = new System.Drawing.Size(15, 16);
            this.Dollar_label1.TabIndex = 22;
            this.Dollar_label1.Text = "$";
            // 
            // Dollar_label2
            // 
            this.Dollar_label2.AutoSize = true;
            this.Dollar_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dollar_label2.Location = new System.Drawing.Point(138, 89);
            this.Dollar_label2.Name = "Dollar_label2";
            this.Dollar_label2.Size = new System.Drawing.Size(15, 16);
            this.Dollar_label2.TabIndex = 23;
            this.Dollar_label2.Text = "$";
            // 
            // labelActive1
            // 
            this.labelActive1.AutoSize = true;
            this.labelActive1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActive1.Location = new System.Drawing.Point(148, 55);
            this.labelActive1.Name = "labelActive1";
            this.labelActive1.Size = new System.Drawing.Size(15, 16);
            this.labelActive1.TabIndex = 24;
            this.labelActive1.Text = "0";
            // 
            // labelActive2
            // 
            this.labelActive2.AutoSize = true;
            this.labelActive2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActive2.Location = new System.Drawing.Point(149, 89);
            this.labelActive2.Name = "labelActive2";
            this.labelActive2.Size = new System.Drawing.Size(15, 16);
            this.labelActive2.TabIndex = 25;
            this.labelActive2.Text = "0";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelActive3
            // 
            this.labelActive3.AutoSize = true;
            this.labelActive3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActive3.Location = new System.Drawing.Point(149, 123);
            this.labelActive3.Name = "labelActive3";
            this.labelActive3.Size = new System.Drawing.Size(15, 16);
            this.labelActive3.TabIndex = 29;
            this.labelActive3.Text = "0";
            // 
            // Dollar_label3
            // 
            this.Dollar_label3.AutoSize = true;
            this.Dollar_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dollar_label3.Location = new System.Drawing.Point(138, 123);
            this.Dollar_label3.Name = "Dollar_label3";
            this.Dollar_label3.Size = new System.Drawing.Size(15, 16);
            this.Dollar_label3.TabIndex = 28;
            this.Dollar_label3.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Total spent:";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 151);
            this.Controls.Add(this.labelActive3);
            this.Controls.Add(this.Dollar_label3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelActive2);
            this.Controls.Add(this.labelActive1);
            this.Controls.Add(this.Dollar_label2);
            this.Controls.Add(this.Dollar_label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Stats";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Dollar_label1;
        private System.Windows.Forms.Label Dollar_label2;
        private System.Windows.Forms.Label labelActive1;
        private System.Windows.Forms.Label labelActive2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelActive3;
        private System.Windows.Forms.Label Dollar_label3;
        private System.Windows.Forms.Label label3;
    }
}