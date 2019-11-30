namespace WindowsFormsApp5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WindowsFormsApp5.model.KiemTraContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WindowsFormsApp5.model.KiemTraContext context)
        {
            for (int i = 1; i < 10; i++)
            {
                context.SinhVien.AddOrUpdate(new model.SinhVien
                {
                    id = i.ToString(),
                    gioitinh = true,
                    ngaysinh = DateTime.Now,
                    hoten = "Hoàng Khánh " + i.ToString()
                });
                context.CNTT.AddOrUpdate(new model.CNTT
                {
                    id_sv = i.ToString(),
                    csharp = i.ToString(),
                    pascal = i.ToString(),
                    sql = i.ToString()
                });
                context.DiemVan.AddOrUpdate(new model.DiemVan
                {
                    id_sv = i.ToString(),
                    vanhoccd = i.ToString(),
                    vanhochd = i.ToString()
                });
                context.VatLy.AddOrUpdate(new model.VatLy
                {
                    id_sv = i.ToString(),
                    cohoc = i.ToString(),
                    quanghoc = i.ToString(),
                    vlhatnhan = i.ToString()
                });
            }
        }
    }
}
