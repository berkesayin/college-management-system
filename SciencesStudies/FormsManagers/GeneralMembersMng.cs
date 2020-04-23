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
    public partial class GeneralMembersMng : Form
    {
        public GeneralMembersMng()
        {
            InitializeComponent();
        }

        //Burada new'lersek her blok ta ayrı ayrı new'lemeye gerek kalmaz
        GeneralMembersDalMng _generalMembersDalMng = new GeneralMembersDalMng();
        private void GeneralMembersMng_Load(object sender, EventArgs e)
        {
            LoadGeneralMembers();
        }

        private void LoadGeneralMembers()
        {
            dgwGeneralMembers.DataSource = _generalMembersDalMng.GetAllGeneralMembers();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            //GeneralMembersDalMng classında yazdığımız ekleme fonk.çağıracağız.
            //GeneralMembers özelliklerini textbox'lara atayalım
            _generalMembersDalMng.Add(new GeneralMembers
            {
                Id = Convert.ToInt32(tbxAddIdMember.Text),
                FirstName = tbxAddFirstNameMember.Text,
                LastName = tbxAddLastNameMember.Text,
                Gender = tbxAddGenderMember.Text,
                Age = Convert.ToInt32(tbxAddAgeMember.Text)
            });

            //Ekleme işlemi gerçekleşince listeyi yeniden yükleyelim.
            LoadGeneralMembers();

            //Kullanıcıya eklendi şeklinde bilgi verelim:
            MessageBox.Show("New Member Added!");

            //En son Add groupbox içindeki textbox'lardaki değerler silinsin(temizlensin)
            ClearAddGroup();
        }

        private void dgwGeneralMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdMember.Text = dgwGeneralMembers.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateFirstNameMember.Text = dgwGeneralMembers.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateLastNameMember.Text = dgwGeneralMembers.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateGenderMember.Text = dgwGeneralMembers.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateAgeMember.Text = dgwGeneralMembers.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            //GeneralMembersDalMng'de yadığımız Update butonunu çağıralım
            _generalMembersDalMng.Update(new GeneralMembers
            {
                Id = Convert.ToInt32(tbxUpdateIdMember.Text),
                FirstName = tbxUpdateFirstNameMember.Text,
                LastName = tbxUpdateLastNameMember.Text,
                Gender = tbxUpdateGenderMember.Text,
                Age = Convert.ToInt32(tbxUpdateAgeMember.Text)
            });

            //Güncelleme işlemi bitince listeyi yeniden yüklemek için:
            LoadGeneralMembers();

            //Kullanıcıya mesaj ver
            MessageBox.Show("Member Updated!!");

            //En son Update groupbox içerisindeki textbox'larda yazılı değerler silinsin :
            ClearUpdateGroup();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _generalMembersDalMng.Delete(new GeneralMembers
            {
                Id = Convert.ToInt32(dgwGeneralMembers.CurrentRow.Cells[0].Value)
            });

            LoadGeneralMembers();  //Bu işlemide yaptıktan sonra program çalışırken listenin anında güncellenmesi için şöyle yaparız:

            MessageBox.Show("Member Deleted!!");  //Silme işlemi bitince kullanıcıya bilgi ver:
        }

        private void btnReturnMenuFromMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void btnAcademiciansAtManagers_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcademiciansMng academiciansMng = new AcademiciansMng();
            academiciansMng.ShowDialog();
        }

        private void btnResearchersAtManagers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResearchersMng researchersMng = new ResearchersMng();
            researchersMng.ShowDialog();
        }

        private void btnTeachersAtManagers_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeachersMng teachersMng = new TeachersMng();
            teachersMng.ShowDialog();
        }

        private void btnCollegeStudentsAtManagers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CollegeStudentsMng collegeStudentsMng = new CollegeStudentsMng();
            collegeStudentsMng.ShowDialog();
        }

        private void btnForeignMembersAtManagers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForeignMembersMng foreignMembersMng = new ForeignMembersMng();
            foreignMembersMng.ShowDialog();
        }

        private void ClearAddGroup()
        {
            tbxAddIdMember.Text = tbxAddFirstNameMember.Text = tbxAddLastNameMember.Text = tbxAddGenderMember.Text
                = tbxAddAgeMember.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdMember.Text = tbxUpdateFirstNameMember.Text = tbxUpdateLastNameMember.Text
                = tbxUpdateGenderMember.Text = tbxUpdateAgeMember.Text = " ";
        }
    }
}
