
namespace OrderFood
{
    partial class ucManagerOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.mainLabel2 = new System.Windows.Forms.Label();
            this.btnOrderManageOrder = new System.Windows.Forms.Button();
            this.dtgOrderDetail = new System.Windows.Forms.DataGridView();
            this.colButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblOrderName = new System.Windows.Forms.Label();
            this.cmbOrderName = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH ĐƠN ĐẶT HÀNG";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "dd/MM/yyyy";
            this.dtpOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDate.Location = new System.Drawing.Point(162, 49);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(180, 30);
            this.dtpOrderDate.TabIndex = 16;
            // 
            // mainLabel2
            // 
            this.mainLabel2.AutoSize = true;
            this.mainLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mainLabel2.Location = new System.Drawing.Point(24, 49);
            this.mainLabel2.Name = "mainLabel2";
            this.mainLabel2.Size = new System.Drawing.Size(58, 25);
            this.mainLabel2.TabIndex = 15;
            this.mainLabel2.Text = "Ngày";
            // 
            // btnOrderManageOrder
            // 
            this.btnOrderManageOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderManageOrder.Location = new System.Drawing.Point(1016, 54);
            this.btnOrderManageOrder.Name = "btnOrderManageOrder";
            this.btnOrderManageOrder.Size = new System.Drawing.Size(116, 34);
            this.btnOrderManageOrder.TabIndex = 18;
            this.btnOrderManageOrder.Text = "Đặt hàng";
            this.btnOrderManageOrder.UseVisualStyleBackColor = true;
            this.btnOrderManageOrder.Click += new System.EventHandler(this.btnOrderManageOrder_Click);
            // 
            // dtgOrderDetail
            // 
            this.dtgOrderDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dtgOrderDetail.AllowUserToAddRows = false;
            this.dtgOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgOrderDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colButton,
            this.colCustomerName,
            this.colFoodName,
            this.colPrice,
            this.colQuantity,
            this.colTotal,
            this.colStatus,
            this.colNote});
            this.dtgOrderDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgOrderDetail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgOrderDetail.Location = new System.Drawing.Point(0, 137);
            this.dtgOrderDetail.Name = "dtgOrderDetail";
            this.dtgOrderDetail.RowHeadersWidth = 62;
            this.dtgOrderDetail.RowTemplate.Height = 28;
            this.dtgOrderDetail.Size = new System.Drawing.Size(1142, 399);
            this.dtgOrderDetail.TabIndex = 19;
            this.dtgOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOrderDetail_CellContentClick);
            // 
            // colButton
            // 
            this.colButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colButton.HeaderText = "";
            this.colButton.MinimumWidth = 8;
            this.colButton.Name = "colButton";
            this.colButton.Text = "Sửa";
            this.colButton.UseColumnTextForButtonValue = true;
            this.colButton.Width = 30;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCustomerName.DataPropertyName = "customerName";
            this.colCustomerName.HeaderText = "Tên Nhân Viên";
            this.colCustomerName.MinimumWidth = 8;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Width = 150;
            // 
            // colFoodName
            // 
            this.colFoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFoodName.DataPropertyName = "food_name";
            this.colFoodName.HeaderText = "Tên Món";
            this.colFoodName.MinimumWidth = 8;
            this.colFoodName.Name = "colFoodName";
            this.colFoodName.Width = 250;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPrice.DataPropertyName = "price";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrice.HeaderText = "Giá";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 150;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colQuantity.DataPropertyName = "quantity";
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.MinimumWidth = 8;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTotal.DataPropertyName = "total_price";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTotal.HeaderText = "Tổng tiền";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 120;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colStatus.DataPropertyName = "statusOrder";
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 150;
            // 
            // colNote
            // 
            this.colNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNote.DataPropertyName = "note";
            this.colNote.HeaderText = "Note";
            this.colNote.MinimumWidth = 8;
            this.colNote.Name = "colNote";
            // 
            // lblOrderName
            // 
            this.lblOrderName.AutoSize = true;
            this.lblOrderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrderName.Location = new System.Drawing.Point(24, 92);
            this.lblOrderName.Name = "lblOrderName";
            this.lblOrderName.Size = new System.Drawing.Size(132, 25);
            this.lblOrderName.TabIndex = 20;
            this.lblOrderName.Text = "Tên người đặt";
            // 
            // cmbOrderName
            // 
            this.cmbOrderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbOrderName.FormattingEnabled = true;
            this.cmbOrderName.Location = new System.Drawing.Point(162, 89);
            this.cmbOrderName.Name = "cmbOrderName";
            this.cmbOrderName.Size = new System.Drawing.Size(180, 33);
            this.cmbOrderName.TabIndex = 21;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(453, 86);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 26);
            this.numericUpDown1.TabIndex = 22;
            // 
            // ucManagerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbOrderName);
            this.Controls.Add(this.lblOrderName);
            this.Controls.Add(this.dtgOrderDetail);
            this.Controls.Add(this.btnOrderManageOrder);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.mainLabel2);
            this.Controls.Add(this.label1);
            this.Name = "ucManagerOrder";
            this.Size = new System.Drawing.Size(1142, 539);
            this.Load += new System.EventHandler(this.ucManagerOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label mainLabel2;
        private System.Windows.Forms.Button btnOrderManageOrder;
        private System.Windows.Forms.DataGridView dtgOrderDetail;
        private System.Windows.Forms.Label lblOrderName;
        private System.Windows.Forms.ComboBox cmbOrderName;
        private System.Windows.Forms.DataGridViewButtonColumn colButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
