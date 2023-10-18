
namespace OrderFood
{
    partial class ucEmployee
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.full_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phone_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.profile_photo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Quản lý nhân viên";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(268, 59);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(827, 688);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Danh sách nhân viên";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(823, 658);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.full_name,
            this.phone_number,
            this.email,
            this.dateOfBirth,
            this.profile_photo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // full_name
            // 
            this.full_name.Caption = "Tên nhân viên";
            this.full_name.FieldName = "full_name";
            this.full_name.MinWidth = 25;
            this.full_name.Name = "full_name";
            this.full_name.Visible = true;
            this.full_name.VisibleIndex = 0;
            this.full_name.Width = 94;
            // 
            // phone_number
            // 
            this.phone_number.Caption = "Số điện thoại";
            this.phone_number.FieldName = "phone_number";
            this.phone_number.MinWidth = 25;
            this.phone_number.Name = "phone_number";
            this.phone_number.Visible = true;
            this.phone_number.VisibleIndex = 1;
            this.phone_number.Width = 94;
            // 
            // email
            // 
            this.email.Caption = "Email";
            this.email.FieldName = "email";
            this.email.MinWidth = 25;
            this.email.Name = "email";
            this.email.Visible = true;
            this.email.VisibleIndex = 2;
            this.email.Width = 94;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Caption = "Ngày sinh ";
            this.dateOfBirth.FieldName = "dateOfBirth";
            this.dateOfBirth.MinWidth = 25;
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Visible = true;
            this.dateOfBirth.VisibleIndex = 4;
            this.dateOfBirth.Width = 94;
            // 
            // profile_photo
            // 
            this.profile_photo.Caption = "Ảnh đại diện";
            this.profile_photo.FieldName = "profile_photo";
            this.profile_photo.MinWidth = 25;
            this.profile_photo.Name = "profile_photo";
            this.profile_photo.Visible = true;
            this.profile_photo.VisibleIndex = 3;
            this.profile_photo.Width = 94;
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
            this.groupControl2.Text = "Tìm kiếm nhân viên";
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
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(1097, 749);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn full_name;
        private DevExpress.XtraGrid.Columns.GridColumn phone_number;
        private DevExpress.XtraGrid.Columns.GridColumn email;
        private DevExpress.XtraGrid.Columns.GridColumn dateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn profile_photo;
    }
}
