
namespace OrderFood
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plParent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.trangChủToolStripMenuItem,
            this.thanhToánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1202, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhàHàngToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // nhàHàngToolStripMenuItem
            // 
            this.nhàHàngToolStripMenuItem.Name = "nhàHàngToolStripMenuItem";
            this.nhàHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhàHàngToolStripMenuItem.Text = "Quản lý nhà hàng";
            this.nhàHàngToolStripMenuItem.Click += new System.EventHandler(this.nhàHàngToolStripMenuItem_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageOrderToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.trangChủToolStripMenuItem.Text = "Đơn Hàng";
            // 
            // manageOrderToolStripMenuItem
            // 
            this.manageOrderToolStripMenuItem.Name = "manageOrderToolStripMenuItem";
            this.manageOrderToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.manageOrderToolStripMenuItem.Text = "Danh sách đơn đặt hàng";
            this.manageOrderToolStripMenuItem.Click += new System.EventHandler(this.manageOrderToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.orderToolStripMenuItem.Text = "Đặt Hàng";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.thanhToánToolStripMenuItem.Text = "Thanh Toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // plParent
            // 
            this.plParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plParent.Location = new System.Drawing.Point(0, 28);
            this.plParent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plParent.Name = "plParent";
            this.plParent.Size = new System.Drawing.Size(1202, 598);
            this.plParent.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 626);
            this.Controls.Add(this.plParent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Text = "ICHIISOFT - Quản Lý Đặt Đồ Ăn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.Panel plParent;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
    }
}