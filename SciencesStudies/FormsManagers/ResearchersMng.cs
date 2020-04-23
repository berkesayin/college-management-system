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
    public partial class ResearchersMng : Form
    {
        public ResearchersMng()
        {
            InitializeComponent();
        }

        private void btnReturnMenuResearchers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        ResearchersDalMng _researchersDalMng = new ResearchersDalMng();

        private void ResearchersMng_Load(object sender, EventArgs e)
        {
            LoadResearchers();
        }

        private void LoadResearchers()
        {
            dgwResearchers.DataSource = _researchersDalMng.GetAllResearchers();
        }

        private void btnAddResearcher_Click(object sender, EventArgs e)
        {
            _researchersDalMng.Add(new Researchers
            {
                Id = Convert.ToInt32(tbxAddIdResearcher.Text),
                FirstName = tbxAddFirstNameResearcher.Text,
                LastName = tbxAddLastNameResearcher.Text,
                Gender = tbxAddGenderResearcher.Text,
                Age = Convert.ToInt32(tbxAddAgeResearcher.Text),
                College = tbxAddCollegeResearcher.Text,
                Department = tbxAddDepartmentResearcher.Text
            });

            //Ekleme bitti listeyi yenile
            LoadResearchers();

            //Kullanıcıya bilgi ver
            MessageBox.Show("Researcher Added!!");

            ClearAddGroup();
        }

        private void dgwResearchers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdResearcher.Text = dgwResearchers.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateFirstNameResearcher.Text = dgwResearchers.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLastNameResearcher.Text = dgwResearchers.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateGenderResearcher.Text = dgwResearchers.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAgeResearcher.Text = dgwResearchers.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateCollegeResearcher.Text = dgwResearchers.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateDepartmentResearcher.Text = dgwResearchers.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdateResearcher_Click(object sender, EventArgs e)
        {
            _researchersDalMng.Update(new Researchers
            {
                Id = Convert.ToInt32(tbxUpdateIdResearcher.Text),
                FirstName = tbxUpdateFirstNameResearcher.Text,
                LastName = tbxUpdateLastNameResearcher.Text,
                Gender = tbxUpdateGenderResearcher.Text,
                Age = Convert.ToInt32(tbxUpdateAgeResearcher.Text),
                College = tbxUpdateCollegeResearcher.Text,
                Department = tbxUpdateDepartmentResearcher.Text
            });
            //işlem bitince listeyi yenile
            LoadResearchers();

            //Kullanıcıya mesaj ver :
            MessageBox.Show("Researcher Updated!!");

            ClearUpdateGroup();
            
        }

        private void btnRemoveResearcher_Click(object sender, EventArgs e)
        {
            _researchersDalMng.Delete(new Researchers
            {
                Id = Convert.ToInt32(dgwResearchers.CurrentRow.Cells[0].Value.ToString())
            });
            //işlem bitince listeyi yenile:
            LoadResearchers();

            //Kullanıcıya mesaj ver :
            MessageBox.Show("Researcher Deleted!!");
        }

        private void btnManagersAtResearchers_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralMembersMng generalMembersMng = new GeneralMembersMng();
            generalMembersMng.ShowDialog();
        }

        private void btnAcademiciansAtResearchers_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcademiciansMng academiciansMng = new AcademiciansMng();
            academiciansMng.ShowDialog();
        }

        private void btnTeachersAtResearchers_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersMng teachersMng = new TeachersMng();
            teachersMng.ShowDialog();
        }

        private void btnCollegeStudentsAtResearchers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CollegeStudentsMng collegeStudentsMng = new CollegeStudentsMng();
            collegeStudentsMng.ShowDialog();
        }

        private void btnForeignMembersAtResearchers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForeignMembersMng foreignMembersMng = new ForeignMembersMng();
            foreignMembersMng.ShowDialog();
        }

        private void ClearAddGroup()
        {
            tbxAddIdResearcher.Text = tbxAddFirstNameResearcher.Text = tbxAddLastNameResearcher.Text
                = tbxAddGenderResearcher.Text = tbxAddAgeResearcher.Text = tbxAddCollegeResearcher.Text
                = tbxAddDepartmentResearcher.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdResearcher.Text = tbxUpdateFirstNameResearcher.Text = tbxUpdateLastNameResearcher.Text
                = tbxUpdateGenderResearcher.Text = tbxUpdateAgeResearcher.Text = tbxUpdateCollegeResearcher.Text
                = tbxUpdateDepartmentResearcher.Text = " ";
        }
    }
}
