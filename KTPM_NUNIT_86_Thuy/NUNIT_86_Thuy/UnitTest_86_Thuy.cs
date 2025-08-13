using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KTPM_NUNIT_86_Thuy;
using Microsoft.Office.Interop.Excel;

namespace NUNIT_86_Thuy
{
    [TestClass]
    public class UnitTest_86_Thuy
    {
        //tạo 1 giá trị RadixConverter_86_Thuy
        private RadixConverter_86_Thuy n_86_Thuy;

        //Thiết lập dữ liệu chung cho các test case
        [TestInitialize]
        public void SetUp_86_Thuy()
        {
            n_86_Thuy = new RadixConverter_86_Thuy(86);
        }

        
        [TestMethod]
        //TC1_baseBienduoi_86_Thuy: n_86_Thuy = 86, k_86_Thuy = 2, expected_86_Thuy = 1010110
        public void TC1_ConvertToBase2_86_Thuy()
        {
            string expected_86_Thuy, actual_86_Thuy;
            expected_86_Thuy = "1010110";
            actual_86_Thuy = n_86_Thuy.ConvertDecimalToAnother(2);
            Assert.AreEqual(expected_86_Thuy, actual_86_Thuy);
        }

        [TestMethod]
        //TC2_baseCanbienduoi_86_Thuy: n_86_Thuy = 86, k_86_Thuy = 3, expected_86_Thuy = 10012
        public void TC2_ConvertToBase3_86_Thuy()
        {
            string expected_86_Thuy, actual_86_Thuy;
            expected_86_Thuy = "10012";
            actual_86_Thuy = n_86_Thuy.ConvertDecimalToAnother(3);
            Assert.AreEqual(expected_86_Thuy, actual_86_Thuy);
        }

        [TestMethod]
        //TC3_baseBinhthuong_86_Thuy: n_86_Thuy = 32, k_86_Thuy = 8, expected_86_Thuy = 126
        public void TC3_ConvertToBase8_86_Thuy()
        {
            string expected_86_Thuy, actual_86_Thuy;
            expected_86_Thuy = "126";
            actual_86_Thuy = n_86_Thuy.ConvertDecimalToAnother(8);
            Assert.AreEqual(expected_86_Thuy, actual_86_Thuy);
        }

        [TestMethod]
        //TC4_baseCanbientren_86_Thuy: n_86_Thuy = 86, k_86_Thuy = 15, expected_86_Thuy = 5B
        public void TC4_ConvertToBase15_86_Thuy()
        {
            string expected_86_Thuy, actual_86_Thuy;
            expected_86_Thuy = "5B";
            actual_86_Thuy = n_86_Thuy.ConvertDecimalToAnother(15);
            Assert.AreEqual(expected_86_Thuy, actual_86_Thuy);
        }

        [TestMethod]
        //TC5_baseBientren_86_Thuy: n_86_Thuy = 86, k_86_Thuy = 16, expected_86_Thuy = 56
        public void TC5_ConvertToBase16_86_Thuy()
        {
            string expected_86_Thuy, actual_86_Thuy;
            expected_86_Thuy = "56";
            actual_86_Thuy = n_86_Thuy.ConvertDecimalToAnother(16);
            Assert.AreEqual(expected_86_Thuy, actual_86_Thuy);
        }

        [TestMethod]
        //TC6_kInvalid_86_Thuy: n_86_Thuy = 86, k_86_Thuy = 17, expected_86_Thuy = Exception
        [ExpectedException(typeof(ArgumentException))]
        public void TC6_baseInvalid_86_Thuy()
        {
            n_86_Thuy.ConvertDecimalToAnother(17);
        }

        [TestMethod]
        //TC7_Invalid_86_Thuy: n_86_Thuy = 0, base_86_Thuy = 2, expected_86_Thuy = Exception
        [ExpectedException(typeof(ArgumentException))]
        public void TC7_nInvalid_86_Thuy()
        {
            RadixConverter_86_Thuy nInvalid_86_Thuy = new RadixConverter_86_Thuy(0);
            nInvalid_86_Thuy.ConvertDecimalToAnother(2);
        }

