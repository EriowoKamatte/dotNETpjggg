namespace TopupGameApp
{
    partial class SignupForm
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
            this.SignUplb = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Emaillb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUplb
            // 
            this.SignUplb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUplb.AutoSize = true;
            this.SignUplb.Location = new System.Drawing.Point(218, 60);
            this.SignUplb.Name = "SignUplb";
            this.SignUplb.Size = new System.Drawing.Size(51, 13);
            this.SignUplb.TabIndex = 0;
            this.SignUplb.Text = "SIGN UP";
            this.SignUplb.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(148, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 184);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(222, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 148);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Emaillb
            // 
            this.Emaillb.AutoSize = true;
            this.Emaillb.Location = new System.Drawing.Point(77, 112);
            this.Emaillb.Name = "Emaillb";
            this.Emaillb.Size = new System.Drawing.Size(35, 13);
            this.Emaillb.TabIndex = 5;
            this.Emaillb.Text = "Email:";
            this.Emaillb.Click += new System.EventHandler(this.Emaillb_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(139, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(273, 242);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(75, 23);
            this.btnSignup.TabIndex = 8;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 353);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Emaillb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.SignUplb);
            this.Name = "SignupForm";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUplb;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Emaillb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSignup;
    }
}