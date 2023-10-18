
namespace OrderFood
{
    partial class ucRestaurant
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dtgRestaurant = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.restaurant_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phone_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bank_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bank_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qr_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.photo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRestaurant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
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
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1097, 749);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Quản lý nhà hàng";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dtgRestaurant);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(268, 59);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(827, 688);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Danh sách nhà hàng";
            // 
            // dtgRestaurant
            // 
            this.dtgRestaurant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRestaurant.Location = new System.Drawing.Point(2, 28);
            this.dtgRestaurant.MainView = this.gridView1;
            this.dtgRestaurant.Name = "dtgRestaurant";
            this.dtgRestaurant.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.dtgRestaurant.Size = new System.Drawing.Size(823, 658);
            this.dtgRestaurant.TabIndex = 0;
            this.dtgRestaurant.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.restaurant_name,
            this.address,
            this.phone_number,
            this.bank_account,
            this.bank_name,
            this.qr_code,
            this.photo});
            this.gridView1.GridControl = this.dtgRestaurant;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // restaurant_name
            // 
            this.restaurant_name.Caption = "Tên nhà hàng";
            this.restaurant_name.FieldName = "restaurant_name";
            this.restaurant_name.MinWidth = 25;
            this.restaurant_name.Name = "restaurant_name";
            this.restaurant_name.Visible = true;
            this.restaurant_name.VisibleIndex = 1;
            this.restaurant_name.Width = 94;
            // 
            // address
            // 
            this.address.Caption = "Địa chỉ";
            this.address.FieldName = "address";
            this.address.MinWidth = 25;
            this.address.Name = "address";
            this.address.Visible = true;
            this.address.VisibleIndex = 2;
            this.address.Width = 94;
            // 
            // phone_number
            // 
            this.phone_number.Caption = "Số điện thoại";
            this.phone_number.FieldName = "phone_number";
            this.phone_number.MinWidth = 25;
            this.phone_number.Name = "phone_number";
            this.phone_number.Visible = true;
            this.phone_number.VisibleIndex = 3;
            this.phone_number.Width = 94;
            // 
            // bank_account
            // 
            this.bank_account.Caption = "Số tài khoản";
            this.bank_account.FieldName = "bank_account";
            this.bank_account.MinWidth = 25;
            this.bank_account.Name = "bank_account";
            this.bank_account.Visible = true;
            this.bank_account.VisibleIndex = 4;
            this.bank_account.Width = 94;
            // 
            // bank_name
            // 
            this.bank_name.Caption = "Tên ngân hàng";
            this.bank_name.FieldName = "bank_name";
            this.bank_name.MinWidth = 25;
            this.bank_name.Name = "bank_name";
            this.bank_name.Visible = true;
            this.bank_name.VisibleIndex = 5;
            this.bank_name.Width = 94;
            // 
            // qr_code
            // 
            this.qr_code.Caption = "QR Code";
            this.qr_code.FieldName = "qr_code";
            this.qr_code.MinWidth = 25;
            this.qr_code.Name = "qr_code";
            this.qr_code.Visible = true;
            this.qr_code.VisibleIndex = 6;
            this.qr_code.Width = 94;
            // 
            // photo
            // 
            this.photo.Caption = "Hình Ảnh";
            this.photo.FieldName = "photo";
            this.photo.MinWidth = 25;
            this.photo.Name = "photo";
            this.photo.Visible = true;
            this.photo.VisibleIndex = 7;
            this.photo.Width = 94;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.textEdit1);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(2, 59);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(266, 688);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Tìm kiếm nhà hàng";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(57, 53);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(176, 22);
            this.textEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.btnAdd,
            this.btnEdit,
            this.btnDel,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(2, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1093, 31);
            this.toolStrip1.TabIndex = 2;
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
            // btnAdd
            // 
            this.btnAdd.Image = global::OrderFood.Properties.Resources.add;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 28);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::OrderFood.Properties.Resources.editing;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 28);
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::OrderFood.Properties.Resources.bin;
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(63, 28);
            this.btnDel.Text = "Xóa";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::OrderFood.Properties.Resources.images1;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 28);
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // ucRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucRestaurant";
            this.Size = new System.Drawing.Size(1097, 749);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRestaurant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDel;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl dtgRestaurant;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn restaurant_name;
        private DevExpress.XtraGrid.Columns.GridColumn address;
        private DevExpress.XtraGrid.Columns.GridColumn phone_number;
        private DevExpress.XtraGrid.Columns.GridColumn bank_account;
        private DevExpress.XtraGrid.Columns.GridColumn bank_name;
        private DevExpress.XtraGrid.Columns.GridColumn qr_code;
        private DevExpress.XtraGrid.Columns.GridColumn photo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}
