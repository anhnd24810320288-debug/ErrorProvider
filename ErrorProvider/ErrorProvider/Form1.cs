namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Clear previous errors
            epCheck.Clear();

            bool valid = true;

            // Username required
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống");
                valid = false;
            }

            // Password required
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống");
                valid = false;
            }

            // Confirm must match
            if (!string.Equals(txtPassword.Text, txtConfirm.Text, StringComparison.Ordinal))
            {
                epCheck.SetError(txtConfirm, "Mật khẩu xác nhận không khớp");
                valid = false;
            }

            // Age check >= 18
            var today = DateTime.Today;
            int age = today.Year - dtpBirth.Value.Year;
            if (dtpBirth.Value.Date > today.AddYears(-age)) age--;
            if (age < 18)
            {
                epCheck.SetError(dtpBirth, "Bạn phải ít nhất 18 tuổi");
                valid = false;
            }

            // Terms must be accepted
            if (!cbTerms.Checked)
            {
                epCheck.SetError(cbTerms, "Bạn phải đồng ý với Điều khoản dịch vụ");
                valid = false;
            }

            if (valid)
            {
                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirm.Text = string.Empty;
            dtpBirth.Value = DateTime.Today;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cbTerms.Checked = false;
            epCheck.Clear();
        }
    }
}
