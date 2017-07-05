using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Libretto.Model;
using Libretto.Model.Entity;

namespace Libretto
{
    public partial class OrderForm : Form
    {
        private LibrettoContext ctx = DbManager.Instance.Context;
        private Auction auction;

        public OrderForm(Auction auction)
        {
            InitializeComponent();

            this.auction = auction;

            titleLabel.Text = auction.Title;
            priceLabel.Text = auction.PricePerUnit.ToString();
            descriptionLabel.Text = auction.Description;
            sellerLabel.Text = auction.Creator.Username;
            quantityNumeric.Value = 1;

        }

        private void quantityNumeric_ValueChanged(object sender, EventArgs e)
        {
            decimal quantity = quantityNumeric.Value;
            sumLabel.Text = (quantity * auction.PricePerUnit).ToString();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Order newOrder = new Order();
                newOrder.Buyer = AuthManager.Instance.CurrentUser;
                newOrder.Auction = auction;
                newOrder.Date = DateTime.Now;
                newOrder.Seller = auction.Creator;
                newOrder.Quantity = (int)quantityNumeric.Value;
                newOrder.Address = addressTextBox.Text;
                ctx.Orders.Add(newOrder);
                ctx.SaveChanges();
                MessageBox.Show("Dodano zamówienie.");
                Close();
            }
        }

        private void addressTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(addressTextBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(addressTextBox, "Proszę wpisać adres.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
