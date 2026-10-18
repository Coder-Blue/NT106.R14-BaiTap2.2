namespace CRUD_APP;

public partial class DangNhap : Form
{
    public DangNhap() => InitializeComponent();

    private async void btnDangNhap_Click(object sender, EventArgs e)
    {
        lblLoi.Text = "";
        var tenDangNhap = txtTenDangNhap.Text.Trim();
        var matKhau = txtMatKhau.Text;

        if (tenDangNhap.Length == 0)
        {
            lblLoi.Text = "Vui lòng nhập tên đăng nhập.";
            txtTenDangNhap.Focus();
            return;
        }

        if (matKhau.Length == 0)
        {
            lblLoi.Text = "Vui lòng nhập mật khẩu.";
            txtMatKhau.Focus();
            return;
        }

        btnDangNhap.Enabled = false;
        btnDangNhap.Text = "Đang xử lý...";
        try
        {
            var nguoiDung = await XuLyNguoiDung.DangNhap(tenDangNhap, matKhau);
            if (nguoiDung is null)
            {
                lblLoi.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";
                txtMatKhau.Clear();
                txtMatKhau.Focus();
                return;
            }

            MoTrangChinh(nguoiDung);
        }
        catch (Exception ex)
        {
            lblLoi.Text = ex.Message;
        }
        finally
        {
            btnDangNhap.Enabled = true;
            btnDangNhap.Text = "Đăng nhập";
        }
    }

    private void MoTrangChinh(NguoiDung nguoiDung)
    {
        Hide();
        using (var formChinh = new FormChinh(nguoiDung))
        {
            formChinh.ShowDialog();
        }
        Show();
        txtMatKhau.Clear();
        txtTenDangNhap.Focus();
    }

    private void btnThoat_Click(object sender, EventArgs e) => Close();

    private void llbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using var formDangKy = new DangKy();
        formDangKy.ShowDialog();

        if (formDangKy.TenDangNhapDaDangKy is { Length: > 0 } tenDangNhap)
        {
            txtTenDangNhap.Text = tenDangNhap;
            txtMatKhau.Clear();
        }
    }
}
