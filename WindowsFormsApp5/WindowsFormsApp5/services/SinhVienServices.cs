using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp5.model;

namespace WindowsFormsApp5.services
{
    class SinhVienServices
    {
        public static List<SinhVien> getAll()
        {
            return new KiemTraContext().SinhVien.ToList();
        }
        public static DiemVan getDiemVan (string idSinhVien)
        {
            List<DiemVan> diemvans = new KiemTraContext().DiemVan.ToList();
            foreach(DiemVan diemvan in diemvans)
            {
                if (diemvan.id_sv == idSinhVien) return diemvan;

            }
            return null;
        }
        public static CNTT getCNTT(string idSinhVien)
        {
            List<CNTT> cntts = new KiemTraContext().CNTT.ToList();
            foreach (CNTT cntt in cntts)
            {
                if (cntt.id_sv == idSinhVien) return cntt;
 
            }
            return null;
        }
        public static VatLy getVatLy(string idSinhVien)
        {
            List<VatLy> vatlys = new KiemTraContext().VatLy.ToList();
            foreach (VatLy vatly in vatlys)
            {
                if (vatly.id_sv == idSinhVien) return vatly;
            }
            return null;
        }
    }
}
