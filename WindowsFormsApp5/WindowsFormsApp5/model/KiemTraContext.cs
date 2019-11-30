using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.model
{
    class KiemTraContext : DbContext
    {
        public KiemTraContext() : base("Data Source=.;Initial Catalog=QLSV;Persist Security Info=True;User ID=sa;Password=123")
        {
        }
        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<DiemVan> DiemVan { get; set; }
        public DbSet<VatLy> VatLy { get; set; }
        public DbSet<CNTT> CNTT { get; set; }

    }
}
