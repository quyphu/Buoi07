using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Phải Nhập Tên Đăng Nhập");
            }
            else
                this.errorProvider1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Phải Nhập Địa Chỉ Email!");
            }
            else
                this.errorProvider1.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(ctr, "Phải Nhập Mật Khẩu");
            }
            else
                this.errorProvider1.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "Phải Nhập Số");
            else
            this.errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s;
            string u;
            Control ctr = (Control)sender;           
            bool kiemtraPassword =txtPassWord.Text != txtXacNhan.Text;           
            if (kiemtraPassword)
            {

                s = "Mật Khẩu Không Trùng Mời Bạn Nhập Lại";
                MessageBox.Show(s);
                txtPassWord.Clear();
                txtXacNhan.Clear();
            }           
            else
            {
                u = "Bạn Đã Đăng Ký Thành Công Với Tài Khoản Có: " + "\n" + "Tên đăng nhập : " + txtTen.Text + "\n" + "Địa Chỉ Email : " + txtEmail.Text + "\n" + "PassWord : ************* ";
                MessageBox.Show(u);
            }
            
        }
    }
}
