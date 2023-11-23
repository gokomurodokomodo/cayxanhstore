using System.Data.SqlClient;
using cayxanh.Database;
using cayxanh.Entity;

namespace cayxanh.Models;

public class NguoiDungViewModel
{
    private NguoiDung _nguoidung;
    
    public NguoiDung nguoiDung
    {
        get
        {
            return _nguoidung;
        }
    }
    public NguoiDungViewModel(string email)
    {
        string query = $"select * from TaiKhoan where Email = {email};";
        using (SqlConnection connection = new SqlConnection(DatabaseConstant.ConnectionString))
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int maNguoiDung = reader.GetInt32(0);
                    string hoTen = reader.GetString(1);
                    string dienThoai = reader.GetString(3);
                    string diaChi = reader.GetString(6);
                    int idQuyen = reader.GetInt32(5);
                    _nguoidung = new NguoiDung(
                        maNguoiDung,
                        hoTen,
                        email,
                        dienThoai,
                        diaChi,
                        idQuyen
                        );
                }
            }
        }
    }
}