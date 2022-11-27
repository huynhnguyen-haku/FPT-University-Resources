namespace WinFormsApp1
{
    partial class frmProductDetail
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
            this.txtUnitStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbUnitStock = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbMProductId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUnitStock
            // 
            this.txtUnitStock.Location = new System.Drawing.Point(563, 224);
            this.txtUnitStock.Name = "txtUnitStock";
            this.txtUnitStock.Size = new System.Drawing.Size(226, 27);
            this.txtUnitStock.TabIndex = 29;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(563, 184);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(226, 27);
            this.txtUnitPrice.TabIndex = 28;
            this.txtUnitPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnitPrice_Validating);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(563, 142);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(226, 27);
            this.txtWeight.TabIndex = 27;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(180, 221);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(226, 27);
            this.txtProductName.TabIndex = 30;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(180, 180);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(226, 27);
            this.txtCategory.TabIndex = 26;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(180, 143);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(226, 27);
            this.txtProductId.TabIndex = 25;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(469, 187);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 24;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(49, 187);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(82, 20);
            this.lbCategory.TabIndex = 23;
            this.lbCategory.Text = "CatagoryId";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(49, 224);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 22;
            this.lbProductName.Text = "Product Name";
            // 
            // lbUnitStock
            // 
            this.lbUnitStock.AutoSize = true;
            this.lbUnitStock.Location = new System.Drawing.Point(469, 224);
            this.lbUnitStock.Name = "lbUnitStock";
            this.lbUnitStock.Size = new System.Drawing.Size(76, 20);
            this.lbUnitStock.TabIndex = 21;
            this.lbUnitStock.Text = "Unit Stock";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(469, 146);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 20;
            this.lbWeight.Text = "Weight";
            // 
            // lbMProductId
            // 
            this.lbMProductId.AutoSize = true;
            this.lbMProductId.Location = new System.Drawing.Point(49, 149);
            this.lbMProductId.Name = "lbMProductId";
            this.lbMProductId.Size = new System.Drawing.Size(79, 20);
            this.lbMProductId.TabIndex = 19;
            this.lbMProductId.Text = "Product ID";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(507, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 31);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(190, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 31);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(51, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 2);
            this.panel1.TabIndex = 33;
            // 
            // lbHeader
            // 
            this.lbHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(265, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(329, 50);
            this.lbHeader.TabIndex = 34;
            this.lbHeader.Text = "PRODUCT DETAIL";
            // 
            // frmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 361);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUnitStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbUnitStock);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbMProductId);
            this.Name = "frmProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProductDetail";
            this.Load += new System.EventHandler(this.frmProductDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUnitStock;
        private TextBox txtUnitPrice;
        private TextBox txtWeight;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtProductId;
        private Label lbUnitPrice;
        private Label lbCategory;
        private Label lbProductName;
        private Label lbUnitStock;
        private Label lbWeight;
        private Label lbMProductId;
        private Button btnCancel;
        private Button btnSave;
        private Panel panel1;
        private Label lbHeader;
    }
}