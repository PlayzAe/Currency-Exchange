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
    public partial class Login_Page : UserControl
    {
        private Form1 _parentForm; // Store a reference to Form1

        public Login_Page(Form1 parentForm)
        {
            InitializeComponent();

            _parentForm = parentForm; // Store the reference to Form1
            CustomizeBackButton(buttonForLogin);

            buttonForLogin.Click += Button1_Click;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void CustomizeBackButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.Transparent;
            button.FlatAppearance.BorderSize = 0; // Remove the border

            int buttonSize = 25;
            button.Size = new Size(buttonSize, buttonSize);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string login = "SELECT * FROM table_users WHERE Email= @Email AND Password= @Password";
                cmd = new OleDbCommand(login, con);

                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);

                OleDbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Create and show the dashboard form with the parent form reference
                    dashboard dashboardForm = new dashboard();
                    dashboardForm.Show();

                    // Set Form1's opacity to 0
                    if (_parentForm != null)
                    {
                        _parentForm.Opacity = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email Address or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEmail.Text = "";
                    textBoxPassword.Text = "";
                    textBoxEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
            textBoxConfirmPass.Text = "";
            textBoxEmail.Text = "";
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

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
