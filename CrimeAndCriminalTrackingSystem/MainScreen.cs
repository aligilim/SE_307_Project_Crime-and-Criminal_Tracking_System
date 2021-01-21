using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeAndCriminalTrackingSystem
{
    public partial class MainScreen : Form
    {
        public MainScreen(String userName)
        {
            InitializeComponent();
            username.Text = userName; // Takes the username from LoginScreen and prints the current user to this screen.
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new CrimeReportScreen();
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new CrimeReportSearchScreen();
            myForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var myForm = new LoginScreen();
            MessageBox.Show("You have been logged out!");
            myForm.Show();
            this.Close();
        }

        private void addNewCriminalButton_Click(object sender, EventArgs e)
        {
            var myForm = new CriminalInformationScreen();
            myForm.Show();
        }

        private void searchCriminalButton_Click(object sender, EventArgs e)
        {
            var myForm = new CriminalSearchScreen();
            myForm.Show();

        }

        private void addNewPoliceButton_Click(object sender, EventArgs e)
        {
            var myForm = new PoliceInformationScreen();
            myForm.Show();
        }

        private void searchPoliceButton_Click(object sender, EventArgs e)
        {
            var myForm = new PoliceSearchScreen();
            myForm.Show();
        }
    }
}
