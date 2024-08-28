namespace currency_converter.UserControls
{
    partial class US_more
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
            this.button1more = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1more
            // 
            this.button1more.BackColor = System.Drawing.Color.Transparent;
            this.button1more.BackgroundImage = global::currency_converter.Properties.Resources.icons8_back_button_50;
            this.button1more.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1more.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1more.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1more.Location = new System.Drawing.Point(3, 3);
            this.button1more.Name = "button1more";
            this.button1more.Size = new System.Drawing.Size(100, 64);
            this.button1more.TabIndex = 27;
            this.button1more.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(537, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(141, 27);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "More";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // US_more
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1more);
            this.Controls.Add(this.textBox1);
            this.Name = "US_more";
            this.Size = new System.Drawing.Size(1220, 673);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1more;
        private System.Windows.Forms.TextBox textBox1;
    }
}
