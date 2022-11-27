using BusinessObject;
using FStoreAppLibrary.Data_Layer.Repository;

namespace WinFormsApp1
{
    public partial class frmProduct : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        public void LoadProductList()
        {
            var products = productRepository.GetProducts();
            FillDataDgv(products);
        }

        private void ClearText()
        {
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitStock.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Add new product",
                InsertOrUpdate = false,
                ProductRepository = productRepository
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductShowed();
                productRepository.DeleteProduct(product.ProductId);
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }
        private Product GetProductShowed()
        {
            Product product = null;
            try
            {
                product = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategory.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtCategory.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitStock = int.Parse(txtUnitStock.Text)
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Update product",
                InsertOrUpdate = true,
                ProductInfor = GetProductShowed(),
                ProductRepository = productRepository
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSearchedProducts();
        }

        private void LoadSearchedProducts()
        {
            try
            {
                var products = ((ProductRepository)productRepository).Searching(cbKeySearching.Text, txtKeyword.Text);
                FillDataDgv(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Searching product");
            }
        }

        private void FillDataDgv(List<Product> products)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                txtProductId.DataBindings.Clear();
                txtCategory.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitStock.DataBindings.Clear();
                txtWeight.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtCategory.DataBindings.Add("Text", source, "CategoryId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitStock.DataBindings.Add("Text", source, "UnitStock");
                txtWeight.DataBindings.Add("Text", source, "Weight");

                dgvProduct.DataSource = null;
                dgvProduct.DataSource = source;
                this.dgvProduct.Columns["OrderDetails"].Visible = false;
                this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                if (products.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
