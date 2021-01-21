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

namespace CrimeAndCriminalTrackingSystem
{
    public partial class LoginScreen : Form
    {
        String connetionString = @"Data Source=DESKTOP-F486JAA\SQLEXPRESS;Initial Catalog=CrimeDB;Integrated Security=True"; // This is the database connection string.
        String userName; // Username will be passed to MainScreen to print the current user.
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*'; // To hide password from user when typing.
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (usernameBox.Text == "")
            {
                MessageBox.Show("Please enter your username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameBox.Focus();
                return;
            }
            if (passwordBox.Text == "")
            {
                MessageBox.Show("Please enter your password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordBox.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection); // Create database connection.
                myConnection = new SqlConnection(connetionString); // Take connection string.

                SqlCommand myCommand = default(SqlCommand); // Create command for query.

                myCommand = new SqlCommand("SELECT Username, Password FROM Admin WHERE Username = @Username AND Password = @Password", myConnection); // Username and password match query.

                SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar); // Set SqLParameter for username.
                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);  // Set SqLParameter for passrord.

                uName.Value = usernameBox.Text; // Get username from the form.
                uPassword.Value = passwordBox.Text; // Get password from the form.

                myCommand.Parameters.Add(uName); // Add username to SQL command.
                myCommand.Parameters.Add(uPassword); // Add username to SQL command.

                myCommand.Connection.Open(); // Open SQL connection.

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection); // Create data reader.

                if (myReader.Read() == true)
                {
                    MessageBox.Show("Login sucessful!");
                    userName = usernameBox.Text;
                    var myForm = new MainScreen(userName);
                    myForm.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Login failed. Please try again!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    usernameBox.Clear();
                    passwordBox.Clear();
                    usernameBox.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
