using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.model
{
    class VatLy
    {
        [Key]
        public string id_sv { get; set; }
        public string cohoc { get; set; }
        public string quanghoc { get; set; }
        public string vlhatnhan { get; set; }
    }
}
