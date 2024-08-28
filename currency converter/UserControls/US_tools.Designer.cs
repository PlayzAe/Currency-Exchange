namespace currency_converter.UserControls
{
    partial class US_tools
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button10tools = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button10tools
            // 
            this.button10tools.BackColor = System.Drawing.Color.Transparent;
            this.button10tools.BackgroundImage = global::currency_converter.Properties.Resources.icons8_back_button_50;
            this.button10tools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10tools.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button10tools.Location = new System.Drawing.Point(3, 3);
            this.button10tools.Name = "button10tools";
            this.button10tools.Size = new System.Drawing.Size(100, 64);
            this.button10tools.TabIndex = 21;
            this.button10tools.UseVisualStyleBackColor = false;
            this.button10tools.Click += new System.EventHandler(this.button10tools_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(501, 293);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(141, 27);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Tools";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // US_tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button10tools);
            this.Controls.Add(this.textBox1);
            this.Name = "US_tools";
            this.Size = new System.Drawing.Size(1214, 670);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button10tools;
        private System.Windows.Forms.TextBox textBox1;
    }
}
