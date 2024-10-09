namespace Contacts
{
    partial class EditContact
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
            btnCancle = new Button();
            btnConfirm = new Button();
            groupBox1 = new GroupBox();
            BDMonth = new TextBox();
            BDYear = new TextBox();
            BDDay = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            Gender = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Email = new TextBox();
            PhoneNumber = new TextBox();
            Family = new TextBox();
            name = new TextBox();
            OldPhoneNumber = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(258, 180);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(75, 23);
            btnCancle.TabIndex = 8;
            btnCancle.Text = "انصراف";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(355, 180);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "ثبت";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BDMonth);
            groupBox1.Controls.Add(BDYear);
            groupBox1.Controls.Add(BDDay);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(Gender);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Email);
            groupBox1.Controls.Add(PhoneNumber);
            groupBox1.Controls.Add(Family);
            groupBox1.Controls.Add(name);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(681, 162);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات";
            // 
            // BDMonth
            // 
            BDMonth.Location = new Point(134, 100);
            BDMonth.MaxLength = 2;
            BDMonth.Name = "BDMonth";
            BDMonth.RightToLeft = RightToLeft.No;
            BDMonth.Size = new Size(33, 23);
            BDMonth.TabIndex = 20;
            // 
            // BDYear
            // 
            BDYear.Location = new Point(60, 100);
            BDYear.MaxLength = 4;
            BDYear.Name = "BDYear";
            BDYear.RightToLeft = RightToLeft.No;
            BDYear.Size = new Size(33, 23);
            BDYear.TabIndex = 19;
            // 
            // BDDay
            // 
            BDDay.Location = new Point(207, 100);
            BDDay.MaxLength = 2;
            BDDay.Name = "BDDay";
            BDDay.RightToLeft = RightToLeft.No;
            BDDay.Size = new Size(33, 23);
            BDDay.TabIndex = 18;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(605, 103);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 10;
            label5.Text = "ایمیل :";
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
            label3.Location = new Point(605, 74);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 8;
            label3.Text = "شماره تلفن :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 45);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "نام خانوادگی :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(605, 45);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 6;
            label1.Text = "نام :";
            // 
            // Email
            // 
            Email.Location = new Point(365, 100);
            Email.Name = "Email";
            Email.RightToLeft = RightToLeft.No;
            Email.Size = new Size(234, 23);
            Email.TabIndex = 5;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(365, 71);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(234, 23);
            PhoneNumber.TabIndex = 3;
            // 
            // Family
            // 
            Family.Location = new Point(6, 42);
            Family.Name = "Family";
            Family.Size = new Size(234, 23);
            Family.TabIndex = 1;
            // 
            // name
            // 
            name.Location = new Point(365, 42);
            name.Name = "name";
            name.RightToLeft = RightToLeft.Yes;
            name.Size = new Size(234, 23);
            name.TabIndex = 0;
            // 
            // OldPhoneNumber
            // 
            OldPhoneNumber.Location = new Point(842, 290);
            OldPhoneNumber.Name = "OldPhoneNumber";
            OldPhoneNumber.Size = new Size(100, 23);
            OldPhoneNumber.TabIndex = 9;
            // 
            // EditContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(708, 212);
            Controls.Add(OldPhoneNumber);
            Controls.Add(btnCancle);
            Controls.Add(btnConfirm);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EditContact";
            Text = "EditContact";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancle;
        private Button btnConfirm;
        private GroupBox groupBox1;
        public TextBox BDMonth;
        public TextBox BDYear;
        public TextBox BDDay;
        private Label label9;
        private Label label8;
        private Label label7;
        public ComboBox Gender;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox Email;
        public TextBox PhoneNumber;
        public TextBox Family;
        internal TextBox name;
        public TextBox OldPhoneNumber;
    }
}