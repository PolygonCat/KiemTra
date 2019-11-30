using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.model
{
    class SinhVien
    {
        [Key]
        public string id{ get; set; }
        public string hoten { get; set; }
        public Boolean gioitinh { get; set; }
        public DateTime ngaysinh { get; set; }
    }
}
