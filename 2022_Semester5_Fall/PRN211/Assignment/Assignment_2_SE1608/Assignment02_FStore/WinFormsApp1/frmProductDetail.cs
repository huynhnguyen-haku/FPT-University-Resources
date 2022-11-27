using BusinessObject;
using FStoreAppLibrary.Data_Layer.Repository;
using System.ComponentModel;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class frmProductDetail : Form
    {
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product ProductInfor { get; set; }

        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            txtProductId.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate == true)
            {
                txtProductId.Text = ProductInfor.ProductId.ToString();
                txtCategory.Text = ProductInfor.CategoryId.ToString();
                txtProductName.Text = ProductInfor.ProductName;
                txtWeight.Text = ProductInfor.Weight;
                txtUnitPrice.Text = ProductInfor.UnitPrice.ToString();
                txtUnitStock.Text = ProductInfor.UnitStock.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    CategoryId = int.Parse(txtCategory.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtCategory.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitStock = int.Parse(txtUnitStock.Text)
                };

                if (InsertOrUpdate == false)
                {
                    ProductRepository.InsertProduct(product);
                }
                else
                {
                    ProductRepository.UpdateProduct(product);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new product" : "Update product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUnitPrice_Validating(object sender, CancelEventArgs e)
        {
            string value;
            NumberStyles style;
            CultureInfo culture;
            decimal currency;

            value = txtUnitPrice.Text;
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("en-US");
            if (!value.Equals("") && !Decimal.TryParse(value, style, culture, out currency))
            {
                MessageBox.Show("Please enter a valid currency amount.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // prevent the textbox from losing focus
                e.Cancel = true;
            }
        }

    }
}
