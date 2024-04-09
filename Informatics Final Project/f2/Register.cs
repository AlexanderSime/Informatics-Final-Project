using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace f2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void usBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (usBox.Text == "Username")
            {
                usBox.Text = "";
                usBox.ForeColor = Color.Black;
            }
        }

        private void passBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (passBox.Text == "Password")
            {
                passBox.Text = "";
                passBox.ForeColor = Color.Black;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            bool temp2 = true;

            if (usBox.Text.Length < 5)
            {
                MessageBox.Show("Username should be at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                temp2 = false;
            }
            if (!(passBox.Text.Length > 8 && passBox.Text.Any(char.IsUpper) && passBox.Text.Any(char.IsLower) && passBox.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("Password must have an UPPERCASE CHARACTER, a LOWERCASE CHARACTER, a NUMBER and LENGTH of at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                temp2 = false;
            }
            if (!IsValidEmail(emailBox.Text))
            {
                MessageBox.Show("Email not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                temp2 = false;
            }
            if (!isValidPhoneNumber(phoneBox.Text))
            {
                MessageBox.Show("Phone number not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                temp2 = false;
            }

            if (temp2)
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=YAPMedia; Integrated Security=True;"))
                {
                    cn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT username FROM [User] WHERE username = @username", cn))
                    {
                        cmd.Parameters.AddWithValue("@username", usBox.Text);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                MessageBox.Show("Username already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                dr.Close();

                                using (SqlCommand cmd2 = new SqlCommand("INSERT INTO [User] (username, password, phoneNumber, email, firstName, lastName, gender, img) VALUES (@username, @password, @phoneNumber, @email, @firstName, @lastName, @gender, NULLIF(CONVERT(varbinary(max), @img), ''))", cn))
                                {
                                    cmd2.Parameters.AddWithValue("@username", usBox.Text);
                                    cmd2.Parameters.AddWithValue("@password", passBox.Text);
                                    cmd2.Parameters.AddWithValue("@phoneNumber", phoneBox.Text);
                                    cmd2.Parameters.AddWithValue("@email", emailBox.Text);
                                    cmd2.Parameters.AddWithValue("@firstName", firstNameBox.Text);
                                    cmd2.Parameters.AddWithValue("@lastName", lastNameBox.Text);
                                    cmd2.Parameters.AddWithValue("@gender", genderBox.Text);
                                    cmd2.Parameters.AddWithValue("@img", "");

                                    cmd2.ExecuteNonQuery();

                                    MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Hide();
                                    LogIn login = new LogIn();
                                    login.Show();
                                }
                            }
                        }
                    }
                    cn.Close();
                }



            }

        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            passCritL.Show();
            sizeL.Show();
            upperL.Show();
            lowerL.Show();
            numL.Show();

            if (passBox.Text.Length > 8)
                sizeL.ForeColor = Color.Green;
            else
                sizeL.ForeColor = Color.Red;

            if (passBox.Text.Any(char.IsUpper))
                upperL.ForeColor = Color.Green;
            else
                upperL.ForeColor = Color.Red;

            if (passBox.Text.Any(char.IsLower))
                lowerL.ForeColor = Color.Green;
            else
                lowerL.ForeColor = Color.Red;

            if (passBox.Text.Any(char.IsDigit))
                numL.ForeColor = Color.Green;
            else
                numL.ForeColor = Color.Red;
        }

        private void emailBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (emailBox.Text == "Email")
            {
                emailBox.Text = "";
                emailBox.ForeColor = Color.Black;
            }
        }

        private void emailBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (emailBox.Text == string.Empty)
            {
                emailBox.Text = "Email";
                emailBox.ForeColor = Color.Gray;
            }
        }
        private static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        private void passBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (passBox.Text == string.Empty)
            {
                passBox.Text = "Password";
                passBox.ForeColor = Color.Gray;
            }

            passCritL.Hide();
            sizeL.Hide();
            upperL.Hide();
            lowerL.Hide();
            numL.Hide();
        }

        private void usBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (usBox.Text == string.Empty)
            {
                usBox.Text = "Username";
                usBox.ForeColor = Color.Gray;
            }
        }

        private void birthBox_DropDown(object sender, EventArgs e)
        {
            MessageBox.Show("Select your birthday date.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (genderBox.Text == "Male" || genderBox.Text == "Female")
            {
                genderBox.ForeColor = Color.Black;
            }
            else
            {
                genderBox.ForeColor = Color.Gray;
            }
        }

        private void phoneBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (phoneBox.Text == string.Empty)
            {
                phoneBox.Text = "Phone number";
                phoneBox.ForeColor = Color.Gray;
            }
        }

        private void phoneBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (phoneBox.Text == "Phone number")
            {
                phoneBox.Text = "";
                phoneBox.ForeColor = Color.Black;
            }
        }

        private bool isValidPhoneNumber(string phoneNumber)
        {
            string phoneNumberPattern = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";

            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            Regex regex = new Regex(phoneNumberPattern);
            return regex.IsMatch(phoneNumber);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

    }


}