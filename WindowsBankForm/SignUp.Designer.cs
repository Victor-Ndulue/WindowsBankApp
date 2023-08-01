namespace WindowsBankForm
{
    partial class SignUp
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
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            EmailLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SignUpButton = new Button();
            HeaderText = new Label();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Microsoft Yi Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(42, 131);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(117, 19);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Enter Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Microsoft Yi Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(603, 298);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(114, 19);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Enter Password";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Microsoft Yi Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(296, 212);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(183, 19);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Enter your Email Address";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(603, 320);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(296, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(42, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 23);
            textBox3.TabIndex = 5;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = SystemColors.ActiveCaption;
            SignUpButton.ForeColor = SystemColors.Highlight;
            SignUpButton.Location = new Point(717, 395);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(104, 44);
            SignUpButton.TabIndex = 6;
            SignUpButton.Text = "SignUp";
            SignUpButton.UseVisualStyleBackColor = false;
            // 
            // HeaderText
            // 
            HeaderText.AutoSize = true;
            HeaderText.BackColor = Color.Transparent;
            HeaderText.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderText.ForeColor = Color.Firebrick;
            HeaderText.Location = new Point(347, 9);
            HeaderText.Name = "HeaderText";
            HeaderText.Size = new Size(331, 61);
            HeaderText.TabIndex = 7;
            HeaderText.Text = "WindowsBank";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Bankapp_background;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(844, 512);
            Controls.Add(HeaderText);
            Controls.Add(SignUpButton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(EmailLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Name = "SignUp";
            Text = "SignUp Form";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label EmailLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button SignUpButton;
        private Label HeaderText;
    }
}