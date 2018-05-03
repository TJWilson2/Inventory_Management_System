namespace Inventory_Management_System
{
    partial class Add_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Item));
            this.Homepage_Button = new System.Windows.Forms.Button();
            this.New_Item_Label = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.TextBox();
            this.Add_Item_Button = new System.Windows.Forms.Button();
            this.BAESystems_Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BAESystems_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Homepage_Button
            // 
            this.Homepage_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Homepage_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Homepage_Button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.Homepage_Button.Location = new System.Drawing.Point(383, 12);
            this.Homepage_Button.Name = "Homepage_Button";
            this.Homepage_Button.Size = new System.Drawing.Size(115, 25);
            this.Homepage_Button.TabIndex = 0;
            this.Homepage_Button.Text = "Return to Settings";
            this.Homepage_Button.UseVisualStyleBackColor = false;
            this.Homepage_Button.Click += new System.EventHandler(this.Homepage_Button_Click);
            // 
            // New_Item_Label
            // 
            this.New_Item_Label.AutoSize = true;
            this.New_Item_Label.Location = new System.Drawing.Point(97, 74);
            this.New_Item_Label.Name = "New_Item_Label";
            this.New_Item_Label.Size = new System.Drawing.Size(294, 13);
            this.New_Item_Label.TabIndex = 1;
            this.New_Item_Label.Text = "Please enter the name of the new item you would like to add:";
            // 
            // Item
            // 
            this.Item.BackColor = System.Drawing.SystemColors.Control;
            this.Item.Location = new System.Drawing.Point(100, 100);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(175, 20);
            this.Item.TabIndex = 2;
            // 
            // Add_Item_Button
            // 
            this.Add_Item_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Add_Item_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_Item_Button.Location = new System.Drawing.Point(334, 154);
            this.Add_Item_Button.Name = "Add_Item_Button";
            this.Add_Item_Button.Size = new System.Drawing.Size(110, 25);
            this.Add_Item_Button.TabIndex = 3;
            this.Add_Item_Button.Text = "Add Item";
            this.Add_Item_Button.UseVisualStyleBackColor = false;
            this.Add_Item_Button.Click += new System.EventHandler(this.Add_Item_Button_Click);
            // 
            // BAESystems_Logo
            // 
            this.BAESystems_Logo.Image = global::Inventory_Management_System.Properties.Resources.BAES_logo;
            this.BAESystems_Logo.Location = new System.Drawing.Point(12, 377);
            this.BAESystems_Logo.Name = "BAESystems_Logo";
            this.BAESystems_Logo.Size = new System.Drawing.Size(158, 23);
            this.BAESystems_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BAESystems_Logo.TabIndex = 8;
            this.BAESystems_Logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 370);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(509, 412);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BAESystems_Logo);
            this.Controls.Add(this.Add_Item_Button);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.New_Item_Label);
            this.Controls.Add(this.Homepage_Button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            ((System.ComponentModel.ISupportInitialize)(this.BAESystems_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Homepage_Button;
        private System.Windows.Forms.Label New_Item_Label;
        private System.Windows.Forms.TextBox Item;
        private System.Windows.Forms.Button Add_Item_Button;
        private System.Windows.Forms.PictureBox BAESystems_Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}