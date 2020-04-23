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
    public partial class NewspapersMng : Form
    {
        public NewspapersMng()
        {
            InitializeComponent();
        }
       
        NewspapersDalMng _newspapersDalMng = new NewspapersDalMng();
        private void btnGeneralBooksAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksMng generalBooksMng = new GeneralBooksMng();
            generalBooksMng.ShowDialog();
        }

        private void btnLiteratureBooksAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksMng literatureBooksMng = new LiteratureBooksMng();
            literatureBooksMng.ShowDialog();

        }

        private void btnSocialBooksAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksMng socialBooksMng = new SocialBooksMng();
            socialBooksMng.ShowDialog();
        }

        private void btnMathematicalBooksAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksMng mathematicalBooksMng = new MathematicalBooksMng();
            mathematicalBooksMng.ShowDialog();
        }

        private void btnEnglishBooksAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksMng englishBooksMng = new EnglishBooksMng();
            englishBooksMng.ShowDialog();
        }

        private void btnJournalsAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsMng journalsMng = new JournalsMng();
            journalsMng.ShowDialog();
        }

        private void btnOrderListAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListMng orderListMng = new OrderListMng();
            orderListMng.ShowDialog();
        }

        private void btnReturnMenuNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void NewspapersMng_Load(object sender, EventArgs e)
        {
            LoadNewspapers();
        }

        private void LoadNewspapers()
        {
            dgwNewspapers.DataSource = _newspapersDalMng.GetAllNewspapers();
        }

        private void btnAddNewspapers_Click(object sender, EventArgs e)
        {
            _newspapersDalMng.Add(new Newspapers
            {
                Id = Convert.ToInt32(tbxAddIdNewspapers.Text),
                NewspapersName = tbxAddNameNewspapers.Text,
                LanguageOfIt = tbxAddLanguageNewspapers.Text,
                Contry = tbxAddCountryNewspapers.Text,
                Price = Convert.ToInt32(tbxAddPriceNewspapers.Text)
            });
            //işlem bitince liste yenilensin :
            LoadNewspapers();

            MessageBox.Show("Newspapers Added!!");

            ClearAddGroup();
        }

        private void dgwNewspapers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdNewspapers.Text = dgwNewspapers.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateNameNewspapers.Text = dgwNewspapers.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLanguageNewspapers.Text = dgwNewspapers.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateCountryNewspapers.Text = dgwNewspapers.CurrentRow.Cells[3].Value.ToString();
            tbxUpdatePriceNewspapers.Text = dgwNewspapers.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnUpdateNewspapers_Click(object sender, EventArgs e)
        {
            _newspapersDalMng.Update(new Newspapers
            {
                Id = Convert.ToInt32(tbxUpdateIdNewspapers.Text),
                NewspapersName = tbxUpdateNameNewspapers.Text,
                LanguageOfIt = tbxUpdateLanguageNewspapers.Text,
                Contry = tbxUpdateCountryNewspapers.Text,
                Price = Convert.ToInt32(tbxUpdatePriceNewspapers.Text)
            });
            //işlem bitince liste yenilensin
            LoadNewspapers();

            MessageBox.Show("Newspapers Added!!");

            ClearUpdateGroup();
        }

        private void btnRemoveNewspapers_Click(object sender, EventArgs e)
        {
            _newspapersDalMng.Delete(new Newspapers
            {
                Id = Convert.ToInt32(dgwNewspapers.CurrentRow.Cells[0].Value.ToString())
            });
            //işlem bitince liste yenilensin
            LoadNewspapers();

            MessageBox.Show("Newspapers Deleted!!");
        }

        private void ClearAddGroup()
        {
            tbxAddIdNewspapers.Text = tbxAddNameNewspapers.Text = tbxAddLanguageNewspapers.Text =
                tbxAddCountryNewspapers.Text = tbxAddPriceNewspapers.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdNewspapers.Text = tbxUpdateNameNewspapers.Text = tbxUpdateLanguageNewspapers.Text =
                tbxUpdateCountryNewspapers.Text = tbxUpdatePriceNewspapers.Text = " ";
        }
    }
}
