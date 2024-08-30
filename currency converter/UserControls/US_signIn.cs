using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace currency_converter.UserControls
{
    public partial class US_signIn : UserControl
    {
        public US_signIn()
        {
            InitializeComponent();




            // Customizing the back button
            CustomizeBackButton(button1GoingBackToHome);

            // Attach the click event handler to the "Sign In" button
            button1GoingBackToHome.Click += Button1GoingBackToHome_Click;

            // If button is clicked go to Login Page
            buttonSignIn.Click += ButtonSignIn_Click;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            Login_Page UC = new Login_Page();
            addUserControl( UC );
        }

        private void Button1GoingBackToHome_Click(object sender, EventArgs e)
        {
            //show panel in Form1
            if (this.Parent is Form1 form1)
            {
                form1.ShowPanel(true);
            }

            // Back To Form1(Original Page)
            this.Parent.Controls.Remove(this);
        }

        private void addUserControl(UserControl userControl)
        {
            if (this.Parent is Form1 form1)
            {
                form1.Controls.Add(userControl);
                userControl.Dock = DockStyle.Fill;
                userControl.BringToFront();
            }
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

        private void button1GoingBackToHome_Click_1(object sender, EventArgs e)
        {

        }

        private void label1RegForm_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxPassword.Text == "" || textBoxConfirmPass.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Registration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPassword.Text == textBoxConfirmPass.Text)
            {
                try
                {
                    con.Open();
                    // Correctly format the SQL INSERT statement, using square brackets for field names
                    string register = "INSERT INTO table_users ([FirstName], [LastName], [Email], [Password]) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(register, con))
                    {
                        // Use parameters to avoid SQL injection and syntax errors
                        cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                        cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                        cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);

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
            else
            {
                MessageBox.Show("Passwords do not match, please re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxConfirmPass.Text = "";
                textBoxPassword.Focus();
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

        private void checkBoxTandCs_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxConfirmPass.Text = "";
            textBoxEmail.Text = "";
            textBoxFirstName.Focus();
        }
    }
}
