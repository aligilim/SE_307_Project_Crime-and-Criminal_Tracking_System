using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrimeAndCriminalTrackingSystem
{
    public partial class PoliceInformationScreen : Form
    {
        String connetionString = @"Data Source=DESKTOP-F486JAA\SQLEXPRESS;Initial Catalog=CrimeDB;Integrated Security=True";
        public PoliceInformationScreen()
        {
            InitializeComponent();
            Random random = new Random();
            policeIDBox.Text = random.Next(100000).ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(connetionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("INSERT INTO Police(ID, Name, Surname, Department, Rank, Phone, Photo) VALUES(@ID, @Name, @Surname, @Department, @Rank, @Phone, @Photo)", myConnection);

                SqlParameter badgeNo = new SqlParameter("@ID", SqlDbType.Int);
                SqlParameter policeName = new SqlParameter("@Name", SqlDbType.VarChar);
                SqlParameter policeSurname = new SqlParameter("@Surname", SqlDbType.VarChar);
                SqlParameter department = new SqlParameter("@Department", SqlDbType.VarChar);
                SqlParameter rank = new SqlParameter("@Rank", SqlDbType.VarChar);
                SqlParameter phone = new SqlParameter("@Phone", SqlDbType.VarChar);
                SqlParameter photo = new SqlParameter("@Photo", SqlDbType.Image);

                badgeNo.Value = policeIDBox.Text;
                policeName.Value = policeNameBox.Text;
                policeSurname.Value = policeSurnameBox.Text;
                department.Value = departmentBox.Text;
                rank.Value = rankBox.Text;
                phone.Value = phoneBox.Text;

                MemoryStream stream = new MemoryStream();
                //through the instruction below, we save the
                //image to byte in the object "stream".
                pictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

                //Below is the most important part, actually you are
                //transferring the bytes of the array
                //to the pic which is also of kind byte[]
                byte[] picture = stream.ToArray();

                photo.Value = picture;

                myCommand.Parameters.Add(badgeNo);
                myCommand.Parameters.Add(policeName);
                myCommand.Parameters.Add(policeSurname);
                myCommand.Parameters.Add(department);
                myCommand.Parameters.Add(rank);
                myCommand.Parameters.Add(phone);
                myCommand.Parameters.Add(photo);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (policeIDBox.Text != null && policeNameBox.Text != null && policeSurnameBox.Text != null && departmentBox.Text != null && rankBox.Text != null && phoneBox.Text != null && pictureBox.Image != null)
                {
                    MessageBox.Show("Police Information Saved!");
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Police information could not be saved! Please do not leave empty fields.", "Saving Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    policeIDBox.Focus();

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

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
