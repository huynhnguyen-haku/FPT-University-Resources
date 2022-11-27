using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmMain : Form
    {

        public static Member User { get; set; } = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMemberManage_Click(object sender, EventArgs e)
        {
            loadForm(new frmMember());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(User != null)
            {
                UserInitializeComponent();
            }

        }

        private void UserInitializeComponent()
        {
            btnMemberManage.Text = "Your Information";
            tsBtnMemberManagememt.Text = "Your Information";
            seperator1.Visible = false;
            btnProductManagement.Visible = false;
            tsBtnProductManagement.Visible = false;
            btnOrderManagement.Text = "Order History";
            tsBtnOrderManagement.Text = "Order History";
        }

        private void loadForm(Form form)
        {
            if (pnContent.Controls.Count > 0)
            {
                pnContent.Controls.RemoveAt(0);
            }
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            this.pnContent.Controls.Add(frm);
            this.pnContent.Tag = frm;
            frm.Show();

        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            loadForm(new frmProduct());
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            loadForm(new frmOrder());
        }

        private void tsBtnMemberManagememt_Click(object sender, EventArgs e)
        {
            btnMemberManage.PerformClick();
        }

        private void tsBtnProductManagement_Click(object sender, EventArgs e)
        {
            btnProductManagement.PerformClick();
        }

        private void tsBtnOrderManagement_Click(object sender, EventArgs e)
        {
            btnOrderManagement.PerformClick();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
