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
    public partial class Form3Main : Form
    {
        public Form3Main()
        {
            InitializeComponent();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4StaffMng form4StaffMng = new Form4StaffMng();
            form4StaffMng.ShowDialog();
        }

        private void btnManagers_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralMembersMng generalMembersMng = new GeneralMembersMng();
            generalMembersMng.ShowDialog();

        }

        private void btnAcademicians_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcademiciansMng academiciansMng = new AcademiciansMng();
            academiciansMng.ShowDialog();
        }

        private void btnResearchers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResearchersMng researchersMng = new ResearchersMng();
            researchersMng.ShowDialog();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersMng teachersMng = new TeachersMng();
            teachersMng.ShowDialog();
        }

        private void btnCollegeStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            CollegeStudentsMng collegeStudentsMng = new CollegeStudentsMng();
            collegeStudentsMng.ShowDialog();
        }

        private void btnForeignMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForeignMembersMng foreignMembersMng = new ForeignMembersMng();
            foreignMembersMng.ShowDialog();
        }

        private void btnGeneralBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksMng generalBooksMng = new GeneralBooksMng();
            generalBooksMng.ShowDialog();
        }

        private void btnLiteratureBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksMng literatureBooksMng = new LiteratureBooksMng();
            literatureBooksMng.ShowDialog();
        }

        private void btnSocialBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksMng socialBooksMng = new SocialBooksMng();
            socialBooksMng.ShowDialog();
        }

        private void btnMathBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksMng mathematicalBooksMng = new MathematicalBooksMng();
            mathematicalBooksMng.ShowDialog();
        }

        private void btnEnglishBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksMng englishBooksMng = new EnglishBooksMng();
            englishBooksMng.ShowDialog();
        }

        private void btnJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsMng journalsMng = new JournalsMng();
            journalsMng.ShowDialog();
        }

        private void btnNewspapers_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersMng newspapersMng = new NewspapersMng();
            newspapersMng.ShowDialog();
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListMng orderListMng = new OrderListMng();
            orderListMng.ShowDialog();
        }

        private void btnReturnToRegister_Click(object sender, EventArgs e)
        {
            //Registration form ekranı açılsın :
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
