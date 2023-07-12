using System.ComponentModel.DataAnnotations;

namespace BanTin24h.Models
{
	public class DiemDanh
	{
		[Key]
		public DateTime ThoiGianDiemDanh { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }

        public ICollection<NhanVienDiemDanh>? NhanVienDiemDanhs { get; set; }
	}
}
