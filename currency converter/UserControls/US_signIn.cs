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

            CustomizeBackButton(button1signIn);

            button1signIn.Click += Button1signIn_Click;
        }

        private void CustomizeBackButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.Transparent;
            button.FlatAppearance.BorderSize = 0;  // Remove the border
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button.TabStop = false;  // Disable focus rectangle
        }

        private void Button1signIn_Click(object sender, EventArgs e)
        {
            // Show the panel in Form1
            if (this.Parent is Form1 form1)
            {
                form1.ShowPanel(true); // Show the panel
            }

            // Go back to the original page 
            this.Parent.Controls.Remove(this);
        }

        private void button1signIn_Click(object sender, EventArgs e)
        {
            // Handle button click events
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle picture box click events
        }
    }
}
