using Newtonsoft.Json;
using OnlineFood.Core.Domain;
using OrderFood.API;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderFood
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (!Validation())
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Lấy thông tin của người dùng
                string username = txtUserName.Text;
                string pass = txtPass.Text;
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("userName", username);
                param.Add("pass", pass);

                // Gọi API
                var res = ApiService.callAPI<Employee>("Employee/login/", Method.Get, param, null).Result;
                if (res.Code == HttpStatusCode.OK)
                {
                    if (res.Data != null)
                    {
                        SessionData.SetEmpCurrent(res.Data);
                        this.Hide();
                        frmMain frm = new frmMain();
                        frm.ShowDialog();                       
                    }
                }
            }
            catch (Exception ex)
            {
                if (txtUserName == null || txtPass == null)
                {
                    MessageBox.Show("Không để trống");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }


        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                return false;
            }
            return true;
        }
    }
}