        //Data file CSV
        public TestContext TestContext { get; set; }
        //thiết lập dữ liệu
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\Data_86_Thuy\DataConvert_86_Thuy.csv", "DataConvert_86_Thuy#csv",
                    DataAccessMethod.Sequential)]
        [TestMethod]
        //TC8: test datasource 3 cột, 4 hàng dữ liệu
        //n_86_Thuy = 10, k_86_Thuy = 2, expected_86_Thuy = 1010 
        //n_86_Thuy = 255, k_86_Thuy = 16, expected_86_Thuy = FF
        //n_86_Thuy = 100, k_86_Thuy = 8, expected_86_Thuy = 144
        //n_86_Thuy = 1, k_86_Thuy = 2, expected_86_Thuy = 1
        //n_86_Thuy = 80, k_86_Thuy = 12, expected_86_Thuy = 73
        public void TC8_CSV3Cot5Dong_86_Thuy()
        {
            int n_86_Thuy = int.Parse(TestContext.DataRow[0].ToString());
            int k_86_Thuy = int.Parse(TestContext.DataRow[1].ToString());
            string expected_86_Thuy = TestContext.DataRow[2].ToString().Trim('\'');
            RadixConverter_86_Thuy c_86_Thuy = new RadixConverter_86_Thuy(n_86_Thuy);
            string actual_86_Thuy = c_86_Thuy.ConvertDecimalToAnother(k_86_Thuy);
            Assert.AreEqual(expected_86_Thuy, actual_86_Thuy);
            Console.WriteLine($"{n_86_Thuy} from 10 to {k_86_Thuy} -> {expected_86_Thuy} : {actual_86_Thuy}");
        }

        //Excel data
        [TestMethod]
        //TC8: test datasource 3 cột, 4 hàng dữ liệu
        //n_86_Thuy = 1, k_86_Thuy = 2, expected_86_Thuy = 1, result_86_Thuy = Pass
        //n_86_Thuy = 2024, k_86_Thuy = 16, expected_86_Thuy = 7E8, result_86_Thuy = Pass
        //n_86_Thuy = 1000, k_86_Thuy = 8, expected_86_Thuy = 1750, result_86_Thuy = Pass
        //n_86_Thuy = 34, k_86_Thuy = 12, expected_86_Thuy = 2A, result_86_Thuy = Pass
        //n_86_Thuy = 8, k_86_Thuy = 2, expected_86_Thuy = 1000, result_86_Thuy = Pass
        public void TC9_Excel3Cot5Dong_86_Thuy()
        {
            // lấy đường đẫn file excel
            string filepath_86_Thuy = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                @"Data_86_Thuy\Excel_86_Thuy.xlsx");

            //Tạo đối tượng làm việc với excel
            Application excel_86_Thuy = new Application();
            Workbook wb_86_Thuy = excel_86_Thuy.Workbooks.Open(filepath_86_Thuy);
            Worksheet ws_86_Thuy = wb_86_Thuy.Worksheets[1];

            Range cell_86_Thuy = ws_86_Thuy.Range["A1", "D6"];
            //khởi tạo mảng 2 chiều từ dữ liệu cell_86_Thuy
            object[,] values_86_Thuy = (object[,])cell_86_Thuy.Value;
            //Đọc dữ liệu từ dòng 2 bỏ qua tên cột
            for( int row_86_Thuy = 2; row_86_Thuy <= values_86_Thuy.GetLength(0); row_86_Thuy++)
            {
                int n_86_Thuy = int.Parse(values_86_Thuy[row_86_Thuy,1].ToString());
                int k_86_Thuy = int.Parse(values_86_Thuy[row_86_Thuy,2].ToString());
                string expect_86_Thuy = values_86_Thuy[row_86_Thuy, 3].ToString().Trim('\'');
                string result_86_Thuy = values_86_Thuy[row_86_Thuy, 4].ToString();
                RadixConverter_86_Thuy c_86_Thuy = new RadixConverter_86_Thuy(n_86_Thuy);
                string actual_86_Thuy = c_86_Thuy.ConvertDecimalToAnother(k_86_Thuy);
                Assert.AreEqual(expect_86_Thuy, actual_86_Thuy);
                Console.WriteLine($"{n_86_Thuy} from 10 to {k_86_Thuy} -> {expect_86_Thuy} : {actual_86_Thuy} : {result_86_Thuy}");
            }
            //đóng 
            wb_86_Thuy.Close();
            excel_86_Thuy.Quit();
            
        }
    }
}
