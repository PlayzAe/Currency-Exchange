using System;
using System.Drawing;
using System.Windows.Forms;

namespace currency_converter.UserControls
{
    public partial class US_sendmoney : UserControl
    {
        public US_sendmoney()
        {
            InitializeComponent();

            // Customize the Back button
            CustomizeBackButton(button1);

            // Attach the click event handler to the Back button
            button1.Click += ButtonBack_Click;
        }


        private void CustomizeBackButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.Transparent;
            button.FlatAppearance.BorderSize = 0; // Remove the border

            // Ensure the button size is appropriate for the image
            int buttonSize = 50;
            button.Size = new Size(buttonSize, buttonSize);

            
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            //show panel in Form1
            if (this.Parent is Form1 form1)
            {
                form1.ShowPanel(true);
            }


            // Go back to the original page 
            this.Parent.Controls.Remove(this); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle any changes in textBox1 here if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This method can be removed if not needed
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // This method can be removed if not needed
        }
    }
}
