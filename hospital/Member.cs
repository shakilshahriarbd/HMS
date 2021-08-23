using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hospital
{
    public partial class Member : Form
    {
        public Member()
        {
        }

        public Member(Form1 form1, string name)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ds = new Form1();
            ds.Show();
        }
    }
}
