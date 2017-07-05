using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Libretto.Model.Entity;
using Libretto.Model;
using System.Data.Entity;

namespace Libretto
{
    public partial class AdminPanel : Form
    {
        private LibrettoContext ctx = DbManager.Instance.Context;

        public AdminPanel()
        {
            InitializeComponent();
            refreshProfitChart();
            bindComboBoxColumns();
          

            
        }

        private void bindComboBoxColumns()
        {
            ctx.Roles.Load();
            ctx.Users.Load();
            userBindingSource.DataSource = ctx.Users.Local.ToBindingList();

            ctx.Orders.Load();
            orderBindingSource.DataSource = ctx.Orders.Local.ToBindingList();

            ctx.Auctions.Load();
            auctionBindingSource.DataSource = ctx.Auctions.Local.ToBindingList();

            userRoleCol.DataSource = ctx.Roles.Local.ToBindingList();
            userRoleCol.ValueMember = "Self";
            userRoleCol.DisplayMember = "Name";


            creatorCol.DataSource = ctx.Users.Local.ToBindingList();
            creatorCol.ValueMember = "Self";
            creatorCol.DisplayMember = "Username";
       
            
            buyerCol.DataSource = ctx.Users.Local.ToBindingList();
            buyerCol.ValueMember = "Self";
            buyerCol.DisplayMember = "Username";


            sellerCol.DataSource = ctx.Users.Local.ToBindingList();
            sellerCol.ValueMember = "Self";
            sellerCol.DisplayMember = "Username";



            auctionCol.DataSource = ctx.Auctions.Local.ToBindingList();
            auctionCol.ValueMember = "Self";
            auctionCol.DisplayMember = "Title";
        }

        private void refreshProfitChart()
        {
            ctx.Orders.Load();

            var queryForProfit = from order
                                 in ctx.Orders.Local
                                 group order by new DateTime(order.Date.Year, order.Date.Month, 1)
                                 into g
                                 select new
                                 {
                                     date = g.Key,
                                     profit = g.Sum(x => x.Auction.PricePerUnit)
                                 };

            Series series = new Series();
            foreach (var point in queryForProfit)
            {
                series.XValueType = ChartValueType.DateTime;
                series.Points.AddXY(point.date, point.profit);
            }

            profitChart.Series.Add(series);
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

    }
}
