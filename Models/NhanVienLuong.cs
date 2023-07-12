namespace BanTin24h.Models
{
	public class NhanVienLuong
	{
        public string? MaNhanVien { get; set; }
        public DateTime? NgayNhanLuong { get; set; }
        public User? NhanVien { get; set; }
        public Luong? Luong { get; set; }
    }
}
