namespace LibraryWinApp
{
    partial class LibraryDetail
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
            this.txtAvaiCopies = new System.Windows.Forms.TextBox();
            this.txtPubliDate = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAvaiCopies
            // 
            this.txtAvaiCopies.Location = new System.Drawing.Point(516, 120);
            this.txtAvaiCopies.Name = "txtAvaiCopies";
            this.txtAvaiCopies.Size = new System.Drawing.Size(250, 23);
            this.txtAvaiCopies.TabIndex = 27;
            // 
            // txtPubliDate
            // 
            this.txtPubliDate.Location = new System.Drawing.Point(516, 219);
            this.txtPubliDate.Name = "txtPubliDate";
            this.txtPubliDate.Size = new System.Drawing.Size(250, 23);
            this.txtPubliDate.TabIndex = 26;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(131, 211);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(250, 23);
            this.txtTitle.TabIndex = 25;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(131, 162);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(250, 23);
            this.txtAuthor.TabIndex = 24;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(516, 170);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(250, 23);
            this.txtLocation.TabIndex = 23;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(131, 112);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(250, 23);
            this.txtBookId.TabIndex = 22;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(131, 255);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(250, 23);
            this.txtTotal.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Copies";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Publication Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Shelf Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Available Copies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Book ID";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(263, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 29);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(416, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 26);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LibraryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAvaiCopies);
            this.Controls.Add(this.txtPubliDate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LibraryDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryDetail";
            this.Load += new System.EventHandler(this.LibraryDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAvaiCopies;
        private TextBox txtPubliDate;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtLocation;
        private TextBox txtBookId;
        private TextBox txtTotal;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}