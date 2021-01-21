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
    public partial class CrimeReportSearchScreen : Form
    {
        String connetionString = @"Data Source=DESKTOP-F486JAA\SQLEXPRESS;Initial Catalog=CrimeDB;Integrated Security=True";
        DataTable dt = new DataTable("Crime");
        SqlDataAdapter adapt;
        public CrimeReportSearchScreen()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crimeDBDataSet.Crime' table. You can move, or remove it, as needed.
            this.crimeTableAdapter.Fill(this.crimeDBDataSet.Crime);
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(connetionString);

                SqlCommand myCommand = default(SqlCommand);
                myCommand = new SqlCommand("SELECT * FROM Crime", myConnection);
                {
                    if (myConnection.State == ConnectionState.Closed)
                        myConnection.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Crime", myConnection))
                    {
                        //Fill data to datatable
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection myConnection = default(SqlConnection);
            myConnection = new SqlConnection(connetionString);
            adapt = new SqlDataAdapter("SELECT * FROM Crime WHERE ID LIKE '" + searchTextBox.Text + "%' OR Date LIKE '" + searchTextBox.Text + "%' OR ReportingOfficer LIKE '" + searchTextBox.Text + "%' OR  PreparedBy LIKE '" + searchTextBox.Text + "%' OR CriminalName LIKE '" + searchTextBox.Text + "%' OR Type LIKE '" + searchTextBox.Text + "%'", myConnection);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var myForm = new UpdateCrimeReportScreen(this);

            myForm.caseNoBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myForm.dateBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            myForm.reportingOfficerBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            myForm.preparedByBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            myForm.criminalNameBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            myForm.crimeTypeBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            myForm.detailsBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            myForm.ShowDialog();
        }
    }
}
