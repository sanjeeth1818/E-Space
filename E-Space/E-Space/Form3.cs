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

namespace E_Space
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Nirosh;Initial Catalog=E_Space;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SPACEDataSet2.Colonist' table. You can move, or remove it, as needed.
            this.colonistTableAdapter.Fill(this.e_SPACEDataSet2.Colonist);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Colonist (Colonist_ID, First_Name, Middle_Name, Sure_Name, Date_of_Birth, Age, Contact_No, Gender, Qualification, Family_Members, Earth_Address, Civil_Status) VALUES (@Colonist_ID, @FirstName, @MiddleName, @SureName, @DateOfBirth, @Age, @ContactNo, @Gender, @Qualification, @FamilyMembers, @EarthAddress, @CivilStatus)", con))
                {
                    cmd.Parameters.AddWithValue("@Colonist_ID", textBox2.Text);
                    cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@SureName", textBox4.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Age", textBox6.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Gender", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Qualification", textBox9.Text);
                    cmd.Parameters.AddWithValue("@FamilyMembers", textBox10.Text);
                    cmd.Parameters.AddWithValue("@EarthAddress", textBox11.Text);
                    cmd.Parameters.AddWithValue("@CivilStatus", comboBox1.SelectedItem.ToString());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record inserted successfully.");
                    ClearFields();
                    RefreshDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            comboBox1.SelectedIndex = -1;  // Clear combo box selection
            dateTimePicker1.Value = DateTime.Now;  // Reset datetime picker to current date
        }

        private void RefreshDataGridView()
        {
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Colonist", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Colonist SET First_Name=@FirstName, Middle_Name=@MiddleName, Sure_Name=@SureName, Date_of_Birth=@DateOfBirth, Age=@Age, Contact_No=@ContactNo, Gender=@Gender, Qualification=@Qualification, Family_Members=@FamilyMembers, Earth_Address=@EarthAddress, Civil_Status=@CivilStatus WHERE Colonist_ID=@ColonistID", con))
                {
                    cmd.Parameters.AddWithValue("@ColonistID", textBox2.Text);
                    cmd.Parameters.AddWithValue("@FirstName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@SureName", textBox4.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Age", textBox6.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Gender", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Qualification", textBox9.Text);
                    cmd.Parameters.AddWithValue("@FamilyMembers", textBox10.Text);
                    cmd.Parameters.AddWithValue("@EarthAddress", textBox11.Text);
                    cmd.Parameters.AddWithValue("@CivilStatus", comboBox1.SelectedItem.ToString());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record updated successfully.");
                    ClearFields();
                    RefreshDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Colonist WHERE Colonist_ID=@ColonistID", con))
                {
                    cmd.Parameters.AddWithValue("@ColonistID", textBox2.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Record deleted successfully.");
                    ClearFields();
                    RefreshDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 DB = new Form2();
            DB.Hide();
            this.Show();
        }
    }
}
