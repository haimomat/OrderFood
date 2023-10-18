
namespace OrderFood
{
    partial class ucPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFromDay = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblToDay = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.dtgNotPaid = new System.Windows.Forms.DataGridView();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpFromDay = new System.Windows.Forms.DateTimePicker();
            this.dtpToDay = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
            this.colOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotPaid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFromDay
            // 
            this.lblFromDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFromDay.AutoSize = true;
            this.lblFromDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFromDay.Location = new System.Drawing.Point(26, 81);
            this.lblFromDay.Name = "lblFromDay";
            this.lblFromDay.Size = new System.Drawing.Size(76, 22);
            this.lblFromDay.TabIndex = 0;
            this.lblFromDay.Text = "Từ ngày";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(378, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(486, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Danh sách đơn hàng chưa thanh toán của tôi ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblToDay
            // 
            this.lblToDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblToDay.AutoSize = true;
            this.lblToDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblToDay.Location = new System.Drawing.Point(26, 124);
            this.lblToDay.Name = "lblToDay";
            this.lblToDay.Size = new System.Drawing.Size(87, 22);
            this.lblToDay.TabIndex = 2;
            this.lblToDay.Text = "Đến ngày";
            // 
            // lblEmployee
            // 
            this.lblEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEmployee.Location = new System.Drawing.Point(675, 89);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(136, 22);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Thanh toán cho";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalMoney.Location = new System.Drawing.Point(675, 127);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(86, 22);
            this.lblTotalMoney.TabIndex = 4;
            this.lblTotalMoney.Text = "Tổng tiền";
            // 
            // lblMoney
            // 
            this.lblMoney.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMoney.Location = new System.Drawing.Point(813, 129);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(63, 22);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "Money";
            // 
            // dtgNotPaid
            // 
            this.dtgNotPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgNotPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNotPaid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderDate,
            this.colFoodName,
            this.colQuantity,
            this.colMoney,
            this.colPayTo,
            this.colStatus});
            this.dtgNotPaid.Location = new System.Drawing.Point(0, 188);
            this.dtgNotPaid.Name = "dtgNotPaid";
            this.dtgNotPaid.RowHeadersWidth = 62;
            this.dtgNotPaid.RowTemplate.Height = 28;
            this.dtgNotPaid.Size = new System.Drawing.Size(1254, 342);
            this.dtgNotPaid.TabIndex = 6;
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPayment.Location = new System.Drawing.Point(1072, 77);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(139, 40);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Location = new System.Drawing.Point(1072, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 38);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dtpFromDay
            // 
            this.dtpFromDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFromDay.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFromDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDay.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dtpFromDay.Location = new System.Drawing.Point(108, 78);
            this.dtpFromDay.Name = "dtpFromDay";
            this.dtpFromDay.Size = new System.Drawing.Size(160, 28);
            this.dtpFromDay.TabIndex = 9;
            this.dtpFromDay.ValueChanged += new System.EventHandler(this.dtpFromDay_ValueChanged);
            // 
            // dtpToDay
            // 
            this.dtpToDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpToDay.CustomFormat = "dd/MM/yyyy";
            this.dtpToDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpToDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDay.Location = new System.Drawing.Point(108, 121);
            this.dtpToDay.Name = "dtpToDay";
            this.dtpToDay.Size = new System.Drawing.Size(160, 28);
            this.dtpToDay.TabIndex = 10;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(817, 83);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(213, 30);
            this.cmbEmployee.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(302, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Trạng thái thanh toán";
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Location = new System.Drawing.Point(490, 81);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(115, 30);
            this.cmbPaymentStatus.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(302, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Trạng thái đơn hàng";
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbOrderStatus.FormattingEnabled = true;
            this.cmbOrderStatus.Location = new System.Drawing.Point(490, 121);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.Size = new System.Drawing.Size(115, 30);
            this.cmbOrderStatus.TabIndex = 15;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DataPropertyName = "order_date";
            this.colOrderDate.HeaderText = "Ngày đặt";
            this.colOrderDate.MinimumWidth = 8;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.ReadOnly = true;
            this.colOrderDate.Width = 150;
            // 
            // colFoodName
            // 
            this.colFoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFoodName.DataPropertyName = "food_name";
            this.colFoodName.HeaderText = "Tên món";
            this.colFoodName.MinimumWidth = 8;
            this.colFoodName.Name = "colFoodName";
            this.colFoodName.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "quantity";
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.MinimumWidth = 8;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 150;
            // 
            // colMoney
            // 
            this.colMoney.DataPropertyName = "price";
            dataGridViewCellStyle1.Format = "N0";
            this.colMoney.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMoney.HeaderText = "Tổng tiền";
            this.colMoney.MinimumWidth = 8;
            this.colMoney.Name = "colMoney";
            this.colMoney.ReadOnly = true;
            this.colMoney.Width = 150;
            // 
            // colPayTo
            // 
            this.colPayTo.DataPropertyName = "employee_ordered_name";
            this.colPayTo.HeaderText = "Thanh toán cho";
            this.colPayTo.MinimumWidth = 8;
            this.colPayTo.Name = "colPayTo";
            this.colPayTo.ReadOnly = true;
            this.colPayTo.Width = 250;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "statusOrder";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 150;
            // 
            // ucPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbOrderStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPaymentStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.dtpToDay);
            this.Controls.Add(this.dtpFromDay);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.dtgNotPaid);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblToDay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFromDay);
            this.Name = "ucPayment";
            this.Size = new System.Drawing.Size(1254, 533);
            this.Load += new System.EventHandler(this.ucPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotPaid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromDay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblToDay;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.DataGridView dtgNotPaid;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpFromDay;
        private System.Windows.Forms.DateTimePicker dtpToDay;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
