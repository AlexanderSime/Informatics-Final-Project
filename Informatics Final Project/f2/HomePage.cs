using static f2.Authenticator;
using static f2.ImageUploader;
using f2;

namespace f2
{
    public partial class HomePage : Form
    {
        private User authenticatedUser;

        public HomePage(User user)
        {
            InitializeComponent();
            authenticatedUser = user;

            welcomeLabel.Text = $"Welcome, {authenticatedUser.Username}!";
            genderLabel.Text = $"{authenticatedUser.Gender}";
            phoneNumberLabel.Text = $"{authenticatedUser.PhoneNumber}";
            emailLabel.Text = $"{authenticatedUser.Email}";
            bdayLabel.Text = $"{authenticatedUser.Bday}";
            

            if (authenticatedUser.Image != null && authenticatedUser.Image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(authenticatedUser.Image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void uploadBtn_Click(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;
                    Image selectedImage = Image.FromFile(selectedImagePath);

                    byte[] imageData = ImageToByteArray(selectedImage);

                    UploadImage(authenticatedUser.Username, imageData);

                    pictureBox1.Image = selectedImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
