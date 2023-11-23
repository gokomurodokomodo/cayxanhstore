namespace cayxanh.Entity;

public class LoaiSanPham
{
    int maSanPham { get; set; }
    string tenSanPham { get; set; }

    public LoaiSanPham(
        int maSanPham,
        string tenSanPham
        )
    {
        this.maSanPham = maSanPham;
        this.tenSanPham = tenSanPham;
    }
}