
namespace OrderFood
{
    partial class ucOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbRestName = new System.Windows.Forms.ComboBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnOrder = new System.Windows.Forms.Button();
            this.mainLabel1 = new System.Windows.Forms.Label();
            this.dtgFood = new System.Windows.Forms.DataGridView();
            this.colChoose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainLabel3 = new System.Windows.Forms.Label();
            this.mainLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFood)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRestName
            // 
            this.cbRestName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbRestName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRestName.FormattingEnabled = true;
            this.cbRestName.Location = new System.Drawing.Point(147, 118);
            this.cbRestName.Name = "cbRestName";
            this.cbRestName.Size = new System.Drawing.Size(249, 28);
            this.cbRestName.TabIndex = 15;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpOrderDate.CustomFormat = "dd/MM/yyyy";
            this.dtpOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDate.Location = new System.Drawing.Point(147, 73);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(180, 30);
            this.dtpOrderDate.TabIndex = 14;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.Location = new System.Drawing.Point(816, 151);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(116, 34);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Đặt hàng";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // mainLabel1
            // 
            this.mainLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainLabel1.AutoSize = true;
            this.mainLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.mainLabel1.Location = new System.Drawing.Point(356, 14);
            this.mainLabel1.Name = "mainLabel1";
            this.mainLabel1.Size = new System.Drawing.Size(205, 46);
            this.mainLabel1.TabIndex = 12;
            this.mainLabel1.Text = "Đặt Đồ Ăn";
            // 
            // dtgFood
            // 
            this.dtgFood.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dtgFood.AllowUserToAddRows = false;
            this.dtgFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtgFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChoose,
            this.colFoodName,
            this.colPrice,
            this.colQuantity,
            this.colNote,
            this.colTotal});
            this.dtgFood.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgFood.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgFood.Location = new System.Drawing.Point(5, 216);
            this.dtgFood.Name = "dtgFood";
            this.dtgFood.RowHeadersWidth = 62;
            this.dtgFood.RowTemplate.Height = 28;
            this.dtgFood.Size = new System.Drawing.Size(940, 302);
            this.dtgFood.TabIndex = 11;
            this.dtgFood.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFood_CellValueChanged);
            // 
            // colChoose
            // 
            this.colChoose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colChoose.HeaderText = "";
            this.colChoose.MinimumWidth = 8;
            this.colChoose.Name = "colChoose";
            this.colChoose.Width = 8;
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
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle1;
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
            // colNote
            // 
            this.colNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNote.DataPropertyName = "note";
            this.colNote.HeaderText = "Note";
            this.colNote.MinimumWidth = 8;
            this.colNote.Name = "colNote";
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTotal.DataPropertyName = "total_price";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTotal.HeaderText = "Tổng tiền";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 120;
            // 
            // mainLabel3
            // 
            this.mainLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainLabel3.AutoSize = true;
            this.mainLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mainLabel3.Location = new System.Drawing.Point(7, 117);
            this.mainLabel3.Name = "mainLabel3";
            this.mainLabel3.Size = new System.Drawing.Size(61, 25);
            this.mainLabel3.TabIndex = 10;
            this.mainLabel3.Text = "Quán";
            // 
            // mainLabel2
            // 
            this.mainLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainLabel2.AutoSize = true;
            this.mainLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mainLabel2.Location = new System.Drawing.Point(10, 73);
            this.mainLabel2.Name = "mainLabel2";
            this.mainLabel2.Size = new System.Drawing.Size(58, 25);
            this.mainLabel2.TabIndex = 9;
            this.mainLabel2.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Khách hàng";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(147, 155);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(249, 28);
            this.cmbCustomer.TabIndex = 17;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRestName);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.mainLabel1);
            this.Controls.Add(this.dtgFood);
            this.Controls.Add(this.mainLabel3);
            this.Controls.Add(this.mainLabel2);
            this.Name = "ucOrder";
            this.Size = new System.Drawing.Size(945, 521);
            this.Load += new System.EventHandler(this.ucOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRestName;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label mainLabel1;
        private System.Windows.Forms.DataGridView dtgFood;
        private System.Windows.Forms.Label mainLabel3;
        private System.Windows.Forms.Label mainLabel2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomer;
    }
}
