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
    public partial class ucManagerOrder : UserControl
    {
        public ucManagerOrder()
        {
            InitializeComponent();
        }
        private void btnOrderManageOrder_Click(object sender, EventArgs e)
        {
            // xóa uc hiện tại, và add ucOrder
            if (!frmMain.Instance.PnlParent.Controls.ContainsKey("ucOrder"))
            {
                ucOrder un = new ucOrder();
                un.Dock = DockStyle.Fill;
                frmMain.Instance.PnlParent.Controls.Add(un);
            }
            frmMain.Instance.PnlParent.Controls["ucOrder"].BringToFront();
            frmMain.Instance.PnlParent.Controls["ucOrder"].Show();
        }
        private void ucManagerOrder_Load(object sender, EventArgs e)
        {
            LoadData();
            dtgOrderDetail.RowHeadersVisible = false;
        }

        public void LoadData()
        {
            dtgOrderDetail.DataSource = SessionData.lstOrderDetail;
            LoadCombobox();
            
        }
        public void AdjustColumn()
        {
            dtgOrderDetail.Columns["createBy"].Visible = false;
            dtgOrderDetail.Columns["updateBy"].Visible = false;
            dtgOrderDetail.Columns["createDate"].Visible = false;
            dtgOrderDetail.Columns["food_id"].Visible = false;
            dtgOrderDetail.Columns["updateDate"].Visible = false;
            dtgOrderDetail.Columns["total_quantity"].Visible = false;
        }
        private void dtgOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var grid = (sender as DataGridView);
                if (grid.Rows[e.RowIndex].Cells["colStatus"].Value.ToString() == "Mới")
                {
                    frmMain.Instance.PnlParent.Controls["ucOrder"].BringToFront();
                    frmMain.Instance.PnlParent.Controls["ucOrder"].Show();
                }
            }
           
        }
        public void takeData()
        {
            List<TransactionLunch> transactionlunch = new List<TransactionLunch>();
            List<Transaction_detail> transaction_Details = new List<Transaction_detail>();
            int i = 0;
            int count = 0;
            int orderId;
            var res = ApiService.callAPI<List<TransactionLunch>>("TransactionLunch/GetAll/", RestSharp.Method.Get, null, null).Result;
            if (res.Data.Count == 0)
            {
                orderId = 1;
            }
            else
            {
                string str = res.Data[res.Data.Count - 1].transaction_id;
                orderId = int.Parse(str.Substring(6)) + 1;
            }
            foreach (DataGridViewRow row in dtgOrderDetail.Rows)
            {
                TransactionLunch tsl = new TransactionLunch();
                Transaction_detail tsd = new Transaction_detail();
                tsl.employee_id = SessionData.empCurrent.employee_id;
                tsl.employee_ordered_name = SessionData.empCurrent.full_name;
                tsl.full_name = row.Cells["colCustomerName"].Value != null ? row.Cells["colCustomerName"].Value.ToString() : "";
                tsd.food_name = row.Cells["colFoodName"].Value != null ? row.Cells["colFoodName"].Value.ToString() : "";
                tsd.price = row.Cells["colPrice"].Value != null ? Convert.ToDecimal(row.Cells["colPrice"].Value.ToString()) : 0; 
                tsd.quantity = row.Cells["colQuantity"].Value != null ? int.Parse(row.Cells["colQuantity"].Value.ToString()) : 0;
                tsl.total_price = row.Cells["colTotal"].Value != null ? Convert.ToDecimal(row.Cells["colTotal"].Value.ToString()) : 0;
                tsl.statusOrder = row.Cells["colStatus"].Value != null ? row.Cells["colStatus"].Value.ToString() : "";
                tsd.note = row.Cells["colNote"].Value != null ? row.Cells["colNote"].Value.ToString() : "";
                tsl.order_date = DateTime.Now;
                tsl.statusPayment = "Chưa thanh toán";
                tsd.restaurant_id = SessionData.restaurant_id;
                tsd.food_id = SessionData.lstOrderDetail[i].food_id;
                tsd.createBy = SessionData.lstOrderDetail[i].createBy;
                tsd.createDate = SessionData.lstOrderDetail[i].createDate;
                tsl.createBy = SessionData.lstOrderDetail[i].createBy;
                tsl.createDate = SessionData.lstOrderDetail[i].createDate;
                count += tsd.quantity;
                tsl.total_quantity = count;
                tsl.updateBy = SessionData.empCurrent.full_name;
                tsd.updateBy = SessionData.empCurrent.full_name;
                string transactionId = "Order_" + orderId.ToString();
                tsl.transaction_id = transactionId;
                tsd.transaction_id = transactionId;
                transactionlunch.Add(tsl);
                transaction_Details.Add(tsd);
                i++;
                orderId++;
            }            
            SessionData.SetListTransactionLunch(transactionlunch);
            SessionData.SetListTransactionDetail(transaction_Details);
        }
        public void CreateNewToDb()
        {
            for (int i = 0; i < SessionData.lstTransactionLunch.Count; i++)
            {
                string body = JsonConvert.SerializeObject(SessionData.lstTransactionLunch[i]);
                var res = ApiService.callAPI<TransactionLunch>("TransactionLunch/CreateNew/", Method.Post, null, body).Result;
            }
            for(int i = 0; i < SessionData.lstTransactionDetail.Count; i++)
            {
                string body = JsonConvert.SerializeObject(SessionData.lstTransactionDetail[i]);
                var res = ApiService.callAPI<Transaction_detail>("Transaction_detail/CreateNew/", Method.Post, null, body).Result;
            }
        }

        public void LoadCombobox()
        {
            try
            {
                var res = ApiService.callAPI<List<Employee>>("Employee/GetAll/", RestSharp.Method.Get, null, null).Result;
                if (res.Code == HttpStatusCode.OK)
                {
                    if (res.Data.Count > 0)
                    {
                        cmbOrderName.DataSource = res.Data;
                        cmbOrderName.DisplayMember = "full_name";
                        cmbOrderName.ValueMember = "employee_id";
                        cmbOrderName.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}

