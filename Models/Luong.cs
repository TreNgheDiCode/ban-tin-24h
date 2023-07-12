using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BanTin24h.Models
{
	public class Luong
	{
		[Key]
        [Required(ErrorMessage = "Vui lòng nhập vào ngày nhận lương")]
        public DateTime NgayNhanLuong { get; set; }
        public int? LuongCung { get; set; }
        public int? LuongThuong { get; set; }
        public int? LuongPhat { get; set; }

		public ICollection<NhanVienLuong>? NhanVienLuongs { get; set; }
	}
}
