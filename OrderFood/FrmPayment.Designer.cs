
namespace OrderFood
{
    partial class FrmPayment
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
            this.components = new System.ComponentModel.Container();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.lblNameOfBank = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.lblStk = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.pcbQrCode = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPayment
            // 
            this.lblPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPayment.Location = new System.Drawing.Point(307, 30);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(133, 29);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Thanh toán";
            // 
            // lblBankName
            // 
            this.lblBankName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBankName.Location = new System.Drawing.Point(57, 462);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(145, 25);
            this.lblBankName.TabIndex = 1;
            this.lblBankName.Text = "Tên ngân hàng";
            // 
            // lblNameOfBank
            // 
            this.lblNameOfBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNameOfBank.AutoSize = true;
            this.lblNameOfBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNameOfBank.Location = new System.Drawing.Point(227, 462);
            this.lblNameOfBank.Name = "lblNameOfBank";
            this.lblNameOfBank.Size = new System.Drawing.Size(47, 25);
            this.lblNameOfBank.TabIndex = 2;
            this.lblNameOfBank.Text = "Tên";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTotalMoney.Location = new System.Drawing.Point(57, 531);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(94, 25);
            this.lblTotalMoney.TabIndex = 3;
            this.lblTotalMoney.Text = "Tổng tiền";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBankAccount.Location = new System.Drawing.Point(57, 496);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(121, 25);
            this.lblBankAccount.TabIndex = 4;
            this.lblBankAccount.Text = "Số tài khoản";
            // 
            // lblStk
            // 
            this.lblStk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStk.AutoSize = true;
            this.lblStk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStk.Location = new System.Drawing.Point(227, 496);
            this.lblStk.Name = "lblStk";
            this.lblStk.Size = new System.Drawing.Size(41, 25);
            this.lblStk.TabIndex = 5;
            this.lblStk.Text = "Stk";
            // 
            // lblMoney
            // 
            this.lblMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMoney.Location = new System.Drawing.Point(227, 531);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(72, 25);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "Money";
            // 
            // pcbQrCode
            // 
            this.pcbQrCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbQrCode.Location = new System.Drawing.Point(173, 87);
            this.pcbQrCode.Name = "pcbQrCode";
            this.pcbQrCode.Size = new System.Drawing.Size(374, 343);
            this.pcbQrCode.TabIndex = 7;
            this.pcbQrCode.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDone.Location = new System.Drawing.Point(312, 563);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(128, 38);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Hoàn tất";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // FrmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 645);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pcbQrCode);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblStk);
            this.Controls.Add(this.lblBankAccount);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.lblNameOfBank);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.lblPayment);
            this.Name = "FrmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.Label lblNameOfBank;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.Label lblStk;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.PictureBox pcbQrCode;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnDone;
    }
}