
namespace OrderFood
{
    partial class ucOrderDetail
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnOrder = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.mainLabel3 = new System.Windows.Forms.Label();
            this.cbRestName = new System.Windows.Forms.ComboBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtgOrderDetail = new DevExpress.XtraGrid.GridControl();
            this.viewOrderDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.employee_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.food_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dtgListFood = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.FoodName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_FoodName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.price = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_price = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.quantity = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.layoutViewField_quantity = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Photo = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_Photo = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.checkBox = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.noteRow = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_noteRow = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewCard2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_FoodName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_noteRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.btnOrder,
            this.btnConfirm});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1220, 31);
            this.toolStrip1.TabIndex = 1;
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
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = global::OrderFood.Properties.Resources.confirmation;
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(97, 28);
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.mainLabel3);
            this.groupControl1.Controls.Add(this.cbRestName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 31);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1220, 52);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // mainLabel3
            // 
            this.mainLabel3.AutoSize = true;
            this.mainLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mainLabel3.Location = new System.Drawing.Point(16, 15);
            this.mainLabel3.Name = "mainLabel3";
            this.mainLabel3.Size = new System.Drawing.Size(49, 20);
            this.mainLabel3.TabIndex = 21;
            this.mainLabel3.Text = "Quán";
            // 
            // cbRestName
            // 
            this.cbRestName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRestName.FormattingEnabled = true;
            this.cbRestName.Location = new System.Drawing.Point(71, 15);
            this.cbRestName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRestName.Name = "cbRestName";
            this.cbRestName.Size = new System.Drawing.Size(222, 24);
            this.cbRestName.TabIndex = 22;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dtgOrderDetail);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 447);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1220, 226);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Danh sách đơn";
            // 
            // dtgOrderDetail
            // 
            this.dtgOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgOrderDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            gridLevelNode1.RelationName = "Level1";
            this.dtgOrderDetail.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dtgOrderDetail.Location = new System.Drawing.Point(2, 28);
            this.dtgOrderDetail.MainView = this.viewOrderDetail;
            this.dtgOrderDetail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgOrderDetail.Name = "dtgOrderDetail";
            this.dtgOrderDetail.Size = new System.Drawing.Size(1216, 196);
            this.dtgOrderDetail.TabIndex = 2;
            this.dtgOrderDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewOrderDetail});
            // 
            // viewOrderDetail
            // 
            this.viewOrderDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.employee_name,
            this.food_name,
            this.gridColumn1,
            this.gridColumn2,
            this.total_price,
            this.status,
            this.note});
            this.viewOrderDetail.DetailHeight = 295;
            this.viewOrderDetail.GridControl = this.dtgOrderDetail;
            this.viewOrderDetail.Name = "viewOrderDetail";
            this.viewOrderDetail.OptionsView.ShowIndicator = false;
            // 
            // employee_name
            // 
            this.employee_name.Caption = "Tên nhân viên";
            this.employee_name.FieldName = "employee_name";
            this.employee_name.MinWidth = 23;
            this.employee_name.Name = "employee_name";
            this.employee_name.Visible = true;
            this.employee_name.VisibleIndex = 1;
            this.employee_name.Width = 87;
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Giá";
            this.gridColumn1.FieldName = "price";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số lượng";
            this.gridColumn2.FieldName = "quantity";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 87;
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
            this.status.FieldName = "status";
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
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dtgListFood);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 83);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1220, 364);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Danh sách món ăn";
            // 
            // dtgListFood
            // 
            this.dtgListFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgListFood.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgListFood.Location = new System.Drawing.Point(2, 28);
            this.dtgListFood.MainView = this.layoutView1;
            this.dtgListFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgListFood.Name = "dtgListFood";
            this.dtgListFood.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkBox,
            this.repositoryItemPictureEdit1,
            this.repositoryItemSpinEdit1});
            this.dtgListFood.Size = new System.Drawing.Size(1216, 334);
            this.dtgListFood.TabIndex = 22;
            this.dtgListFood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(229, 290);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.FoodName,
            this.price,
            this.quantity,
            this.Photo,
            this.layoutViewColumn1,
            this.noteRow});
            this.layoutView1.GridControl = this.dtgListFood;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // FoodName
            // 
            this.FoodName.Caption = "Tên món";
            this.FoodName.FieldName = "food_name";
            this.FoodName.LayoutViewField = this.layoutViewField_FoodName;
            this.FoodName.MinWidth = 27;
            this.FoodName.Name = "FoodName";
            this.FoodName.Width = 60;
            // 
            // layoutViewField_FoodName
            // 
            this.layoutViewField_FoodName.EditorPreferredWidth = 125;
            this.layoutViewField_FoodName.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_FoodName.Name = "layoutViewField_FoodName";
            this.layoutViewField_FoodName.Size = new System.Drawing.Size(211, 26);
            this.layoutViewField_FoodName.TextSize = new System.Drawing.Size(75, 16);
            // 
            // price
            // 
            this.price.AppearanceCell.Options.UseTextOptions = true;
            this.price.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.price.Caption = "Giá";
            this.price.FieldName = "price";
            this.price.LayoutViewField = this.layoutViewField_price;
            this.price.MinWidth = 27;
            this.price.Name = "price";
            this.price.Width = 60;
            // 
            // layoutViewField_price
            // 
            this.layoutViewField_price.EditorPreferredWidth = 125;
            this.layoutViewField_price.Location = new System.Drawing.Point(0, 26);
            this.layoutViewField_price.Name = "layoutViewField_price";
            this.layoutViewField_price.Size = new System.Drawing.Size(211, 26);
            this.layoutViewField_price.TextSize = new System.Drawing.Size(75, 16);
            // 
            // quantity
            // 
            this.quantity.Caption = "Số lượng ";
            this.quantity.ColumnEdit = this.repositoryItemSpinEdit1;
            this.quantity.FieldName = "quantity";
            this.quantity.LayoutViewField = this.layoutViewField_quantity;
            this.quantity.MinWidth = 27;
            this.quantity.Name = "quantity";
            this.quantity.Width = 39;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // layoutViewField_quantity
            // 
            this.layoutViewField_quantity.EditorPreferredWidth = 125;
            this.layoutViewField_quantity.Location = new System.Drawing.Point(0, 52);
            this.layoutViewField_quantity.Name = "layoutViewField_quantity";
            this.layoutViewField_quantity.Size = new System.Drawing.Size(211, 28);
            this.layoutViewField_quantity.TextSize = new System.Drawing.Size(75, 17);
            // 
            // Photo
            // 
            this.Photo.Caption = "Hình ảnh";
            this.Photo.ColumnEdit = this.repositoryItemPictureEdit1;
            this.Photo.FieldName = "FoodImage";
            this.Photo.LayoutViewField = this.layoutViewField_Photo;
            this.Photo.MinWidth = 25;
            this.Photo.Name = "Photo";
            this.Photo.OptionsColumn.FixedWidth = true;
            this.Photo.Width = 94;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.CustomHeight = 100;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repositoryItemPictureEdit1.SvgImageSize = new System.Drawing.Size(100, 100);
            // 
            // layoutViewField_Photo
            // 
            this.layoutViewField_Photo.EditorPreferredWidth = 125;
            this.layoutViewField_Photo.Location = new System.Drawing.Point(0, 80);
            this.layoutViewField_Photo.Name = "layoutViewField_Photo";
            this.layoutViewField_Photo.Size = new System.Drawing.Size(211, 110);
            this.layoutViewField_Photo.StartNewLine = true;
            this.layoutViewField_Photo.TextSize = new System.Drawing.Size(75, 17);
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.ColumnEdit = this.checkBox;
            this.layoutViewColumn1.FieldName = "checkedBox";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.layoutViewColumn1.MinWidth = 25;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.Width = 94;
            // 
            // checkBox
            // 
            this.checkBox.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.CheckBox;
            this.checkBox.Name = "checkBox";
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 125;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 190);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(211, 28);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(75, 16);
            // 
            // noteRow
            // 
            this.noteRow.Caption = "Note";
            this.noteRow.FieldName = "note";
            this.noteRow.LayoutViewField = this.layoutViewField_noteRow;
            this.noteRow.MinWidth = 27;
            this.noteRow.Name = "noteRow";
            this.noteRow.Width = 41;
            // 
            // layoutViewField_noteRow
            // 
            this.layoutViewField_noteRow.EditorPreferredWidth = 125;
            this.layoutViewField_noteRow.Location = new System.Drawing.Point(0, 218);
            this.layoutViewField_noteRow.Name = "layoutViewField_noteRow";
            this.layoutViewField_noteRow.Size = new System.Drawing.Size(211, 26);
            this.layoutViewField_noteRow.TextSize = new System.Drawing.Size(75, 16);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_FoodName,
            this.layoutViewField_price,
            this.layoutViewField_quantity,
            this.layoutViewField_Photo,
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_noteRow});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // layoutViewCard2
            // 
            this.layoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard2.Name = "layoutViewCard2";
            // 
            // ucOrderDetail
            // 
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ucOrderDetail";
            this.Size = new System.Drawing.Size(1220, 673);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_FoodName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_noteRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnOrder;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label mainLabel3;
        private System.Windows.Forms.ComboBox cbRestName;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl dtgListFood;
        private DevExpress.XtraGrid.GridControl dtgOrderDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView viewOrderDetail;
        private DevExpress.XtraGrid.Columns.GridColumn employee_name;
        private DevExpress.XtraGrid.Columns.GridColumn food_name;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn total_price;
        private DevExpress.XtraGrid.Columns.GridColumn status;
        private DevExpress.XtraGrid.Columns.GridColumn note;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn FoodName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn price;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn quantity;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn Photo;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn noteRow;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_FoodName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_price;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_quantity;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_Photo;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_noteRow;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
 #endregion  