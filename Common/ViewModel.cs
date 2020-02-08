using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class ViewModel
    {
        public string Login { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string DonVi { get; set; }
        public string ViTri { get; set; }
        public DateTime Age { get; set; }
        public Object LoaiVatTu { get; set; }
        public Object NhaCungCap { get; set; }
        public Object Kho { get; set; }
        public Object KhachHang { get; set; }
        public ViewModel()
        {
            Age = DateTime.Now;
        }
    }
}
