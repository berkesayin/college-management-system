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
    public partial class MathematicalBooksMng : Form
    {
        public MathematicalBooksMng()
        {
            InitializeComponent();
        }

        MathematicalBooksDalMng _mathematicalBooksDalMng = new MathematicalBooksDalMng();
        private void btnGeneralBooksAtMathematicalBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksMng generalBooksMng = new GeneralBooksMng();
            generalBooksMng.ShowDialog();
        }

        private void btnLiteratureBooksAtMathematicalBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksMng literatureBooksMng = new LiteratureBooksMng();
            literatureBooksMng.ShowDialog();
        }

        private void btnSocialBooksAtMathematicalBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksMng socialBooksMng = new SocialBooksMng();
            socialBooksMng.ShowDialog();
        }

        private void btnEnglishBooksAtMathematicalBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksMng englishBooksMng = new EnglishBooksMng();
            englishBooksMng.ShowDialog();

        }

        private void btnJournalsAtSMathematicalBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsMng journalsMng = new JournalsMng();
            journalsMng.ShowDialog();
        }

        private void btnNewspapersAtMathematicalBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersMng newspapersMng = new NewspapersMng();
            newspapersMng.ShowDialog();
        }

        private void btnOrderListAtMathematicalBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListMng orderListMng = new OrderListMng();
            orderListMng.ShowDialog();
        }

        private void btnReturnMenuMathematicalBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void MathematicalBooksMng_Load(object sender, EventArgs e)
        {
            LoadMathematicalBooks();
        }

        private void LoadMathematicalBooks()
        {
            dgwMathematicalBooks.DataSource = _mathematicalBooksDalMng.GetAllMathematicalBooks();
        }

        private void btnAddMathematicalBooks_Click(object sender, EventArgs e)
        {
            _mathematicalBooksDalMng.Add(new MathematicalBooks
            {
                Id = Convert.ToInt32(tbxAddIdMathematicalBooks.Text),
                BookName = tbxAddBookNameMathematicalBooks.Text,
                LanguageOfIt = tbxAddLanguageMathematicalBooks.Text,
                KindOfBook = tbxAddKindMathematicalBooks.Text,
                AuthorName = tbxAddAuthorNameMathematicalBooks.Text,
                Price = Convert.ToInt32(tbxAddPriceMathematicalBooks.Text),
                Branch = tbxAddBranchMathematicalBooks.Text
            });
            //İşlem bitince liste yenilensin:
            LoadMathematicalBooks();

            //Kullanıcıya mesaj verelim :
            MessageBox.Show("Mathematical Book Added!!");

            ClearAddGroup();
        }

        private void dgwMathematicalBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdMathematicalBooks.Text = dgwMathematicalBooks.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateBookNameMathematicalBooks.Text = dgwMathematicalBooks.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLanguageMathematicalBooks.Text = dgwMathematicalBooks.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateKindMathematicalBooks.Text = dgwMathematicalBooks.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAuthorNameMathematicalBooks.Text = dgwMathematicalBooks.CurrentRow.Cells[4].Value.ToString();
            tbxUpdatePriceMathematicalBooks.Text = dgwMathematicalBooks.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateBranchMathematicalBooks.Text = dgwMathematicalBooks.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdateMathematicalBooks_Click(object sender, EventArgs e)
        {
            _mathematicalBooksDalMng.Update(new MathematicalBooks
            {
                Id = Convert.ToInt32(tbxUpdateIdMathematicalBooks.Text),
                BookName = tbxUpdateBookNameMathematicalBooks.Text,
                LanguageOfIt = tbxUpdateLanguageMathematicalBooks.Text,
                KindOfBook = tbxUpdateKindMathematicalBooks.Text,
                AuthorName = tbxUpdateAuthorNameMathematicalBooks.Text,
                Price = Convert.ToInt32(tbxUpdatePriceMathematicalBooks.Text),
                Branch = tbxUpdateBranchMathematicalBooks.Text
            });
            //İşlem bitince liste yenilensin :
            LoadMathematicalBooks();

            //Kullanıcıya mesaj verelim :
            MessageBox.Show("Mathematical Book Updated!!");

            ClearUpdateGroup();
        }

        private void btnRemoveMathematicalBooks_Click(object sender, EventArgs e)
        {
            _mathematicalBooksDalMng.Delete(new MathematicalBooks
            {
                Id = Convert.ToInt32(dgwMathematicalBooks.CurrentRow.Cells[0].Value.ToString())
            });
            //işlem bitince liste yenilensin :
            LoadMathematicalBooks();

            //kullanıcıya mesaj verelim:
            MessageBox.Show("Mathematical Book Deleted!!");
        }

        private void ClearAddGroup()
        {
            tbxAddIdMathematicalBooks.Text = tbxAddBookNameMathematicalBooks.Text =
                tbxAddLanguageMathematicalBooks.Text = tbxAddKindMathematicalBooks.Text =
                tbxAddAuthorNameMathematicalBooks.Text = tbxAddPriceMathematicalBooks.Text
                = tbxAddBranchMathematicalBooks.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdMathematicalBooks.Text = tbxUpdateBookNameMathematicalBooks.Text
                = tbxUpdateLanguageMathematicalBooks.Text = tbxUpdateKindMathematicalBooks.Text
                = tbxUpdateAuthorNameMathematicalBooks.Text = tbxUpdatePriceMathematicalBooks.Text
                = tbxUpdateBranchMathematicalBooks.Text = " ";
        }
    }
}
