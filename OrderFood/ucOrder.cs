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
    public partial class ucOrder : UserControl
    {
        public ucOrder()
        {
            InitializeComponent();
        }

        private void ucOrder_Load(object sender, EventArgs e)
        {
            // Set ngày hiện tại
            dtpOrderDate.Value = DateTime.Today;

            // Set data cho combobox nhà hàng
            LoadCombobox();
            // Set giá trị mặc định cho Combobox

            // Hiển thị danh sách món ăn theo RestaurantID được chọn
            LoadFood();
            //Set data cho combobox khách hàng
            LoadCustomer();
        }

        private void LoadCombobox()
        {
            try
            {
                var res = ApiService.callAPI<List<Restaurant>>("Restaurant/GetAll/", RestSharp.Method.Get, null, null).Result;
                if (res.Code == HttpStatusCode.OK)
                {
                    if (res.Data.Count > 0)
                    {
                        cbRestName.DataSource = res.Data;
                        cbRestName.DisplayMember = "restaurant_name";
                        cbRestName.ValueMember = "restaurant_id";
                        cbRestName.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void LoadFood()
        {
            try
            {
                int restauranat_id = int.Parse(cbRestName.SelectedValue.ToString());
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("restaurant_id", restauranat_id.ToString());
                var res = ApiService.callAPI<List<Food>>("Food/GetByRestaurantId/", RestSharp.Method.Get, param, null).Result;
                var api = ApiService.callAPI<Restaurant>("Restaurant/GetByRestaurantId/", RestSharp.Method.Get, param, null).Result;
                SessionData.SetRestaurantId(restauranat_id);
                SessionData.SetRestaurant(api.Data);
                if (res.Code == HttpStatusCode.OK)
                {
                    if (res.Data.Count > 0)
                    {
                        List<FoodOrder> listFoodOrder = new List<FoodOrder>();
                        for (int i = 0; i < res.Data.Count; i++)
                        {
                            FoodOrder foodOrder = new FoodOrder();
                            foodOrder.food_name = res.Data[i].food_name;
                            foodOrder.food_id = res.Data[i].food_id;
                            foodOrder.price = res.Data[i].price;
                            foodOrder.note = res.Data[i].note;
                            foodOrder.quantity = 1;
                            foodOrder.total_price = res.Data[i].price;
                            listFoodOrder.Add(foodOrder);
                        }
                        DataColumn total_price = new DataColumn();
                        dtgFood.DataSource = listFoodOrder;
                        AdjustColumnOrder();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void AdjustColumnOrder()
        {
            dtgFood.RowHeadersVisible = false;
            dtgFood.Columns["food_id"].Visible = false;
            dtgFood.Columns["restaurant_id"].Visible = false;
            dtgFood.Columns["photo"].Visible = false;
          
        }

        private void dtgFood_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (sender as DataGridView);
            if (e.RowIndex != -1)
            {
                var quantity = (grid.Rows[e.RowIndex]).Cells["colQuantity"].Value != null ? Convert.ToDecimal((grid.Rows[e.RowIndex]).Cells["colQuantity"].Value) : 0;
                var price = (grid.Rows[e.RowIndex]).Cells["colPrice"].Value != null ? Convert.ToDecimal((grid.Rows[e.RowIndex]).Cells["colPrice"].Value) : 0;
                (grid.Rows[e.RowIndex]).Cells["colTotal"].Value = quantity * price;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            List<FoodOrder> lstChoosed = new List<FoodOrder>();
            foreach (DataGridViewRow row in dtgFood.Rows)
            {
                bool isChecked = row.Cells["colChoose"].Value != null ? Convert.ToBoolean(row.Cells["colChoose"].Value != null) : false;
                if (isChecked)
                {
                    FoodOrder foodOrder = new FoodOrder();
                    foodOrder.food_name = row.Cells["colFoodName"].Value != null ? row.Cells["colFoodName"].Value.ToString() : "";
                    foodOrder.price = row.Cells["colPrice"].Value != null ? Convert.ToDecimal(row.Cells["colPrice"].Value.ToString()) : 0;
                    foodOrder.note = row.Cells["colNote"].Value != null ? row.Cells["colNote"].Value.ToString() : "";
                    foodOrder.quantity = row.Cells["colQuantity"].Value != null ? int.Parse(row.Cells["colQuantity"].Value.ToString()) : 0;
                    foodOrder.total_price = row.Cells["colTotal"].Value != null ? Convert.ToDecimal(row.Cells["colTotal"].Value.ToString()) : 0;
                    lstChoosed.Add(foodOrder);
                }
            }
            if (lstChoosed.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Nếu đã chọn thì đi sang form chi tiết đơn hàng
            SessionData.SetListOrder(lstChoosed);
            SetOrderDetail();
            ucOrderList uc = new ucOrderList();
            frmSubmit frm = new frmSubmit(uc);
            frm.ShowDialog();
        }
        //Set OrderDetail
        private void SetOrderDetail()
        {
            List<OrderDetail> lstOrderDetail = new List<OrderDetail>();
            foreach (DataGridViewRow row in dtgFood.Rows)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.food_name = row.Cells["colFoodName"].Value != null ? row.Cells["colFoodName"].Value.ToString() : "";
                orderDetail.price = row.Cells["colPrice"].Value != null ? Convert.ToDecimal(row.Cells["colPrice"].Value.ToString()) : 0;
                orderDetail.note = row.Cells["colNote"].Value != null ? row.Cells["colNote"].Value.ToString() : "";
                orderDetail.quantity = row.Cells["colQuantity"].Value != null ? int.Parse(row.Cells["colQuantity"].Value.ToString()) : 0;
                orderDetail.food_id= row.Cells["food_id"].Value != null ? int.Parse(row.Cells["food_id"].Value.ToString()) : 0;
                orderDetail.total_price = row.Cells["colTotal"].Value != null ? Convert.ToDecimal(row.Cells["colTotal"].Value.ToString()) : 0;
                orderDetail.customerName = SessionData.empCurrent.full_name;
                orderDetail.createBy = SessionData.empCurrent.full_name;
                orderDetail.createDate = DateTime.Now;
                orderDetail.updateBy = SessionData.empCurrent.full_name;
                orderDetail.updateDate = DateTime.Now;
                orderDetail.statusOrder = "Mới";
                orderDetail.statusPayment = "Chưa thanh toán";
                orderDetail.orderDate = dtpOrderDate.Value;
                lstOrderDetail.Add(orderDetail);
            }
            SessionData.SetListOrderDetail(lstOrderDetail);
        }
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void LoadCustomer()
        {
            try
            {
                var res = ApiService.callAPI<List<Employee>>("Employee/GetAll", RestSharp.Method.Get, null, null).Result;
                if (res.Code == HttpStatusCode.OK)
                {
                    if (res.Data.Count > 0)
                    {
                        var a = SessionData.empCurrent.full_name;
                        cmbCustomer.DataSource = res.Data;
                        cmbCustomer.DisplayMember = "full_name";
                        cmbCustomer.ValueMember = "employee_id";
                        cmbCustomer.Text = a;
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
