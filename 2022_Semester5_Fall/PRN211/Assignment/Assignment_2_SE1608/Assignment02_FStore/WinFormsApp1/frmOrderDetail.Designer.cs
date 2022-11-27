namespace WinFormsApp1
{
    partial class frmOrderDetail
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
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.lbHeader1 = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHeader2 = new System.Windows.Forms.Label();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnItemInfor = new System.Windows.Forms.Panel();
            this.lbHeaderGDV = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtShippedDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(144, 326);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(226, 27);
            this.txtFreight.TabIndex = 47;
            this.txtFreight.Validating += new System.ComponentModel.CancelEventHandler(this.txtFreight_Validating);
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(144, 138);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(226, 27);
            this.txtMemberId.TabIndex = 44;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(144, 91);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(226, 27);
            this.txtOrderId.TabIndex = 43;
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(26, 282);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(100, 20);
            this.lbShippedDate.TabIndex = 42;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(26, 145);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(84, 20);
            this.lbMemberId.TabIndex = 41;
            this.lbMemberId.Text = "Member ID";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(27, 191);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(83, 20);
            this.lbOrderDate.TabIndex = 40;
            this.lbOrderDate.Text = "Order Date";
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(28, 329);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(55, 20);
            this.lbFreight.TabIndex = 39;
            this.lbFreight.Text = "Freight";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(28, 235);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(105, 20);
            this.lbRequiredDate.TabIndex = 38;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Location = new System.Drawing.Point(28, 96);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(66, 20);
            this.lbOrderId.TabIndex = 37;
            this.lbOrderId.Text = "Order ID";
            // 
            // lbHeader1
            // 
            this.lbHeader1.AutoSize = true;
            this.lbHeader1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHeader1.Location = new System.Drawing.Point(63, 24);
            this.lbHeader1.Name = "lbHeader1";
            this.lbHeader1.Size = new System.Drawing.Size(285, 38);
            this.lbHeader1.TabIndex = 50;
            this.lbHeader1.Text = "General Information";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(470, 144);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 49;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(470, 193);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(65, 20);
            this.lbQuantity.TabIndex = 49;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(470, 242);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(67, 20);
            this.lbDiscount.TabIndex = 49;
            this.lbDiscount.Text = "Discount";
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Location = new System.Drawing.Point(470, 95);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(79, 20);
            this.lbProductId.TabIndex = 49;
            this.lbProductId.Text = "Product ID";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(583, 89);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(226, 27);
            this.txtProductId.TabIndex = 51;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(583, 140);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(226, 27);
            this.txtUnitPrice.TabIndex = 51;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(583, 242);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(226, 27);
            this.txtDiscount.TabIndex = 51;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(583, 191);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(226, 27);
            this.txtQuantity.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(424, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 327);
            this.panel1.TabIndex = 52;
            // 
            // lbHeader2
            // 
            this.lbHeader2.AutoSize = true;
            this.lbHeader2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHeader2.Location = new System.Drawing.Point(525, 24);
            this.lbHeader2.Name = "lbHeader2";
            this.lbHeader2.Size = new System.Drawing.Size(245, 38);
            this.lbHeader2.TabIndex = 50;
            this.lbHeader2.Text = "Item Information";
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(12, 460);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 29;
            this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetail.Size = new System.Drawing.Size(841, 133);
            this.dgvOrderDetail.TabIndex = 53;
            this.dgvOrderDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellDoubleClick);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveOrder.Location = new System.Drawing.Point(77, 375);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(133, 29);
            this.btnSaveOrder.TabIndex = 54;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // btnNewItem
            // 
            this.btnNewItem.Location = new System.Drawing.Point(514, 299);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(133, 31);
            this.btnNewItem.TabIndex = 55;
            this.btnNewItem.Text = "New item";
            this.btnNewItem.UseVisualStyleBackColor = true;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(676, 299);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(133, 31);
            this.btnDeleteItem.TabIndex = 56;
            this.btnDeleteItem.Text = "Delete item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(237, 375);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 29);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(415, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 2);
            this.panel2.TabIndex = 57;
            // 
            // pnItemInfor
            // 
            this.pnItemInfor.BackColor = System.Drawing.Color.Transparent;
            this.pnItemInfor.Location = new System.Drawing.Point(413, 12);
            this.pnItemInfor.Name = "pnItemInfor";
            this.pnItemInfor.Size = new System.Drawing.Size(440, 409);
            this.pnItemInfor.TabIndex = 58;
            // 
            // lbHeaderGDV
            // 
            this.lbHeaderGDV.AutoSize = true;
            this.lbHeaderGDV.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHeaderGDV.Location = new System.Drawing.Point(12, 426);
            this.lbHeaderGDV.Name = "lbHeaderGDV";
            this.lbHeaderGDV.Size = new System.Drawing.Size(215, 31);
            this.lbHeaderGDV.TabIndex = 59;
            this.lbHeaderGDV.Text = "Items in the Order:";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtOrderDate.Location = new System.Drawing.Point(144, 185);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(226, 27);
            this.txtOrderDate.TabIndex = 60;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtRequiredDate.Location = new System.Drawing.Point(144, 233);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(226, 27);
            this.txtRequiredDate.TabIndex = 60;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtShippedDate.Location = new System.Drawing.Point(144, 281);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(226, 27);
            this.txtShippedDate.TabIndex = 60;
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 612);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.lbHeaderGDV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnNewItem);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lbHeader2);
            this.Controls.Add(this.lbHeader1);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.lbMemberId);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbOrderId);
            this.Controls.Add(this.pnItemInfor);
            this.Name = "frmOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOrderDetail";
            this.Load += new System.EventHandler(this.frmOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFreight;
        private TextBox txtMemberId;
        private TextBox txtOrderId;
        private Label lbShippedDate;
        private Label lbMemberId;
        private Label lbOrderDate;
        private Label lbFreight;
        private Label lbRequiredDate;
        private Label lbOrderId;
        private Label lbHeader1;
        private Label lbUnitPrice;
        private Label lbQuantity;
        private Label lbDiscount;
        private Label lbProductId;
        private TextBox txtProductId;
        private TextBox txtUnitPrice;
        private TextBox txtDiscount;
        private TextBox txtQuantity;
        private Panel panel1;
        private Label lbHeader2;
        private DataGridView dgvOrderDetail;
        private Button btnSaveOrder;
        private Button btnNewItem;
        private Button btnDeleteItem;
        private Button btnClose;
        private Panel panel2;
        private Panel pnItemInfor;
        private Label lbHeaderGDV;
        private DateTimePicker txtOrderDate;
        private DateTimePicker txtRequiredDate;
        private DateTimePicker txtShippedDate;
    }
}