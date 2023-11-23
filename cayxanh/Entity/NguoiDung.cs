namespace cayxanh.Entity;

public class NguoiDung
{
    int maNguoiDung { get; set; }
    string hoTen { get; set; }
    string email { get; set; }
    string dienThoai { get; set; }
    string diaChi { get; set; }
    int idQuyen { get; set; }

    public NguoiDung(
        int maNguoiDung,
        string hoTen,
        string email,
        string dienThoai,
        string diaChi,
        int idQuyen
    )
    {
        this.maNguoiDung = maNguoiDung;
        this.hoTen = hoTen;
        this.email = email;
        this.dienThoai = dienThoai;
        this.diaChi = diaChi;
        this.idQuyen = idQuyen;
    }
}