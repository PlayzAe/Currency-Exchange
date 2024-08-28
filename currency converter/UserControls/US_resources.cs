﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace currency_converter.UserControls
{
    public partial class US_resources : UserControl
    {
        public US_resources()
        {
            InitializeComponent();

            CustomizeBackButton(button9);

            
            button9.Click += ButtonBack_Click; // button9 is the back button
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
            this.Parent.Controls.Remove(this); // Remove the current UserControl to go back to the main form
        }
    }
}

