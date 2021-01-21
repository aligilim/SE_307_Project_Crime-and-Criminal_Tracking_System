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
    public partial class CriminalSearchScreen : Form
    {
        String connetionString = @"Data Source=DESKTOP-F486JAA\SQLEXPRESS;Initial Catalog=CrimeDB;Integrated Security=True";
        DataTable dt = new DataTable("Criminal");
        SqlDataAdapter adapt;
        public CriminalSearchScreen()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crimeDBDataSet1.Criminal' table. You can move, or remove it, as needed.
            this.criminalTableAdapter.Fill(this.crimeDBDataSet1.Criminal);
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(connetionString);

                SqlCommand myCommand = default(SqlCommand);
                myCommand = new SqlCommand("SELECT * FROM Criminal", myConnection);
                {
                    if (myConnection.State == ConnectionState.Closed)
                        myConnection.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Criminal", myConnection))
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
            adapt = new SqlDataAdapter("SELECT * FROM Criminal WHERE ID LIKE '" + searchTextBox.Text + "%' OR  Name LIKE '" + searchTextBox.Text + "%' OR Surname LIKE '" + searchTextBox.Text + "%' OR DateOfBirth LIKE '" + searchTextBox.Text + "%' OR Gender LIKE '" + searchTextBox.Text + "%' OR CrimeRecord LIKE '" + searchTextBox.Text + "%'", myConnection);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            myConnection.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var myForm = new UpdateCriminalInformationScreen(this);

            myForm.criminalIDBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myForm.criminalNameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            myForm.criminalSurnameBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            myForm.dateBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            myForm.genderBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            myForm.crimeRecordBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            SqlConnection myConnection = default(SqlConnection);
            myConnection = new SqlConnection(connetionString);
            SqlCommand myCommand = default(SqlCommand);
            myCommand = new SqlCommand("SELECT Photo FROM Criminal WHERE ID = " + myForm.criminalIDBox.Text, myConnection);

            myCommand.CommandType = CommandType.Text;
            if (myConnection.State == ConnectionState.Closed)
            {
                myConnection.Open();
            }
            SqlDataAdapter adp = new SqlDataAdapter(myCommand);
            DataSet ds = new DataSet();
            adp.Fill(ds, "tblWatchDog");
            try
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0][0] != System.DBNull.Value)
                    {
                        byte[] photo_aray = (byte[])ds.Tables[0].Rows[0][0];
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        Image img = (Image)converter.ConvertFrom(photo_aray);
                        myForm.pictureBox.Image = img;
                        myForm.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        myForm.pictureBox.Refresh();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Image cannot be retrieved! Try again.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
            }
                myForm.ShowDialog();

        }
    }
}
