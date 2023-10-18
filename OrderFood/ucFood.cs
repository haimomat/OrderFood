using DevExpress.XtraEditors;
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
    public partial class ucFood : DevExpress.XtraEditors.XtraUserControl
    {
        public ucFood()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_CLick(object sender, EventArgs e)
        {
            if (!frmMain.Instance.PnlParent.Controls.ContainsKey("ucRestaurant"))
            {
                ucRestaurant un = new ucRestaurant();
                un.Dock = DockStyle.Fill;
                frmMain.Instance.PnlParent.Controls.Add(un);
            }
            frmMain.Instance.PnlParent.Controls["ucRestaurant"].BringToFront();
            frmMain.Instance.PnlParent.Controls["ucRestaurant"].Show();
            ucRestaurant.isShowed = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.PnlParent.Controls.ContainsKey("ucAddFood"))
            {
                ucAddFood un = new ucAddFood();
                un.Dock = DockStyle.Fill;
                frmMain.Instance.PnlParent.Controls.Add(un);
            }
            frmMain.Instance.PnlParent.Controls["ucAddFood"].BringToFront();
            frmMain.Instance.PnlParent.Controls["ucAddFood"].Show();
            ucRestaurant.isShowed = true;
        }
    }
}
