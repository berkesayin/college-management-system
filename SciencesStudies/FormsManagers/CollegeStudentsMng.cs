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
    public partial class CollegeStudentsMng : Form
    {
        public CollegeStudentsMng()
        {
            InitializeComponent();
        }

        CollegeStudentsDalMng _collegeStudentsDalMng = new CollegeStudentsDalMng();
        private void btnReturnMenuCollegeStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void CollegeStudentsMng_Load(object sender, EventArgs e)
        {
            LoadCollegeStudents();
        }

        private void LoadCollegeStudents()
        {
            dgwCollegeStudents.DataSource = _collegeStudentsDalMng.GetAllCollegeStudents();
        }

        private void btnAddCollegeStudent_Click(object sender, EventArgs e)
        {
            _collegeStudentsDalMng.Add(new CollegeStudents
            {
                Id = Convert.ToInt32(tbxAddIdCollegeStudent.Text),
                FirstName = tbxAddFirstNameCollegeStudent.Text,
                LastName = tbxAddLastNameCollegeStudent.Text,
                Gender = tbxAddGenderCollegeStudent.Text,
                Age = Convert.ToInt32(tbxAddAgeCollegeStudent.Text),
                College = tbxAddCollegeCollegeStudent.Text,
                Department = tbxAddDepartmentCollegeStudent.Text
            });
            //İşlem bitince liste yenilensin :
            LoadCollegeStudents();
            //Kullanıcıya mesaj ver :
            MessageBox.Show("College Student Added!!");

            ClearAddGroup();
        }

        private void dgwCollegeStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdCollegeStudent.Text = dgwCollegeStudents.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateFirstNameCollegeStudent.Text = dgwCollegeStudents.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLastNameCollegeStudent.Text = dgwCollegeStudents.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateGenderCollegeStudent.Text = dgwCollegeStudents.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAgeCollegeStudent.Text = dgwCollegeStudents.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateCollegeCollegeStudent.Text = dgwCollegeStudents.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateDepartmentCollegeStudent.Text = dgwCollegeStudents.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdateCollegeStudent_Click(object sender, EventArgs e)
        {
            _collegeStudentsDalMng.Update(new CollegeStudents
            {
                Id = Convert.ToInt32(tbxUpdateIdCollegeStudent.Text),
                FirstName = tbxUpdateFirstNameCollegeStudent.Text,
                LastName = tbxUpdateLastNameCollegeStudent.Text,
                Gender = tbxUpdateGenderCollegeStudent.Text,
                Age = Convert.ToInt32(tbxUpdateAgeCollegeStudent.Text),
                College = tbxUpdateCollegeCollegeStudent.Text,
                Department = tbxUpdateDepartmentCollegeStudent.Text
            });
            //İşlem bitince liste yenilensin :
            LoadCollegeStudents();

            //Kullanıcıya mesaj ver :
            MessageBox.Show("College Student Updated!!");

            ClearUpdateGroup();
        }

        private void btnRemoveCollegeStudent_Click(object sender, EventArgs e)
        {
            _collegeStudentsDalMng.Delete(new CollegeStudents
            {
                Id = Convert.ToInt32(dgwCollegeStudents.CurrentRow.Cells[0].Value.ToString())
            });
            //İşlem bitince liste yenilensin :
            LoadCollegeStudents();

            //Kullanıcıya mesaj verelim :
            MessageBox.Show("College Student Updated!!");
        }

        private void btnManagersAtCollegeStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralMembersMng generalMembersMng = new GeneralMembersMng();
            generalMembersMng.ShowDialog();
        }

        private void btnAcademiciansAtCollegeStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcademiciansMng academiciansMng = new AcademiciansMng();
            academiciansMng.ShowDialog();
        }

        private void btnResearchersAtCollegeStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResearchersMng researchersMng = new ResearchersMng();
            researchersMng.ShowDialog();
        }

        private void btnTeachersAtCollegeStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersMng teachersMng = new TeachersMng();
            teachersMng.ShowDialog();
        }

        private void btnForeignMembersAtCollegeStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForeignMembersMng foreignMembersMng = new ForeignMembersMng();
            foreignMembersMng.ShowDialog();
        }

        private void ClearAddGroup()
        {
            tbxAddIdCollegeStudent.Text = tbxAddFirstNameCollegeStudent.Text = tbxAddLastNameCollegeStudent.Text
                = tbxAddGenderCollegeStudent.Text = tbxAddAgeCollegeStudent.Text = tbxAddCollegeCollegeStudent.Text
                = tbxAddDepartmentCollegeStudent.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdCollegeStudent.Text = tbxUpdateFirstNameCollegeStudent.Text =
                tbxUpdateLastNameCollegeStudent.Text = tbxUpdateGenderCollegeStudent.Text
                = tbxUpdateCollegeCollegeStudent.Text = tbxUpdateDepartmentCollegeStudent.Text = " ";
        }
    }
}
