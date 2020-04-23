using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SciencesStudies
{
    public partial class NewspapersUser : Form
    {
        public NewspapersUser()
        {
            InitializeComponent();
        }

        NewspapersDalUser _newspapersDalUser = new NewspapersDalUser();
        private void btnStaffAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4StaffMng form4StaffMng = new Form4StaffMng();
            form4StaffMng.ShowDialog();
        }

        private void btnGeneralBooksAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksUser generalBooksUser = new GeneralBooksUser();
            generalBooksUser.ShowDialog();
        }

        private void btnLiteratureAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksUser literatureBooksUser = new LiteratureBooksUser();
            literatureBooksUser.ShowDialog();
        }

        private void btnSocialAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksUser socialBooksUser = new SocialBooksUser();
            socialBooksUser.ShowDialog();
        }

        private void btnMathematicalAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksUser mathematicalBooksUser = new MathematicalBooksUser();
            mathematicalBooksUser.ShowDialog();
        }

        private void btnEnglishAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksUser englishBooksUser = new EnglishBooksUser();
            englishBooksUser.ShowDialog();
        }

        private void btnJournalsAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsUser journalsUser = new JournalsUser();
            journalsUser.ShowDialog();
        }

        private void btnOrderListAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListUser orderListUser = new OrderListUser();
            orderListUser.ShowDialog();
        }

        private void btnChangeAccountAtNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void NewspapersUser_Load(object sender, EventArgs e)
        {
            LoadNewspapers();
        }

        private void LoadNewspapers()
        {
            dgwNewspapers.DataSource = _newspapersDalUser.GetAllNewspapers();
        }
    }
}
