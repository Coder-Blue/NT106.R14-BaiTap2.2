namespace CRUD_APP;

public partial class FormChinh : Form
{
    public FormChinh() => InitializeComponent();

    public FormChinh(NguoiDung nguoiDung) : this()
    {
        lblChaoMung.Text = $"Xin chào, {nguoiDung.HoTen}!";
        lblTenDangNhap.Text = nguoiDung.TenDangNhap;
        lblHoTen.Text = nguoiDung.HoTen;
        lblEmail.Text = HienThi(nguoiDung.Email);
        lblNgayTao.Text = nguoiDung.NgayTao.ToString("dd/MM/yyyy HH:mm");
        lblLanDangNhapCuoi.Text = nguoiDung.LanDangNhapCuoi?.ToString("dd/MM/yyyy HH:mm") ?? "Đăng nhập lần đầu";
    }

    private static string HienThi(string giaTri) => string.IsNullOrEmpty(giaTri) ? "(không có)" : giaTri;

    private void btnDangXuat_Click(object sender, EventArgs e) => Close();
}
