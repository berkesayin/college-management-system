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
            tbxSignInUsername.Clear();
            pnlSignInUsername.BackColor = Color.FromArgb(78, 184, 206);
            tbxSignInUsername.ForeColor = Color.FromArgb(78, 184, 206);

            pnlSignInPassword.BackColor = Color.WhiteSmoke;
            tbxSignInPassword.ForeColor = Color.WhiteSmoke;
        }

        private void tbxSignInPassword_Click(object sender, EventArgs e)
        {
            tbxSignInPassword.Clear();           
            pnlSignInPassword.BackColor = Color.FromArgb(78, 184, 206);
            tbxSignInPassword.ForeColor = Color.FromArgb(78, 184, 206);

            pnlSignInUsername.BackColor = Color.WhiteSmoke;
            tbxSignInUsername.ForeColor = Color.WhiteSmoke;
        }

        private void btnSignInLogo_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB ; Initial Catalog = FellowsAndMembersDb ; Integrated Security=True ;");
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
    }
}
