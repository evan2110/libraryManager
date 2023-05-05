using LibraryManage.BusinessObject;
using LibraryManage.Repository;
using LibraryWinApp;
using System.Diagnostics;

namespace LoginWinForm
{
    public partial class frmLogin : Form
    {
        IAccountRepository accountRepository = new AccountRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            Account account = new Account();
            account.Email = email;
            account.Password = password;

            Account accountFind = accountRepository.GetAccountByEmailAndPass(account);

            if (accountFind == null)
            {
                MessageBox.Show("Wrong email or password. Try again !");
            }
            else
            {
                if (accountFind.RoleId == 2)
                {
                    this.Hide(); 
                    LibraryManageForm libraryManageForm = new LibraryManageForm();
                    libraryManageForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    frmLibraryBorrow libraryBorrow = new frmLibraryBorrow();
                    libraryBorrow.ShowDialog();
                    this.Close();
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
    }
}