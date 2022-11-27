namespace WinFormsApp1
{
    partial class frmProduct
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lbBy = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbKeySearching = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(405, 298);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 29);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(214, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 29);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoad.Location = new System.Drawing.Point(23, 298);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(146, 29);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtUnitStock
            // 
            this.txtUnitStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitStock.Location = new System.Drawing.Point(534, 246);
            this.txtUnitStock.Name = "txtUnitStock";
            this.txtUnitStock.ReadOnly = true;
            this.txtUnitStock.Size = new System.Drawing.Size(226, 27);
            this.txtUnitStock.TabIndex = 17;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitPrice.Location = new System.Drawing.Point(534, 206);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(226, 27);
            this.txtUnitPrice.TabIndex = 16;
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWeight.Location = new System.Drawing.Point(534, 164);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(226, 27);
            this.txtWeight.TabIndex = 15;
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.Location = new System.Drawing.Point(151, 243);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(226, 27);
            this.txtProductName.TabIndex = 18;
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategory.Location = new System.Drawing.Point(151, 202);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(226, 27);
            this.txtCategory.TabIndex = 14;
            // 
            // txtProductId
            // 
            this.txtProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductId.Location = new System.Drawing.Point(151, 165);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(226, 27);
            this.txtProductId.TabIndex = 13;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(440, 209);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 12;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbCategory
            // 
            this.lbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(20, 209);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(82, 20);
            this.lbCategory.TabIndex = 11;
            this.lbCategory.Text = "CatagoryId";
            // 
            // lbProductName
            // 
            this.lbProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(20, 246);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 10;
            this.lbProductName.Text = "Product Name";
            // 
            // lbUnitStock
            // 
            this.lbUnitStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUnitStock.AutoSize = true;
            this.lbUnitStock.Location = new System.Drawing.Point(440, 246);
            this.lbUnitStock.Name = "lbUnitStock";
            this.lbUnitStock.Size = new System.Drawing.Size(76, 20);
            this.lbUnitStock.TabIndex = 9;
            this.lbUnitStock.Text = "Unit Stock";
            // 
            // lbWeight
            // 
            this.lbWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(440, 168);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(56, 20);
            this.lbWeight.TabIndex = 8;
            this.lbWeight.Text = "Weight";
            // 
            // lbMProductId
            // 
            this.lbMProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMProductId.AutoSize = true;
            this.lbMProductId.Location = new System.Drawing.Point(20, 171);
            this.lbMProductId.Name = "lbMProductId";
            this.lbMProductId.Size = new System.Drawing.Size(79, 20);
            this.lbMProductId.TabIndex = 7;
            this.lbMProductId.Text = "Product ID";
            // 
            // dgvProduct
            // 
            this.dgvProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(-1, 354);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(799, 132);
            this.dgvProduct.TabIndex = 6;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // lbHeader
            // 
            this.lbHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHeader.Location = new System.Drawing.Point(168, 19);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(474, 50);
            this.lbHeader.TabIndex = 5;
            this.lbHeader.Text = "PRODUCT MANAGEMENT";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(23, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 2);
            this.panel1.TabIndex = 22;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKeyword.Location = new System.Drawing.Point(373, 91);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(194, 27);
            this.txtKeyword.TabIndex = 13;
            // 
            // lbBy
            // 
            this.lbBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBy.AutoSize = true;
            this.lbBy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBy.Location = new System.Drawing.Point(23, 91);
            this.lbBy.Name = "lbBy";
            this.lbBy.Size = new System.Drawing.Size(39, 25);
            this.lbBy.TabIndex = 7;
            this.lbBy.Text = "By:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(614, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 29);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbKeySearching
            // 
            this.cbKeySearching.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbKeySearching.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeySearching.FormattingEnabled = true;
            this.cbKeySearching.Items.AddRange(new object[] {
            "Product ID",
            "Product Name",
            "Unit Price",
            "Unit In Stock"});
            this.cbKeySearching.Location = new System.Drawing.Point(94, 90);
            this.cbKeySearching.Name = "cbKeySearching";
            this.cbKeySearching.Size = new System.Drawing.Size(207, 28);
            this.cbKeySearching.TabIndex = 23;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(596, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 29);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 487);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbKeySearching);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtUnitStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbUnitStock);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbBy);
            this.Controls.Add(this.lbMProductId);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.lbHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnDelete;
        private Button btnAdd;
        private Button btnLoad;
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
        private DataGridView dgvProduct;
        private Label lbHeader;
        private Panel panel1;
        private TextBox txtKeyword;
        private Label lbBy;
        private Button btnSearch;
        private ComboBox cbKeySearching;
        private Button btnClose;
    }
}