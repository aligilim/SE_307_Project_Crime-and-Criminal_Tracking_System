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
    public partial class CriminalInformationScreen : Form
    {
        String connetionString = @"Data Source=DESKTOP-F486JAA\SQLEXPRESS;Initial Catalog=CrimeDB;Integrated Security=True";
        public CriminalInformationScreen()
        {
            InitializeComponent();
            Random random = new Random();
            criminalIDBox.Text = random.Next(100000).ToString();
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

                myCommand = new SqlCommand("INSERT INTO Criminal(ID, Name, Surname, DateOfBirth, Gender, CrimeRecord, Photo) VALUES(@ID, @Name, @Surname, @DateOfBirth, @Gender, @CrimeRecord, @Photo)", myConnection);

                SqlParameter criminalID = new SqlParameter("@ID", SqlDbType.Int);
                SqlParameter criminalName = new SqlParameter("@Name", SqlDbType.VarChar);
                SqlParameter criminalSurname = new SqlParameter("@Surname", SqlDbType.VarChar);
                SqlParameter dateOfBirth = new SqlParameter("@DateOfBirth", SqlDbType.Date);
                SqlParameter gender = new SqlParameter("@Gender", SqlDbType.VarChar);
                SqlParameter crimeRecord = new SqlParameter("@CrimeRecord", SqlDbType.VarChar);
                SqlParameter photo = new SqlParameter("@Photo", SqlDbType.Image);

                criminalID.Value = criminalIDBox.Text;
                criminalName.Value = criminalNameBox.Text;
                criminalSurname.Value = criminalSurnameBox.Text;
                dateOfBirth.Value = dateBox.Text;
                gender.Value = genderBox.Text;
                crimeRecord.Value = crimeRecordBox.Text;


                MemoryStream stream = new MemoryStream(); // Create a MemoryStream for image upload.
                pictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg); // Save the image to byte in the object stream.
                byte[] picture = stream.ToArray(); // Transfer the bytes of the array yo the picture as byte array.
                photo.Value = picture;

                myCommand.Parameters.Add(criminalID);
                myCommand.Parameters.Add(criminalName);
                myCommand.Parameters.Add(criminalSurname);
                myCommand.Parameters.Add(dateOfBirth);
                myCommand.Parameters.Add(gender);
                myCommand.Parameters.Add(crimeRecord);
                myCommand.Parameters.Add(photo);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (criminalIDBox.Text != null && criminalNameBox.Text != null && criminalSurnameBox.Text != null && dateBox.Text != null && genderBox.Text != null && crimeRecordBox.Text != null && pictureBox.Text != null)
                {
                    MessageBox.Show("Criminal Information Saved!");
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Information could not be saved! Please do not leave empty fields.", "Saving Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    criminalIDBox.Focus();

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
