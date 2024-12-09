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

namespace E_Space
{
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Nirosh;Initial Catalog=E_Space;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public Form5()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Dependent", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox11.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Dependent (Dependent_ID, Name, Relationship, Gender, Date_of_Birth) VALUES (@Dependent_ID, @Name, @Relationship, @Gender, @Date_of_Birth)", con);
                cmd.Parameters.AddWithValue("@Dependent_ID", textBox2.Text);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Relationship", textBox3.Text);
                cmd.Parameters.AddWithValue("@Gender", textBox11.Text);
                cmd.Parameters.AddWithValue("@Date_of_Birth", dateTimePicker1.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted successfully.");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox11.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Please enter the Dependent_ID.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Dependent SET Name = @Name, Relationship = @Relationship, Gender = @Gender, Date_of_Birth = @Date_of_Birth WHERE Dependent_ID = @Dependent_ID", con);
                cmd.Parameters.AddWithValue("@Dependent_ID", textBox2.Text);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Relationship", textBox3.Text);
                cmd.Parameters.AddWithValue("@Gender", textBox11.Text);
                cmd.Parameters.AddWithValue("@Date_of_Birth", dateTimePicker1.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully.");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Please enter the Dependent_ID.");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Dependent WHERE Dependent_ID = @Dependent_ID", con);
                cmd.Parameters.AddWithValue("@Dependent_ID", textBox2.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully.");
                LoadData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_SPACEDataSet1.Dependent' table. You can move, or remove it, as needed.
            this.dependentTableAdapter.Fill(this.e_SPACEDataSet1.Dependent);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 DB = new Form2();
            DB.Hide();
            this.Show();
        }
    }
}
