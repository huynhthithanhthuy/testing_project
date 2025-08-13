using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPM_NUNIT_86_Thuy
{
    public partial class Convert_86_Thuy: Form
    {
        public Convert_86_Thuy()
        {
            InitializeComponent();
        }

        private void btConvert_86_Thuy_Click(object sender, EventArgs e)
        {
            // lấy 2 giá trị n và k người dùng nhập vào
            int n_86_Thuy = int.Parse(txtN_86_Thuy.Text);
            int k_86_Thuy = int.Parse(txtK_86_Thuy.Text);
            //khởi tạo RadixConverter_86_Thuy
            RadixConverter_86_Thuy converter_86_Thuy = new RadixConverter_86_Thuy(n_86_Thuy);
            //Gọi phương thức chuyển đổi
            string kq_86_Thuy = converter_86_Thuy.ConvertDecimalToAnother(k_86_Thuy);
            //In kết quả ra textbox
            txtKetqua_86_Thuy.Text = kq_86_Thuy;
        }
    }
}
