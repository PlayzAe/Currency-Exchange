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
    public partial class Login_Page : UserControl
    {
        public Login_Page()
        {
            InitializeComponent();

            CustomizeBackButton(buttonForLogin);

            buttonForLogin.Click += Button1_Click;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this); 
        }

        private void label4Email_Click(object sender, EventArgs e)
        {

        }
    }
}
