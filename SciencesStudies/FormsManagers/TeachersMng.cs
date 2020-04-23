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
    public partial class TeachersMng : Form
    {
        public TeachersMng()
        {
            InitializeComponent();
        }
        TeachersDalMng _teachersDalMng = new TeachersDalMng();
        private void btnReturnMenuTeachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void TeachersMng_Load(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void LoadTeachers()
        {
            dgwTeachers.DataSource = _teachersDalMng.GetAllTeachers();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            _teachersDalMng.Add(new Teachers
            {
                Id = Convert.ToInt32(tbxAddIdTeacher.Text),
                FirstName = tbxAddFirstNameTeacher.Text,
                LastName = tbxAddLastNameTeacher.Text,
                Gender = tbxAddGenderTeacher.Text,
                Age = Convert.ToInt32(tbxAddAgeTeacher.Text),
                College = tbxAddCollegeTeacher.Text,
                Department = tbxAddDepartmentTeacher.Text
            });
            //Ekleme işlemi bitince listeyi yenile
            LoadTeachers();

            //Kullanıcıya mesaj ver :
            MessageBox.Show("Teacher Added!!");

            ClearAddGroup();

        }

        private void dgwTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdTeacher.Text = dgwTeachers.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateFirstNameTeacher.Text = dgwTeachers.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLastNameTeacher.Text = dgwTeachers.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateGenderTeacher.Text = dgwTeachers.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAgeTeacher.Text = dgwTeachers.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateCollegeTeacher.Text = dgwTeachers.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateDepartmentTeacher.Text = dgwTeachers.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            _teachersDalMng.Update(new Teachers
            {
                Id = Convert.ToInt32(tbxUpdateIdTeacher.Text),
                FirstName = tbxUpdateFirstNameTeacher.Text,
                LastName = tbxUpdateLastNameTeacher.Text,
                Gender = tbxUpdateGenderTeacher.Text,
                Age = Convert.ToInt32(tbxUpdateAgeTeacher.Text),
                College = tbxUpdateCollegeTeacher.Text,
                Department = tbxUpdateDepartmentTeacher.Text
            });

            //Güncelleme işlemi bitti,liste yenilensin;
            LoadTeachers();

            //Kullanıcıya mesaj verilsin: 
            MessageBox.Show("Teacher Updated!!");

            ClearUpdateGroup();
        }

        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            _teachersDalMng.Delete(new Teachers
            {
                Id = Convert.ToInt32(dgwTeachers.CurrentRow.Cells[0].Value.ToString())
            });
            //Silme işlemi bitti,listeyi yenile
            LoadTeachers();

            //Kullanıcıya mesaj ver :
            MessageBox.Show("Teacher Deleted!!");
        }

        private void btnManagersAtTeachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralMembersMng generalMembersMng = new GeneralMembersMng();
            generalMembersMng.ShowDialog();
            
        }

        private void btnAcademiciansAtTeachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcademiciansMng academiciansMng = new AcademiciansMng();
            academiciansMng.ShowDialog();
        }

        private void btnResearchersAtTeachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResearchersMng researchersMng = new ResearchersMng();
            researchersMng.ShowDialog();
        }

        private void btnCollegeStudentsAtTeachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CollegeStudentsMng collegeStudentsMng = new CollegeStudentsMng();
            collegeStudentsMng.ShowDialog();
        }

        private void btnForeignMembersAtTeachers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForeignMembersMng foreignMembersMng = new ForeignMembersMng();
            foreignMembersMng.ShowDialog();
        }

        private void ClearAddGroup()
        {
            tbxAddIdTeacher.Text = tbxAddFirstNameTeacher.Text = tbxAddLastNameTeacher.Text
                = tbxAddGenderTeacher.Text = tbxAddAgeTeacher.Text = tbxAddCollegeTeacher.Text
                = tbxAddDepartmentTeacher.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdTeacher.Text = tbxUpdateFirstNameTeacher.Text = tbxUpdateLastNameTeacher.Text
                = tbxUpdateGenderTeacher.Text = tbxUpdateAgeTeacher.Text = tbxUpdateCollegeTeacher.Text
                = tbxUpdateDepartmentTeacher.Text = " ";
        }
    }
}
