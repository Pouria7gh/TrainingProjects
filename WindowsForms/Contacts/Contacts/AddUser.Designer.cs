namespace Contacts
{
    partial class AddUser
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
            btnCancle = new Button();
            btnConfirm = new Button();
            groupBox1 = new GroupBox();
            label13 = new Label();
            UserName = new TextBox();
            Show = new Button();
            Show2 = new Button();
            Hide = new Button();
            Hide2 = new Button();
            label11 = new Label();
            label10 = new Label();
            Password = new TextBox();
            rPassWord = new TextBox();
            BDMonth = new TextBox();
            BDYear = new TextBox();
            BDDay = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            Gender = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PhoneNumber = new TextBox();
            Family = new TextBox();
            name = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            RoleCB = new CheckBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(258, 192);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(75, 23);
            btnCancle.TabIndex = 8;
            btnCancle.Text = "انصراف";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(355, 192);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "ثبت";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(UserName);
            groupBox1.Controls.Add(Show);
            groupBox1.Controls.Add(Show2);
            groupBox1.Controls.Add(Hide);
            groupBox1.Controls.Add(Hide2);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(rPassWord);
            groupBox1.Controls.Add(BDMonth);
            groupBox1.Controls.Add(BDYear);
            groupBox1.Controls.Add(BDDay);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(Gender);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(PhoneNumber);
            groupBox1.Controls.Add(Family);
            groupBox1.Controls.Add(name);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(692, 174);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(605, 45);
            label13.Name = "label13";
            label13.Size = new Size(61, 15);
            label13.TabIndex = 34;
            label13.Text = "نام کاربری :";
            // 
            // UserName
            // 
            UserName.Location = new Point(365, 42);
            UserName.Name = "UserName";
            UserName.RightToLeft = RightToLeft.No;
            UserName.Size = new Size(234, 23);
            UserName.TabIndex = 33;
            UserName.TextChanged += UserName_TextChanged;
            // 
            // Show
            // 
            Show.BackgroundImage = Properties.Resources.Show;
            Show.BackgroundImageLayout = ImageLayout.Zoom;
            Show.FlatStyle = FlatStyle.Flat;
            Show.Location = new Point(577, 129);
            Show.Name = "Show";
            Show.Size = new Size(22, 23);
            Show.TabIndex = 30;
            Show.UseVisualStyleBackColor = true;
            Show.Click += Show_Click_1;
            // 
            // Show2
            // 
            Show2.BackgroundImage = Properties.Resources.Show;
            Show2.BackgroundImageLayout = ImageLayout.Zoom;
            Show2.FlatStyle = FlatStyle.Flat;
            Show2.Location = new Point(218, 129);
            Show2.Name = "Show2";
            Show2.Size = new Size(22, 23);
            Show2.TabIndex = 29;
            Show2.UseVisualStyleBackColor = true;
            Show2.Click += Show2_Click_1;
            // 
            // Hide
            // 
            Hide.BackgroundImage = Properties.Resources.images;
            Hide.BackgroundImageLayout = ImageLayout.Zoom;
            Hide.FlatStyle = FlatStyle.Flat;
            Hide.Location = new Point(577, 129);
            Hide.Name = "Hide";
            Hide.Size = new Size(22, 23);
            Hide.TabIndex = 28;
            Hide.UseVisualStyleBackColor = true;
            Hide.Click += Hide_Click;
            // 
            // Hide2
            // 
            Hide2.BackgroundImage = Properties.Resources.images;
            Hide2.BackgroundImageLayout = ImageLayout.Zoom;
            Hide2.FlatStyle = FlatStyle.Flat;
            Hide2.Location = new Point(218, 129);
            Hide2.Name = "Hide2";
            Hide2.Size = new Size(22, 23);
            Hide2.TabIndex = 26;
            Hide2.UseVisualStyleBackColor = true;
            Hide2.Click += Hide2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(246, 132);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 24;
            label11.Text = "تکرار رمز عبور :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(605, 132);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 23;
            label10.Text = "رمز عبور :";
            // 
            // Password
            // 
            Password.Location = new Point(365, 129);
            Password.Name = "Password";
            Password.PasswordChar = '●';
            Password.RightToLeft = RightToLeft.No;
            Password.Size = new Size(234, 23);
            Password.TabIndex = 22;
            // 
            // rPassWord
            // 
            rPassWord.Location = new Point(6, 129);
            rPassWord.Name = "rPassWord";
            rPassWord.PasswordChar = '●';
            rPassWord.RightToLeft = RightToLeft.No;
            rPassWord.Size = new Size(234, 23);
            rPassWord.TabIndex = 21;
            // 
            // BDMonth
            // 
            BDMonth.Location = new Point(134, 100);
            BDMonth.MaxLength = 2;
            BDMonth.Name = "BDMonth";
            BDMonth.RightToLeft = RightToLeft.No;
            BDMonth.Size = new Size(33, 23);
            BDMonth.TabIndex = 20;
            BDMonth.KeyPress += BDMonth_KeyPress;
            // 
            // BDYear
            // 
            BDYear.Location = new Point(60, 100);
            BDYear.MaxLength = 4;
            BDYear.Name = "BDYear";
            BDYear.RightToLeft = RightToLeft.No;
            BDYear.Size = new Size(33, 23);
            BDYear.TabIndex = 19;
            BDYear.KeyPress += BDYear_KeyPress;
            // 
            // BDDay
            // 
            BDDay.Location = new Point(207, 100);
            BDDay.MaxLength = 2;
            BDDay.Name = "BDDay";
            BDDay.RightToLeft = RightToLeft.No;
            BDDay.Size = new Size(33, 23);
            BDDay.TabIndex = 18;
            BDDay.KeyPress += BDDay_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(173, 103);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(28, 15);
            label9.TabIndex = 17;
            label9.Text = "روز :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(99, 103);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(29, 15);
            label8.TabIndex = 16;
            label8.Text = "ماه :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 103);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(34, 15);
            label7.TabIndex = 14;
            label7.Text = "سال :";
            // 
            // Gender
            // 
            Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "مرد", "زن" });
            Gender.Location = new Point(6, 71);
            Gender.Name = "Gender";
            Gender.Size = new Size(234, 23);
            Gender.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 103);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 11;
            label6.Text = "تاریخ تولد(شمسی) :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 74);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 9;
            label4.Text = "جنسیت :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(605, 103);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 8;
            label3.Text = "شماره تلفن :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(605, 74);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "نام خانوادگی :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 45);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 6;
            label1.Text = "نام :";
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(365, 100);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(234, 23);
            PhoneNumber.TabIndex = 3;
            PhoneNumber.KeyPress += PhoneNumber_KeyPress;
            // 
            // Family
            // 
            Family.Location = new Point(365, 71);
            Family.Name = "Family";
            Family.Size = new Size(234, 23);
            Family.TabIndex = 1;
            // 
            // name
            // 
            name.Location = new Point(6, 42);
            name.Name = "name";
            name.Size = new Size(234, 23);
            name.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RoleCB
            // 
            RoleCB.AutoSize = true;
            RoleCB.Location = new Point(557, 195);
            RoleCB.Name = "RoleCB";
            RoleCB.RightToLeft = RightToLeft.Yes;
            RoleCB.Size = new Size(54, 19);
            RoleCB.TabIndex = 35;
            RoleCB.Text = "ادمین";
            RoleCB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(617, 196);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(63, 15);
            label5.TabIndex = 36;
            label5.Text = "نقش کاربر :";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(716, 230);
            Controls.Add(label5);
            Controls.Add(RoleCB);
            Controls.Add(btnCancle);
            Controls.Add(btnConfirm);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddUser";
            Text = "AddUser";
            Load += AddUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancle;
        private Button btnConfirm;
        private GroupBox groupBox1;
        private TextBox BDMonth;
        private TextBox BDYear;
        private TextBox BDDay;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox Gender;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox PhoneNumber;
        private TextBox Family;
        private TextBox name;
        private TextBox Password;
        private TextBox rPassWord;
        private Label label10;
        private Label label11;
        private ErrorProvider errorProvider1;
        private Button Hide2;
        private Button Hide;
        private Button Show2;
        private Button Show;
        private Label label13;
        private TextBox UserName;
        private Label label5;
        private CheckBox RoleCB;
    }
}