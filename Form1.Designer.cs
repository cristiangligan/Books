namespace Books
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
            this.gbxBooks = new System.Windows.Forms.GroupBox();
            this.lbxBooks = new System.Windows.Forms.ListBox();
            this.grbxProperties = new System.Windows.Forms.GroupBox();
            this.lbxAuthors = new System.Windows.Forms.ListBox();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxLanguage = new System.Windows.Forms.TextBox();
            this.lblPubDate = new System.Windows.Forms.Label();
            this.tbxPages = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.tbxPubDate = new System.Windows.Forms.TextBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.gbxBooks.SuspendLayout();
            this.grbxProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBooks
            // 
            this.gbxBooks.Controls.Add(this.lbxBooks);
            this.gbxBooks.Location = new System.Drawing.Point(563, 54);
            this.gbxBooks.Name = "gbxBooks";
            this.gbxBooks.Size = new System.Drawing.Size(200, 342);
            this.gbxBooks.TabIndex = 17;
            this.gbxBooks.TabStop = false;
            this.gbxBooks.Text = "Books";
            // 
            // lbxBooks
            // 
            this.lbxBooks.FormattingEnabled = true;
            this.lbxBooks.Location = new System.Drawing.Point(6, 19);
            this.lbxBooks.Name = "lbxBooks";
            this.lbxBooks.Size = new System.Drawing.Size(188, 316);
            this.lbxBooks.TabIndex = 0;
            // 
            // grbxProperties
            // 
            this.grbxProperties.Controls.Add(this.lbxAuthors);
            this.grbxProperties.Controls.Add(this.tbxGenre);
            this.grbxProperties.Controls.Add(this.lblTitle);
            this.grbxProperties.Controls.Add(this.tbxLanguage);
            this.grbxProperties.Controls.Add(this.lblPubDate);
            this.grbxProperties.Controls.Add(this.tbxPages);
            this.grbxProperties.Controls.Add(this.lblGenre);
            this.grbxProperties.Controls.Add(this.lblAuthors);
            this.grbxProperties.Controls.Add(this.lblPages);
            this.grbxProperties.Controls.Add(this.tbxPubDate);
            this.grbxProperties.Controls.Add(this.lblLanguage);
            this.grbxProperties.Controls.Add(this.tbxTitle);
            this.grbxProperties.Location = new System.Drawing.Point(38, 54);
            this.grbxProperties.Name = "grbxProperties";
            this.grbxProperties.Size = new System.Drawing.Size(243, 342);
            this.grbxProperties.TabIndex = 16;
            this.grbxProperties.TabStop = false;
            this.grbxProperties.Text = "Properties";
            // 
            // lbxAuthors
            // 
            this.lbxAuthors.FormattingEnabled = true;
            this.lbxAuthors.Location = new System.Drawing.Point(101, 108);
            this.lbxAuthors.Name = "lbxAuthors";
            this.lbxAuthors.Size = new System.Drawing.Size(136, 160);
            this.lbxAuthors.TabIndex = 16;
            // 
            // tbxGenre
            // 
            this.tbxGenre.Location = new System.Drawing.Point(101, 77);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(136, 20);
            this.tbxGenre.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // tbxLanguage
            // 
            this.tbxLanguage.Location = new System.Drawing.Point(101, 312);
            this.tbxLanguage.Name = "tbxLanguage";
            this.tbxLanguage.Size = new System.Drawing.Size(136, 20);
            this.tbxLanguage.TabIndex = 12;
            // 
            // lblPubDate
            // 
            this.lblPubDate.AutoSize = true;
            this.lblPubDate.Location = new System.Drawing.Point(6, 51);
            this.lblPubDate.Name = "lblPubDate";
            this.lblPubDate.Size = new System.Drawing.Size(83, 13);
            this.lblPubDate.TabIndex = 2;
            this.lblPubDate.Text = "Publication date";
            // 
            // tbxPages
            // 
            this.tbxPages.Location = new System.Drawing.Point(101, 284);
            this.tbxPages.Name = "tbxPages";
            this.tbxPages.Size = new System.Drawing.Size(136, 20);
            this.tbxPages.TabIndex = 11;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(6, 80);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre";
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Location = new System.Drawing.Point(6, 108);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(43, 13);
            this.lblAuthors.TabIndex = 4;
            this.lblAuthors.Text = "Authors";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(6, 287);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(37, 13);
            this.lblPages.TabIndex = 5;
            this.lblPages.Text = "Pages";
            // 
            // tbxPubDate
            // 
            this.tbxPubDate.Location = new System.Drawing.Point(101, 48);
            this.tbxPubDate.Name = "tbxPubDate";
            this.tbxPubDate.Size = new System.Drawing.Size(136, 20);
            this.tbxPubDate.TabIndex = 8;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(6, 315);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 6;
            this.lblLanguage.Text = "Language";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(101, 20);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(136, 20);
            this.tbxTitle.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxBooks);
            this.Controls.Add(this.grbxProperties);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxBooks.ResumeLayout(false);
            this.grbxProperties.ResumeLayout(false);
            this.grbxProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBooks;
        private System.Windows.Forms.ListBox lbxBooks;
        private System.Windows.Forms.GroupBox grbxProperties;
        private System.Windows.Forms.ListBox lbxAuthors;
        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxLanguage;
        private System.Windows.Forms.Label lblPubDate;
        private System.Windows.Forms.TextBox tbxPages;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox tbxPubDate;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.TextBox tbxTitle;
    }
}

