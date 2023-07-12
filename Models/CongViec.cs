using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanTin24h.Models
{
	public class CongViec
	{
        [Key]
        public int Id { get; set; }
        [ForeignKey("PhongBan")]
        public int MaPhongBan { get; set; }
        public PhongBan? PhongBan { get; set; }
        [ForeignKey("ChucVu")]
        public int MaChucVu { get; set; }
        public ChucVu? ChucVu { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên công việc")]
        public string TenCongViec { get; set; }
        [Required(ErrorMessage = "Vui lòng điền ngày bắt đầu")]
        public DateTime NgayBatDau { get; set; }
		[Required(ErrorMessage = "Vui lòng điền ngày bắt đầu")]
		public DateTime NgayKetThuc { get; set; }
		[Required(ErrorMessage = "Vui lòng nhập số lượng người cần cho công việc")]
		public int SoLuong { get; set; }
		public int? SoNguoiNhan { get; set; }

		public ICollection<NhanVienCongViec>? NhanVienCongViecs { get; set; }
	}
}
