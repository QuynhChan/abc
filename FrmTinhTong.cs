using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_Part1
{
    public partial class FrmTinhTong : Form
    {
        public FrmTinhTong()
        {
            InitializeComponent();
        }

        private void txtSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
(e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void txtSoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
(e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SoA, SoB;
            if (txtSoA.Text == "")

{
                MessageBox.Show(" Ban phai nhap gia tri cho a"," Thong bao ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSoA.Focus();
               
               return;
            }
            if (txtSoB.Text =="")
{
                MessageBox.Show("Ban phai nhap gia tri cho b"," Thong bao ",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSoB.Focus();
                
                return;
            }

                SoA = Convert.ToInt32(txtSoA.Text);
                SoB = Convert.ToInt32(txtSoB.Text);
            int button1 = 0;
            if (SoA < SoB)
            {
                for (int i = SoA; i <= SoB; i++)
                { button1 = button1 + i; }

            }
            if (SoA > SoB)
            {
                for (int i = SoB; i <= SoA; i++)
                { button1 = button1 + i; }
            }
            label1.Text = "Tong cac so tu " + SoA + " den " + SoB + " = " + button1.ToString();

            {

        }
    }


        private void LamLai_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            button1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban ca muon thoat khong","Thong bao",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==System.Windows.Forms.DialogResult.Yes)
              Application.Exit();
        }
    }
}
