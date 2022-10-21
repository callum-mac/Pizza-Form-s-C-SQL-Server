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

namespace Pizzer_v2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        public static string FirstName;
        public static string LastName;
        public static string Address;
        public static string Phone;
        public static string account;


        private void check_login()
        {
            


            string account = $"{UsernameBox.Text}";
            string password = $"{PasswordBox.Text}";
            


            

            bool account_exist = false;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = $@"Data Source={Environment.MachineName}\SQLEXPRESS;Database=pizzas;Trusted_Connection=true";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM accounts WHERE account_name=@accountName", conn);
                command.Parameters.AddWithValue("@accountName", account);
                command.Parameters.AddWithValue("@accountPass", password);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        account_exist = true;
                        string database_password = reader.GetString(2);
                        string salt = reader.GetString(3);
                        bool isvalidpassword = SecurityHelper.CheckPassword(database_password,password,salt,1000,100);
                        if (isvalidpassword)
                        {
                            this.Hide();
                            new Form1(account).Show();
                        } 
                        else
                        {
                            MessageBox.Show("That password is incorrect! Please try again!");
                        }
                    }
                    if (account_exist == false)
                    {
                        MessageBox.Show("That Account doesn't exist! Click the Sign Up button below to create an account");
                    }
                                        
                }
                conn.Close();
                conn.Dispose();

            }
        }


        #region Labels
        private void ErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }
        
        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Boxes

        

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Buttons

        private void LoginButton_Click(object sender, EventArgs e)
        {
            check_login();

            //Form1 objectData = new Form1();// create a object for parent form.  
            //FirstName = FirstNameBox.Text;//assign the data to the public  static variable.  
            //LastName = LastNameBox.Text;//assign the data to the public  static variable.  
            //Address = AddressBox.Text;//assign the data to the public  static variable.  
            //Phone = PhoneBox.Text;//assign the data to the public  static variable. 
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpForm().Show();
        }





        #endregion

        
    }
}
