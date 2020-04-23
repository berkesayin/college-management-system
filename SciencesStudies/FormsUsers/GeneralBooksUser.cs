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
    public partial class GeneralBooksUser : Form
    {
        GeneralBooksDalUser _generalBooksDalUser = new GeneralBooksDalUser();
        public GeneralBooksUser()
        {
            InitializeComponent();
        }

        private void GeneralBooksUser_Load(object sender, EventArgs e)
        {
            LoadGeneralBooks();
        }

        private void LoadGeneralBooks()
        {
            dgwGeneralBooks.DataSource = _generalBooksDalUser.GetAllGeneralBooks();
        }

        private void btnStaffAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4StaffMng form4StaffMng = new Form4StaffMng();
            form4StaffMng.ShowDialog();
        }

        private void btnLiteratureBooksAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksUser literatureBooksUser = new LiteratureBooksUser();
            literatureBooksUser.ShowDialog();
        }

        private void btnSocialBooksAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksUser socialBooksUser = new SocialBooksUser();
            socialBooksUser.ShowDialog();
        }

        private void btnMathematicalBooksAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksUser mathematicalBooksUser = new MathematicalBooksUser();
            mathematicalBooksUser.ShowDialog();
        }

        private void btnEnglishBooksAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksUser englishBooksUser = new EnglishBooksUser();
            englishBooksUser.ShowDialog();
        }

        private void btnJournalsAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsUser journalsUser = new JournalsUser();
            journalsUser.ShowDialog();
        }

        private void btnNewspapersAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersUser newspapersUser = new NewspapersUser();
            newspapersUser.ShowDialog();
        }

        private void btnOrderListAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListUser orderListUser = new OrderListUser();
            orderListUser.ShowDialog();
        }

        private void btnChangeAccountAtGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
