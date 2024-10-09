namespace Contacts
{
    partial class loginFrm
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
            components = new System.ComponentModel.Container();
            contactsLabel = new Label();
            UserName = new TextBox();
            Password = new TextBox();
            enterBtn = new Button();
            exitBtn = new Button();
            userNameLabel = new Label();
            passLabel = new Label();
            passPic = new PictureBox();
            userPic = new PictureBox();
            contactsPic = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            SignUp = new Label();
            Hide = new Button();
            Show = new Button();
            ((System.ComponentModel.ISupportInitialize)passPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contactsPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // contactsLabel
            // 
            contactsLabel.AutoSize = true;
            contactsLabel.Location = new Point(252, 9);
            contactsLabel.Margin = new Padding(4, 0, 4, 0);
            contactsLabel.Name = "contactsLabel";
            contactsLabel.Size = new Size(108, 15);
            contactsLabel.TabIndex = 0;
            contactsLabel.Text = "نرم افزار دفترچه تلفن";
            // 
            // UserName
            // 
            UserName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.Location = new Point(164, 47);
            UserName.Margin = new Padding(4, 3, 4, 3);
            UserName.Name = "UserName";
            UserName.Size = new Size(283, 21);
            UserName.TabIndex = 2;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 9F);
            Password.Location = new Point(165, 83);
            Password.Margin = new Padding(4, 3, 4, 3);
            Password.Name = "Password";
            Password.PasswordChar = '●';
            Password.Size = new Size(283, 23);
            Password.TabIndex = 3;
            // 
            // enterBtn
            // 
            enterBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterBtn.Location = new Point(324, 121);
            enterBtn.Margin = new Padding(4, 3, 4, 3);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(88, 36);
            enterBtn.TabIndex = 4;
            enterBtn.Text = "ورود";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(196, 121);
            exitBtn.Margin = new Padding(4, 3, 4, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(88, 36);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "انصراف";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(455, 50);
            userNameLabel.Margin = new Padding(4, 0, 4, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(64, 13);
            userNameLabel.TabIndex = 6;
            userNameLabel.Text = ": نام کاربری";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passLabel.Location = new Point(456, 86);
            passLabel.Margin = new Padding(4, 0, 4, 0);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(53, 13);
            passLabel.TabIndex = 7;
            passLabel.Text = ": رمز عبور";
            // 
            // passPic
            // 
            passPic.Image = Properties.Resources.password;
            passPic.Location = new Point(517, 83);
            passPic.Margin = new Padding(4, 3, 4, 3);
            passPic.Name = "passPic";
            passPic.Size = new Size(26, 20);
            passPic.SizeMode = PictureBoxSizeMode.Zoom;
            passPic.TabIndex = 9;
            passPic.TabStop = false;
            // 
            // userPic
            // 
            userPic.Image = Properties.Resources.user;
            userPic.Location = new Point(517, 47);
            userPic.Margin = new Padding(4, 3, 4, 3);
            userPic.Name = "userPic";
            userPic.Size = new Size(26, 20);
            userPic.SizeMode = PictureBoxSizeMode.Zoom;
            userPic.TabIndex = 8;
            userPic.TabStop = false;
            // 
            // contactsPic
            // 
            contactsPic.Image = Properties.Resources.contacts;
            contactsPic.Location = new Point(14, 14);
            contactsPic.Margin = new Padding(4, 3, 4, 3);
            contactsPic.Name = "contactsPic";
            contactsPic.Size = new Size(142, 143);
            contactsPic.SizeMode = PictureBoxSizeMode.Zoom;
            contactsPic.TabIndex = 1;
            contactsPic.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // SignUp
            // 
            SignUp.AutoSize = true;
            SignUp.Font = new Font("Segoe UI", 9F);
            SignUp.ForeColor = Color.RoyalBlue;
            SignUp.Location = new Point(517, 147);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(43, 15);
            SignUp.TabIndex = 10;
            SignUp.Text = "ثبت نام";
            SignUp.Click += SignUp_Click;
            // 
            // Hide
            // 
            Hide.BackgroundImage = Properties.Resources.images;
            Hide.BackgroundImageLayout = ImageLayout.Zoom;
            Hide.FlatStyle = FlatStyle.Flat;
            Hide.Location = new Point(426, 83);
            Hide.Name = "Hide";
            Hide.Size = new Size(22, 23);
            Hide.TabIndex = 29;
            Hide.UseVisualStyleBackColor = true;
            Hide.Click += Hide_Click;
            // 
            // Show
            // 
            Show.BackgroundImage = Properties.Resources.Show;
            Show.BackgroundImageLayout = ImageLayout.Zoom;
            Show.FlatStyle = FlatStyle.Flat;
            Show.Location = new Point(426, 83);
            Show.Name = "Show";
            Show.Size = new Size(22, 23);
            Show.TabIndex = 31;
            Show.UseVisualStyleBackColor = true;
            Show.Click += Show_Click;
            // 
            // loginFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(572, 171);
            Controls.Add(Show);
            Controls.Add(Hide);
            Controls.Add(SignUp);
            Controls.Add(passPic);
            Controls.Add(userPic);
            Controls.Add(passLabel);
            Controls.Add(userNameLabel);
            Controls.Add(exitBtn);
            Controls.Add(enterBtn);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(contactsPic);
            Controls.Add(contactsLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "loginFrm";
            ((System.ComponentModel.ISupportInitialize)passPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)contactsPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label contactsLabel;
        private System.Windows.Forms.PictureBox contactsPic;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.PictureBox userPic;
        private System.Windows.Forms.PictureBox passPic;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Label SignUp;
        private Button Hide;
        private Button Show;
    }
}