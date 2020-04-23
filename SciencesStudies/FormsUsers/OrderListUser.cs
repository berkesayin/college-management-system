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
    public partial class OrderListUser : Form
    {
        public OrderListUser()
        {
            InitializeComponent();
        }

        OrderListDalUser _orderListDalUser = new OrderListDalUser();
        private void btnStaffAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4StaffMng form4StaffMng = new Form4StaffMng();
            form4StaffMng.ShowDialog();
        }

        private void btnGeneralBooksAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksUser generalBooksUser = new GeneralBooksUser();
            generalBooksUser.ShowDialog();
        }

        private void btnWorldLiteratureAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksUser literatureBooksUser = new LiteratureBooksUser();
            literatureBooksUser.ShowDialog();
        }

        private void btnSocialAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksUser socialBooksUser = new SocialBooksUser();
            socialBooksUser.ShowDialog();
        }

        private void btnMathematicalAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksUser mathematicalBooksUser = new MathematicalBooksUser();
            mathematicalBooksUser.ShowDialog();
        }

        private void btnEnglishAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksUser englishBooksUser = new EnglishBooksUser();
            englishBooksUser.ShowDialog();
        }

        private void btnJournalsAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsUser journalsUser = new JournalsUser();
            journalsUser.ShowDialog();
        }

        private void btnNewspapersAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersUser newspapersUser = new NewspapersUser();
            newspapersUser.ShowDialog();
        }

        private void btnChangeAccountAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void OrderListUser_Load(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void LoadOrderList()
        {
            dgwOrderList.DataSource = _orderListDalUser.GetAllOrderLists();
        }

        private void btnAddOrderList_Click(object sender, EventArgs e)
        {
            _orderListDalUser.Add(new OrderList
            {
                Id = Convert.ToInt32(tbxAddIdOrderList.Text),
                KindOfText = tbxAddKindOrderList.Text,
                NameOfText = tbxAddNameOrderList.Text,
                LanguageOfIt = tbxAddLanguageOrderList.Text,
                Price = Convert.ToInt32(tbxAddPriceOrderList.Text),
                DeliveryDay = Convert.ToInt32(tbxAddDeliveryDayOrderList.Text)
            });
            //işlem bitince liste yenilensin
            LoadOrderList();

            MessageBox.Show("New Order Added!!");

            //textbox'lar temizlensin :
            ClearAddGroup();
        }

        private void ClearAddGroup()
        {
            tbxAddIdOrderList.Text = tbxAddKindOrderList.Text = tbxAddNameOrderList.Text =
                tbxAddLanguageOrderList.Text = tbxAddPriceOrderList.Text = tbxAddDeliveryDayOrderList.Text = " ";
        }

        private void dgwOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateIdOrderList.Text = dgwOrderList.CurrentRow.Cells[0].Value.ToString();
            tbxUpdateKindOrderList.Text = dgwOrderList.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateNameOrderList.Text = dgwOrderList.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateLanguageOrderList.Text = dgwOrderList.CurrentRow.Cells[3].Value.ToString();
            tbxUpdatePriceOrderList.Text = dgwOrderList.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateDeliveryDayOrderList.Text = dgwOrderList.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdateOrderList_Click(object sender, EventArgs e)
        {
            _orderListDalUser.Update(new OrderList
            {
                Id = Convert.ToInt32(tbxUpdateIdOrderList.Text),
                KindOfText = tbxUpdateKindOrderList.Text,
                NameOfText = tbxUpdateNameOrderList.Text,
                LanguageOfIt = tbxUpdateLanguageOrderList.Text,
                Price = Convert.ToInt32(tbxUpdatePriceOrderList.Text),
                DeliveryDay = Convert.ToInt32(tbxUpdateDeliveryDayOrderList.Text)
            });
            //işlem bitince liste yenilensin :
            LoadOrderList();

            MessageBox.Show("Order Updated!!");

            //textbox'lar temizlensin :
            ClearUpdateGroup();
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdOrderList.Text = tbxUpdateKindOrderList.Text = tbxUpdateNameOrderList.Text =
                tbxUpdateLanguageOrderList.Text = tbxUpdatePriceOrderList.Text =
                tbxUpdateDeliveryDayOrderList.Text = " ";
        }

        private void btnRemoveOrderList_Click(object sender, EventArgs e)
        {
            _orderListDalUser.Delete(new OrderList
            {
                Id = Convert.ToInt32(dgwOrderList.CurrentRow.Cells[0].Value.ToString())
            });
            //işlem bitince liste yenilensin :
            LoadOrderList();

            MessageBox.Show("Order Deleted!!");
        }
    }
}
