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
    public partial class ForeignMembersMng : Form
    {
        public ForeignMembersMng()
        {
            InitializeComponent();
        }

        
        private void btnReturnMenuForeignMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        ForeignMembersDalMng _foreignMembersDalMng = new ForeignMembersDalMng();
        private void ForeignMembersMng_Load(object sender, EventArgs e)
        {
            LoadForeignMembers();
        }

        private void LoadForeignMembers()
        {
            dgwForeignMembers.DataSource = _foreignMembersDalMng.GetAllForeignMembers();
        }

        private void btnAddForeignMember_Click(object sender, EventArgs e)
        {
            _foreignMembersDalMng.Add(new ForeignMembers
            {
                Id = Convert.ToInt32(tbxAddIdForeignMember.Text),
                FirstName = tbxAddFirstNameForeignMember.Text,
                LastName = tbxAddLastNameForeignMember.Text,
                Gender = tbxAddGenderForeignMember.Text,
                Age = Convert.ToInt32(tbxAddAgeForeignMember.Text),
                Nationality = tbxAddNationalityForeignMember.Text,
                Job = tbxAddJobForeignMember.Text
            });
            //Ekleme işlemi bitince liste yenilensin :
            LoadForeignMembers();

            //Kullanıcıya mesaj verelim :
            MessageBox.Show("Foreign Member Added!!");

            ClearAddGroup();
        }

        private void dgwForeignMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdForeignMember.Text = dgwForeignMembers.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateFirstNameForeignMember.Text = dgwForeignMembers.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLastNameForeignMember.Text = dgwForeignMembers.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateGenderForeignMember.Text = dgwForeignMembers.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAgeForeignMember.Text = dgwForeignMembers.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateNationalityForeignMember.Text = dgwForeignMembers.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateJobForeignMember.Text = dgwForeignMembers.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdateForeignMember_Click(object sender, EventArgs e)
        {
            _foreignMembersDalMng.Update(new ForeignMembers
            {
                Id = Convert.ToInt32(tbxUpdateIdForeignMember.Text),
                FirstName = tbxUpdateFirstNameForeignMember.Text,
                LastName = tbxUpdateLastNameForeignMember.Text,
                Gender = tbxUpdateGenderForeignMember.Text,
                Age = Convert.ToInt32(tbxUpdateAgeForeignMember.Text),
                Nationality = tbxUpdateNationalityForeignMember.Text,
                Job = tbxUpdateJobForeignMember.Text
            });
            //İşlem bitince listeyi yenile :
            LoadForeignMembers();

            //Kullanıcıya mesaj ver
            MessageBox.Show("Foreign Member Deleted!!");

            ClearUpdateGroup();
        }

        private void btnRemoveForeignMember_Click(object sender, EventArgs e)
        {
            _foreignMembersDalMng.Delete(new ForeignMembers
            {
                Id = Convert.ToInt32(dgwForeignMembers.CurrentRow.Cells[0].Value.ToString())
            });
            //İşlem bitince liste yenilensin :
            LoadForeignMembers();

            //Kullanıcıya mesaj verilsin :
            MessageBox.Show("Foreign Member Deleted!!");
        }

        private void btnManagersAtForeignMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralMembersMng generalMembersMng = new GeneralMembersMng();
            generalMembersMng.ShowDialog();
        }

        private void btnAcademiciansAtForeignMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcademiciansMng academiciansMng = new AcademiciansMng();
            academiciansMng.ShowDialog();
        }

        private void btnResearchersAtForeignMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResearchersMng researchersMng = new ResearchersMng();
            researchersMng.ShowDialog();
        }

        private void btnTeachersAtForeignMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersMng teachersMng = new TeachersMng();
            teachersMng.ShowDialog();
        }

        private void btnCollegeStudentsAtForeignMembers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CollegeStudentsMng collegeStudentsMng = new CollegeStudentsMng();
            collegeStudentsMng.ShowDialog();
        }

        private void ClearAddGroup()
        {
            tbxAddIdForeignMember.Text = tbxAddFirstNameForeignMember.Text = tbxAddLastNameForeignMember.Text
                = tbxAddGenderForeignMember.Text = tbxAddAgeForeignMember.Text =
                tbxAddNationalityForeignMember.Text = tbxAddJobForeignMember.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdForeignMember.Text = tbxUpdateFirstNameForeignMember.Text =
                tbxAddLastNameForeignMember.Text = tbxUpdateGenderForeignMember.Text = tbxUpdateAgeForeignMember.Text
                = tbxUpdateNationalityForeignMember.Text = tbxUpdateJobForeignMember.Text = " ";
        }
    }
}
