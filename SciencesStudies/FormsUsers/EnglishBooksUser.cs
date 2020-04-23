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
    public partial class EnglishBooksUser : Form
    {
        public EnglishBooksUser()
        {
            InitializeComponent();
        }

        EnglishBooksDalUser _englishBooksDalUser = new EnglishBooksDalUser();
        private void btnStaffAtEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4StaffMng form4StaffMng = new Form4StaffMng();
            form4StaffMng.ShowDialog();
        }

        private void btnGeneralBooksAtEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksUser generalBooksUser = new GeneralBooksUser();
            generalBooksUser.ShowDialog();
        }

        private void btnLiteratureAtEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksUser literatureBooksUser = new LiteratureBooksUser();
            literatureBooksUser.ShowDialog();
        }

        private void btnSocialAtEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksUser socialBooksUser = new SocialBooksUser();
            socialBooksUser.ShowDialog();
        }

        private void btnMathematicalAtEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksUser mathematicalBooksUser = new MathematicalBooksUser();
            mathematicalBooksUser.ShowDialog();
        }

        private void btnJournalsAtEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsUser journalsUser = new JournalsUser();
            journalsUser.ShowDialog();
        }

        private void btnNewspapersAtEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersUser newspapersUser = new NewspapersUser();
            newspapersUser.ShowDialog();
        }

        private void btnOrderListAtEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListUser orderListUser = new OrderListUser();
            orderListUser.ShowDialog();
        }

        private void btnChangeAccountAtEnglish_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void EnglishBooksUser_Load(object sender, EventArgs e)
        {
            LoadEnglihBooks();
        }

        private void LoadEnglihBooks()
        {
            dgwEnglishBooks.DataSource = _englishBooksDalUser.GetAllEnglishBooks();
        }
    }
}
