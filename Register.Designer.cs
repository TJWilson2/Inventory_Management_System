namespace Inventory_Management_System
{
    partial class Register
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.Homepage_Button = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.ConfirmationPassword = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.AuthenticationKey = new System.Windows.Forms.TextBox();
            this.Username_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Confirmation_Password_Label = new System.Windows.Forms.Label();
            this.Authentication_Key_Label = new System.Windows.Forms.Label();
            this.Baesystems_Label = new System.Windows.Forms.Label();
            this.Register_Button = new System.Windows.Forms.Button();
            this.BAESystems_Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BAESystems_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Homepage_Button
            // 
            this.Homepage_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Homepage_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Homepage_Button.Location = new System.Drawing.Point(383, 12);
            this.Homepage_Button.Name = "Homepage_Button";
            this.Homepage_Button.Size = new System.Drawing.Size(115, 25);
            this.Homepage_Button.TabIndex = 0;
            this.Homepage_Button.Text = "Return to Homepage";
            this.Homepage_Button.UseVisualStyleBackColor = false;
            this.Homepage_Button.Click += new System.EventHandler(this.Homepage_Button_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.SystemColors.Control;
            this.Password.Location = new System.Drawing.Point(100, 150);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(175, 20);
            this.Password.TabIndex = 4;
            // 
            // ConfirmationPassword
            // 
            this.ConfirmationPassword.BackColor = System.Drawing.SystemColors.Control;
            this.ConfirmationPassword.Location = new System.Drawing.Point(100, 200);
            this.ConfirmationPassword.Name = "ConfirmationPassword";
            this.ConfirmationPassword.PasswordChar = '*';
            this.ConfirmationPassword.Size = new System.Drawing.Size(175, 20);
            this.ConfirmationPassword.TabIndex = 6;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.SystemColors.Control;
            this.Username.Location = new System.Drawing.Point(100, 100);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(175, 20);
            this.Username.TabIndex = 1;
            // 
            // AuthenticationKey
            // 
            this.AuthenticationKey.BackColor = System.Drawing.SystemColors.Control;
            this.AuthenticationKey.Location = new System.Drawing.Point(100, 250);
            this.AuthenticationKey.Name = "AuthenticationKey";
            this.AuthenticationKey.Size = new System.Drawing.Size(175, 20);
            this.AuthenticationKey.TabIndex = 8;
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(97, 84);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(55, 13);
            this.Username_Label.TabIndex = 2;
            this.Username_Label.Text = "Username";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(97, 134);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(53, 13);
            this.Password_Label.TabIndex = 5;
            this.Password_Label.Text = "Password";
            // 
            // Confirmation_Password_Label
            // 
            this.Confirmation_Password_Label.AutoSize = true;
            this.Confirmation_Password_Label.Location = new System.Drawing.Point(97, 184);
            this.Confirmation_Password_Label.Name = "Confirmation_Password_Label";
            this.Confirmation_Password_Label.Size = new System.Drawing.Size(97, 13);
            this.Confirmation_Password_Label.TabIndex = 7;
            this.Confirmation_Password_Label.Text = "Re-enter Password";
            // 
            // Authentication_Key_Label
            // 
            this.Authentication_Key_Label.AutoSize = true;
            this.Authentication_Key_Label.Location = new System.Drawing.Point(98, 234);
            this.Authentication_Key_Label.Name = "Authentication_Key_Label";
            this.Authentication_Key_Label.Size = new System.Drawing.Size(96, 13);
            this.Authentication_Key_Label.TabIndex = 9;
            this.Authentication_Key_Label.Text = "Authentication Key";
            // 
            // Baesystems_Label
            // 
            this.Baesystems_Label.AutoSize = true;
            this.Baesystems_Label.Location = new System.Drawing.Point(281, 103);
            this.Baesystems_Label.Name = "Baesystems_Label";
            this.Baesystems_Label.Size = new System.Drawing.Size(96, 13);
            this.Baesystems_Label.TabIndex = 3;
            this.Baesystems_Label.Text = "@baesystems.com";
            // 
            // Register_Button
            // 
            this.Register_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Register_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_Button.Location = new System.Drawing.Point(372, 300);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(55, 25);
            this.Register_Button.TabIndex = 10;
            this.Register_Button.Text = "Register";
            this.Register_Button.UseVisualStyleBackColor = false;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // BAESystems_Logo
            // 
            this.BAESystems_Logo.Image = global::Inventory_Management_System.Properties.Resources.BAES_logo;
            this.BAESystems_Logo.Location = new System.Drawing.Point(12, 377);
            this.BAESystems_Logo.Name = "BAESystems_Logo";
            this.BAESystems_Logo.Size = new System.Drawing.Size(158, 23);
            this.BAESystems_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BAESystems_Logo.TabIndex = 11;
            this.BAESystems_Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please enter your registration details below";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(509, 412);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAESystems_Logo);
            this.Controls.Add(this.Register_Button);
            this.Controls.Add(this.Baesystems_Label);
            this.Controls.Add(this.Authentication_Key_Label);
            this.Controls.Add(this.Confirmation_Password_Label);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.AuthenticationKey);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.ConfirmationPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Homepage_Button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BAESystems_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Homepage_Button;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ConfirmationPassword;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox AuthenticationKey;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label Confirmation_Password_Label;
        private System.Windows.Forms.Label Authentication_Key_Label;
        private System.Windows.Forms.Label Baesystems_Label;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.PictureBox BAESystems_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}