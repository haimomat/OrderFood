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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderFood
{
    public partial class frmSubmit : Form
    {
        //List<FoodOrder> _lstChoosed;
        public frmSubmit()
        {
            InitializeComponent();
        }
        private ucOrderList un;
        public frmSubmit(ucOrderList uc)
        {
            InitializeComponent();
            un = uc;
        }
        private void frmSubmit_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = SessionData.empCurrent.full_name;
            dtgSubmit.DataSource = SessionData.lstChoosed;
            LoadMoney();
            AdjustColumnOrder();
        }
        private void AdjustColumnOrder()
        {
            dtgSubmit.RowHeadersVisible = false;
            dtgSubmit.Columns["food_id"].Visible = false;
            dtgSubmit.Columns["restaurant_id"].Visible = false;
            dtgSubmit.Columns["photo"].Visible = false;
        }
        private void LoadMoney()
        {
            decimal money = 0;
            foreach (DataGridViewRow row in dtgSubmit.Rows)
            {
                money += Convert.ToDecimal(row.Cells["colTotalMoney"].Value);
            }
            lblMoney.Text = money.ToString("#.##") + "VND";
            SessionData.SetMoney(money.ToString("#.##"));
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!frmMain.Instance.PnlParent.Controls.ContainsKey("ucOrderList"))
            {
                ucOrderList uc = new ucOrderList();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.PnlParent.Controls.Add(uc);
            }
            un.LoadData();
            //un.takeData();
            //un.CreateNewToDb();
            un.Dock = DockStyle.Fill;
            frmMain.Instance.PnlParent.Controls.RemoveByKey("ucOrderList");
            frmMain.Instance.PnlParent.Controls.Add(un);
            //frmMain.Instance.PnlParent.Controls["ucManagerOrder"].BringToFront();
            frmMain.Instance.PnlParent.Controls["ucOrder"].Hide();
        }
    }
}
