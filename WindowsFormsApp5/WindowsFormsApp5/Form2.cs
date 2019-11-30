using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.model;
using WindowsFormsApp5.services;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sinhvien = new SinhVien();
            VatLy vatly = new VatLy();
            DiemVan diemvan = new DiemVan();
            CNTT cntt = new CNTT();

            sinhvien.id = Guid.NewGuid().ToString();
            sinhvien.hoten = textBox1.Text;
            sinhvien.gioitinh = radioButton1.Checked == true ? true : false;
            sinhvien.ngaysinh = dateTimePicker1.Value;

            diemvan.id_sv = sinhvien.id;
            diemvan.vanhoccd = textBox10.Text;
            diemvan.vanhochd = textBox9.Text;

            vatly.id_sv = sinhvien.id;
            vatly.cohoc = textBox7.Text;
            vatly.quanghoc = textBox6.Text;
            vatly.vlhatnhan = textBox5.Text;

            cntt.id_sv = sinhvien.id;
            cntt.pascal = textBox2.Text;
            cntt.csharp = textBox3.Text;
            cntt.sql = textBox4.Text;
            SinhVienServices.adddata(sinhvien, diemvan, vatly, cntt);
            DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}
