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
    public partial class Form1 : Form
    {
        public string account;
        public Form1(string account)
        {
            InitializeComponent();
            this.account = account;
            WelcomeLabel.Text = ($"Welcome {account}!");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        string pizzas = "";

        int pizza_count = 0;

        Decimal subtotal = 0;


        private void get_pizza(string my_pizza)

        {
            if (pizza_count >= 20)
            {
                MessageBox.Show("You have selected a maximum of 20 pizzas!");
                return;
            }
            
           
            pizzas += (my_pizza + ", ");
            pizza_count++; 

            using (SqlConnection conn = new SqlConnection())
            {                
                conn.ConnectionString = $@"Data Source={Environment.MachineName}\SQLEXPRESS;Database=pizzas;Trusted_Connection=true";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM tbl_pizzas where pizza_type = @0", conn);
                command.Parameters.Add(new SqlParameter("0", my_pizza));
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SelectedPizzas.Items.Add(string.Format("Type: {0}, Cost: {1,2:C}", reader[1], reader[3]));
                        subtotal += (Decimal)reader[3];
                        OrderTotal.Text = subtotal.ToString("c");
                    }

                }
                conn.Close();
                conn.Dispose();
                
            }
        }


        private void checkout()
        {
            using (SqlConnection conn = new SqlConnection())
            {


                conn.ConnectionString = $@"Data Source={Environment.MachineName}\SQLEXPRESS;Database=pizzas;Trusted_Connection=true";
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM accounts WHERE account_name=@accountName", conn);
                command.Parameters.Add(new SqlParameter("accountName", this.account));


                string FirstName = "";
                string LastName = "";
                string Address = "";
                string Phone = "";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    FirstName = reader.GetString(4);
                    LastName = reader.GetString(5);
                    Address = reader.GetString(6);
                    Phone = reader.GetString(7);
                }

                // These need to be in the order of the columns in your db
                // if your columns go, id, name, address, phone number then put the same names below
                // if they go id, address, name, phone number, then do that
                //                                                                    These bits here
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO customers_orders(Name, Address, Number, PizzasSelected, Total) VALUES (@Name, @Address, @Number,@PizzasSelected,@Total)", conn);
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

                string pizza_list = string.Join(", ", pizzas);

                da.SelectCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar)).Value = ($"{FirstName} {LastName}");
                da.SelectCommand.Parameters.Add(new SqlParameter("@Address", SqlDbType.NVarChar)).Value = ($"{Address}");
                da.SelectCommand.Parameters.Add(new SqlParameter("@Number", SqlDbType.NVarChar)).Value = ($"{Phone}");
                da.SelectCommand.Parameters.Add(new SqlParameter("@PizzasSelected", SqlDbType.NVarChar)).Value = ($"{pizza_list}");
                da.SelectCommand.Parameters.Add(new SqlParameter("@Total", SqlDbType.NVarChar)).Value = ($"{OrderTotal.Text}");
                da.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("Your Order has been placed!");
            }
        }

        #region Pizza Buttons

        private void Cheese_Click(object sender, EventArgs e)
        {
            get_pizza(Cheese.Text);
        }

        private void BBQ_Click(object sender, EventArgs e)
        {
            get_pizza(BBQ.Text);
        }

        private void Meat_Click(object sender, EventArgs e)
        {
            get_pizza(Meat.Text);

        }

        private void Piri_Click(object sender, EventArgs e)
        {
            get_pizza(Piri.Text);

        }

        private void Hawaii_Click(object sender, EventArgs e)
        {
            get_pizza(Hawaii.Text);

        }

        private void Mediteranian_Click(object sender, EventArgs e)
        {
            get_pizza(Mediteranian.Text);

        }

        private void Mexican_Click(object sender, EventArgs e)
        {
            get_pizza(Mexican.Text);

        }

        private void TheWorks_Click(object sender, EventArgs e)
        {
            get_pizza(TheWorks.Text);

        }
        private void Checkout_Click(object sender, EventArgs e)
        {
            checkout();
            SelectedPizzas.Items.Clear();
            subtotal = 0;
            pizza_count = 0;
            OrderTotal.Text = subtotal.ToString("c");
        }

        private void NewOrder_Click(object sender, EventArgs e)
        {
            SelectedPizzas.Items.Clear();
            subtotal = 0;
            OrderTotal.Text = subtotal.ToString("c");
            pizza_count = 0;
        }

        #endregion

        #region Labels
        
        private void OrderTotal_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region List Boxes
        private void SelectedPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        
    }
}
