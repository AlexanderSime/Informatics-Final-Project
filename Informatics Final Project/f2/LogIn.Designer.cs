namespace f2
{
    partial class LogIn
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
            usBox = new TextBox();
            passBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // usBox
            // 
            usBox.ForeColor = Color.Gray;
            usBox.Location = new Point(226, 294);
            usBox.Name = "usBox";
            usBox.Size = new Size(193, 23);
            usBox.TabIndex = 1;
            usBox.Text = "Username";
            usBox.MouseClick += usBox_MouseClick;
            usBox.Validating += usBox_Validating;
            // 
            // passBox
            // 
            passBox.ForeColor = Color.Gray;
            passBox.Location = new Point(226, 323);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(193, 23);
            passBox.TabIndex = 2;
            passBox.Text = "Password";
            passBox.MouseClick += passBox_MouseClick;
            passBox.Validating += passBox_Validating;
            // 
            // button1
            // 
            button1.Location = new Point(226, 352);
            button1.Name = "button1";
            button1.Size = new Size(193, 23);
            button1.TabIndex = 3;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(226, 250);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 4;
            label1.Text = "Welcome Back";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 693);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(passBox);
            Controls.Add(usBox);
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usBox;
        private TextBox passBox;
        private Button button1;
        private Label label1;
    }
}