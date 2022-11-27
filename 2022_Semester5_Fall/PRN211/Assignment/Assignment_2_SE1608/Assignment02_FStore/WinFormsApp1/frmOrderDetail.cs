using BusinessObject;
using FStoreAppLibrary.Data_Layer.Repository;
using System.ComponentModel;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class frmOrderDetail : Form
    {
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource source;

        public IOrderRepository OrderRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Order OrderInfor { get; set; }

        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            txtOrderId.Enabled = !InsertOrUpdate;

            if (InsertOrUpdate == true)
            {
                txtOrderId.Text = OrderInfor.OrderId.ToString();
                txtMemberId.Text = OrderInfor.MemberId.ToString();
                txtOrderDate.Text = OrderInfor.OrderDate.ToString();
                txtOrderDate.Text = OrderInfor.OrderDate.ToString();
                txtRequiredDate.Text = OrderInfor.RequiredDate.ToString();
                txtShippedDate.Text = OrderInfor.ShippedDate.ToString();
                txtFreight.Text = OrderInfor.Freight.ToString();
                LoadOrderItemsList();
            }
            else
            {
                btnNewItem.Enabled = false;
                btnDeleteItem.Enabled = false;
                dgvOrderDetail.Enabled = false;
                this.Height -= dgvOrderDetail.Height;
                this.Width -= pnItemInfor.Width;
            }

            if(frmMain.User != null)
            {
                UserInitializeComponent();
            }
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new Order
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    MemberId = int.Parse(txtMemberId.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };

                if (InsertOrUpdate == false)
                {
                    OrderRepository.InsertOrder(order);
                }
                else
                {
                    OrderRepository.UpdateOrder(order);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new item" : "Update item");
            }
        }

        public void LoadOrderItemsList()
        {
            var items = ((OrderDetailRepository)orderDetailRepository)
                .GetOrderItemsByOrderId(int.Parse(txtOrderId.Text));
            try
            {
                source = new BindingSource();
                source.DataSource = items;

                txtProductId.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtQuantity.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtQuantity.DataBindings.Add("Text", source, "Quantity");
                txtDiscount.DataBindings.Add("Text", source, "Discount");

                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.DataSource = source;
                this.dgvOrderDetail.Columns["Order"].Visible = false;
                this.dgvOrderDetail.Columns["OrderNavigation"].Visible = false;
                this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                if (items.Count() == 0)
                {
                    ClearText();
                    btnDeleteItem.Enabled = false;
                }
                else
                {
                    btnDeleteItem.Enabled = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load items in order");
            }
        }

        private void ClearText()
        {
            txtProductId.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDiscount.Text = string.Empty;
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            frmOrderItem frmOrderItem = new frmOrderItem
            {
                Text = "Add new item in order",
                InsertOrUpdate = false,
                OrderDetailInfor = GetItemShowed(),
                OrderDetailRepository = orderDetailRepository
            };
            if (frmOrderItem.ShowDialog() == DialogResult.OK)
            {
                LoadOrderItemsList();
                source.Position = source.Count - 1;
            }
        }


        private OrderDetail GetItemShowed()
        {
            OrderDetail orderDetail = null;
            try
            {
                orderDetail = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    ProductId = int.Parse(txtProductId.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Discount = float.Parse(txtDiscount.Text)
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Item in Order");
            }
            return orderDetail;
        }

        private void dgvOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderItem frmOrderItem = new frmOrderItem
            {
                Text = "Update item in the order",
                InsertOrUpdate = true,
                OrderDetailInfor = GetItemShowed(),
                OrderDetailRepository = orderDetailRepository
            };
            if (frmOrderItem.ShowDialog() == DialogResult.OK)
            {
                LoadOrderItemsList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                var item = GetItemShowed();
                orderDetailRepository.DeleteOrderDetail(item.OrderId, item.ProductId);
                LoadOrderItemsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void txtFreight_Validating(object sender, CancelEventArgs e)
        {
            string value;
            NumberStyles style;
            CultureInfo culture;
            decimal currency;

            value = txtFreight.Text;
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("en-US");
            if (!value.Equals("")  && !Decimal.TryParse(value, style, culture, out currency))
            {
                MessageBox.Show("Please enter a valid currency amount.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // prevent the textbox from losing focus
                e.Cancel = true;
            }
        }

        private void UserInitializeComponent()
        {
            btnSaveOrder.Visible = false; 
            btnDeleteItem.Visible = false;
            btnNewItem.Visible = false;
            txtOrderId.ReadOnly = true;
            txtMemberId.ReadOnly = true;
            txtOrderDate.Enabled = false;
            txtRequiredDate.Enabled = false;
            txtShippedDate.Enabled = false;
            txtFreight.ReadOnly = true;
        }

    }
}
