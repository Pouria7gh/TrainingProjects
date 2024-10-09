namespace Contacts
{
    partial class Main
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            Search = new TextBox();
            label1 = new Label();
            AddPeople = new Label();
            Welcome = new TextBox();
            btnDelete = new Button();
            AddUser = new Label();
            Update = new Label();
            ChangePass = new Label();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(809, 264);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(821, 292);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "لیست";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Search);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(821, 73);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "جستجو";
            // 
            // Search
            // 
            Search.Location = new Point(402, 30);
            Search.Name = "Search";
            Search.Size = new Size(297, 23);
            Search.TabIndex = 1;
            Search.TextChanged += Search_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(705, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "جستجو :";
            // 
            // AddPeople
            // 
            AddPeople.AutoSize = true;
            AddPeople.Location = new Point(725, 9);
            AddPeople.Name = "AddPeople";
            AddPeople.Size = new Size(102, 15);
            AddPeople.TabIndex = 3;
            AddPeople.Text = "افزودن شخص جدید";
            AddPeople.Click += AddPeople_Click;
            // 
            // Welcome
            // 
            Welcome.Location = new Point(18, 408);
            Welcome.Name = "Welcome";
            Welcome.ReadOnly = true;
            Welcome.Size = new Size(256, 23);
            Welcome.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(752, 407);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // AddUser
            // 
            AddUser.AutoSize = true;
            AddUser.Location = new Point(627, 9);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(92, 15);
            AddUser.TabIndex = 7;
            AddUser.Text = "افزودن کاربر جدید";
            AddUser.Click += AddUser_Click;
            // 
            // Update
            // 
            Update.AutoSize = true;
            Update.Location = new Point(561, 9);
            Update.Name = "Update";
            Update.Size = new Size(60, 15);
            Update.TabIndex = 8;
            Update.Text = "بروز رسانی";
            Update.Click += Update_Click;
            // 
            // ChangePass
            // 
            ChangePass.AutoSize = true;
            ChangePass.Location = new Point(480, 9);
            ChangePass.Name = "ChangePass";
            ChangePass.Size = new Size(75, 15);
            ChangePass.TabIndex = 9;
            ChangePass.Text = "تغییر رمز عبور";
            ChangePass.Click += ChangePass_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(671, 408);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "ویرایش";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(845, 440);
            Controls.Add(btnEdit);
            Controls.Add(ChangePass);
            Controls.Add(Update);
            Controls.Add(AddUser);
            Controls.Add(btnDelete);
            Controls.Add(Welcome);
            Controls.Add(AddPeople);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox Search;
        private Label AddPeople;
        private Button btnDelete;
        private Label AddUser;
        private Label Update;
        private Label ChangePass;
        private Button btnEdit;
        public DataGridView dataGridView1;
        private TextBox Welcome;
    }
}