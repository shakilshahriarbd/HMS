using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace hospital
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public object DA { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP\\SQLEXPRESS; database = hospital; integrated security = True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from UserInfo where Id='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
                MessageBox.Show("Login Invalid");
        }
    }

    }
    

            
        
            


        
            