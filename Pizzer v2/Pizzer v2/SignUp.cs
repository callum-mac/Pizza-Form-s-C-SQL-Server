using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Windows.Forms;

namespace Pizzer_v2
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }


        #region Labels
        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void NumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {

        }




        #endregion

        #region Boxes

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }



        #endregion

        #region Buttons

        private void SubmitButton_Click(object sender, EventArgs e)
        {


            string account = ($"{UsernameBox.Text}");
            bool account_exist = false;

            bool execute = false;
            
            // if the NumberBox has anything but integers, it will display an error message
            BigInteger i;
            if (!BigInteger.TryParse(NumberBox.Text, out i))
            {
                MessageBox.Show("This is a number only field", "Please Enter a Phone Number: ", MessageBoxButtons.OK);
                execute = false;
            }                        
            else if (String.IsNullOrEmpty(FirstNameBox.Text))
            {
                MessageBox.Show("Please Enter a First Name!", "Please Enter a First Name: ", MessageBoxButtons.OK);
                execute = false;
            }            
            else if (NumberBox.TextLength != 11)
            {
                MessageBox.Show("That is not a valid phone number.\nPlease Try Again!", "Please Enter a Phone Number: ", MessageBoxButtons.OK);
                execute = false;
            }
            else if(String.IsNullOrEmpty(LastNameBox.Text))
            {
                MessageBox.Show("Please Enter a Last Name!", "Please Enter a Last Name: ", MessageBoxButtons.OK);
                execute = false;
            }
            else if (String.IsNullOrEmpty(AddressBox.Text))
            {
                MessageBox.Show("Please Enter an Address!", "Please Enter a Phone Number: ", MessageBoxButtons.OK);
                execute = false;
            }
            else if (String.IsNullOrEmpty(NumberBox.Text))
            {
                MessageBox.Show("Please Enter a Phone Number!", "Please Enter a Phone Number: ", MessageBoxButtons.OK);
                execute = false;
            }
            else if (String.IsNullOrEmpty(UsernameBox.Text))
            {
                MessageBox.Show("Please Enter a Username!", "Please Enter a Username: ", MessageBoxButtons.OK);
                execute = false;
            }
            else if (String.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Please Enter a Password!", "Please Enter a Password: ", MessageBoxButtons.OK);
                execute = false;
            }
            else
            {
                execute = true;
            }

            if (execute == true)
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = $@"Data Source={Environment.MachineName}\SQLEXPRESS;Database=pizzas;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM accounts WHERE account_name=@accountName", conn);
                    command.Parameters.AddWithValue("@accountName", account);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            account_exist = true;
                            MessageBox.Show("That Username is already in use!\nPlease select another Username!");
                        }
                    }

                    if (account_exist == false)
                    {

                        // Get password from register field
                        string password = this.PasswordBox.Text;

                        SqlCommand sqlCommand = new SqlCommand("INSERT INTO accounts VALUES (@account_name, @account_password, @salt, @first_name, @last_name, @address, @number)", conn);
                        SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

                        // Generate a salt for this user, you will need to
                        // store this in the database
                        string salt = SecurityHelper.GenerateSalt(100);
                        // Generate the hashed password using the salt.
                        // 1000 and 100 are the iterations that 
                        string hash = SecurityHelper.HashPassword(password, salt, 1000, 100);

                        // Store the hashed password and salt in the database



                        da.SelectCommand.Parameters.Add(new SqlParameter("@account_name", SqlDbType.NVarChar)).Value = ($"{UsernameBox.Text}");
                        da.SelectCommand.Parameters.Add(new SqlParameter("@account_password", SqlDbType.NVarChar)).Value = ($"{hash}");
                        da.SelectCommand.Parameters.Add(new SqlParameter("@salt", SqlDbType.NVarChar)).Value = ($"{salt}");
                        da.SelectCommand.Parameters.Add(new SqlParameter("@first_name", SqlDbType.NVarChar)).Value = ($"{FirstNameBox.Text}");
                        da.SelectCommand.Parameters.Add(new SqlParameter("@last_name", SqlDbType.NVarChar)).Value = ($"{LastNameBox.Text}");
                        da.SelectCommand.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar)).Value = ($"{AddressBox.Text}");
                        da.SelectCommand.Parameters.Add(new SqlParameter("@number", SqlDbType.NVarChar)).Value = ($"{NumberBox.Text}");
                        da.SelectCommand.ExecuteNonQuery();


                        MessageBox.Show("Account Created!");
                        this.Hide();
                        new LoginForm().Show();
                    }

                    conn.Close();
                    conn.Dispose();
                }
            }

        }
        #endregion 
    }
}
