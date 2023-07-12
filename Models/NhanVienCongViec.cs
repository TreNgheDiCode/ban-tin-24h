namespace BanTin24h.Models
{
	public class NhanVienCongViec
	{
        public string? MaNhanVien { get; set; }
        public int? MaCongViec { get; set; }
        public User? NhanVien { get; set; }
        public CongViec? CongViec { get; set; }
    }
}
