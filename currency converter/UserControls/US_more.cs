﻿using System;
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
    public partial class US_more : UserControl
    {
        public US_more()
        {
            InitializeComponent();

            CustomizeBackButton(button1more);

            button1more.Click += Button1more_Click;
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

        private void Button1more_Click(object sender, EventArgs e)
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

        }
    }
}
