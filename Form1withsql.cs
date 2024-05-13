using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalExam
{
    public partial class Form1withsql : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-97T8JVOG;Initial Catalog=Hospital;Integrated Security=True");
        public Form1withsql()
        {
            InitializeComponent();
        }

        private void PleaseRefreshMyPatient()
        {
            string query = "SELECT * FROM PatientTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "PatientTable");
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void DisplayPatientTable()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM PatientTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void PleaseRefreshMyDoctor()
        {
            string query = "SELECT * FROM DoctorTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "DoctorTable");
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void DisplayDoctorTable()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM DoctorTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PatientTable VALUES ('" + txtPatientID.Text + "','" + txtSecNum.Text + "','" + txtBalance.Text + "','" + txtDisSta.Text + "','" + txtFname.Text + "','" + txtLname.Text + "','" + txtDepCode.Text + "')";
                cmd.ExecuteNonQuery();
                DisplayPatientTable();
                MessageBox.Show("New Patient added to the table");
            }
            catch(Exception)
            {

            }
            conn.Close();
            DisplayPatientTable();

            //try
            //{
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand("sp_insert_patient", conn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("patientID", SqlDbType.VarChar).Value = txtPatientID.Text;
            //    cmd.Parameters.AddWithValue("sectionNumber", SqlDbType.VarChar).Value = txtSecNum.Text;
            //    cmd.Parameters.AddWithValue("balance", SqlDbType.Float).Value = Convert.ToDouble(txtBalance.Text);
            //    cmd.Parameters.AddWithValue("dischargeStatus", SqlDbType.VarChar).Value = txtDisSta.Text;
            //    cmd.Parameters.AddWithValue("firstname", SqlDbType.VarChar).Value = txtFname.Text;
            //    cmd.Parameters.AddWithValue("lastname", SqlDbType.VarChar).Value = txtLname.Text;
            //    cmd.Parameters.AddWithValue("Commission", SqlDbType.Int).Value = txtDepCode.Text;
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Artist has been added to the table");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("an exception happend!");

            //}
            //finally
            //{
            //    conn.Close();
            //    DisplayPatientTable();
            //}
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO DoctorTable VALUES ('" + txtDoctorID.Text + "','" + txtYOP.Text + "','" + txtShiftHours.Text + "','" + txtFDname.Text + "','" + txtLDname.Text + "','" + txtDDepCode.Text + "')";
                cmd.ExecuteNonQuery();
                DisplayPatientTable();
                MessageBox.Show("New Doctor added to the table");
            }
            catch(Exception)
            {
                
            }
            conn.Close();
            DisplayDoctorTable();
        }
    }
}
