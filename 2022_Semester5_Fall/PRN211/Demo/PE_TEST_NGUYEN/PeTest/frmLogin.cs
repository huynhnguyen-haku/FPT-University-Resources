
using DataAccess.DAO;
using DataAccess.Repository.Imple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;

namespace PeTest
{
    public partial class frmLogin : Form
    {
       // HraccountRepository hraccountRepository = null;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PeTestContext context = new PeTestContext();
            string userEmail = txtUserEmail.Text;
            string password = txtPassword.Text;
            //con tiep
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}