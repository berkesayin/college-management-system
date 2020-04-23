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
    public partial class LiteratureBooksMng : Form
    {
        public LiteratureBooksMng()
        {
            InitializeComponent();
        }

        LiteratureBooksDalMng _literatureBooksDalMng = new LiteratureBooksDalMng();
        private void btnGeneralBooksAtLiterature_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksMng generalBooksMng = new GeneralBooksMng();
            generalBooksMng.ShowDialog();
        }

        private void btnSocialAtLiterature_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksMng socialBooksMng = new SocialBooksMng();
            socialBooksMng.ShowDialog();
        }

        private void btnMathematicalAtLiterature_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksMng mathematicalBooksMng = new MathematicalBooksMng();
            mathematicalBooksMng.ShowDialog();
        }

        private void btnEnglishAtLiterature_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksMng englishBooksMng = new EnglishBooksMng();
            englishBooksMng.ShowDialog();
        }

        private void btnJournalsAtLiterature_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsMng journalsMng = new JournalsMng();
            journalsMng.ShowDialog();
        }

        private void btnNewspapersAtLiterature_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersMng newspapersMng = new NewspapersMng();
            newspapersMng.ShowDialog();
        }

        private void btnOrderListAtLiterature_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListMng orderListMng = new OrderListMng();
            orderListMng.ShowDialog();
        }

        private void btnReturnMenuLiterature_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void LiteratureBooksMng_Load(object sender, EventArgs e)
        {
            LoadLiteratureBooks();
        }

        private void LoadLiteratureBooks()
        {
            dgwLiteratureBooks.DataSource = _literatureBooksDalMng.GetAllLiteratureBooks();
        }

        private void btnAddLiteratureBooks_Click(object sender, EventArgs e)
        {
            _literatureBooksDalMng.Add(new LiteratureBooks
            {
                Id = Convert.ToInt32(tbxAddIdLiterature.Text),
                BookName = tbxAddBookNameLiterature.Text,
                LanguageOfIt = tbxAddLanguageLiterature.Text,
                KindOfBook = tbxAddKindLiterature.Text,
                AuthorName = tbxAddAuthorLiterature.Text,
                Price = Convert.ToInt32(tbxAddPriceLiterature.Text),
                Country = tbxAddCountryLiterature.Text
            });
            //İşlem bitince liste yenilensin
            LoadLiteratureBooks();
            //Kullanıcıya mesaj verelim.
            MessageBox.Show("Literature Book Added!!");

            //textbox'lardaki değerler temizlensin
            ClearAddGroup();
        }

        private void dgwLiteratureBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdLiterature.Text = dgwLiteratureBooks.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateBookNameLiterature.Text = dgwLiteratureBooks.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLanguageLiterature.Text = dgwLiteratureBooks.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateKindLiterature.Text = dgwLiteratureBooks.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAuthorNameLiterature.Text = dgwLiteratureBooks.CurrentRow.Cells[4].Value.ToString();
            tbxUpdatePriceLiterature.Text = dgwLiteratureBooks.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateCountryLiterature.Text = dgwLiteratureBooks.CurrentRow.Cells[6].Value.ToString();           
        }

        private void btnUpdateLiteratureBooks_Click(object sender, EventArgs e)
        {
            _literatureBooksDalMng.Update(new LiteratureBooks
            {
                Id = Convert.ToInt32(tbxUpdateIdLiterature.Text),
                BookName = tbxUpdateBookNameLiterature.Text,
                LanguageOfIt = tbxUpdateLanguageLiterature.Text,
                KindOfBook = tbxUpdateKindLiterature.Text,
                AuthorName = tbxUpdateAuthorNameLiterature.Text,
                Price = Convert.ToInt32(tbxUpdatePriceLiterature.Text),
                Country = tbxUpdateCountryLiterature.Text
            });
            //İşlem bitince liste yenilensin
            LoadLiteratureBooks();

            //Kullanıcıya mesaj verelim:
            MessageBox.Show("Literature Book Updated!!");

            ClearUpdateGroup();
        }

        private void btnRemoveLiteratureBooks_Click(object sender, EventArgs e)
        {
            _literatureBooksDalMng.Delete(new LiteratureBooks
            {
                Id = Convert.ToInt32(dgwLiteratureBooks.CurrentRow.Cells[0].Value.ToString())
            });
            //işlem bitince liste yenilensin :
            LoadLiteratureBooks();

            //Kullamıcıya mesaj verelim: 
            MessageBox.Show("Literature Book Deleted!!");
        }

        private void ClearAddGroup()
        {
            tbxAddIdLiterature.Text = tbxAddBookNameLiterature.Text = tbxAddLanguageLiterature.Text
                = tbxAddKindLiterature.Text = tbxAddAuthorLiterature.Text = tbxAddPriceLiterature.Text
                   = tbxAddCountryLiterature.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdLiterature.Text = tbxUpdateBookNameLiterature.Text = tbxUpdateLanguageLiterature.Text
                = tbxUpdateKindLiterature.Text = tbxUpdateAuthorNameLiterature.Text =
                tbxUpdatePriceLiterature.Text = tbxUpdateCountryLiterature.Text = " ";
        }
    }
}
