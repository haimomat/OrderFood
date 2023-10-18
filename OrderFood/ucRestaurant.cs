using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using OnlineFood.Core.Domain;
using OrderFood.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderFood
{

    public partial class ucRestaurant : DevExpress.XtraEditors.XtraUserControl
    {
        public static bool isShowed = true;
        public ucRestaurant()
        {
            InitializeComponent();
            loadRestaurant();
        }
        private void loadRestaurant()
        {
            var res = ApiService.callAPI<List<Restaurant>>("Restaurant/GetAll/", RestSharp.Method.Get, null, null).Result;
            dtgRestaurant.DataSource = res.Data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.PnlParent.Controls.ContainsKey("ucAddRestaurant"))
            {
                ucAddRestaurant un = new ucAddRestaurant();
                un.Dock = DockStyle.Fill;
                frmMain.Instance.PnlParent.Controls.Add(un);
            }
            frmMain.Instance.PnlParent.Controls["ucAddRestaurant"].BringToFront();
            frmMain.Instance.PnlParent.Controls["ucAddRestaurant"].Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var gridView = dtgRestaurant.MainView as GridView;

            if (gridView != null)
            {
                var selectedRowsHandles = gridView.GetSelectedRows();
                var selectedData = new List<Restaurant>();

                foreach (var rowHandle in selectedRowsHandles)
                {
                    var data = gridView.GetRow(rowHandle) as Restaurant;
                    if (data != null)
                    {
                        selectedData.Add(data);
                    }
                }
                SessionData.restaurant = selectedData[0];
                ucAddRestaurant.isChecked = true;
                if (!frmMain.Instance.PnlParent.Controls.ContainsKey("ucAddRestaurant"))
                {
                    ucAddRestaurant un = new ucAddRestaurant();
                    un.Dock = DockStyle.Fill;
                    frmMain.Instance.PnlParent.Controls.Add(un);
                }
                frmMain.Instance.PnlParent.Controls["ucAddRestaurant"].BringToFront();
                frmMain.Instance.PnlParent.Controls["ucAddRestaurant"].Show();
            }

            //if (checkbox.Checked)
            //{
            //    var restaurant = gridView1.GetFocusedRow() as Restaurant;
            //    SessionData.SetRestaurant(restaurant);
            //    ucAddRestaurant.isChecked = true;
            //}
            //if (!frmMain.Instance.PnlParent.Controls.ContainsKey("ucAddRestaurant"))
            //{
            //    ucAddRestaurant un = new ucAddRestaurant();
            //    un.Dock = DockStyle.Fill;
            //    frmMain.Instance.PnlParent.Controls.Add(un);
            //}
            //frmMain.Instance.PnlParent.Controls["ucAddRestaurant"].BringToFront();
            //frmMain.Instance.PnlParent.Controls["ucAddRestaurant"].Show();
        }
    }
}
