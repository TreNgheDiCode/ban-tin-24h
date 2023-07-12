namespace BanTin24h.Models
{
	public class NhanVienDiemDanh
	{
		public string? MaNhanVien { get; set; }
		public DateTime? ThoiGianDiemDanh { get; set; }
        public decimal SoGioLam { get; set; }
        public User? NhanVien { get; set; }
        public DiemDanh? DiemDanh { get; set; }
    }
}
