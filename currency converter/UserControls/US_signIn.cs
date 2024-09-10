using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace currency_converter.UserControls
{
    public partial class US_signIn : UserControl
    {
        private Form1 _parentForm;

        public US_signIn(Form1 parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm;

            // Customizing the back button
            CustomizeBackButton(button1GoingBackToHome);

            // Attach the click event handler to the "Sign In" button
            button1GoingBackToHome.Click += Button1GoingBackToHome_Click;

            // If button is clicked, go to Login Page
            buttonSignIn.Click += ButtonSignIn_Click;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            // Pass the reference to Form1 when creating the Login_Page user control
            Login_Page UC = new Login_Page(_parentForm);
            addUserControl(UC);
        }

        private void Button1GoingBackToHome_Click(object sender, EventArgs e)
        {
            // Show panel in Form1
            _parentForm.ShowPanel(true);

            // Back To Form1 (Original Page)
            this.Parent.Controls.Remove(this);
        }

        private void addUserControl(UserControl userControl)
        {
            _parentForm.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }

        private void CustomizeBackButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.Transparent;
            button.FlatAppearance.BorderSize = 0; // Remove the border

            // Ensure the button size is appropriate for the image
            int buttonSize = 25;
            button.Size = new Size(buttonSize, buttonSize);
        }

        // Other event handlers...

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Check if the "Agree to Terms" checkbox is checked
            if (!checkBoxTandCs.Checked)
            {
                MessageBox.Show("Please agree to the Terms of Use and Privacy Policy.", "Registration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution if terms are not agreed
            }

            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxConfirmPass.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Please fill in all fields", "Registration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution if any field is empty
            }

            // Check if passwords match
            if (textBoxPassword.Text != textBoxConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match, please re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxConfirmPass.Text = "";
                textBoxPassword.Focus();
                return; // Stop further execution if passwords do not match
            }

            // All checks passed, proceed with registration
            try
            {
                con.Open();

                // SQL INSERT statement with parameters
                string register = "INSERT INTO table_users ([FirstName], [LastName], [Email], [Password]) VALUES (?, ?, ?, ?)";
                using (OleDbCommand cmd = new OleDbCommand(register, con))
                {
                    // Use parameters to avoid SQL injection and syntax errors
                    cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Your account has been successfully created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the text boxes after successful registration
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxPassword.Text = "";
                textBoxConfirmPass.Text = "";
                textBoxEmail.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPass.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxConfirmPass.PasswordChar = '•';
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxConfirmPass.Text = "";
            textBoxEmail.Text = "";
            textBoxFirstName.Focus();
        }

        private void checkBoxTandCs_CheckedChanged(object sender, EventArgs e)
        {
          
            

        }
    }
}
