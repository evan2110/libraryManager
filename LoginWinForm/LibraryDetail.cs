using LibraryManage.BusinessObject;
using LibraryManage.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinApp
{
    public partial class LibraryDetail : Form
    {
        public LibraryDetail()
        {
            InitializeComponent();
        }

        public IBookRepository BookRepository { get; set; }
        public bool InserOrUpdate { get; set; } //False: Insert, True: Update
        public Book BookInfo { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var book = new Book
                {
                    BookId = int.Parse(txtBookId.Text),
                    Author = txtAuthor.Text,
                    AvailableCopies = int.Parse(txtAvaiCopies.Text),
                    PublicationDate = DateTime.Parse(txtPubliDate.Text),
                    ShelfLocation = txtLocation.Text,
                    Title = txtTitle.Text,
                    TotalCopies = int.Parse(txtTotal.Text)
                    
                };
                if (InserOrUpdate == false)
                {
                    BookRepository.InsertBook(book);
                }
                else
                {
                    BookRepository.UpdateBook(book);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InserOrUpdate == false ? "Add a new book" : "Update a book");
            }
        }

        private void LibraryDetail_Load(object sender, EventArgs e)
        {
            txtBookId.Enabled = !InserOrUpdate;
            if (InserOrUpdate == true) //Update mode
            {
                txtBookId.Text = BookInfo.BookId.ToString();
                txtAuthor.Text = BookInfo.Author;
                txtAvaiCopies.Text = BookInfo.AvailableCopies.ToString();
                txtLocation.Text = BookInfo.ShelfLocation;
                txtPubliDate.Text = BookInfo.PublicationDate.ToString();
                txtTitle.Text = BookInfo.Title;
                txtTotal.Text = BookInfo.TotalCopies.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
        
    }
}
