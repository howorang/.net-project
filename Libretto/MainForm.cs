using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libretto.Model;
using Libretto.Model.Entity;
using System.Data.Entity;

namespace Libretto
{
    public partial class MainForm : Form
    {
        private LibrettoContext ctx = DbManager.Instance.Context;
        public MainForm()
        {
            InitializeComponent();
            adminPanelButton.Visible = (AuthManager.Instance.CurrentUser.UserRole.Name == "ADMIN");
            usernameLabel.Text = AuthManager.Instance.CurrentUser.Username;

            ctx.Auctions.Load();
            auctionBindingSource.DataSource = ctx.Auctions.Local.ToBindingList();

            User currentUser = AuthManager.Instance.CurrentUser;

            ctx.Orders.Load();
            var usersOrders = from order
                              in ctx.Orders.Local
                              where order.Buyer == currentUser
                              select order;

            orderBindingSource.DataSource = usersOrders.ToList();

        }

        private void addAuctionButton_Click(object sender, EventArgs e)
        {
            AddAuctionForm newForm = new AddAuctionForm();
            newForm.Show();

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ctx.Auctions.Load();
            auctionBindingSource.DataSource = ctx.Auctions.Local.ToBindingList();

        }

        private void auctionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void auctionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            DataGridViewButtonColumn buttonColumn = senderGrid.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            if (buttonColumn != null && e.RowIndex >= 0)
            {
                if (buttonColumn.Name == "openColumn")
                {
                    Auction selectedAuction = (Auction)senderGrid.Rows[e.RowIndex].DataBoundItem;
                    ViewAuctionForm newForm = new ViewAuctionForm(selectedAuction);
                    newForm.Show();
                }
            }
        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ordersRefreshButton_Click(object sender, EventArgs e)
        {
            User currentUser = AuthManager.Instance.CurrentUser;

            ctx.Orders.Load();
            var usersOrders = from order
                              in ctx.Orders.Local
                              where order.Buyer == currentUser
                              select order;

            orderBindingSource.DataSource = usersOrders.ToList();
        }

        private void adminPanelButton_Click(object sender, EventArgs e)
        {
            AdminPanel newForm = new AdminPanel();
            newForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            var query = from auction
                        in ctx.Auctions
                        where auction.Title.Contains(searchText)
                        || auction.Description.Contains(searchText)
                        || auction.Creator.Username.Contains(searchText)
                        select auction;

            auctionBindingSource.DataSource = query.ToList();
        }
    }
}
