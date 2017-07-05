using Libretto.Model;
using Libretto.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libretto
{
    public partial class AddAuctionForm : Form
    {

        private LibrettoContext ctx = DbManager.Instance.Context;

        public AddAuctionForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Auction newAuction = new Auction();
                newAuction.Title = titleTextBox.Text;
                newAuction.ItemQuantity = (int)quantityNumeric.Value;
                newAuction.Description = descriptionTextBox.Text;
                newAuction.Creator = AuthManager.Instance.CurrentUser;
                newAuction.PricePerUnit = GetBruttoPrice(priceNumeric.Value);
                newAuction.Image = getImageBytes(photoPictureBox.Image);
                ctx.Auctions.Add(newAuction);
                ctx.SaveChanges();
                Close();
            }
        }


        public static byte[] getImageBytes(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private void titleTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (titleTextBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(titleTextBox, "Proszę wpisać tytuł.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void priceNumeric_Validating(object sender, CancelEventArgs e)
        {
            if (priceNumeric.Value == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(priceNumeric, "Cena nie może wynosić 0.");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void descriptionTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (descriptionTextBox.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(descriptionTextBox, "Proszę wpisać opis.");
            }
            else
            {
                e.Cancel = false;
            }

        }

        private void priceNumeric_ValueChanged(object sender, EventArgs e)
        {
            bruttoLabel.Text = GetBruttoPrice(priceNumeric.Value).ToString();
        }

        private decimal GetBruttoPrice(decimal price)
        {
            return price * 1.05m;
        }

        private void AddAuctionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                {
                    Image image = Image.FromFile(openFileDialog1.FileName);
                    photoPictureBox.Image = image;
                }
            }
            catch
            {
                MessageBox.Show("Błąd otwierania pliku.");
            }
        }

        private void loadPhotoButton_Click(object sender, EventArgs e)
        {
            loadPhotoButton.CausesValidation = false;
            openFileDialog1.ShowDialog(this);
        }

    }

}

