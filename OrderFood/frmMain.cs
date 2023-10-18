using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Panel = System.Windows.Forms.Panel;

namespace OrderFood
{

    public partial class frmMain : Form
    {
        static frmMain obj;
        public static frmMain Instance
        {
            get
            {
                if(obj == null)
                {
                    obj = new frmMain();
                }
                return obj;
            }
        }
        public Panel PnlParent
        {
            get { return plParent; }
            set { plParent = value; }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            obj = this;
            // Load form danh sách đơn hàng
            ucOrderList ucOrder = new ucOrderList();
            plParent.Controls.Add(ucOrder);
            ucOrder.Dock = DockStyle.Fill;
        }
        private void manageOrderToolStripMenuItem_Click (object sender, EventArgs e)
        {
            plParent.Controls["ucOrderList"].BringToFront();
        }
        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.PnlParent.Controls.ContainsKey("ucPayment"))
            {
                ucPayment un = new ucPayment();
                un.Dock = DockStyle.Fill;
                frmMain.Instance.PnlParent.Controls.Add(un);
            }
            frmMain.Instance.PnlParent.Controls["ucPayment"].BringToFront();
            frmMain.Instance.PnlParent.Controls["ucPayment"].Show();
        }
 

        private void nhàHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.PnlParent.Controls.ContainsKey("ucRestaurant"))
            {
                ucRestaurant un = new ucRestaurant();
                un.Dock = DockStyle.Fill;
                frmMain.Instance.PnlParent.Controls.Add(un);
            }
            frmMain.Instance.PnlParent.Controls["ucRestaurant"].BringToFront();
            frmMain.Instance.PnlParent.Controls["ucRestaurant"].Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.PnlParent.Controls.ContainsKey("ucFood"))
            {
                ucFood un = new ucFood();
                un.Dock = DockStyle.Fill;
                frmMain.Instance.PnlParent.Controls.Add(un);
            }
            frmMain.Instance.PnlParent.Controls["ucFood"].BringToFront();
            frmMain.Instance.PnlParent.Controls["ucFood"].Show();
        }
    }
}
