using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using Newtonsoft.Json;
using OnlineFood.Core.Domain;
using OrderFood.API;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderFood
{
    public partial class ucOrderList : DevExpress.XtraEditors.XtraUserControl
    {
        public ucOrderList()
        {
            InitializeComponent();
            LoadData();
        }
       public void LoadData()
        { 
                dtpOrderDate.EditValue = DateTime.Today;
                dtgOrderDetail.DataSource = SessionData.lstOrderDetail;   
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.PnlParent.Controls.ContainsKey("ucOrderDetail"))
            {
                ucOrderDetail un = new ucOrderDetail();
                un.Dock = DockStyle.Fill;
                frmMain.Instance.PnlParent.Controls.Add(un);
            }
            frmMain.Instance.PnlParent.Controls["ucOrderDetail"].BringToFront();
            frmMain.Instance.PnlParent.Controls["ucOrderDetail"].Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //take data from combo box, text, dtp
            if (dtpOrderDate != null || cmbCustomerName != null || txtFoodName != null)
            {
            }
            //
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã click");
        }
    }
}
