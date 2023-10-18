using OnlineFood.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderFood
{
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
        }
        private void FrmPayment_Load(object sender, EventArgs e)
        {
            //load ảnh
            LoadImg();
            //load thông tin ngân hàng
            LoadRestaurantInfo();
        }
        private void LoadRestaurantInfo()
        {
            Restaurant restInfo = SessionData.restaurant;
            lblNameOfBank.Text = restInfo.bank_name;
            lblStk.Text = restInfo.bank_account;
            lblMoney.Text = SessionData.money + "VND";
        }
        private void LoadImg()
        {
            string imageUrl = "https://cdn.britannica.com/17/155017-050-9AC96FC8/Example-QR-code.jpg";//SessionData.restaurant.qr_code; // Replace with the URL of your image

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(imageUrl);

                    // Create a MemoryStream from the downloaded image data
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        // Set the PictureBox's Image property to the downloaded image
                        pcbQrCode.Image = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
