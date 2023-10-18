
namespace OrderFood
{
    partial class ucOrderList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dtgOrderDetail = new DevExpress.XtraGrid.GridControl();
            this.viewOrderDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.customerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.food_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.orderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Xoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtFoodName = new DevExpress.XtraEditors.TextEdit();
            this.cmbCustomerName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtpOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnOrder = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.toolStrip1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1097, 749);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "DANH SÁCH ĐƠN HÀNG";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dtgOrderDetail);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(341, 59);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(754, 688);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Danh sách đơn đặt hàng hôm nay";
            // 
            // dtgOrderDetail
            // 
            this.dtgOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgOrderDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            gridLevelNode2.RelationName = "Level1";
            this.dtgOrderDetail.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.dtgOrderDetail.Location = new System.Drawing.Point(2, 28);
            this.dtgOrderDetail.MainView = this.viewOrderDetail;
            this.dtgOrderDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgOrderDetail.Name = "dtgOrderDetail";
            this.dtgOrderDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa});
            this.dtgOrderDetail.Size = new System.Drawing.Size(750, 658);
            this.dtgOrderDetail.TabIndex = 0;
            this.dtgOrderDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewOrderDetail});
            // 
            // viewOrderDetail
            // 
            this.viewOrderDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.customerName,
            this.food_name,
            this.orderDate,
            this.price,
            this.quantity,
            this.total_price,
            this.status,
            this.note,
            this.Xoa});
            this.viewOrderDetail.DetailHeight = 295;
            this.viewOrderDetail.GridControl = this.dtgOrderDetail;
            this.viewOrderDetail.Name = "viewOrderDetail";
            this.viewOrderDetail.OptionsView.ShowIndicator = false;
            // 
            // customerName
            // 
            this.customerName.Caption = "Tên nhân viên";
            this.customerName.FieldName = "customerName";
            this.customerName.MinWidth = 23;
            this.customerName.Name = "customerName";
            this.customerName.Visible = true;
            this.customerName.VisibleIndex = 1;
            this.customerName.Width = 87;
            // 
            // food_name
            // 
            this.food_name.Caption = "Tên món";
            this.food_name.FieldName = "food_name";
            this.food_name.MinWidth = 23;
            this.food_name.Name = "food_name";
            this.food_name.Visible = true;
            this.food_name.VisibleIndex = 0;
            this.food_name.Width = 87;
            // 
            // orderDate
            // 
            this.orderDate.Caption = "Ngày đặt";
            this.orderDate.FieldName = "orderDate";
            this.orderDate.MinWidth = 23;
            this.orderDate.Name = "orderDate";
            this.orderDate.Visible = true;
            this.orderDate.VisibleIndex = 7;
            this.orderDate.Width = 87;
            // 
            // price
            // 
            this.price.Caption = "Giá";
            this.price.FieldName = "price";
            this.price.MinWidth = 23;
            this.price.Name = "price";
            this.price.Visible = true;
            this.price.VisibleIndex = 2;
            this.price.Width = 87;
            // 
            // quantity
            // 
            this.quantity.Caption = "Số lượng";
            this.quantity.FieldName = "quantity";
            this.quantity.MinWidth = 23;
            this.quantity.Name = "quantity";
            this.quantity.Visible = true;
            this.quantity.VisibleIndex = 3;
            this.quantity.Width = 87;
            // 
            // total_price
            // 
            this.total_price.Caption = "Tổng tiền";
            this.total_price.FieldName = "total_price";
            this.total_price.MinWidth = 23;
            this.total_price.Name = "total_price";
            this.total_price.Visible = true;
            this.total_price.VisibleIndex = 4;
            this.total_price.Width = 87;
            // 
            // status
            // 
            this.status.Caption = "Trạng thái";
            this.status.FieldName = "statusOrder";
            this.status.MinWidth = 23;
            this.status.Name = "status";
            this.status.Visible = true;
            this.status.VisibleIndex = 5;
            this.status.Width = 87;
            // 
            // note
            // 
            this.note.Caption = "Note";
            this.note.FieldName = "note";
            this.note.MinWidth = 23;
            this.note.Name = "note";
            this.note.Visible = true;
            this.note.VisibleIndex = 6;
            this.note.Width = 87;
            // 
            // Xoa
            // 
            this.Xoa.Caption = "Xóa";
            this.Xoa.ColumnEdit = this.btnXoa;
            this.Xoa.MinWidth = 25;
            this.Xoa.Name = "Xoa";
            this.Xoa.Visible = true;
            this.Xoa.VisibleIndex = 8;
            this.Xoa.Width = 94;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtFoodName);
            this.groupControl2.Controls.Add(this.cmbCustomerName);
            this.groupControl2.Controls.Add(this.dtpOrderDate);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(2, 59);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(339, 688);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Tìm kiếm đơn hàng";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(82, 119);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(208, 22);
            this.txtFoodName.TabIndex = 7;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.Location = new System.Drawing.Point(82, 80);
            this.cmbCustomerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomerName.Size = new System.Drawing.Size(208, 22);
            this.cmbCustomerName.TabIndex = 4;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.EditValue = null;
            this.dtpOrderDate.Location = new System.Drawing.Point(82, 43);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpOrderDate.Size = new System.Drawing.Size(208, 22);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 121);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tên món";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 83);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Người đặt";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 45);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ngày đặt";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.btnOrder,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(2, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1093, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = global::OrderFood.Properties.Resources.cancel;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(74, 28);
            this.toolStripButton2.Text = "Đóng";
            // 
            // btnOrder
            // 
            this.btnOrder.Image = global::OrderFood.Properties.Resources.shopping_cart;
            this.btnOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(98, 28);
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Image = global::OrderFood.Properties.Resources.images2;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 28);
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // ucOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ucOrderList";
            this.Size = new System.Drawing.Size(1097, 749);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCustomerName;
        private DevExpress.XtraEditors.DateEdit dtpOrderDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private DevExpress.XtraGrid.GridControl dtgOrderDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView viewOrderDetail;
        private DevExpress.XtraGrid.Columns.GridColumn food_name;
        private DevExpress.XtraGrid.Columns.GridColumn customerName;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private DevExpress.XtraGrid.Columns.GridColumn quantity;
        private DevExpress.XtraGrid.Columns.GridColumn total_price;
        private DevExpress.XtraGrid.Columns.GridColumn status;
        private DevExpress.XtraGrid.Columns.GridColumn note;
        private System.Windows.Forms.ToolStripButton btnOrder;
        private DevExpress.XtraGrid.Columns.GridColumn orderDate;
        private DevExpress.XtraEditors.TextEdit txtFoodName;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private DevExpress.XtraGrid.Columns.GridColumn Xoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
    }
}
