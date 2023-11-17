namespace TopupGameApp
{
    partial class MainWeb
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
            this.NavigateBar = new System.Windows.Forms.Panel();
            this.WebName = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductView = new System.Windows.Forms.ListView();
            this.NavigateBar.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigateBar
            // 
            this.NavigateBar.BackColor = System.Drawing.Color.SpringGreen;
            this.NavigateBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NavigateBar.Controls.Add(this.WebName);
            this.NavigateBar.Controls.Add(this.btnCart);
            this.NavigateBar.Controls.Add(this.pnSearch);
            this.NavigateBar.Controls.Add(this.btnSearch);
            this.NavigateBar.Controls.Add(this.btnMainPage);
            this.NavigateBar.Controls.Add(this.btnSignup);
            this.NavigateBar.Controls.Add(this.btnLogin);
            this.NavigateBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigateBar.Location = new System.Drawing.Point(0, 0);
            this.NavigateBar.Margin = new System.Windows.Forms.Padding(2);
            this.NavigateBar.Name = "NavigateBar";
            this.NavigateBar.Size = new System.Drawing.Size(921, 86);
            this.NavigateBar.TabIndex = 0;
            // 
            // WebName
            // 
            this.WebName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WebName.AutoSize = true;
            this.WebName.Font = new System.Drawing.Font("MV Boli", 19F, System.Drawing.FontStyle.Bold);
            this.WebName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.WebName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WebName.Location = new System.Drawing.Point(273, 2);
            this.WebName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WebName.Name = "WebName";
            this.WebName.Size = new System.Drawing.Size(364, 41);
            this.WebName.TabIndex = 6;
            this.WebName.Text = "xxx TOP-UP CENTER";
            this.WebName.Click += new System.EventHandler(this.WebName_Click);
            // 
            // btnCart
            // 
            this.btnCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCart.Location = new System.Drawing.Point(825, 43);
            this.btnCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(90, 36);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "My Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // pnSearch
            // 
            this.pnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSearch.BackColor = System.Drawing.Color.White;
            this.pnSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnSearch.Controls.Add(this.SearchBox);
            this.pnSearch.Location = new System.Drawing.Point(182, 42);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(546, 36);
            this.pnSearch.TabIndex = 4;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Location = new System.Drawing.Point(0, 9);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(526, 13);
            this.SearchBox.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(731, 43);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMainPage
            // 
            this.btnMainPage.Location = new System.Drawing.Point(2, 2);
            this.btnMainPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(106, 76);
            this.btnMainPage.TabIndex = 2;
            this.btnMainPage.Text = "LOGO_placeholder";
            this.btnMainPage.UseVisualStyleBackColor = true;
            // 
            // btnSignup
            // 
            this.btnSignup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignup.Location = new System.Drawing.Point(731, 2);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(90, 36);
            this.btnSignup.TabIndex = 1;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(825, 2);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 36);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 517);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 31);
            this.panel1.TabIndex = 1;
            // 
            // ProductView
            // 
            this.ProductView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductView.HideSelection = false;
            this.ProductView.Location = new System.Drawing.Point(0, 86);
            this.ProductView.Name = "ProductView";
            this.ProductView.Size = new System.Drawing.Size(921, 431);
            this.ProductView.TabIndex = 3;
            this.ProductView.UseCompatibleStateImageBehavior = false;
            // 
            // MainWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(921, 548);
            this.Controls.Add(this.ProductView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavigateBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(700, 332);
            this.Name = "MainWeb";
            this.NavigateBar.ResumeLayout(false);
            this.NavigateBar.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigateBar;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label WebName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView ProductView;
    }
}

