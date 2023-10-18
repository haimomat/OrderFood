
namespace OrderFood
{
    partial class frmSubmit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSubmitOrder = new System.Windows.Forms.Label();
            this.mainLabel3 = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dtgSubmit = new System.Windows.Forms.DataGridView();
            this.colFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubmitOrder
            // 
            this.lblSubmitOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubmitOrder.AutoSize = true;
            this.lblSubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSubmitOrder.Location = new System.Drawing.Point(294, 24);
            this.lblSubmitOrder.Name = "lblSubmitOrder";
            this.lblSubmitOrder.Size = new System.Drawing.Size(366, 46);
            this.lblSubmitOrder.TabIndex = 0;
            this.lblSubmitOrder.Text = "Xác nhận đơn hàng";
            this.lblSubmitOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainLabel3
            // 
            this.mainLabel3.AutoSize = true;
            this.mainLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mainLabel3.Location = new System.Drawing.Point(45, 105);
            this.mainLabel3.Name = "mainLabel3";
            this.mainLabel3.Size = new System.Drawing.Size(184, 29);
            this.mainLabel3.TabIndex = 2;
            this.mainLabel3.Text = "Tên khách hàng";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalMoney.Location = new System.Drawing.Point(621, 105);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(115, 29);
            this.lblTotalMoney.TabIndex = 4;
            this.lblTotalMoney.Text = "Tổng tiền";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmit.Location = new System.Drawing.Point(302, 620);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 51);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.Location = new System.Drawing.Point(504, 620);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(123, 51);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Chỉnh sửa ";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCustomerName.Location = new System.Drawing.Point(235, 105);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 29);
            this.lblCustomerName.TabIndex = 10;
            // 
            // dtgSubmit
            // 
            this.dtgSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dtgSubmit.AllowUserToAddRows = false;
            this.dtgSubmit.AllowUserToResizeColumns = false;
            this.dtgSubmit.AllowUserToResizeRows = false;
            this.dtgSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSubmit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgSubmit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgSubmit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSubmit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFoodName,
            this.colPrice,
            this.colQuantity,
            this.dataGridViewTextBoxColumn1,
            this.colTotalMoney});
            this.dtgSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgSubmit.Location = new System.Drawing.Point(1, 181);
            this.dtgSubmit.Name = "dtgSubmit";
            this.dtgSubmit.ReadOnly = true;
            this.dtgSubmit.RowHeadersWidth = 62;
            this.dtgSubmit.RowTemplate.Height = 28;
            this.dtgSubmit.Size = new System.Drawing.Size(956, 406);
            this.dtgSubmit.TabIndex = 12;
            // 
            // colFoodName
            // 
            this.colFoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFoodName.DataPropertyName = "food_name";
            this.colFoodName.HeaderText = "Tên Món";
            this.colFoodName.MinimumWidth = 8;
            this.colFoodName.Name = "colFoodName";
            this.colFoodName.ReadOnly = true;
            this.colFoodName.Width = 250;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPrice.DataPropertyName = "price";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPrice.HeaderText = "Giá";
            this.colPrice.MinimumWidth = 8;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 150;
            // 
            // colQuantity
            // 
            this.colQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colQuantity.DataPropertyName = "quantity";
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.MinimumWidth = 8;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn1.HeaderText = "Note";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colTotalMoney
            // 
            this.colTotalMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTotalMoney.DataPropertyName = "total_price";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.colTotalMoney.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTotalMoney.HeaderText = "Tổng tiền";
            this.colTotalMoney.MinimumWidth = 8;
            this.colTotalMoney.Name = "colTotalMoney";
            this.colTotalMoney.ReadOnly = true;
            this.colTotalMoney.Width = 120;
            // 
            // lblMoney
            // 
            this.lblMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMoney.Location = new System.Drawing.Point(742, 105);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(65, 29);
            this.lblMoney.TabIndex = 13;
            this.lblMoney.Text = "blaal";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 767);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.dtgSubmit);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.mainLabel3);
            this.Controls.Add(this.lblSubmitOrder);
            this.Name = "frmSubmit";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.frmSubmit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSubmit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubmitOrder;
        private System.Windows.Forms.Label mainLabel3;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.DataGridView dtgSubmit;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalMoney;
    }
}