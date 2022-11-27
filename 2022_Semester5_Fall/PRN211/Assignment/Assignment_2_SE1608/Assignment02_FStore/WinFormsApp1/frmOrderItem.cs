using BusinessObject;
using FStoreAppLibrary.Data_Layer.Repository;
using System.ComponentModel;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class frmOrderItem : Form
    {
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public bool InsertOrUpdate { get; set; }

        public OrderDetail OrderDetailInfor { get; set; }

        public frmOrderItem()
        {
            InitializeComponent();
        }

        private void frmOrderItem_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = OrderDetailInfor.OrderId.ToString();
           
            txtOrderId.Enabled = false;
            txtProductId.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate == true)
            {
                txtProductId.Text = OrderDetailInfor.ProductId.ToString();
                txtQuantity.Text = OrderDetailInfor.Quantity.ToString();
                txtUnitPrice.Text = OrderDetailInfor.UnitPrice.ToString();
                txtDiscount.Text = OrderDetailInfor.Discount.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetail = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    ProductId = int.Parse(txtProductId.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Discount = float.Parse(txtDiscount.Text)
                };

                if (InsertOrUpdate == false)
                {
                    OrderDetailRepository.InsertOrderDetail(orderDetail);
                }
                else
                {
                    OrderDetailRepository.UpdateOrderDetail(orderDetail);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new Item in order" : "Update item in order");
            }
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
