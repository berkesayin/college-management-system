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
    public partial class GeneralBooksMng : Form
    {
        public GeneralBooksMng()
        {
            InitializeComponent();
        }

        GeneralBooksDalMng _generalBooksDalMng = new GeneralBooksDalMng();
        private void btnLiteratureAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksMng literatureBooksMng = new LiteratureBooksMng();
            literatureBooksMng.ShowDialog();
        }

        private void btnSocialAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksMng socialBooksMng = new SocialBooksMng();
            socialBooksMng.ShowDialog();
        }

        private void btnMathematicalAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksMng mathematicalBooksMng = new MathematicalBooksMng();
            mathematicalBooksMng.ShowDialog();
        }

        private void btnEnglishAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksMng englishBooksMng = new EnglishBooksMng();
            englishBooksMng.ShowDialog();
        }

        private void btnJournalsAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsMng journalsMng = new JournalsMng();
            journalsMng.ShowDialog();
        }

        private void btnNewspapersAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersMng newspapersMng = new NewspapersMng();
            newspapersMng.ShowDialog();
        }

        private void btnOrderListAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListMng orderListMng = new OrderListMng();
            orderListMng.ShowDialog();
        }

        private void btnReturnMenuGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void GeneralBooksMng_Load(object sender, EventArgs e)
        {
            LoadGeneralBooks();
        }

        private void LoadGeneralBooks()
        {
            dgwGeneralBooks.DataSource = _generalBooksDalMng.GetAllGeneralBooks();
        }

        private void btnAddGeneralBooks_Click(object sender, EventArgs e)
        {
            _generalBooksDalMng.Add(new GeneralBooks
            {
                Id = Convert.ToInt32(tbxAddIdGeneralBooks.Text),
                BookName = tbxAddBookNameGeneralBooks.Text,
                LanguageOfIt = tbxAddLanguageGeneralBooks.Text,
                KindOfBook = tbxAddKindGeneralBooks.Text,
                AuthorName = tbxAddAuthorNameGeneralBooks.Text,
                Price = Convert.ToInt32(tbxAddPriceGeneralBooks.Text)
            });
            //Ekleme işlemi bitince liste yenilensin
            LoadGeneralBooks();

            //Kullanıcıya mesaj verilsin:
            MessageBox.Show("New Book Added!!");

            ClearAddGroup();

        }

        private void dgwGeneralBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdGeneralBooks.Text = dgwGeneralBooks.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateBookNameGeneralBooks.Text = dgwGeneralBooks.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLanguageGeneralBooks.Text = dgwGeneralBooks.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateKindGeneralBooks.Text = dgwGeneralBooks.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAuthorNameGeneralBooks.Text = dgwGeneralBooks.CurrentRow.Cells[4].Value.ToString();
            tbxUpdatePriceGeneralBooks.Text = dgwGeneralBooks.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdateGeneralBooks_Click(object sender, EventArgs e)
        {
            _generalBooksDalMng.Update(new GeneralBooks
            {
                Id = Convert.ToInt32(tbxUpdateIdGeneralBooks.Text),
                BookName = tbxUpdateBookNameGeneralBooks.Text,
                LanguageOfIt = tbxUpdateLanguageGeneralBooks.Text,
                KindOfBook = tbxUpdateKindGeneralBooks.Text,
                AuthorName = tbxUpdateAuthorNameGeneralBooks.Text,
                Price = Convert.ToInt32(tbxUpdatePriceGeneralBooks.Text)
            });
            //İşlem bitince liste yenilensin.
            LoadGeneralBooks();

            //Kullnıcıya mesaj verelim.
            MessageBox.Show("Book Updated!!");

            ClearUpdateGroup();
        }

        private void btnRemoveGeneralBooks_Click(object sender, EventArgs e)
        {
            _generalBooksDalMng.Delete(new GeneralBooks
            {
                Id = Convert.ToInt32(dgwGeneralBooks.CurrentRow.Cells[0].Value.ToString())
            });
            //İşlem bitince liste yenilensin :
            LoadGeneralBooks();
            //Kullanıcıya mesaj verelim :
            MessageBox.Show("Book Deleted!!");
        }

        private void ClearAddGroup()
        {
            tbxAddIdGeneralBooks.Text = tbxAddBookNameGeneralBooks.Text = tbxAddLanguageGeneralBooks.Text
                = tbxAddKindGeneralBooks.Text = tbxAddAuthorNameGeneralBooks.Text = tbxAddPriceGeneralBooks.Text
                = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdGeneralBooks.Text = tbxUpdateBookNameGeneralBooks.Text =
                tbxUpdateLanguageGeneralBooks.Text = tbxUpdateKindGeneralBooks.Text
                = tbxUpdateAuthorNameGeneralBooks.Text = tbxUpdatePriceGeneralBooks.Text = " ";
        }
    }
}
