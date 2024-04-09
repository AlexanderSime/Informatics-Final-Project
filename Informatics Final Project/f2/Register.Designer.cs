namespace f2
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usBox = new TextBox();
            passBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            sizeL = new Label();
            upperL = new Label();
            lowerL = new Label();
            numL = new Label();
            passCritL = new Label();
            emailBox = new TextBox();
            genderBox = new ComboBox();
            phoneBox = new TextBox();
            linkLabel1 = new LinkLabel();
            firstNameBox = new TextBox();
            lastNameBox = new TextBox();
            SuspendLayout();
            // 
            // usBox
            // 
            usBox.ForeColor = Color.Gray;
            usBox.Location = new Point(156, 178);
            usBox.Name = "usBox";
            usBox.Size = new Size(193, 23);
            usBox.TabIndex = 0;
            usBox.Text = "Username";
            usBox.MouseClick += usBox_MouseClick;
            usBox.Validating += usBox_Validating;
            // 
            // passBox
            // 
            passBox.ForeColor = Color.Gray;
            passBox.Location = new Point(157, 350);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(193, 23);
            passBox.TabIndex = 1;
            passBox.Text = "Password";
            passBox.MouseClick += passBox_MouseClick;
            passBox.TextChanged += passBox_TextChanged;
            passBox.Validating += passBox_Validating;
            // 
            // button1
            // 
            button1.Location = new Point(157, 379);
            button1.Name = "button1";
            button1.Size = new Size(193, 23);
            button1.TabIndex = 2;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(156, 135);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 3;
            label1.Text = "Welcome";
            // 
            // sizeL
            // 
            sizeL.AutoSize = true;
            sizeL.ForeColor = Color.Red;
            sizeL.Location = new Point(157, 463);
            sizeL.Name = "sizeL";
            sizeL.Size = new Size(128, 15);
            sizeL.TabIndex = 4;
            sizeL.Text = "More than 8 characters";
            sizeL.Visible = false;
            // 
            // upperL
            // 
            upperL.AutoSize = true;
            upperL.ForeColor = Color.Red;
            upperL.Location = new Point(157, 488);
            upperL.Name = "upperL";
            upperL.Size = new Size(164, 15);
            upperL.TabIndex = 5;
            upperL.Text = "At least 1 uppercase character";
            upperL.Visible = false;
            // 
            // lowerL
            // 
            lowerL.AutoSize = true;
            lowerL.ForeColor = Color.Red;
            lowerL.Location = new Point(157, 515);
            lowerL.Name = "lowerL";
            lowerL.Size = new Size(162, 15);
            lowerL.TabIndex = 6;
            lowerL.Text = "At least 1 lowercase character";
            lowerL.Visible = false;
            // 
            // numL
            // 
            numL.AutoSize = true;
            numL.ForeColor = Color.Red;
            numL.Location = new Point(157, 543);
            numL.Name = "numL";
            numL.Size = new Size(100, 15);
            numL.TabIndex = 7;
            numL.Text = "At least 1 number";
            numL.Visible = false;
            // 
            // passCritL
            // 
            passCritL.AutoSize = true;
            passCritL.ForeColor = Color.Green;
            passCritL.Location = new Point(157, 439);
            passCritL.Name = "passCritL";
            passCritL.Size = new Size(99, 15);
            passCritL.TabIndex = 8;
            passCritL.Text = "Password criteria:";
            passCritL.Visible = false;
            // 
            // emailBox
            // 
            emailBox.ForeColor = Color.Gray;
            emailBox.Location = new Point(156, 207);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(193, 23);
            emailBox.TabIndex = 9;
            emailBox.Text = "Email";
            emailBox.MouseClick += emailBox_MouseClick;
            emailBox.Validating += emailBox_Validating;
            // 
            // genderBox
            // 
            genderBox.ForeColor = Color.Gray;
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "Male", "Female" });
            genderBox.Location = new Point(157, 294);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(193, 23);
            genderBox.TabIndex = 11;
            genderBox.Text = "Gender";
            genderBox.Validating += comboBox1_Validating;
            // 
            // phoneBox
            // 
            phoneBox.ForeColor = Color.Gray;
            phoneBox.Location = new Point(157, 323);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(194, 23);
            phoneBox.TabIndex = 12;
            phoneBox.Text = "Phone number";
            phoneBox.MouseClick += phoneBox_MouseClick;
            phoneBox.Validating += phoneBox_Validating;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.Black;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(214, 405);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(81, 15);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log in instead";
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // firstNameBox
            // 
            firstNameBox.ForeColor = Color.Gray;
            firstNameBox.Location = new Point(157, 236);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(193, 23);
            firstNameBox.TabIndex = 14;
            firstNameBox.Text = "First Name";
            // 
            // lastNameBox
            // 
            lastNameBox.ForeColor = Color.Gray;
            lastNameBox.Location = new Point(157, 265);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(193, 23);
            lastNameBox.TabIndex = 15;
            lastNameBox.Text = "Last Name";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 683);
            Controls.Add(lastNameBox);
            Controls.Add(firstNameBox);
            Controls.Add(linkLabel1);
            Controls.Add(phoneBox);
            Controls.Add(genderBox);
            Controls.Add(emailBox);
            Controls.Add(passCritL);
            Controls.Add(numL);
            Controls.Add(lowerL);
            Controls.Add(upperL);
            Controls.Add(sizeL);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(passBox);
            Controls.Add(usBox);
            Name = "Register";
            Text = "Form1";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usBox;
        private TextBox passBox;
        private Button button1;
        private Label label1;
        private Label sizeL;
        private Label upperL;
        private Label lowerL;
        private Label numL;
        private Label passCritL;
        private TextBox emailBox;
        private ComboBox genderBox;
        private TextBox phoneBox;
        private Label label2;
        private LinkLabel linkLabel1;
        private TextBox firstNameBox;
        private TextBox lastNameBox;
    }
}