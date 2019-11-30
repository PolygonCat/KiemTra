using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.model
{
    class DiemVan
    {
        [Key]
        public string id_sv { get; set; }
        public string vanhoccd { get; set; }
        public string vanhochd { get; set; }
    }
}
