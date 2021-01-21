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
    public partial class PoliceSearchScreen : Form
    {
        String connetionString = @"Data Source=DESKTOP-F486JAA\SQLEXPRESS;Initial Catalog=CrimeDB;Integrated Security=True";
        DataTable dt = new DataTable("Police");
        SqlDataAdapter adapt;
        public PoliceSearchScreen()
        {
            InitializeComponent();
        }

        private void PoliceSearchScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crimeDBDataSet2.Police' table. You can move, or remove it, as needed.
            this.policeTableAdapter.Fill(this.crimeDBDataSet2.Police);

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection myConnection = default(SqlConnection);
            myConnection = new SqlConnection(connetionString);
            adapt = new SqlDataAdapter("SELECT * FROM Police WHERE ID LIKE '" + searchTextBox.Text + "%' OR  Name LIKE '" + searchTextBox.Text + "%' OR Surname LIKE '" + searchTextBox.Text + "%' OR Department LIKE '" + searchTextBox.Text + "%' OR Rank LIKE '" + searchTextBox.Text + "%' OR Phone LIKE '" + searchTextBox.Text + "%'", myConnection);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }
    }
}
