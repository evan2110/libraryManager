using LibraryManage.BusinessObject;
using LibraryManage.DataAccess;
using LibraryManage.Repository;
using LoginWinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinApp
{
    public partial class LibraryManageForm : Form
    {
        IBookRepository bookRepository = new BookRepository();
        BindingSource source;
        int pageNumber = 1;
        int numberRecord = 10;
        public LibraryManageForm()
        {
            InitializeComponent();
        }

        private void LibraryManageForm_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvBookList.CellDoubleClick += DgvBookList_CellDoubleClick;
        }

        private void DgvBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LibraryDetail libraryDetail = new LibraryDetail
            {
                Text = "Update book",
                InserOrUpdate = true,
                BookInfo = GetBookObject(),
                BookRepository = bookRepository
            };
            if (libraryDetail.ShowDialog() == DialogResult.OK)
            {
                LoadBookList(pageNumber, numberRecord);
                source.Position = source.Count - 1;
            }
        }

        private Book GetBookObject()
        {
            Book book = null;
            try
            {
                book = new Book
                {
                    BookId = int.Parse(txtBookId.Text),
                    Author = txtAuthor.Text,
                    AvailableCopies = int.Parse(txtAvaiCopies.Text),
                    PublicationDate = DateTime.Parse(txtPubliDate.Text),
                    ShelfLocation = txtLocation.Text,
                    Title = txtTitle.Text,
                    TotalCopies = int.Parse(txtTotal.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Book");
            }
            return book;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadBookList(pageNumber, numberRecord);
        }

        public void LoadBookList(int pageNumber, int numberRecord)
        {
            var books = bookRepository.GetBooks(pageNumber, numberRecord);
            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = books;

                txtBookId.DataBindings.Clear();
                txtAuthor.DataBindings.Clear();
                txtAvaiCopies.DataBindings.Clear();
                txtLocation.DataBindings.Clear();
                txtPubliDate.DataBindings.Clear();
                txtTitle.DataBindings.Clear();
                txtTotal.DataBindings.Clear();

                txtBookId.DataBindings.Add("Text", source, "BookId");
                txtAuthor.DataBindings.Add("Text", source, "Author");
                txtAvaiCopies.DataBindings.Add("Text", source, "AvailableCopies");
                txtLocation.DataBindings.Add("Text", source, "ShelfLocation");
                txtPubliDate.DataBindings.Add("Text", source, "PublicationDate");
                txtTitle.DataBindings.Add("Text", source, "Title");
                txtTotal.DataBindings.Add("Text", source, "TotalCopies");


                dgvBookList.DataSource = null;

                dgvBookList.DataSource = source;
                dgvBookList.Columns["BookId"].Visible = true;
                dgvBookList.Columns["Author"].Visible = true;
                dgvBookList.Columns["AvailableCopies"].Visible = true;
                dgvBookList.Columns["ShelfLocation"].Visible = true;
                dgvBookList.Columns["PublicationDate"].Visible = true;
                dgvBookList.Columns["Title"].Visible = true;
                dgvBookList.Columns["TotalCopies"].Visible = true;


                dgvBookList.Columns["BooksBorrows"].Visible = false;

                if (books.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }

                else
                {
                    btnDelete.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load book list");

            }
        }//end LoadcarList

        private void ClearText()
        {
            txtBookId.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtAvaiCopies.Text = string.Empty;
            txtLocation.Text = string.Empty;
            txtPubliDate.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtTotal.Text = string.Empty;

        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnNew_Click(object sender, EventArgs e)
        {
            LibraryDetail libraryDetail = new LibraryDetail
            {
                Text = "Add book",
                InserOrUpdate = false,
                BookRepository = bookRepository
            };
            if (libraryDetail.ShowDialog() == DialogResult.OK)
            {
                LoadBookList(pageNumber, numberRecord);
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                try
                {
                    var book = GetBookObject();
                    bookRepository.DeleteBook(book.BookId);
                    LoadBookList(pageNumber, numberRecord);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete a book");
                }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginWinForm = new frmLogin();
            loginWinForm.ShowDialog();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalRecord = 0;
            using var context = new DatabaseTestProjectContext();
            totalRecord = context.Books.Count();
            if(pageNumber - 1< totalRecord / numberRecord)
            {
                pageNumber++;
                LoadBookList(pageNumber, numberRecord);
            }
            

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
            if(pageNumber - 1 > 0)
            {
                pageNumber--;
                LoadBookList(pageNumber, numberRecord);
            }
        }
    }
}
