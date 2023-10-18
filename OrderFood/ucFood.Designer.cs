
namespace OrderFood
{
    partial class ucFood
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridFood = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.food_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.photo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
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
            this.groupControl1.Text = "Quản lý món ăn";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(289, 59);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(806, 688);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Danh sách món ăn";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 28);
            this.gridControl1.MainView = this.gridFood;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(802, 658);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridFood});
            // 
            // gridFood
            // 
            this.gridFood.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.food_name,
            this.price,
            this.photo,
            this.note});
            this.gridFood.GridControl = this.gridControl1;
            this.gridFood.Name = "gridFood";
            this.gridFood.OptionsView.ShowIndicator = false;
            // 
            // food_name
            // 
            this.food_name.Caption = "Tên món ";
            this.food_name.FieldName = "food_name";
            this.food_name.MinWidth = 25;
            this.food_name.Name = "food_name";
            this.food_name.Visible = true;
            this.food_name.VisibleIndex = 0;
            this.food_name.Width = 94;
            // 
            // price
            // 
            this.price.Caption = "Giá";
            this.price.FieldName = "price";
            this.price.MinWidth = 25;
            this.price.Name = "price";
            this.price.Visible = true;
            this.price.VisibleIndex = 1;
            this.price.Width = 94;
            // 
            // photo
            // 
            this.photo.Caption = "Ảnh";
            this.photo.FieldName = "photo";
            this.photo.MinWidth = 25;
            this.photo.Name = "photo";
            this.photo.Visible = true;
            this.photo.VisibleIndex = 2;
            this.photo.Width = 94;
            // 
            // note
            // 
            this.note.Caption = "Note";
            this.note.FieldName = "note";
            this.note.MinWidth = 25;
            this.note.Name = "note";
            this.note.Visible = true;
            this.note.VisibleIndex = 3;
            this.note.Width = 94;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.buttonEdit1);
            this.groupControl2.Controls.Add(this.comboBoxEdit2);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(2, 59);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(287, 688);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Tìm kiếm món ăn";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(115, 58);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit1.Size = new System.Drawing.Size(156, 22);
            this.buttonEdit1.TabIndex = 4;
            this.buttonEdit1.Click += new System.EventHandler(this.comboBoxEdit1_CLick);
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(115, 96);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(156, 22);
            this.comboBoxEdit2.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên món ăn";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn nhà hàng";
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
            this.toolStrip1.TabIndex = 3;
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
            // ucFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucFood";
            this.Size = new System.Drawing.Size(1097, 749);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnSearch;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridFood;
        private DevExpress.XtraGrid.Columns.GridColumn food_name;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private DevExpress.XtraGrid.Columns.GridColumn photo;
        private DevExpress.XtraGrid.Columns.GridColumn note;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
    }
}
