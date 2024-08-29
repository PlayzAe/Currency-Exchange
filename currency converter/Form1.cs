using currency_converter.UserControls;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace currency_converter
{
    public partial class Form1 : Form

    {
        public Form1()
        {

            InitializeComponent();
            InitializeFadeInTimer();

           

            // Underlining the text in button6
            button6.Text = "Sign Up";
            button6.Font = new Font(button6.Font, FontStyle.Underline);

            // Customizing buttons
            CustomizeButton(button1); // Send Money button
            CustomizeButton(button2); // Resources
            CustomizeButton(button3); // Tools
            CustomizeButton(button4); // Help
            CustomizeButton(button5); // Support
            CustomizeButton(button6); // Sign Up
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
            button2.Click += ButtonResources_Click;

            // Attach the click event handler to the "Tools" button
            button3.Click += ButtonTools_Click;

            // Attach the click event handler to the "Help" button
            button4.Click += ButtonHelp_Click;

            // Attach the click event handler to the "Support" button
            button5.Click += ButtonSupport_Click;

            // Attach the click event handler to the "More" button
            button8.Click += ButtonMore_Click;

            // Attach the click event handler to the "Sign Up" button
            button6.Click += ButtonSignIn_Click;
        }

        // Handling fade in animation
        private Timer fadeInTimer;
        private float opacityStep = 0.1f; //The step of opacity change

        public void ShowPanel(bool show)
        {
            panel1.Visible = show;

        }

//---------------------------------------------------------------------------------------------------------------//
  //----------------------------Handling Customization Of Buttons And Other Things-------------------------------//

        private void InitializeFadeInTimer()
        {
            fadeInTimer = new Timer();
            fadeInTimer.Interval = 1; //Milliseconds
            fadeInTimer.Tick += FadeInTimer_Tick;

        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
            {
                Opacity += opacityStep;
            }
            else
            {
                Opacity = 1.0;
                fadeInTimer.Stop();
            }
        }

        private void ShowUserControlithFadeIn(UserControl userControl)
        {
            Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            Opacity = 0; // Start with 0 opacity
            fadeInTimer.Start();
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
                button.BackColor = Color.DarkGray;
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


 //-----------------------------------------------------------------------------------------------------------------//
    //-----------------------------------Handling Of Button Interations----------------------------------//
    

        //Handles Send Money Button//
        private void ButtonSendMoney_Click(object sender, EventArgs e)
        {

            // Hide The Panel
            ShowPanel(false);

            // Button Function To Enter New Page
            US_sendmoney UC = new US_sendmoney();
            addUserControl(UC);
        }


        // Handles Resources Button
        private void ButtonResources_Click(object sender, EventArgs e)
        {
            // Hide The Panel
            ShowPanel(false);

            // Button Function To Enter New Page
            US_resources uS_Resources = new US_resources();
            addUserControl(uS_Resources);
        }


        //Handles Tools Button
        private void ButtonTools_Click(object sender, EventArgs e) 
        {

            // Hide The Panel
            ShowPanel(false);

            // Button Function To Enter New Page
            US_tools usS_Tools = new US_tools();
            addUserControl(usS_Tools);

        }


        //Handles Help Button
        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            // Hide The Panel
            ShowPanel(false);

            // Button Function To Enter New Page
            US_help usS_Help = new US_help();
            addUserControl(usS_Help);
        }


        //Handles Support Button
        private void ButtonSupport_Click(object sender, EventArgs e)
        {

            // Hide The Panel
            ShowPanel(false);

            // Button Function To Enter New Page
            US_support usS_Support = new US_support();
            addUserControl(usS_Support);
        }


        //Handles More Button
        private void ButtonMore_Click(object sender, EventArgs e)
        {
            // Hide The Panel
            ShowPanel(false);

            // Button Function To Enter New Page
            US_more usS_More = new US_more();       
            addUserControl(usS_More);
        }


        //Handles Sign Up Button
        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            // Hide The Panel
            ShowPanel(false);

            // Button Function To Enter New Page
            US_signIn uS_SignIn = new US_signIn();
            addUserControl(uS_SignIn);

            // Button function for a fade in into the page
            ShowUserControlithFadeIn(uS_SignIn);
        }


      

      
//-----------------------------------------------------------------------------------------------------------------//

        // Do not remove this part is important
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
