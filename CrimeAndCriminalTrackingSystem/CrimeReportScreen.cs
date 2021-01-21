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
    public partial class CrimeReportScreen : Form
    {
        String connetionString = @"Data Source=DESKTOP-F486JAA\SQLEXPRESS;Initial Catalog=CrimeDB;Integrated Security=True"; // This is the database connection string.
        public CrimeReportScreen()
        {
            InitializeComponent();
            Random random = new Random(); // Generating a random case number.
            caseNoBox.Text = random.Next(100000).ToString(); // converts case number to string and displays on caseNoBox
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection); // Create database connection.
                myConnection = new SqlConnection(connetionString); // Take connection string.

                SqlCommand myCommand = default(SqlCommand); // Create command for query.

                myCommand = new SqlCommand("INSERT INTO Crime(ID, Date, ReportingOfficer, PreparedBy, CriminalName, Type, Details) VALUES(@ID, @Date, @ReportingOfficer, @PreparedBy, @CriminalName, @Type, @Details)", myConnection);

                SqlParameter caseNo = new SqlParameter("@ID", SqlDbType.Int);
                SqlParameter crimeDate = new SqlParameter("@Date", SqlDbType.Date);
                SqlParameter reportingOfficer = new SqlParameter("@ReportingOfficer", SqlDbType.VarChar);
                SqlParameter preparedBy = new SqlParameter("@PreparedBy", SqlDbType.VarChar);
                SqlParameter criminalName = new SqlParameter("@CriminalName", SqlDbType.VarChar);
                SqlParameter crimeType = new SqlParameter("@Type", SqlDbType.VarChar);
                SqlParameter details = new SqlParameter("@Details", SqlDbType.VarChar);

                caseNo.Value = caseNoBox.Text;
                crimeDate.Value = dateBox.Text;
                reportingOfficer.Value = reportingOfficerBox.Text;
                preparedBy.Value = preparedByBox.Text;
                criminalName.Value = criminalNameBox.Text;
                crimeType.Value = crimeTypeBox.Text;
                details.Value = detailsBox.Text;

                myCommand.Parameters.Add(caseNo);
                myCommand.Parameters.Add(crimeDate);
                myCommand.Parameters.Add(reportingOfficer);
                myCommand.Parameters.Add(preparedBy);
                myCommand.Parameters.Add(criminalName);
                myCommand.Parameters.Add(crimeType);
                myCommand.Parameters.Add(details);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (caseNoBox.Text != null && dateBox.Text != null && reportingOfficerBox.Text != null && preparedByBox.Text != null && criminalNameBox.Text != null && crimeTypeBox.Text != null && detailsBox.Text != null)
                {
                    MessageBox.Show("Report Saved!");
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Report could not be saved! Please do not leave empty fields.", "Saving Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    caseNoBox.Focus();

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
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
