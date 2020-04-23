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
    public partial class SocialBooksMng : Form
    {
        public SocialBooksMng()
        {
            InitializeComponent();
        }

        SocialBooksDalMng _socialBooksDalMng = new SocialBooksDalMng();
        private void btnGeneralBooksAtSocialBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksMng generalBooksMng = new GeneralBooksMng();
            generalBooksMng.ShowDialog();
        }

        private void btnLiteratureAtSocialBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksMng literatureBooksMng = new LiteratureBooksMng();
            literatureBooksMng.ShowDialog();
        }

        private void btnMathematicalBooksAtSocialBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksMng mathematicalBooksMng = new MathematicalBooksMng();
            mathematicalBooksMng.ShowDialog();
        }

        private void btnEnglishBooksAtSocial_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksMng englishBooksMng = new EnglishBooksMng();
            englishBooksMng.ShowDialog();
        }

        private void btnJournalsAtSocial_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsMng journalsMng = new JournalsMng();
            journalsMng.ShowDialog();
        }

        private void btnNewspapersAtSocial_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersMng newspapersMng = new NewspapersMng();
            newspapersMng.ShowDialog();
        }

        private void btnOrderListAtSocial_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListMng orderListMng = new OrderListMng();
            orderListMng.ShowDialog();
        }

        private void btnReturnMenuSocial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void SocialBooksMng_Load(object sender, EventArgs e)
        {
            LoadSocialBooks();
        }

        private void LoadSocialBooks()
        {
            dgwSocialBooks.DataSource = _socialBooksDalMng.GetAllSocialBooks();
        }

        private void btnAddSocialBooks_Click(object sender, EventArgs e)
        {
            _socialBooksDalMng.Add(new SocialBooks
            {
                Id = Convert.ToInt32(tbxAddIdSocial.Text),
                BookName = tbxAddBookNameSocial.Text,
                LanguageOfIt = tbxAddLanguageSocial.Text,
                KindOfBook = tbxAddKindSocial.Text,
                AuthorName = tbxAddAuthorNameSocial.Text,
                Price = Convert.ToInt32(tbxAddPriceSocial.Text),
                Branch = tbxAddBranchSocial.Text
            });
            //İşlem bitince liste yenilensin :
            LoadSocialBooks();

            //Kullanıcıya mesaj verilsin :
            MessageBox.Show("Social Book Added!!");

            ClearAddGroup();
        }

        private void dgwSocialBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdSocial.Text = dgwSocialBooks.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateBookNameSocial.Text = dgwSocialBooks.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLanguageSocial.Text = dgwSocialBooks.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateKindSocial.Text = dgwSocialBooks.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAuthorNameSocial.Text = dgwSocialBooks.CurrentRow.Cells[4].Value.ToString();
            tbxUpdatePriceSocial.Text = dgwSocialBooks.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateBranchSocial.Text = dgwSocialBooks.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdateSocialBooks_Click(object sender, EventArgs e)
        {
            _socialBooksDalMng.Update(new SocialBooks
            {
                Id = Convert.ToInt32(tbxUpdateIdSocial.Text),
                BookName = tbxUpdateBookNameSocial.Text,
                LanguageOfIt = tbxUpdateLanguageSocial.Text,
                KindOfBook = tbxUpdateKindSocial.Text,
                AuthorName = tbxUpdateAuthorNameSocial.Text,
                Price = Convert.ToInt32(tbxUpdatePriceSocial.Text),
                Branch = tbxUpdateBranchSocial.Text
            });
            //İşlem bitince liste yenilensin
            LoadSocialBooks();

            //Kullanıcıya mesaj verelim :
            MessageBox.Show("Social Book Updated!!");

            ClearUpdateGroup();
        }

        private void btnRemoveSocialBooks_Click(object sender, EventArgs e)
        {
            _socialBooksDalMng.Delete(new SocialBooks
            {
                Id = Convert.ToInt32(dgwSocialBooks.CurrentRow.Cells[0].Value.ToString())
            });
            //işlem bitince liste yenilensin :
            LoadSocialBooks();

            MessageBox.Show("Social Book Deleted!!");

        }

        private void ClearAddGroup()
        {
            tbxAddIdSocial.Text = tbxAddBookNameSocial.Text = tbxAddLanguageSocial.Text =
                tbxAddKindSocial.Text = tbxAddAuthorNameSocial.Text = tbxAddPriceSocial.Text
                = tbxAddBranchSocial.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdSocial.Text = tbxUpdateBookNameSocial.Text = tbxUpdateLanguageSocial.Text
                = tbxUpdateKindSocial.Text = tbxUpdateAuthorNameSocial.Text = tbxUpdatePriceSocial.Text
                = tbxUpdateBranchSocial.Text = " ";
        }
    }
}
