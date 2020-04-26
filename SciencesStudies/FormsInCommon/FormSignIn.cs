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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();  
            
        }

        private void tbxSignInUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void tbxSignInPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSignInLogo_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-PFG1UGB\SQLEXPRESS ; Initial Catalog = FellowsAndMembersDb ; Integrated Security=True ;");
            ///Yukarıdaki gibi yazalım eğer hata verirse FellowsAndMembersDb Properties'den copy-paste yaparız.
            string query = "Select * from tblMembers Where username = '" + tbxSignInUsername.Text.Trim() + "'and Password = '" + tbxSignInPassword.Text.Trim() + "'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                if (radioBtnManager.Checked)
                {
                    Form3Main form3Main = new Form3Main();
                    this.Hide();
                    form3Main.ShowDialog();
                }
                else
                {
                    this.Hide();
                    Form3MainMembers form3MainMembers = new Form3MainMembers();
                    form3MainMembers.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Please Check your Username and Password");
            }

        }

        private void tbxSignInUsername_Enter(object sender, EventArgs e)
        {
            if (tbxSignInUsername.Text == "User Name")
            {
                tbxSignInUsername.Text = string.Empty;
                tbxSignInUsername.ForeColor = Color.White;
            }
        }

        private void tbxSignInUsername_Leave(object sender, EventArgs e)
        {
            if (tbxSignInUsername.Text == string.Empty)
            {
                tbxSignInUsername.Text = "User Name";
                tbxSignInUsername.ForeColor = Color.FromArgb(150, 150, 150);
            }
        }

        private void tbxSignInPassword_Enter(object sender, EventArgs e)
        {

            if (tbxSignInPassword.Text == "Password")
            {
                tbxSignInPassword.Text = string.Empty;
                tbxSignInPassword.ForeColor = Color.White;
            }
            if (i % 2 == 0)
                tbxSignInPassword.UseSystemPasswordChar = true; // TechLead kodu
        }

        private void tbxSignInPassword_Leave(object sender, EventArgs e)
        {
            if (tbxSignInPassword.Text == string.Empty)
            {
                tbxSignInPassword.Text = "Password";
                tbxSignInPassword.ForeColor = Color.FromArgb(150, 150, 150);
                if (i % 2 == 0)
                    tbxSignInPassword.UseSystemPasswordChar = false;
            }
            
        }
        int i = 0;
        private void pictureBoxToggle_Click(object sender, EventArgs e)
        {
            //pictureBoxToggle.Image = global::SciencesStudies.Properties.Resources.toggleImageTurkuaz;
            //this.pictureBoxToggle.Location = new System.Drawing.Point(274, 171);
            //this.pictureBoxToggle.Name = "pictureBoxToggle";
            //this.pictureBoxToggle.Size = new System.Drawing.Size(33, 26);
            //this.pictureBoxToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            //this.pictureBoxToggle.TabIndex = 15;
            //this.pictureBoxToggle.TabStop = false;
            //yeni eklendi.

            if (i % 2 == 0)
            {
                tbxSignInPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxSignInPassword.UseSystemPasswordChar = true;
            }
            i++;
            


        }
    }
}
