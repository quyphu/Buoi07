using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi_07
{
    public partial class Form1 : Form
    {
        List<string> ListName;
        List<Product> productList;
        public Form1()
        {
            InitializeComponent();
            ListName = new List<string>();
            productList = new List<Product>();
            productList.Add(new Product("Banh Trung Thu", 1, 30));
            productList.Add(new Product("Banh Gao", 2, 45));
            productList.Add(new Product("Banh Bim Bim", 3, 10));
            productList.Add(new Product("Banh Xe", 4, 20));
            productList.Add(new Product("Banh Keo", 5, 15));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            foreach (Product ele in productList)
            {
                bool logic = Convert.ToInt16(txtTimKiem.Text) == ele.getCode();
                if (logic)
                {
                    txtKetQua.Text = ele.getName() + "\t" + ele.getGia();                  
                }   
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListName.Add(txtTimKiem.Text);
            txtTimKiem.Text = Convert.ToString(ListName.Count);
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        
        

    }
}
