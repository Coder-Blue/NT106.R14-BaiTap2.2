namespace CRUD_APP;

public partial class DangKy : Form
{
    public string TenDangNhapDaDangKy { get; private set; } = "";

    public DangKy() => InitializeComponent();

    private async void btnDangKy_Click(object sender, EventArgs e)
    {
        if (!KiemTraDuLieuHopLe())
        {
            return;
        }

        btnDangKy.Enabled = false;
        btnDangKy.Text = "Đang xử lý...";
        try
        {
            var tenDangNhap = txtTenDangNhap.Text.Trim();

            // Ngăn trùng tên đăng nhập ở mức chương trình trước khi thêm bản ghi.
            if (await XuLyNguoiDung.KiemTraTenDangNhapTonTai(tenDangNhap))
            {
                lblLoiTenDangNhap.Text = "Tên này đã có người dùng.";
                txtTenDangNhap.Focus();
                return;
            }

            await XuLyNguoiDung.DangKy(tenDangNhap, txtMatKhau.Text, txtHoTen.Text.Trim(), txtEmail.Text.Trim());
            TenDangNhapDaDangKy = tenDangNhap;

            MessageBox.Show("Đăng ký thành công! Bạn có thể đăng nhập ngay.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnDangKy.Enabled = true;
            btnDangKy.Text = "Đăng ký";
        }
    }

    private void btnHuy_Click(object sender, EventArgs e) => Close();

    private bool KiemTraDuLieuHopLe()
    {
        var cacO = new (TextBox Nhap, Label Loi, string? ThongBao)[]
        {
            (txtTenDangNhap, lblLoiTenDangNhap, KiemTraNhapLieu.TenDangNhap(txtTenDangNhap.Text.Trim())),
            (txtMatKhau, lblLoiMatKhau, KiemTraNhapLieu.MatKhau(txtMatKhau.Text)),
            (txtXacNhanMatKhau, lblLoiXacNhanMatKhau, KiemTraNhapLieu.XacNhanMatKhau(txtMatKhau.Text, txtXacNhanMatKhau.Text)),
            (txtHoTen, lblLoiHoTen, KiemTraNhapLieu.HoTen(txtHoTen.Text.Trim())),
            (txtEmail, lblLoiEmail, KiemTraNhapLieu.Email(txtEmail.Text.Trim())),
        };

        foreach (var (_, loi, thongBao) in cacO)
        {
            loi.Text = thongBao ?? "";
        }

        var oLoiDauTien = Array.Find(cacO, o => o.ThongBao is not null);
        oLoiDauTien.Nhap?.Focus();
        return oLoiDauTien.ThongBao is null;
    }
}
