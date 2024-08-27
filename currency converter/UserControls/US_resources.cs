using System;
using System.Windows.Forms;

namespace currency_converter.UserControls
{
    public partial class US_resources : UserControl
    {
        public US_resources()
        {
            InitializeComponent();

            
            button9.Click += ButtonBack_Click; // Assuming button9 is the back button
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this); // Remove the current UserControl to go back to the main form
        }
    }
}

