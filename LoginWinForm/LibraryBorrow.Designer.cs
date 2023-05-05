namespace LibraryWinApp
{
    partial class frmLibraryBorrow
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
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.BorrowButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookList
            // 
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BorrowButton});
            this.dgvBookList.Location = new System.Drawing.Point(57, 105);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.RowTemplate.Height = 25;
            this.dgvBookList.Size = new System.Drawing.Size(684, 281);
            this.dgvBookList.TabIndex = 0;
            this.dgvBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellContentClick);
            // 
            // BorrowButton
            // 
            this.BorrowButton.HeaderText = "Borrow";
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Text = "";
            this.BorrowButton.Width = 80;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(57, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Tag = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(154, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Seach";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogout.Location = new System.Drawing.Point(666, 48);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(220, 409);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(521, 409);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 6;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // frmLibraryBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvBookList);
            this.Name = "frmLibraryBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryBorrow";
            this.Load += new System.EventHandler(this.LibraryBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBookList;
        private DataGridViewButtonColumn BorrowButton;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnLogout;
        private Button btnPrevious;
        private Button Next;
    }
}