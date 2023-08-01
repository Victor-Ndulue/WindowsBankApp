namespace WindowsBankForm
{
    partial class WindowsBankForm
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
            HeaderText = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            LogInButton = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            SignUpButton = new Button();
            SuspendLayout();
            // 
            // HeaderText
            // 
            HeaderText.AutoSize = true;
            HeaderText.BackColor = Color.Transparent;
            HeaderText.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderText.ForeColor = Color.Firebrick;
            HeaderText.Location = new Point(364, 9);
            HeaderText.Name = "HeaderText";
            HeaderText.Size = new Size(331, 61);
            HeaderText.TabIndex = 1;
            HeaderText.Text = "WindowsBank";
            HeaderText.Click += HeaderText_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gabriola", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(37, 49);
            label1.Name = "label1";
            label1.Size = new Size(126, 59);
            label1.TabIndex = 2;
            label1.Text = "Welcome,";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(367, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 25);
            textBox1.TabIndex = 3;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = SystemColors.InactiveCaption;
            LogInButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogInButton.Location = new Point(484, 311);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(104, 40);
            LogInButton.TabIndex = 4;
            LogInButton.Text = "Login";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(385, 137);
            label2.Name = "label2";
            label2.Size = new Size(298, 32);
            label2.TabIndex = 5;
            label2.Text = "Enter your Email address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Firebrick;
            label3.Location = new Point(410, 224);
            label3.Name = "label3";
            label3.Size = new Size(249, 32);
            label3.TabIndex = 7;
            label3.Text = "Enter your Password";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(367, 259);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(328, 25);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = SystemColors.InactiveCaption;
            SignUpButton.Cursor = Cursors.AppStarting;
            SignUpButton.FlatStyle = FlatStyle.Popup;
            SignUpButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SignUpButton.Location = new Point(484, 389);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(104, 40);
            SignUpButton.TabIndex = 8;
            SignUpButton.Text = "Register";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // WindowsBankForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = Properties.Resources.Bankapp_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1065, 450);
            Controls.Add(SignUpButton);
            Controls.Add(LogInButton);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(HeaderText);
            ForeColor = SystemColors.Highlight;
            Name = "WindowsBankForm";
            Text = "WindowsBank";
            Load += WindowsBankForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label HeaderText;
        private Label label1;
        private TextBox textBox1;
        private Button LogInButton;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button SignUpButton;
    }
}