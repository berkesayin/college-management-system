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
    public partial class OrderListMng : Form
    {
        public OrderListMng()
        {
            InitializeComponent();
        }

        OrderListDalMng _orderListDalMng = new OrderListDalMng();
        private void btnGeneralBooksAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            GeneralBooksMng generalBooksMng = new GeneralBooksMng();
            generalBooksMng.ShowDialog();
        }

        private void btnLiteratureBooksAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            LiteratureBooksMng literatureBooksMng = new LiteratureBooksMng();
            literatureBooksMng.ShowDialog();
        }

        private void btnSocialBooksAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            SocialBooksMng socialBooksMng = new SocialBooksMng();
            socialBooksMng.ShowDialog();
        }

        private void btnMathematicalBooksAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathematicalBooksMng mathematicalBooksMng = new MathematicalBooksMng();
            mathematicalBooksMng.ShowDialog();
        }

        private void btnEnglishBooksAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishBooksMng englishBooksMng = new EnglishBooksMng();
            englishBooksMng.ShowDialog();
        }

        private void btnJournalsAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            JournalsMng journalsMng = new JournalsMng();
            journalsMng.ShowDialog();
        }

        private void btnNewspapersAtOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewspapersMng newspapersMng = new NewspapersMng();
            newspapersMng.ShowDialog();
        }

        private void btnReturnMenuOrderList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3Main form3Main = new Form3Main();
            form3Main.ShowDialog();
        }

        private void OrderListMng_Load(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void LoadOrderList()
        {
            dgwOrderList.DataSource = _orderListDalMng.GetAllOrderLists();
        }

        private void btnAddOrderList_Click(object sender, EventArgs e)
        {
            _orderListDalMng.Add(new OrderList
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

            MessageBox.Show("Order Added!!");

            ClearAddGroup();
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
            _orderListDalMng.Update(new OrderList
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

            ClearUpdateGroup();
        }

        private void btnRemoveOrderList_Click(object sender, EventArgs e)
        {
            _orderListDalMng.Delete(new OrderList
            {
                Id = Convert.ToInt32(dgwOrderList.CurrentRow.Cells[0].Value.ToString())
            });
            //işlem bitince liste yenilensin :
            LoadOrderList();

            MessageBox.Show("Order Deleted!!");
        }

        private void ClearAddGroup()
        {
            tbxAddIdOrderList.Text = tbxAddKindOrderList.Text = tbxAddNameOrderList.Text =
                tbxAddLanguageOrderList.Text = tbxAddPriceOrderList.Text = tbxAddDeliveryDayOrderList.Text = " ";
        }

        private void ClearUpdateGroup()
        {
            tbxUpdateIdOrderList.Text = tbxUpdateKindOrderList.Text = tbxUpdateNameOrderList.Text =
                tbxUpdateLanguageOrderList.Text = tbxUpdatePriceOrderList.Text =
                tbxUpdateDeliveryDayOrderList.Text = " ";

        }
    }
}
