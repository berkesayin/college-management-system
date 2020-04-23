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
    public partial class MathematicalBooksUser : Form
    {
        public MathematicalBooksUser()
        {
            InitializeComponent();
        }

        MathematicalBooksDalUser _mathematicalBooksDalUser = new MathematicalBooksDalUser();
        private void btnStaffAtMathematical_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4StaffMng form4StaffMng = new Form4StaffMng();
            form4StaffMng.ShowDialog();
        }

        private void btnGeneralBooksAtMathematical_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksUser generalBooksUser = new GeneralBooksUser();
            generalBooksUser.ShowDialog();
        }

        private void btnLiteratureAtMathematical_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksUser literatureBooksUser = new LiteratureBooksUser();
            literatureBooksUser.ShowDialog();
        }

        private void btnSocialAtMathematical_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksUser socialBooksUser = new SocialBooksUser();
            socialBooksUser.ShowDialog();
        }

        private void btnEnglishAtMathematical_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksUser englishBooksUser = new EnglishBooksUser();
            englishBooksUser.ShowDialog();
        }

        private void btnJournalsAtMathematical_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsUser journalsUser = new JournalsUser();
            journalsUser.ShowDialog();
        }

        private void btnNewspapersAtMathematical_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersUser newspapersUser = new NewspapersUser();
            newspapersUser.ShowDialog();
        }

        private void btnOrderListAtMathematical_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListUser orderListUser = new OrderListUser();
            orderListUser.ShowDialog();
        }

        private void btnChangeAccountAtMathematical_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void MathematicalBooksUser_Load(object sender, EventArgs e)
        {
            LoadMathematicalBooks();
        }

        private void LoadMathematicalBooks()
        {
            dgwMathematicalBooks.DataSource = _mathematicalBooksDalUser.GetAllMathematicalBooks();
        }
    }
}
