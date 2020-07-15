namespace library_final
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.libraryMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMemberInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookRentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeABookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryMembersToolStripMenuItem,
            this.libraryRentalsToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // libraryMembersToolStripMenuItem
            // 
            this.libraryMembersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMembersToolStripMenuItem,
            this.insertNewMemberToolStripMenuItem,
            this.updateMemberInfoToolStripMenuItem,
            this.deleteMemberToolStripMenuItem});
            this.libraryMembersToolStripMenuItem.Name = "libraryMembersToolStripMenuItem";
            this.libraryMembersToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.libraryMembersToolStripMenuItem.Text = "Library Members";
            // 
            // viewMembersToolStripMenuItem
            // 
            this.viewMembersToolStripMenuItem.Name = "viewMembersToolStripMenuItem";
            this.viewMembersToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewMembersToolStripMenuItem.Text = "View Members";
            this.viewMembersToolStripMenuItem.Click += new System.EventHandler(this.viewMembersToolStripMenuItem_Click);
            // 
            // insertNewMemberToolStripMenuItem
            // 
            this.insertNewMemberToolStripMenuItem.Name = "insertNewMemberToolStripMenuItem";
            this.insertNewMemberToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.insertNewMemberToolStripMenuItem.Text = "Add New Member";
            this.insertNewMemberToolStripMenuItem.Click += new System.EventHandler(this.insertNewMemberToolStripMenuItem_Click);
            // 
            // updateMemberInfoToolStripMenuItem
            // 
            this.updateMemberInfoToolStripMenuItem.Name = "updateMemberInfoToolStripMenuItem";
            this.updateMemberInfoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.updateMemberInfoToolStripMenuItem.Text = "Update Member Info";
            this.updateMemberInfoToolStripMenuItem.Click += new System.EventHandler(this.updateMemberInfoToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deleteMemberToolStripMenuItem.Text = "Delete Member";
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // libraryRentalsToolStripMenuItem
            // 
            this.libraryRentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBookRentalsToolStripMenuItem,
            this.rentABookToolStripMenuItem,
            this.updateBookRentalToolStripMenuItem,
            this.deleteBookRentalToolStripMenuItem});
            this.libraryRentalsToolStripMenuItem.Name = "libraryRentalsToolStripMenuItem";
            this.libraryRentalsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.libraryRentalsToolStripMenuItem.Text = "Library Rentals";
            // 
            // viewBookRentalsToolStripMenuItem
            // 
            this.viewBookRentalsToolStripMenuItem.Name = "viewBookRentalsToolStripMenuItem";
            this.viewBookRentalsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewBookRentalsToolStripMenuItem.Text = "View Book Rentals";
            this.viewBookRentalsToolStripMenuItem.Click += new System.EventHandler(this.viewBookRentalsToolStripMenuItem_Click);
            // 
            // rentABookToolStripMenuItem
            // 
            this.rentABookToolStripMenuItem.Name = "rentABookToolStripMenuItem";
            this.rentABookToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.rentABookToolStripMenuItem.Text = "Rent Book";
            this.rentABookToolStripMenuItem.Click += new System.EventHandler(this.rentABookToolStripMenuItem_Click);
            // 
            // updateBookRentalToolStripMenuItem
            // 
            this.updateBookRentalToolStripMenuItem.Name = "updateBookRentalToolStripMenuItem";
            this.updateBookRentalToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.updateBookRentalToolStripMenuItem.Text = "Update Book Rental";
            this.updateBookRentalToolStripMenuItem.Click += new System.EventHandler(this.updateBookRentalToolStripMenuItem_Click);
            // 
            // deleteBookRentalToolStripMenuItem
            // 
            this.deleteBookRentalToolStripMenuItem.Name = "deleteBookRentalToolStripMenuItem";
            this.deleteBookRentalToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.deleteBookRentalToolStripMenuItem.Text = "Delete Book Rental";
            this.deleteBookRentalToolStripMenuItem.Click += new System.EventHandler(this.deleteBookRentalToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllBooksToolStripMenuItem,
            this.addABookToolStripMenuItem,
            this.updateABookToolStripMenuItem,
            this.removeABookToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // viewAllBooksToolStripMenuItem
            // 
            this.viewAllBooksToolStripMenuItem.Name = "viewAllBooksToolStripMenuItem";
            this.viewAllBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewAllBooksToolStripMenuItem.Text = "View All Books";
            this.viewAllBooksToolStripMenuItem.Click += new System.EventHandler(this.viewAllBooksToolStripMenuItem_Click);
            // 
            // addABookToolStripMenuItem
            // 
            this.addABookToolStripMenuItem.Name = "addABookToolStripMenuItem";
            this.addABookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addABookToolStripMenuItem.Text = "Add Book";
            this.addABookToolStripMenuItem.Click += new System.EventHandler(this.addABookToolStripMenuItem_Click);
            // 
            // updateABookToolStripMenuItem
            // 
            this.updateABookToolStripMenuItem.Name = "updateABookToolStripMenuItem";
            this.updateABookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateABookToolStripMenuItem.Text = "Update Book";
            this.updateABookToolStripMenuItem.Click += new System.EventHandler(this.updateABookToolStripMenuItem_Click);
            // 
            // removeABookToolStripMenuItem
            // 
            this.removeABookToolStripMenuItem.Name = "removeABookToolStripMenuItem";
            this.removeABookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeABookToolStripMenuItem.Text = "Remove Book";
            this.removeABookToolStripMenuItem.Click += new System.EventHandler(this.removeABookToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library Manager 1.0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(19, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 333);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Members";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(749, 295);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Book Rentals";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.LabelEdit = true;
            this.listView2.Location = new System.Drawing.Point(6, 6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(749, 295);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(761, 307);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Books";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.LabelEdit = true;
            this.listView3.Location = new System.Drawing.Point(6, 6);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(749, 295);
            this.listView3.TabIndex = 5;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designed and Coded by Jackson";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(320, 50);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Manager 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem libraryMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libraryRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem viewMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNewMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMemberInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookRentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateABookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeABookToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

