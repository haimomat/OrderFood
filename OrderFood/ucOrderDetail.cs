using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using OnlineFood.Core.Domain;
using OrderFood.API;
using OrderFood.Models;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace OrderFood
{
    public partial class ucOrderDetail : UserControl
    {
        List<FoodOrder> lstOrder = new List<FoodOrder>();
        public ucOrderDetail()
        {
            InitializeComponent();
            LoadComboBox();
            LoadImage();
        }
        private void LoadImage()
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
                        List<FoodOrderModel> listFoodOrder = new List<FoodOrderModel>();
                        for (int i = 0; i < res.Data.Count; i++)
                        {
                            FoodOrderModel foodOrder = new FoodOrderModel();
                            foodOrder.food_name = res.Data[i].food_name;
                            foodOrder.food_id = res.Data[i].food_id;
                            foodOrder.price = res.Data[i].price;
                            string DefaultImagePath = res.Data[i].photo;
                            DefaultImagePath = DefaultImagePath.Replace("\"", "");
                            foodOrder.photo = DefaultImagePath;
                            foodOrder.note = res.Data[i].note;
                            foodOrder.quantity = 1;
                            foodOrder.status = "Chưa xác nhận";
                            listFoodOrder.Add(foodOrder);
                        }
                        /*for (int y = 0; y < res.Data.Count; y++)
                        {
                            string DefaultImagePath = res.Data[y].photo;
                            DefaultImagePath = DefaultImagePath.Replace("\"", "");
                           // cardView1.GetRow(y). = System.Drawing.Image.FromFile(DefaultImagePath);
                        }*/
                        dtgListFood.DataSource = listFoodOrder;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void LoadComboBox()
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckEdit;
            if (checkbox.Checked)
            {
                var product = layoutView1.GetFocusedRow() as FoodOrder;
                product.status = "Chưa xác nhận";
                product.total_price = product.quantity * product.price;
                product.restaurant_id = SessionData.restaurant_id;
                product.checkedBox = true;
                product.employee_name = SessionData.empCurrent.full_name;
                lstOrder.Add(product);
            }
            else
            {
                var product = layoutView1.GetFocusedRow() as FoodOrder;
                lstOrder.Remove(product);
                product.checkedBox = false;
            }
            dtgOrderDetail.DataSource = lstOrder;
            dtgOrderDetail.RefreshDataSource();
        }
    }
}
