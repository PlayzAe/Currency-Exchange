using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currency_converter.UserControls
{
    public partial class US_signIn : UserControl
    {
        public US_signIn()
        {
            InitializeComponent();

            CustomizeBackButton(button1GoingBackToHome);

            // Attach the click event handler to the "Sign In" button
            button1GoingBackToHome.Click += Button1GoingBackToHome_Click;

            // If button is clicked go to Login Page
            buttonSignIn.Click += ButtonSignIn_Click;
        }

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
    }
}
