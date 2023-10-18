using OnlineFood.Core.Domain;
using OrderFood.API;
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
    public partial class ucPayment : UserControl
    {
        private List<PaymentDetail> lstPayment = new List<PaymentDetail>();
        public ucPayment()
        {
            InitializeComponent();
        }

        private void dtpFromDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ucPayment_Load(object sender, EventArgs e)
        {
            dtpFromDay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDay.Value = DateTime.Now;
            //load grid vỉew
            LoadGridView();
            AdjustCollumn();
            //load combo box
            LoadEmployee();
            LoadCmbPayment();
            LoadCmbOrder();
            //load money 
            LoadMoney();

        }
        private void LoadGridView()
        {
            try
            {
                var res = ApiService.callAPI<List<TransactionLunch>>("TransactionLunch/GetAll/", RestSharp.Method.Get, null, null).Result;
                var api = ApiService.callAPI<List<Transaction_detail>>("Transaction_detail/GetAll/", RestSharp.Method.Get, null, null).Result;
                List<TransactionLunch> lstTransactionLunch = res.Data;
                List<Transaction_detail> lstTransactionDetail = api.Data;
                for (int i = 0; i < lstTransactionLunch.Count; i++) 
                {
                    if (lstTransactionLunch[i].full_name == SessionData.empCurrent.full_name)
                    {
                        PaymentDetail payment = new PaymentDetail();
                        if (lstTransactionLunch[i].statusPayment == "Chưa thanh toán")
                        {
                            payment.customerName = lstTransactionLunch[i].full_name;
                            payment.total_quantity = lstTransactionLunch[i].total_quantity;
                            payment.total_price = lstTransactionLunch[i].total_price;
                            payment.statusOrder = lstTransactionLunch[i].statusOrder;
                            payment.statusPayment = lstTransactionLunch[i].statusPayment;
                            payment.employee_ordered_name = lstTransactionLunch[i].employee_ordered_name;
                            payment.order_date = lstTransactionLunch[i].order_date;
                            payment.full_name = lstTransactionLunch[i].full_name;
                            payment.employee_id = lstTransactionLunch[i].employee_id;
                            payment.transaction_id = lstTransactionLunch[i].transaction_id;
                            payment.createBy = lstTransactionLunch[i].createBy;
                            payment.createDate = lstTransactionLunch[i].createDate;
                            payment.updateBy = lstTransactionLunch[i].updateBy;
                            payment.updateDate = lstTransactionLunch[i].updateDate;
                        }
                        if (lstTransactionDetail[i].transaction_id == lstTransactionLunch[i].transaction_id)
                        {
                            payment.food_name = lstTransactionDetail[i].food_name;
                            payment.price = lstTransactionDetail[i].price;
                            payment.quantity = lstTransactionDetail[i].quantity;
                            payment.food_id = lstTransactionDetail[i].food_id;
                            payment.note = lstTransactionDetail[i].note;
                            payment.restaurant_id = lstTransactionDetail[i].restaurant_id;
                            payment.transaction_detail_id = lstTransactionDetail[i].transaction_detail_id;
                        }
                        lstPayment.Add(payment);
                    }
                }
                dtgNotPaid.DataSource = lstPayment;
                }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }
        private void AdjustCollumn()
        {
            dtgNotPaid.RowHeadersVisible = false;
            dtgNotPaid .Columns["employee_id"].Visible = false;
            dtgNotPaid.Columns["full_name"].Visible = false;
        }
        private void LoadEmployee()
        {
            try
            {
                var res = ApiService.callAPI<List<Employee>>("Employee/GetAll", RestSharp.Method.Get, null, null).Result;
                if (res.Code == HttpStatusCode.OK)
                {
                    if (res.Data.Count > 0)
                    {
                        var a = SessionData.empCurrent.full_name;
                        cmbEmployee.DataSource = res.Data;
                        cmbEmployee.DisplayMember = "full_name";
                        cmbEmployee.ValueMember = "employee_id";
                        cmbEmployee.Text = a;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void LoadMoney()
        {
            decimal money = 0;
            foreach (DataGridViewRow row in dtgNotPaid.Rows)
            {
                money += row.Cells["colMoney"].Value != null ? Convert.ToDecimal(row.Cells["colMoney"].Value.ToString()) : 0;
            }
            lblMoney.Text = money.ToString("#.##") + "VND";
        }
        private void LoadCmbPayment()
        {
            List<String> lstPayment = new List<String>();
            lstPayment.Add("Đã nhận");
            lstPayment.Add("Đã thanh toán");
            lstPayment.Add("Chưa thanh toán");
            cmbPaymentStatus.DataSource = lstPayment;
            cmbPaymentStatus.DisplayMember = "Chưa thanh toán";
        }
        private void LoadCmbOrder()
        {
            List<String> lstOrder = new List<String>();
            lstOrder.Add("Mới");
            lstOrder.Add("Chưa xác nhận");
            lstOrder.Add("Đã xác nhận");
            cmbOrderStatus.DataSource = lstOrder;
            cmbOrderStatus.DisplayMember = "Mới";
        }
    }
}
