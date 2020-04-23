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
    public partial class JournalsUser : Form
    {
        public JournalsUser()
        {
            InitializeComponent();
        }

        JournalsDalUser _journalsDalUser = new JournalsDalUser();
        private void btnStaffAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4StaffMng form4StaffMng = new Form4StaffMng();
            form4StaffMng.ShowDialog();
        }

        private void btnGeneralBooksAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksUser generalBooksUser = new GeneralBooksUser();
            generalBooksUser.ShowDialog();
        }

        private void btnLiteratureAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksUser literatureBooksUser = new LiteratureBooksUser();
            literatureBooksUser.ShowDialog();
        }

        private void btnSocialAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksUser socialBooksUser = new SocialBooksUser();
            socialBooksUser.ShowDialog();
        }

        private void btnMathematicalAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksUser mathematicalBooksUser = new MathematicalBooksUser();
            mathematicalBooksUser.ShowDialog();
        }

        private void btnEnglishAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksUser englishBooksUser = new EnglishBooksUser();
            englishBooksUser.ShowDialog();
        }

        private void btnNewspapersAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersUser newspapersUser = new NewspapersUser();
            newspapersUser.ShowDialog();
        }

        private void btnOrderListAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListUser orderListUser = new OrderListUser();
            orderListUser.ShowDialog();
        }

        private void btnChangeAccountAtJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void JournalsUser_Load(object sender, EventArgs e)
        {
            LoadJournals();
        }

        private void LoadJournals()
        {
            dgwJournals.DataSource = _journalsDalUser.GetAllJournals();
        }
    }
}
