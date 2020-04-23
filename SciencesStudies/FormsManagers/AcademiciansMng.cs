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
    public partial class AcademiciansMng : Form
    {
        public AcademiciansMng()
        {
            InitializeComponent();
        }

        AcademiciansDalMng _academiciansDalMng = new AcademiciansDalMng();
        private void AcademiciansMng_Load(object sender, EventArgs e)
        {
            LoadAcademicians();
        }

        private void LoadAcademicians()
        {
            dgwAcademicians.DataSource = _academiciansDalMng.GetAllAcademicians();
        }

        private void btnAddAcademician_Click(object sender, EventArgs e)
        {
            //AcademiciansDalMng içinde yazdığımız Ekleme fonksiyonunu çağıralım
            //Academicians özelliklerini textbox'lara atayalım
            _academiciansDalMng.Add(new Academicians
            {
                Id = Convert.ToInt32(tbxAddIdAcademician.Text),
                FirstName = tbxAddFirstNameAcademician.Text,
                LastName = tbxAddLastNameAcademician.Text,
                Gender = tbxAddGenderAcademician.Text,
                Age = Convert.ToInt32(tbxAddAgeAcademician.Text),
                College = tbxAddCollegeAcademician.Text,
                Department = tbxAddDepartmentAcademician.Text

            });

            //Listeyi yenile
            LoadAcademicians();

            //Kullancıya eklendi mesajı ver
            MessageBox.Show("Academician Added!!");

            ClearAddGroup();
        }

        private void dgwAcademicians_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdAcademician.Text = dgwAcademicians.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateFirstNameAcademician.Text = dgwAcademicians.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLastNameAcademician.Text = dgwAcademicians.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateGenderAcademician.Text = dgwAcademicians.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAgeAcademician.Text = dgwAcademicians.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateCollegeAcademician.Text = dgwAcademicians.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateDepartmentAcademician.Text = dgwAcademicians.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnUpdateAcademician_Click(object sender, EventArgs e)
        {
            _academiciansDalMng.Update(new Academicians
            {
                Id = Convert.ToInt32(tbxUpdateIdAcademician.Text),
                FirstName = tbxUpdateFirstNameAcademician.Text,
                LastName = tbxUpdateLastNameAcademician.Text,
                Gender = tbxAddGenderAcademician.Text,
                Age = Convert.ToInt32(tbxUpdateAgeAcademician.Text),
                College = tbxUpdateCollegeAcademician.Text,
                Department = tbxUpdateDepartmentAcademician.Text
            });

            //Listeyi yenile
            LoadAcademicians();

            //kullanıcıya mesaj ver
            MessageBox.Show("Academician Updated!!");

            ClearUpdateGroup();
        }

        private void btnRemoveAcademician_Click(object sender, EventArgs e)
        {
            _academiciansDalMng.Delete(new Academicians
            {
                Id = Convert.ToInt32(dgwAcademicians.CurrentRow.Cells[0].Value.ToString())
            });

            //Listeyi yenile
            LoadAcademicians();

            //Kullanıcıya mesaj ver.
            MessageBox.Show("Academician Deleted!");

        }

        private void btnReturnMenuAcademicians_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void btnManagersAtAcademicians_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralMembersMng generalMembersMng = new GeneralMembersMng();
            generalMembersMng.ShowDialog();
        }

        private void btnResearchersAtAcademicians_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResearchersMng researchersMng = new ResearchersMng();
            researchersMng.ShowDialog();
        }

        private void btnTeachersAtAcademicians_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersMng teachersMng = new TeachersMng();
            teachersMng.ShowDialog();
        }

        private void btnCollegeStudentsAtAcademicians_Click(object sender, EventArgs e)
        {
            this.Hide();
            CollegeStudentsMng collegeStudentsMng = new CollegeStudentsMng();
            collegeStudentsMng.ShowDialog();
        }

        private void btnForeignMembersAtAcademicians_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForeignMembersMng foreignMembersMng = new ForeignMembersMng();
            foreignMembersMng.ShowDialog();
        }

        private void ClearAddGroup()
        {
            tbxAddIdAcademician.Text = tbxAddFirstNameAcademician.Text = tbxAddLastNameAcademician.Text
                = tbxAddGenderAcademician.Text = tbxAddAgeAcademician.Text = tbxAddCollegeAcademician.Text
                   = tbxAddDepartmentAcademician.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdAcademician.Text = tbxUpdateFirstNameAcademician.Text = tbxUpdateLastNameAcademician.Text
                = tbxUpdateGenderAcademician.Text = tbxUpdateAgeAcademician.Text = tbxUpdateCollegeAcademician.Text
                = tbxUpdateDepartmentAcademician.Text = " ";
        }
    }
}
