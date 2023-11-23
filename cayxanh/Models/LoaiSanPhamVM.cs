using System.Data.SqlClient;
using cayxanh.Database;
using cayxanh.Entity;

namespace cayxanh.Models;

public class LoaiSanPhamVM
{
    List<LoaiSanPham> _loaisanpham = new List<LoaiSanPham>();
    
    public List<LoaiSanPham> LoaiSanPhams
    {
        get
        {
            return _loaisanpham;
        }
    }
    
    public LoaiSanPhamVM()
    {
        string query = "SELECT * FROM LoaiSanPham;";
        using (SqlConnection connection = new SqlConnection(DatabaseConstant.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    _loaisanpham.Add(new LoaiSanPham(id, name));
                }
            }
        }
    }
}