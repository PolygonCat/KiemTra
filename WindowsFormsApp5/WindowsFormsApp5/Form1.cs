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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var sinhvien = SinhVienServices.getAll();
            dataGridView1.AutoGenerateColumns = false;
            bindingSource1.DataSource = sinhvien;
            dataGridView1.DataSource = bindingSource1;
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var sinhvienCurrent = bindingSource1.Current as SinhVien;
            textBox1.Text = sinhvienCurrent.hoten;
            radioButton1.Checked = sinhvienCurrent.gioitinh == true ? true : false;
            dateTimePicker1.Value = sinhvienCurrent.ngaysinh;
            textBox10.Text = SinhVienServices.getDiemVan(sinhvienCurrent.id).vanhoccd;
            textBox9.Text = SinhVienServices.getDiemVan(sinhvienCurrent.id).vanhoccd;
            textBox7.Text = SinhVienServices.getVatLy(sinhvienCurrent.id).cohoc;
            textBox6.Text = SinhVienServices.getVatLy(sinhvienCurrent.id).quanghoc;
            textBox5.Text = SinhVienServices.getVatLy(sinhvienCurrent.id).vlhatnhan;
            textBox2.Text = SinhVienServices.getCNTT(sinhvienCurrent.id).pascal;
            textBox3.Text = SinhVienServices.getCNTT(sinhvienCurrent.id).csharp;
            textBox4.Text = SinhVienServices.getCNTT(sinhvienCurrent.id).sql;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = radioButton1.Checked == true ? false : true;
        }
    }
}
