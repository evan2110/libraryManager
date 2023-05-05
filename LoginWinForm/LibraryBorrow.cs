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
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryWinApp
{
    public partial class frmLibraryBorrow : Form
    {
        IBookRepository bookRepository = new BookRepository();
        BindingSource source;
        int pageNumber = 1;
        int numberRecord = 10;
        public frmLibraryBorrow()
        {
            InitializeComponent();
            dgvBookList.CellFormatting += dgvBookList_CellFormatting;
        }

        private void LibraryBorrow_Load(object sender, EventArgs e)
        {
            LoadBookList(pageNumber, numberRecord);
        }

        private void dgvBookList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBookList.Columns[e.ColumnIndex].Name == "BorrowButton")
            {
                var row = dgvBookList.Rows[e.RowIndex];
                int availableCopies = Convert.ToInt32(row.Cells["AvailableCopies"].Value);
                string title = (string)row.Cells["Title"].Value;
                DataGridViewButtonCell borrowButtonCell = row.Cells["BorrowButton"] as DataGridViewButtonCell;
                if (availableCopies <= 0 && title != null)
                {
                    borrowButtonCell.Value = "Out of Books";
                }
                
            }
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
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load book list");

            }
        }//end LoadcarList

        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvBookList.Rows[e.RowIndex];
                int availableCopies = Convert.ToInt32(row.Cells["AvailableCopies"].Value);
                if (availableCopies > 0)
                {
                    if (e.ColumnIndex == dgvBookList.Columns["BorrowButton"].Index)
                    {
                        // Lấy giá trị của ô trong cột ID tương ứng với nút mà người dùng nhấn
                        int bookId = (int)dgvBookList.Rows[e.RowIndex].Cells["BookId"].Value;


                        // ...
                        //Message Box:
                        DialogResult dr =
                        MessageBox.Show(
                            "Are you sure ?",
                            "Confirm",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            Book book = bookRepository.GetBookByID(bookId);
                            book.AvailableCopies--;
                            bookRepository.UpdateBook(book);

                            List<Book> books = bookRepository.GetBooks(pageNumber, numberRecord);
                            LoadNewData(books);
                        }

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void LoadNewData(List<Book> books)
        {
            dgvBookList.Rows.Clear();
            books = bookRepository.GetBooks(pageNumber, numberRecord);

            source = new BindingSource();
            source.DataSource = books;

            dgvBookList.DataSource = null;

            dgvBookList.DataSource = source;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            List<Book> lstBoook = bookRepository.SearchBooksByTitleOrAuthorOrPublicDateOrLocaion(search);
            dgvBookList.Rows.Clear();

            source = new BindingSource();
            source.DataSource = lstBoook;

            dgvBookList.DataSource = null;

            dgvBookList.DataSource = source;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginWinForm = new frmLogin();
            loginWinForm.ShowDialog();
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber - 1 > 0)
            {
                pageNumber--;
                LoadBookList(pageNumber, numberRecord);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            int totalRecord = 0;
            using var context = new DatabaseTestProjectContext();
            totalRecord = context.Books.Count();
            if (pageNumber - 1 < totalRecord / numberRecord)
            {
                pageNumber++;
                LoadBookList(pageNumber, numberRecord);
            }
        }
    }
}
