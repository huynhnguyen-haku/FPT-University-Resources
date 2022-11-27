using BusinessObject;
using FStoreAppLibrary.Data_Layer.Repository;

namespace WinFormsApp1
{
    public partial class frmOrder : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(frmMain.User == null)
            {
                LoadOrderList();
            }
            else
            {
                LoadUserOrderHistory();
            }
        }

        private void LoadOrderList()
        {
            var orders = orderRepository.GetOrders();
            try
            {
                FillDataGridView(orders);

                if (orders.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        private void ClearText()
        {
            txtOrderId.Text = string.Empty;
            txtMemberId.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
            txtFreight.Text = string.Empty;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderShowed();
                orderRepository.DeleteOrder(order.OrderId);
                LoadOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private Order GetOrderShowed()
        {
            Order order = null;
            try
            {
                order = new Order
                {
                    OrderId = int.Parse(txtOrderId.Text),
                    MemberId = int.Parse(txtMemberId.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order");
            }
            return order;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail
            {
                Text = "Add new order",
                InsertOrUpdate = false,
                OrderRepository = orderRepository
            };
            if (frmOrderDetail.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                source.Position = source.Count - 1;
            }
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;

            if(frmMain.User != null)
            {
                UserInitializeComponent();
            }
        }

        private void dgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail
            {
                Text = "Update order",
                InsertOrUpdate = true,
                OrderInfor = GetOrderShowed(),
                OrderRepository = orderRepository
            };
            if (frmOrderDetail.ShowDialog() == DialogResult.OK)
            {
                if (frmMain.User == null) {
                    LoadOrderList();
                }
                else {
                    LoadUserOrderHistory();
                }
                source.Position = source.Count - 1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UserInitializeComponent()
        {
            lbHeader.Text = "YOUR ORDER HISTORY";
            btnAdd.Visible = false;
            btnDelete.Visible = false;

            lbFrom.Visible = false;
            lbTo.Visible = false;
            lbStatistic.Visible = false;
            txtStartDate.Visible = false;
            txtEndDate.Visible = false;
            btnReport.Visible = false;
            line.Visible = false;

        }

        public void LoadUserOrderHistory()
        {
            var orders = orderRepository.GetOrdersByMemberId(frmMain.User.MemberId);
            try
            {
                FillDataGridView(orders);

                if (orders.Count() == 0)
                {
                    MessageBox.Show("You do not have any order yet", "Message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order history");
            }
        }

        private void FillDataGridView(List<Order> orders)
        {
            source = new BindingSource();
            source.DataSource = orders;

            txtOrderId.DataBindings.Clear();
            txtMemberId.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtRequiredDate.DataBindings.Clear();
            txtShippedDate.DataBindings.Clear();
            txtFreight.DataBindings.Clear();

            txtOrderId.DataBindings.Add("Text", source, "OrderId");
            txtMemberId.DataBindings.Add("Text", source, "MemberId");
            txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
            txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
            txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
            txtFreight.DataBindings.Add("Text", source, "Freight");

            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = source;
            this.dgvOrderList.Columns["Member"].Visible = false;
            this.dgvOrderList.Columns["OrderDetails"].Visible = false;
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var orders = orderRepository.GetOrdersInDateRange(DateTime.Parse(txtStartDate.Text),
                DateTime.Parse(txtEndDate.Text));
            try
            {
                FillDataGridView(orders);

                if (orders.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load report order list");
            }
        }
    }
}
