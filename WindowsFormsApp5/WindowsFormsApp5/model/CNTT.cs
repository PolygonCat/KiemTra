using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.model
{
    class CNTT
    {
        [Key]
        public string id_sv { get; set; }
        public string pascal { get; set; }
        public string csharp { get; set; }
        public string sql { get; set; }
    }
}
