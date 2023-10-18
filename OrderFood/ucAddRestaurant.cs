using DevExpress.XtraEditors;
using Newtonsoft.Json;
using OnlineFood.Core.Domain;
using OrderFood.API;
using RestSharp;
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

namespace OrderFood
{
    public partial class ucAddRestaurant : DevExpress.XtraEditors.XtraUserControl
    {
        public static bool isChecked = false;
        public ucAddRestaurant()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            if (isChecked == true)
            {
                Restaurant rest = SessionData.restaurant;
                txtRestName.Text = rest.restaurant_name;
                txtRestAddr.Text = rest.address;
                txtPhoneNumber.Text = rest.phone_number;
                txtBankName.Text = rest.bank_name;
                txtBankAcc.Text = rest.bank_account;
                btnQr.Text = rest.qr_code;
                btnPhoto.Text = rest.photo;
            }
            else
            {
                txtRestName.Text = "";
                txtRestAddr.Text = "";
                txtPhoneNumber.Text = "";
                txtBankName.Text = "";
                txtBankAcc.Text = "";
                btnQr.Text = "";
                btnPhoto.Text = "";
            }
        }

        private void buttonEdit3_Click(object sender, EventArgs e)
        {
            xtraOpenFileDialog1.InitialDirectory = "c:\\";
            xtraOpenFileDialog1.Filter = "Bitmaps | *.bmp | PNG files | *.png | JPEG files | *.jpg | GIF files | *.gif | TIFF files | *.tif | Image files | *.bmp; *.jpg; *.gif; *.png; *.tif | All files | *.*";

            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file.
                string filePath = xtraOpenFileDialog1.FileName;
                btnQr.Text = filePath;
            }
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            xtraOpenFileDialog1.InitialDirectory = "c:\\";
            xtraOpenFileDialog1.Filter = "Bitmaps | *.bmp | PNG files | *.png | JPEG files | *.jpg | GIF files | *.gif | TIFF files | *.tif | Image files | *.bmp; *.jpg; *.gif; *.png; *.tif | All files | *.*";

            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file.
                string filePath = xtraOpenFileDialog1.FileName;
                btnPhoto.Text = filePath;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (isChecked == true)
            {
                Restaurant empRest = new Restaurant();
                empRest.restaurant_id = SessionData.restaurant.restaurant_id;
                empRest.restaurant_name = txtRestName.Text;
                empRest.phone_number = txtPhoneNumber.Text;
                empRest.address = txtRestAddr.Text;
                empRest.bank_account = txtBankAcc.Text;
                empRest.bank_name = txtBankName.Text;
                empRest.qr_code = btnQr.Text;
                empRest.photo = btnPhoto.Text;
                string body = JsonConvert.SerializeObject(empRest);
                var del = ApiService.callAPI<Restaurant>("Restaurant/Update/", Method.Delete, null, body).Result;
            }
            else
            {
                Restaurant empRest = new Restaurant();
                empRest.restaurant_id = SessionData.restaurant.restaurant_id;
                empRest.restaurant_name = txtRestName.Text;
                empRest.phone_number = txtPhoneNumber.Text;
                empRest.address = txtRestAddr.Text;
                empRest.bank_account = txtBankAcc.Text;
                empRest.bank_name = txtBankName.Text;
                empRest.qr_code = btnQr.Text;
                empRest.photo = btnPhoto.Text;
                string body = JsonConvert.SerializeObject(empRest);
                var res = ApiService.callAPI<Restaurant>("Restaurant/CreateNew/", Method.Post, null, body).Result;
            }
          
        }
    }
}