using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SciencesStudies
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-PFG1UGB\SQLEXPRESS;Initial Catalog=FellowsAndMembersDb;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();           
        }

        private void tbxFirstName_Click(object sender, EventArgs e)
        {
            tbxFirstName.Clear();
            pnlFirstName.BackColor = Color.FromArgb(78, 184, 206);
            tbxFirstName.ForeColor = Color.FromArgb(78, 184, 206);

            pnlLastName.BackColor = Color.WhiteSmoke;
            tbxLastName.ForeColor = Color.WhiteSmoke;

            pnlGender.BackColor = Color.WhiteSmoke;
            tbxGender.ForeColor = Color.WhiteSmoke;

            pnlUsername.BackColor = Color.WhiteSmoke;
            tbxUsername.ForeColor = Color.WhiteSmoke;

            pnlPassword.BackColor = Color.WhiteSmoke;
            tbxPassword.ForeColor = Color.WhiteSmoke;
        }

        private void tbxLastName_Click(object sender, EventArgs e)
        {
            tbxLastName.Clear();
            pnlLastName.BackColor = Color.FromArgb(78, 184, 206);
            tbxLastName.ForeColor = Color.FromArgb(78, 184, 206);

            pnlFirstName.BackColor = Color.WhiteSmoke;
            tbxFirstName.ForeColor = Color.WhiteSmoke;
            
            pnlGender.BackColor = Color.WhiteSmoke;
            tbxGender.ForeColor = Color.WhiteSmoke;

            pnlUsername.BackColor = Color.WhiteSmoke;
            tbxUsername.ForeColor = Color.WhiteSmoke;

            pnlPassword.BackColor = Color.WhiteSmoke;
            tbxPassword.ForeColor = Color.WhiteSmoke;


        }

        private void tbxGender_Click(object sender, EventArgs e)
        {
            tbxGender.Clear();
            pnlGender.BackColor = Color.FromArgb(78, 184, 206);
            tbxGender.ForeColor = Color.FromArgb(78, 184, 206);

            pnlFirstName.BackColor = Color.WhiteSmoke;
            tbxFirstName.ForeColor = Color.WhiteSmoke;

            pnlLastName.BackColor = Color.WhiteSmoke;
            tbxLastName.ForeColor = Color.WhiteSmoke;

            pnlUsername.BackColor = Color.WhiteSmoke;
            tbxUsername.ForeColor = Color.WhiteSmoke;

            pnlPassword.BackColor = Color.WhiteSmoke;
            tbxPassword.ForeColor = Color.WhiteSmoke;

        }

        private void tbxUsername_Click(object sender, EventArgs e)
        {
            tbxUsername.Clear();
            pnlUsername.BackColor = Color.FromArgb(78, 184, 206);
            tbxUsername.ForeColor = Color.FromArgb(78, 184, 206);

            pnlFirstName.BackColor = Color.WhiteSmoke;
            tbxFirstName.ForeColor = Color.WhiteSmoke;

            pnlLastName.BackColor = Color.WhiteSmoke;
            tbxLastName.ForeColor = Color.WhiteSmoke;

            pnlGender.BackColor = Color.WhiteSmoke;
            tbxGender.ForeColor = Color.WhiteSmoke;

            pnlPassword.BackColor = Color.WhiteSmoke;
            tbxPassword.ForeColor = Color.WhiteSmoke;

        }

        private void tbxPassword_Click(object sender, EventArgs e)
        {
            tbxPassword.Clear(); //hazır fonksiyon
            tbxPassword.PasswordChar = '*'; //Kullanıcı tbxPassword'e şifre girerken şifre gözükmesin 
            pnlPassword.BackColor = Color.FromArgb(78, 184, 206);
            tbxPassword.ForeColor = Color.FromArgb(78, 184, 206);

            pnlFirstName.BackColor = Color.WhiteSmoke;
            tbxFirstName.ForeColor = Color.WhiteSmoke;

            pnlLastName.BackColor = Color.WhiteSmoke;
            tbxLastName.ForeColor = Color.WhiteSmoke;

            pnlGender.BackColor = Color.WhiteSmoke;
            tbxGender.ForeColor = Color.WhiteSmoke;

            pnlUsername.BackColor = Color.WhiteSmoke;
            tbxUsername.ForeColor = Color.WhiteSmoke;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "" || tbxPassword.Text == "")
            {
                MessageBox.Show("Please fill the mandatory fields! Username and Password informations are obligatory!");
            }

            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    //SqlCommand 'den nesne oluşturalım: //parantez içine stored procuders'daki name yazılır:
                    //ve de 2.parametre olarak sqlConnection yazılır.
                    SqlCommand sqlCommand = new SqlCommand("MemberAdd", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure; //komut(sqlCommand) nesnesini kullanırız.

                    //Stored procedure için parametreleri girmeliyiz.(management studio'daki parametreleri)
                    sqlCommand.Parameters.AddWithValue("@FirstName", tbxFirstName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@LastName", tbxLastName.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Gender", tbxGender.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Username", tbxUsername.Text.Trim());
                    sqlCommand.Parameters.AddWithValue("@Password", tbxPassword.Text.Trim());

                   
                    if (radioBtnAcademician.Checked)
                    {
                        sqlCommand.Parameters.AddWithValue("@Status", radioBtnAcademician.Text);
                    }
                    else if (radioBtnResearcher.Checked)
                    {
                        sqlCommand.Parameters.AddWithValue("@Status", radioBtnResearcher.Text);
                    }
                    else if (radioBtnTeacher.Checked)
                    {
                        sqlCommand.Parameters.AddWithValue("@Status", radioBtnTeacher.Text);
                    }
                    else if (radioBtnCollegeStudent.Checked)
                    {
                        sqlCommand.Parameters.AddWithValue("@Status", radioBtnCollegeStudent.Text);
                    }
                    else if (radioBtnForeignMember.Checked)
                    {
                        sqlCommand.Parameters.AddWithValue("@Status", radioBtnForeignMember.Text);
                    }

                    //Kaydedip Execute yapmak için:
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Registration is Successful!");
                    Clear();  //hazır fonk.değil,biz aşağıda yazdık
                }
            }
        }

        void Clear()  //Kayıt işlemi bitince taxtbox'lar temizlensin.
        {
            tbxFirstName.Text = tbxLastName.Text = tbxGender.Text = tbxUsername.Text = tbxPassword.Text = "";
        }

        private void btnRegisteredAlready_Click(object sender, EventArgs e)
        {
            this.Hide(); //bu ekran arka planda saklansın yani gitsin
            FormSignIn formSignIn = new FormSignIn();  //2.formun referansın
            formSignIn.ShowDialog(); //2.form ekranı açılsın.

        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void pnlTryMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void pnlTryMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

      

        private void pnlTryMove_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

    }
}
