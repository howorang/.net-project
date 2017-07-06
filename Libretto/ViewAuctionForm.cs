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
    public partial class ViewAuctionForm : Form
    {

        private Auction auction;

        public ViewAuctionForm(Auction auction)
        {
            InitializeComponent();

            titleLabel.Text = auction.Title;
            priceLabel.Text = auction.PricePerUnit.ToString();
            descriptionLabel.Text = auction.Description;
            sellerLabel.Text = auction.Creator.Username;
            if(auction.Image != null)
                photoPictureBox.Image = (Bitmap)((new ImageConverter()).ConvertFrom(auction.Image));

            this.auction = auction;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm newForm = new OrderForm(auction);
            newForm.FormClosed += (p, s) => this.Close();
            this.Hide();
            newForm.Show();
        }
    }
}
