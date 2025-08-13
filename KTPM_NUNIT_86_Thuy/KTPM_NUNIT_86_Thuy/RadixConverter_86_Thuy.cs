using System;
using System.Text;

namespace KTPM_NUNIT_86_Thuy
{
    public class RadixConverter_86_Thuy
    {
        // Khởi tạo biến số nguyên dương n
        public int n_86_Thuy;

        // Tạo phương thức khởi tạo
        public RadixConverter_86_Thuy(int input_86_Thuy)
        {
            // Kiểm tra biến n người dùng nhập có là số nguyên dương không
            if (input_86_Thuy <= 0)
                throw new ArgumentException("Invalid n. Allowed range: greater than 0.");
            n_86_Thuy = input_86_Thuy;
        }

        // Tạo phương thức chuyển đổi hệ cơ số 10 sang cơ số bất kì
        public string ConvertDecimalToAnother(int k_86_Thuy)
        {
            int temp_86_Thuy = this.n_86_Thuy;
            // Kiểm tra biến hệ cơ số k có hợp lệ
            if (k_86_Thuy < 2 || k_86_Thuy > 16)
                throw new ArgumentException("Invalid k. Allowed range: 2 to 16.");
            string value_86_Thuy = "0123456789ABCDEF";
            StringBuilder result_86_Thuy = new StringBuilder();
            // Thực hiện chuyển đổi
            while (temp_86_Thuy > 0)
            {
                result_86_Thuy.Insert(0, value_86_Thuy[temp_86_Thuy % k_86_Thuy]);
                temp_86_Thuy /= k_86_Thuy;
            }
            return result_86_Thuy.ToString();
        }
    }
}
