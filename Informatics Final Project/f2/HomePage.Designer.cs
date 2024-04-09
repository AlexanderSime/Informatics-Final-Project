namespace f2
{
    partial class HomePage
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
            label1 = new Label();
            welcomeLabel = new Label();
            imgUpload = new Button();
            pictureBox1 = new PictureBox();
            genderLabel = new Label();
            phoneNumberLabel = new Label();
            emailLabel = new Label();
            bdayLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 205);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(217, 66);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(103, 30);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "Welcome";
            // 
            // imgUpload
            // 
            imgUpload.Location = new Point(244, 322);
            imgUpload.Name = "imgUpload";
            imgUpload.Size = new Size(117, 23);
            imgUpload.TabIndex = 5;
            imgUpload.Text = "Upload Image";
            imgUpload.UseCompatibleTextRendering = true;
            imgUpload.UseVisualStyleBackColor = true;
            imgUpload.MouseClick += uploadBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.profile_icon_9;
            pictureBox1.InitialImage = Properties.Resources.profpic1;
            pictureBox1.Location = new Point(199, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(206, 390);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(0, 15);
            genderLabel.TabIndex = 7;
            genderLabel.UseMnemonic = false;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(206, 420);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(0, 15);
            phoneNumberLabel.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(206, 451);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(0, 15);
            emailLabel.TabIndex = 9;
            // 
            // bdayLabel
            // 
            bdayLabel.AutoSize = true;
            bdayLabel.Location = new Point(206, 482);
            bdayLabel.Name = "bdayLabel";
            bdayLabel.Size = new Size(0, 15);
            bdayLabel.TabIndex = 10;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 581);
            Controls.Add(bdayLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(genderLabel);
            Controls.Add(pictureBox1);
            Controls.Add(imgUpload);
            Controls.Add(welcomeLabel);
            Controls.Add(label1);
            Name = "HomePage";
            Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label welcomeLabel;
        private Button imgUpload;
        private PictureBox pictureBox1;
        private Label genderLabel;
        private Label phoneNumberLabel;
        private Label emailLabel;
        private Label bdayLabel;
    }
}