using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SciencesStudies.Model;

namespace SciencesStudies
{
    public partial class EnglishBooksMng : Form
    {
        public EnglishBooksMng()
        {
            InitializeComponent();
        }

        EnglishBooksDalMng _englishBooksDalMng = new EnglishBooksDalMng();
        private void btnGeneralBooksAtEnglishBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksMng generalBooksMng = new GeneralBooksMng();
            generalBooksMng.ShowDialog();
        }

        private void btnLiteratureBooksAtEnglishBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksMng literatureBooksMng = new LiteratureBooksMng();
            literatureBooksMng.ShowDialog();
        }

        private void btnSocialBooksAtEnglishBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksMng socialBooksMng = new SocialBooksMng();
            socialBooksMng.ShowDialog();
        }

        private void btnMathematicalBooksAtEnglishBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksMng mathematicalBooksMng = new MathematicalBooksMng();
            mathematicalBooksMng.ShowDialog();
        }

        private void btnJournalsAtEnglishBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsMng journalsMng = new JournalsMng();
            journalsMng.ShowDialog();
        }

        private void btnNewspapersAtEnglishBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersMng newspapersMng = new NewspapersMng();
            newspapersMng.ShowDialog();
        }

        private void btnOrderListAtEnglishBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListMng orderListMng = new OrderListMng();
            orderListMng.ShowDialog();
        }

        private void btnReturnMenuEnglishBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void EnglishBooksMng_Load(object sender, EventArgs e)
        {
            LoadEnglishBooks();
        }

        private void LoadEnglishBooks()
        {
            dgwEnglishBooks.DataSource = _englishBooksDalMng.GetAllEnglishBooks();
        }

        private void btnAddEnglishBooks_Click(object sender, EventArgs e)
        {
            _englishBooksDalMng.Add(new EnglishBooks
            {
                Id = Convert.ToInt32(tbxAddIdEnglishBooks.Text),
                BookName = tbxAddBookEnglishBooks.Text,
                LanguageOfIt = tbxAddLanguageEnglishBooks.Text,
                KindOfBook = tbxAddKindEnglishBooks.Text,
                AuthorName = tbxAddAuthorNameEnglishBooks.Text,
                Price = Convert.ToInt32(tbxAddPriceEnglishBooks.Text),
                Available = tbxAddAvailableEnglishBooks.Text
            });
            //işlem bitince liste yenilensin :
            LoadEnglishBooks();

            //Kullanıcıya mesaj verelim
            MessageBox.Show("English Book Added!!");

            ClearAddGroup();
        }

        private void dgwEnglishBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdEnglishBooks.Text = dgwEnglishBooks.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateBookNameEnglishBooks.Text = dgwEnglishBooks.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLanguageEnglishBooks.Text = dgwEnglishBooks.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateKindEnglishBooks.Text = dgwEnglishBooks.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAuthorNameEnglishBooks.Text = dgwEnglishBooks.CurrentRow.Cells[4].Value.ToString();
            tbxUpdatePriceEnglishBooks.Text = dgwEnglishBooks.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateAvailableEnglishBooks.Text = dgwEnglishBooks.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdateEnglishBooks_Click(object sender, EventArgs e)
        {
            _englishBooksDalMng.Update(new EnglishBooks
            {
                Id = Convert.ToInt32(tbxUpdateIdEnglishBooks.Text),
                BookName = tbxUpdateBookNameEnglishBooks.Text,
                LanguageOfIt = tbxUpdateLanguageEnglishBooks.Text,
                KindOfBook = tbxUpdateKindEnglishBooks.Text,
                AuthorName = tbxUpdateAuthorNameEnglishBooks.Text,
                Price = Convert.ToInt32(tbxUpdatePriceEnglishBooks.Text),
                Available = tbxUpdateAvailableEnglishBooks.Text
            });
            //işlem bitince liste yenilensin :
            LoadEnglishBooks();

            //Kullanıcıya mesaj verelim :
            MessageBox.Show("English Book Updated!!");

            ClearUpdateGroup();
        }

        private void btnRemoveEnglishBooks_Click(object sender, EventArgs e)
        {
            _englishBooksDalMng.Delete(new EnglishBooks
            {
                Id = Convert.ToInt32(dgwEnglishBooks.CurrentRow.Cells[0].Value.ToString())
            });
            //işlem bitince liste yenilensin :
            LoadEnglishBooks();

            //Kullanıcıya mesaj verelim :
            MessageBox.Show("English Book Deleted!!");
        }

        private void ClearAddGroup()
        {
            tbxAddIdEnglishBooks.Text = tbxAddBookEnglishBooks.Text = tbxAddLanguageEnglishBooks.Text =
                tbxAddKindEnglishBooks.Text = tbxAddAuthorNameEnglishBooks.Text =
                tbxAddPriceEnglishBooks.Text = tbxAddAvailableEnglishBooks.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdEnglishBooks.Text = tbxUpdateBookNameEnglishBooks.Text = tbxUpdateLanguageEnglishBooks.Text
                = tbxUpdateKindEnglishBooks.Text = tbxUpdateAuthorNameEnglishBooks.Text =
                tbxUpdatePriceEnglishBooks.Text = tbxUpdateAvailableEnglishBooks.Text = " ";
        }     
    }
}
