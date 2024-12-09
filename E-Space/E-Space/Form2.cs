using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Space
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of Form4
                Form5 form5 = new Form5();

                // Clear the panel2 control (assuming it's a Panel) and add Form4 to it
                panel2.Controls.Clear();
                form5.TopLevel = false;
                form5.FormBorderStyle = FormBorderStyle.None;
                form5.Dock = DockStyle.Fill;
                panel2.Controls.Add(form5);
                form5.BringToFront();
                form5.Show();

                // Optionally, clear any text fields or controls

            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., show an error message
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

                // Create an instance of Form4
                Form3 form3 = new Form3();

                // Clear the panel2 control (assuming it's a Panel) and add Form4 to it
                panel2.Controls.Clear();
                form3.TopLevel = false;
                form3.FormBorderStyle = FormBorderStyle.None;
                form3.Dock = DockStyle.Fill;
                panel2.Controls.Add(form3);
                form3.BringToFront();
                form3.Show();

                // Optionally, clear any text fields or controls

            }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of Form7
                Form7 form7 = new Form7();

                // Clear any existing controls in Panel2
                panel2.Controls.Clear();

                // Add the Form7 instance to Panel2
                form7.TopLevel = false; // Important to make Form7 behave like a user control
                form7.FormBorderStyle = FormBorderStyle.None; // Optional: remove form borders
                form7.Dock = DockStyle.Fill; // Fill the panel with Form7
                panel2.Controls.Add(form7);

                // Show the form
                form7.Show();
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of Form4
                Form6 form6 = new Form6();

                // Clear the panel2 control (assuming it's a Panel) and add Form4 to it
                panel2.Controls.Clear();
                form6.TopLevel = false;
                form6.FormBorderStyle = FormBorderStyle.None;
                form6.Dock = DockStyle.Fill;
                panel2.Controls.Add(form6);
                form6.BringToFront();
                form6.Show();

                // Optionally, clear any text fields or controls

            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., show an error message
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of Form4
                Form4 form4 = new Form4();

                // Clear the panel2 control (assuming it's a Panel) and add Form4 to it
                panel2.Controls.Clear();
                form4.TopLevel = false;
                form4.FormBorderStyle = FormBorderStyle.None;
                form4.Dock = DockStyle.Fill;
                panel2.Controls.Add(form4);
                form4.BringToFront();
                form4.Show();

                // Optionally, clear any text fields or controls
              
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., show an error message
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of Form8
                Form8 form8 = new Form8();

                // Check if Panel2 already contains a control, and remove it if necessary
                if (panel2.Controls.Count > 0)
                {
                    panel2.Controls.Clear();
                }

                // Set the Form8 instance as a control on Panel2
                form8.TopLevel = false;
                form8.FormBorderStyle = FormBorderStyle.None;
                form8.Dock = DockStyle.Fill;
                panel2.Controls.Add(form8);
                form8.Show();

                // Code to clear content or reset settings if needed
                // For example, clearing text boxes, resetting values, etc.
                // textBox1.Clear();
                // otherControls.Reset();

            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of Form8
                Form9 form9 = new Form9();

                // Check if Panel2 already contains a control, and remove it if necessary
                if (panel2.Controls.Count > 0)
                {
                    panel2.Controls.Clear();
                }

                // Set the Form8 instance as a control on Panel2
                form9.TopLevel = false;
                form9.FormBorderStyle = FormBorderStyle.None;
                form9.Dock = DockStyle.Fill;
                panel2.Controls.Add(form9);
                form9.Show();

                // Code to clear content or reset settings if needed
                // For example, clearing text boxes, resetting values, etc.
                // textBox1.Clear();
                // otherControls.Reset();

            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
