using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hospital
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ds = new Form1();
            ds.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String address = txtAddress.Text;
                Int64 contact = Convert.ToInt64(txtContact.Text);
                int age = Convert.ToInt32(txtAge.Text);
                String gender = comboGender.Text;
                String blood = comboBlood.Text;
                String any = txtAny.Text;
                int pid = Convert.ToInt32(txtPid.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP\\SQLEXPRESS;database = hospital;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into AddPatient values ('" + name + "','" + address + "'," + contact + "," + age + ",'" + gender + "','" + blood + "','" + any + "'," + pid + ")";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data");
            }

            MessageBox.Show("Data Saved");

            txtName.ResetText();
            txtAddress.ResetText();
            txtContact.ResetText();
            txtAge.ResetText();
            comboBlood.ResetText();
            txtAny.ResetText();
            txtAny.ResetText();
            comboGender.ResetText();
            txtPid.ResetText();





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBxPid.Text != "")


            {
                int pid = Convert.ToInt32(txtBxPid.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP\\SQLEXPRESS;database = hospital;integrated security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Addpatient where pid = " + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(txtBxPid.Text);
                String symptoms = txtBxSymptoms.Text;
                String diagnosis = txtBxDiagnosis2.Text;
                String medicine = txtBxMedicine2.Text;
                String room = comboBxRoom.Text;
                String roomType = comboBxRoomType.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP\\SQLEXPRESS;database = hospital;integrated security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into PatientMore values (" + pid + ",'" + symptoms + "','" + diagnosis + "','" + medicine + "','" + room + "','" + roomType + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }
            catch (Exception)
            {
                MessageBox.Show("Any field is empty 'OR' Data is in WRONG format.");
            }
            MessageBox.Show("Data Saved.");

            txtBxPid.Clear();
            txtBxSymptoms.Clear();
            txtBxDiagnosis2.Clear();
            txtBxMedicine2.Clear();
            comboBxRoom.ResetText();
            comboBxRoomType.ResetText();


        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;

        }

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP\\SQLEXPRESS;database = hospital;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from AddPatient inner join PatientMore on AddPatient.pid = PatientMore.pid";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView2.DataSource = DS.Tables[0];
        }



        private void btnAddPatient_MouseEnter(object sender, EventArgs e)
        {
            btnAddPatient.ForeColor = Color.Blue;
        }

        private void btnAddPatient_MouseLeave(object sender, EventArgs e)
        {
            btnAddPatient.ForeColor = Color.Black;
        }

        private void btnAddDiagnosis_MouseEnter(object sender, EventArgs e)
        {
            btnAddDiagnosis.ForeColor = Color.Blue;
        }

        private void btnAddDiagnosis_MouseLeave(object sender, EventArgs e)
        {
            btnAddDiagnosis.ForeColor = Color.Black;
        }

        private void btnFullHistory_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnFullHistory_MouseEnter(object sender, EventArgs e)
        {
            btnFullHistory.ForeColor = Color.Blue;
        }

        private void btnFullHistory_MouseLeave(object sender, EventArgs e)
        {
            btnFullHistory.ForeColor = Color.Black;
        }



        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.Black;

        }



        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.ForeColor = Color.Blue;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.ForeColor = Color.Black;
        }

        private void comboBlood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                    if (!(txtDelete.Text == string.Empty))
                    {
                        string str = "data source = DESKTOP\\SQLEXPRESS;database = hospital;integrated security=True;";
                        SqlConnection con = new SqlConnection(str);
                        string query = "Delete from AddPatient where Pid= '" + this.txtDelete.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader myreader;
                        try
                        {
                            con.Open();
                            myreader = cmd.ExecuteReader();
                            MessageBox.Show("successfully data Deleted", "user information");
                            while (myreader.Read())
                            {
                            }
                            con.Close();
                        }
                        catch (Exception ec)
                        {
                            MessageBox.Show(ec.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("enter ID which you want to delete", "User information");
                    }
                }
            }

        }
    


        
  
