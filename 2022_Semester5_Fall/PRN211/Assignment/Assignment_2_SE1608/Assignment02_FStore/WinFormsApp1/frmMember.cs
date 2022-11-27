using BusinessObject;
using FStoreAppLibrary.Data_Layer.Repository;

namespace WinFormsApp1
{
    public partial class frmMember : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;

        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;

            if(frmMain.User != null)
            {
                UserInitializeComponent();
            }
        }

         private void UserInitializeComponent()
        {
            lbHeader.Text = "YOUR INFORMATION";
            btnAdd.Visible = false;
            btnLoad.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = true;
            dgvMemberList.Visible = false;

            txtMenberId.Text = frmMain.User.MemberId.ToString();
            txtEmail.Text = frmMain.User.Email;
            txtCompanyName.Text = frmMain.User.CompanyName;
            txtCity.Text = frmMain.User.City;
            txtCountry.Text = frmMain.User.Country;
            txtPassword.Text = frmMain.User.Password;

            txtCity.ReadOnly = false;
            txtCompanyName.ReadOnly = false;
            txtCountry.ReadOnly = false;
            //txtEmail.ReadOnly = false;
            txtPassword.ReadOnly = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                IMemberRepository memberRepository = new MemberRepository();
                var member = new Member
                {
                    MemberId = int.Parse(txtMenberId.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };

                memberRepository.UpdateMember(member);

                MessageBox.Show("Update successfully" , "Message");

                frmMain.User = null;

                frmMain.User = memberRepository.GetMemberById(int.Parse(txtMenberId.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update information");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void ClearText()
        {
            txtMenberId.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        public void LoadMemberList()
        {
            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMenberId.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMenberId.DataBindings.Add("Text", source, "MemberId");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                this.dgvMemberList.Columns["Orders"].Visible = false;
                this.dgvMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                if (members.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberShowed();
                memberRepository.DeleteMember(member.MemberId);
                LoadMemberList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private Member GetMemberShowed()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = int.Parse(txtMenberId.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberInfor = GetMemberShowed(),
                MemberRepository = memberRepository
            };
            if(frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Add new member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if(frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
