﻿namespace currency_converter.UserControls
{
    partial class US_help
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
            this.button1help = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1help
            // 
            this.button1help.BackColor = System.Drawing.Color.Transparent;
            this.button1help.BackgroundImage = global::currency_converter.Properties.Resources.icons8_back_button_50;
            this.button1help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1help.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1help.Location = new System.Drawing.Point(3, 3);
            this.button1help.Name = "button1help";
            this.button1help.Size = new System.Drawing.Size(100, 64);
            this.button1help.TabIndex = 23;
            this.button1help.UseVisualStyleBackColor = false;
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
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Help";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // US_help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1help);
            this.Controls.Add(this.textBox1);
            this.Name = "US_help";
            this.Size = new System.Drawing.Size(1244, 654);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1help;
        private System.Windows.Forms.TextBox textBox1;
    }
}
