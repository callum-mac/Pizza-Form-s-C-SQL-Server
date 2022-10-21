
namespace Pizzer_v2
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(278, 101);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(117, 24);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name:";
            this.FirstNameLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(281, 127);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(114, 24);
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Text = "Last Name:";
            this.LastNameLabel.Click += new System.EventHandler(this.LastNameLabel_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(284, 205);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(111, 24);
            this.UsernameLabel.TabIndex = 11;
            this.UsernameLabel.Text = "Username:";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(302, 153);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(93, 24);
            this.AddressLabel.TabIndex = 12;
            this.AddressLabel.Text = "Address:";
            this.AddressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel.Location = new System.Drawing.Point(304, 179);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(91, 24);
            this.NumberLabel.TabIndex = 13;
            this.NumberLabel.Text = "Number:";
            this.NumberLabel.Click += new System.EventHandler(this.NumberLabel_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(289, 231);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 24);
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(401, 131);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameBox.TabIndex = 16;
            this.LastNameBox.TextChanged += new System.EventHandler(this.LastNameBox_TextChanged);
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(401, 157);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(100, 20);
            this.AddressBox.TabIndex = 17;
            this.AddressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(401, 183);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(100, 20);
            this.NumberBox.TabIndex = 18;
            this.NumberBox.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(401, 209);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameBox.TabIndex = 19;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(401, 235);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 20;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.Location = new System.Drawing.Point(335, 46);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(117, 31);
            this.SignUpLabel.TabIndex = 21;
            this.SignUpLabel.Text = "Sign Up";
            this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SubmitButton.Location = new System.Drawing.Point(341, 278);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(119, 42);
            this.SubmitButton.TabIndex = 22;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(401, 105);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameBox.TabIndex = 23;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.FirstNameBox_TextChanged);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 465);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox FirstNameBox;
    }
}