namespace Contacts
{
    partial class ChangePass
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
            CurrentPass = new TextBox();
            NewPass = new TextBox();
            NewPass2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnReg = new Button();
            Hide2 = new Button();
            Hide3 = new Button();
            Hide = new Button();
            Show2 = new Button();
            Show = new Button();
            Show3 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // CurrentPass
            // 
            CurrentPass.Location = new Point(12, 22);
            CurrentPass.Name = "CurrentPass";
            CurrentPass.PasswordChar = '●';
            CurrentPass.Size = new Size(319, 23);
            CurrentPass.TabIndex = 0;
            // 
            // NewPass
            // 
            NewPass.Location = new Point(12, 51);
            NewPass.Name = "NewPass";
            NewPass.PasswordChar = '●';
            NewPass.Size = new Size(319, 23);
            NewPass.TabIndex = 1;
            // 
            // NewPass2
            // 
            NewPass2.Location = new Point(12, 80);
            NewPass2.Name = "NewPass2";
            NewPass2.PasswordChar = '●';
            NewPass2.Size = new Size(319, 23);
            NewPass2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "رمز عبور :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 54);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(80, 15);
            label2.TabIndex = 4;
            label2.Text = "رمز عبور جدید :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 83);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "تکرار رمز عبور جدید :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnReg
            // 
            btnReg.Location = new Point(202, 116);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(75, 23);
            btnReg.TabIndex = 6;
            btnReg.Text = "انجام";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // Hide2
            // 
            Hide2.BackgroundImage = Properties.Resources.images;
            Hide2.BackgroundImageLayout = ImageLayout.Zoom;
            Hide2.FlatStyle = FlatStyle.Flat;
            Hide2.Location = new Point(309, 51);
            Hide2.Name = "Hide2";
            Hide2.Size = new Size(22, 23);
            Hide2.TabIndex = 27;
            Hide2.UseVisualStyleBackColor = true;
            Hide2.Click += Hide2_Click;
            // 
            // Hide3
            // 
            Hide3.BackgroundImage = Properties.Resources.images;
            Hide3.BackgroundImageLayout = ImageLayout.Zoom;
            Hide3.FlatStyle = FlatStyle.Flat;
            Hide3.Location = new Point(309, 80);
            Hide3.Name = "Hide3";
            Hide3.Size = new Size(22, 23);
            Hide3.TabIndex = 28;
            Hide3.UseVisualStyleBackColor = true;
            Hide3.Click += Hide3_Click;
            // 
            // Hide
            // 
            Hide.BackgroundImage = Properties.Resources.images;
            Hide.BackgroundImageLayout = ImageLayout.Zoom;
            Hide.FlatStyle = FlatStyle.Flat;
            Hide.Location = new Point(309, 22);
            Hide.Name = "Hide";
            Hide.Size = new Size(22, 23);
            Hide.TabIndex = 29;
            Hide.UseVisualStyleBackColor = true;
            Hide.Click += Hide_Click;
            // 
            // Show2
            // 
            Show2.BackgroundImage = Properties.Resources.Show;
            Show2.BackgroundImageLayout = ImageLayout.Zoom;
            Show2.FlatStyle = FlatStyle.Flat;
            Show2.Location = new Point(309, 51);
            Show2.Name = "Show2";
            Show2.Size = new Size(22, 23);
            Show2.TabIndex = 30;
            Show2.UseVisualStyleBackColor = true;
            Show2.Click += Show2_Click;
            // 
            // Show
            // 
            Show.BackgroundImage = Properties.Resources.Show;
            Show.BackgroundImageLayout = ImageLayout.Zoom;
            Show.FlatStyle = FlatStyle.Flat;
            Show.Location = new Point(309, 22);
            Show.Name = "Show";
            Show.Size = new Size(22, 23);
            Show.TabIndex = 31;
            Show.UseVisualStyleBackColor = true;
            Show.Click += Show_Click;
            // 
            // Show3
            // 
            Show3.BackgroundImage = Properties.Resources.Show;
            Show3.BackgroundImageLayout = ImageLayout.Zoom;
            Show3.FlatStyle = FlatStyle.Flat;
            Show3.Location = new Point(309, 80);
            Show3.Name = "Show3";
            Show3.Size = new Size(22, 23);
            Show3.TabIndex = 32;
            Show3.UseVisualStyleBackColor = true;
            Show3.Click += Show3_Click;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(469, 149);
            Controls.Add(Show3);
            Controls.Add(Show);
            Controls.Add(Show2);
            Controls.Add(Hide);
            Controls.Add(Hide3);
            Controls.Add(Hide2);
            Controls.Add(btnReg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NewPass2);
            Controls.Add(NewPass);
            Controls.Add(CurrentPass);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChangePass";
            RightToLeft = RightToLeft.No;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CurrentPass;
        private TextBox NewPass;
        private TextBox NewPass2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider1;
        private Button btnReg;
        private Button Hide;
        private Button Hide3;
        private Button Hide2;
        private Button Show3;
        private Button Show;
        private Button Show2;
    }
}