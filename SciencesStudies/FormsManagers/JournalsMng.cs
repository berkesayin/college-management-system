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
    public partial class JournalsMng : Form
    {
        public JournalsMng()
        {
            InitializeComponent();
        }

        JournalsDalMng _journalsDalMng = new JournalsDalMng();
        private void btnGeneralBooksAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksMng generalBooksMng = new GeneralBooksMng();
            generalBooksMng.ShowDialog();
        }

        private void btnLiteratureBooksAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksMng literatureBooksMng = new LiteratureBooksMng();
            literatureBooksMng.ShowDialog();
        }

        private void btnSocialBooksAtJounals_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksMng socialBooksMng = new SocialBooksMng();
            socialBooksMng.ShowDialog();
        }

        private void btnMathematicalBooksAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksMng mathematicalBooksMng = new MathematicalBooksMng();
            mathematicalBooksMng.ShowDialog();
        }

        private void btnEnglishBooksAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksMng englishBooksMng = new EnglishBooksMng();
            englishBooksMng.ShowDialog();
        }

        private void btnNewspapersAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersMng newspapersMng = new NewspapersMng();
            newspapersMng.ShowDialog();
        }

        private void btnOrderListAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListMng orderListMng = new OrderListMng();
            orderListMng.ShowDialog();
        }

        private void btnReturnMenuJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void JournalsMng_Load(object sender, EventArgs e)
        {
            LoadJournals();
        }

        private void LoadJournals()
        {
            dgwJournals.DataSource = _journalsDalMng.GetAllJournals();
        }

        private void btnAddJournals_Click(object sender, EventArgs e)
        {
            _journalsDalMng.Add(new Journals
            {
                Id = Convert.ToInt32(tbxAddIdJournals.Text),
                JournalName = tbxAddJournalNameJournals.Text,
                LanguageOfIt = tbxAddLanguageJournals.Text,
                SubjectOfIt = tbxAddSubjectJournals.Text,
                Country = tbxAddCountryJournals.Text,
                Price = Convert.ToInt32(tbxAddPriceJournals.Text)
            });
            //işlem bitince liste yenilensin :
            LoadJournals();

            //kullanıcı bilgilendirilsin:
            MessageBox.Show("Journal Added!!");

            ClearAddGroup();
        }

        private void dgwJournals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdJournals.Text = dgwJournals.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateJournalNameJournals.Text = dgwJournals.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLanguageJournals.Text = dgwJournals.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateSubjectJournals.Text = dgwJournals.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateCountryJournals.Text = dgwJournals.CurrentRow.Cells[4].Value.ToString();
            tbxUpdatePriceJournals.Text = dgwJournals.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdateJournals_Click(object sender, EventArgs e)
        {
            _journalsDalMng.Update(new Journals
            {
                Id = Convert.ToInt32(tbxUpdateIdJournals.Text),
                JournalName = tbxUpdateJournalNameJournals.Text,
                LanguageOfIt = tbxUpdateLanguageJournals.Text,
                SubjectOfIt = tbxUpdateSubjectJournals.Text,
                Country = tbxUpdateCountryJournals.Text,
                Price = Convert.ToInt32(tbxUpdatePriceJournals.Text)
            });
            //işlem bitince liste yenilensin :
            LoadJournals();

            MessageBox.Show("Journal Updated!!");

            ClearUpdateGroup();
        }

        private void btnRemoveJournals_Click(object sender, EventArgs e)
        {
            _journalsDalMng.Delete(new Journals
            {
                Id = Convert.ToInt32(dgwJournals.CurrentRow.Cells[0].Value.ToString())
            });
            //işlem bitince liste yenilensin :
            LoadJournals();

            MessageBox.Show("Journal Deleted!!");
        }

        private void ClearAddGroup()
        {
            tbxAddIdJournals.Text = tbxAddJournalNameJournals.Text = tbxAddLanguageJournals.Text =
                tbxAddSubjectJournals.Text = tbxAddCountryJournals.Text = tbxAddPriceJournals.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdJournals.Text = tbxUpdateJournalNameJournals.Text =
                tbxUpdateLanguageJournals.Text = tbxUpdateSubjectJournals.Text =
                tbxUpdateCountryJournals.Text = tbxUpdatePriceJournals.Text = " ";
        }
    }
}
