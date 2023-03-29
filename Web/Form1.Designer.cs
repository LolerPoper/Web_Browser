namespace Web
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnUrl = new System.Windows.Forms.Button();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnForw = new System.Windows.Forms.Button();
            this.BtnRefr = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.Bookmarks = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 117);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1093, 519);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // BtnUrl
            // 
            this.BtnUrl.Location = new System.Drawing.Point(13, 13);
            this.BtnUrl.Name = "BtnUrl";
            this.BtnUrl.Size = new System.Drawing.Size(75, 23);
            this.BtnUrl.TabIndex = 1;
            this.BtnUrl.Text = "Search";
            this.BtnUrl.UseVisualStyleBackColor = true;
            this.BtnUrl.Click += new System.EventHandler(this.BtnUrl_Click);
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(94, 15);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(646, 20);
            this.TxtUrl.TabIndex = 2;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(13, 65);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnForw
            // 
            this.BtnForw.Location = new System.Drawing.Point(94, 65);
            this.BtnForw.Name = "BtnForw";
            this.BtnForw.Size = new System.Drawing.Size(75, 23);
            this.BtnForw.TabIndex = 4;
            this.BtnForw.Text = "Forward";
            this.BtnForw.UseVisualStyleBackColor = true;
            this.BtnForw.Click += new System.EventHandler(this.BtnForw_Click);
            // 
            // BtnRefr
            // 
            this.BtnRefr.Location = new System.Drawing.Point(323, 65);
            this.BtnRefr.Name = "BtnRefr";
            this.BtnRefr.Size = new System.Drawing.Size(75, 23);
            this.BtnRefr.TabIndex = 5;
            this.BtnRefr.Text = "Refresh";
            this.BtnRefr.UseVisualStyleBackColor = true;
            this.BtnRefr.Click += new System.EventHandler(this.BtnRefr_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(204, 65);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(75, 23);
            this.BtnHome.TabIndex = 6;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // Bookmarks
            // 
            this.Bookmarks.FormattingEnabled = true;
            this.Bookmarks.Items.AddRange(new object[] {
            "Google.com",
            "Youtube.com"});
            this.Bookmarks.Location = new System.Drawing.Point(1102, 13);
            this.Bookmarks.Name = "Bookmarks";
            this.Bookmarks.Size = new System.Drawing.Size(127, 368);
            this.Bookmarks.TabIndex = 7;
            this.Bookmarks.Click += new System.EventHandler(this.Bookmarks_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(1114, 387);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(96, 40);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add Page";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(1114, 460);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(96, 40);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 638);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Bookmarks);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.BtnRefr);
            this.Controls.Add(this.BtnForw);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.BtnUrl);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BtnUrl;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnForw;
        private System.Windows.Forms.Button BtnRefr;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.ListBox Bookmarks;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnClear;
    }
}

