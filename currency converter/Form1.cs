using currency_converter.UserControls;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace currency_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Underlining the text in button6
            button6.Text = "Sign In";
            button6.Font = new Font(button6.Font, FontStyle.Underline);

            // Customizing buttons
            CustomizeButton(button1); // Send Money button
            CustomizeButton(button2); // Resources
            CustomizeButton(button3); // Tools
            CustomizeButton(button4); // Help
            CustomizeButton(button5); // Support
            CustomizeButton(button6); // Sign in
            CustomizeButton(button8); // More

            // Customizing button7 (Get the App) separately
            CustomizeGetTheAppButton(button7);

            // Customizing label1 to display "Tend" with a transparent background
            CustomizeLabel(label1);

            // Customizing textBox1 to be transparent
            CustomizeTextBox(textBox1);

            // Attach the click event handler to the "Send Money" button
            button1.Click += ButtonSendMoney_Click;

            // Attach the click event handler to the "Resources" button
            button2.Click += ButtonSendMoney_Click;
        }

        private void addUserControl(UserControl userControl)
        {
            this.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }

        private void CustomizeButton(Button button)
        {
            // General button customization here
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.Transparent;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.LightGray; // Light gray hover animation
            button.FlatAppearance.MouseDownBackColor = Color.Gray; // Optional: darker color on click

            // Handle the Paint event for custom rendering
            button.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle buttonRect = new Rectangle(0, 0, button.Width, button.Height);
                GraphicsPath path = RoundedRectangle(buttonRect, 10);
                button.Region = new Region(path);
                g.FillPath(new SolidBrush(button.BackColor), path);
            };
        }

        private void CustomizeGetTheAppButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.BackColor = Color.SlateBlue;
            button.ForeColor = Color.White; // Set text color to white
            button.FlatAppearance.BorderSize = 0;

            // Handle the Paint event for custom rendering
            button.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle buttonRect = new Rectangle(0, 0, button.Width, button.Height);
                GraphicsPath path = RoundedRectangle(buttonRect, 10);
                button.Region = new Region(path);

                // Draw the background
                g.FillPath(new SolidBrush(button.BackColor), path);

                // Draw the text above the background
                TextRenderer.DrawText(g, button.Text, button.Font, button.ClientRectangle, button.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };

            // Change background and text color on hover
            button.MouseEnter += (sender, e) =>
            {
                button.BackColor = Color.LightGray;
                button.ForeColor = Color.Black;
                button.Invalidate(); // Redraw the button
            };

            // Revert background and text color when mouse leaves
            button.MouseLeave += (sender, e) =>
            {
                button.BackColor = Color.SlateBlue;
                button.ForeColor = Color.Black;
                button.Invalidate(); // Redraw the button
            };

            // Change background color when clicked
            button.MouseDown += (sender, e) =>
            {
                button.BackColor = Color.LightGray;
                button.Invalidate(); // Redraw the button
            };

            // Revert background color when mouse is released
            button.MouseUp += (sender, e) =>
            {
                button.BackColor = Color.SlateBlue;
                button.Invalidate(); // Redraw the button
            };
        }

        private GraphicsPath RoundedRectangle(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void CustomizeLabel(Label label)
        {
            label.Text = "Tend";
            label.BackColor = Color.Transparent; // Make the background transparent
            label.ForeColor = this.ForeColor; // Set the text color to match the form's text color
        }

        private void CustomizeTextBox(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.None; // Remove the border
            textBox.ForeColor = this.ForeColor; // Set the text color to match the form's text color
            textBox.ReadOnly = true; // Make the TextBox read-only to prevent editing
            textBox.TabStop = false; // Prevent the TextBox from being selected
        }

        private void ButtonSendMoney_Click(object sender, EventArgs e)
        {
            // Replace with the UserControl you want to display
            US_sendmoney UC = new US_sendmoney();
            addUserControl(UC);
        }

        private void ButtonResources_Click(object sender, EventArgs e)
        {
            US_resources uS_Resources = new US_resources();
            addUserControl(uS_Resources);
        }

        // Other event handlers
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
