using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebDriver_86_Thuy
{
    public partial class WebDiver_86_Thuy: Form
    {
        IWebDriver driver_86_thuy;
        public WebDiver_86_Thuy()
        {
            InitializeComponent();
        }

        private void btLogin_86_Thuy_Click(object sender, EventArgs e)
        {
            // đóng màn hình đen khi chạy
            ChromeDriverService chrome_86_thuy = ChromeDriverService.CreateDefaultService();
            chrome_86_thuy.HideCommandPromptWindow = true;

            //điều hướng trình duyệt đến web pinterest
            driver_86_thuy = new ChromeDriver(chrome_86_thuy);
            driver_86_thuy.Navigate().GoToUrl("https://www.pinterest.com/");
            Thread.Sleep(5000);

            //tìm button log in 1 và mở form đăng nhập
            driver_86_thuy.FindElement(By.CssSelector("div[data-test-id='simple-login-button'] button")).Click();
            Thread.Sleep(5000);

            //TC1_Login_86_Thuy: không nhập email và password
            //email_86_Thuy ="", password_86_Thuy ="", expected = Thông báo lỗi
            //Click log in
            driver_86_thuy.FindElement(By.CssSelector("div[data-test-id='registerFormSubmitButton'] button")).Click();
            //kiểm tra email-error có tồn tại hay không, tồn tại -> pass, ngược lại -> fail
            if (driver_86_thuy.FindElements(By.Id("email-error")).Count > 0)
                Console.WriteLine("TC1_Login_86_Thuy: khong nhap email va password -> Pass ");
            else
                Console.WriteLine("TC1_Login_86_Thuy: khong nhap email va password -> Fail ");
            Thread.Sleep(5000);


            //TC2_Login_86_Thuy: nhập email, không nhập password
            //email_86_Thuy ="sheisthy29@gmail.com", password_86_Thuy ="", expected = Thông báo lỗi
            // nhập email
            driver_86_thuy.FindElement(By.Id("email")).SendKeys("sheisthy29@gmail.com");
            Thread.Sleep(2000);
            //Click log in
            driver_86_thuy.FindElement(By.CssSelector("div[data-test-id='registerFormSubmitButton'] button")).Click();
            Thread.Sleep(2000);
            //kiểm tra password-error có tồn tại hay không, tồn tại -> pass, ngược lại -> fail
            if (driver_86_thuy.FindElements(By.Id("password-error")).Count > 0)
                Console.WriteLine("TC2_Login_86_Thuy: chi nhap email -> Pass ");
            else
                Console.WriteLine("TC2_Login_86_Thuy: chi nhap email -> Fail ");
            Thread.Sleep(5000);


            //TC3_Login_86_Thuy: nhập mail, nhập password
            //email_86_Thuy ="sheisthy_86_Thuy", password_86_Thuy ="ThuyOu2004", expected = Đăng nhập thành công
            // nhập password
            driver_86_thuy.FindElement(By.Id("password")).SendKeys("ThuyOu2004");
            Thread.Sleep(2000);
            //Click log in
            driver_86_thuy.FindElement(By.CssSelector("div[data-test-id='registerFormSubmitButton'] button")).Click();
            Thread.Sleep(2000);
            //kiểm tra error có tồn tại hay không, nếu cả 2 tồn tại -> fail, ngược lại -> pass
            if (driver_86_thuy.FindElements(By.Id("email-error")).Count > 0 && driver_86_thuy.FindElements(By.Id("password-error")).Count > 0)
                Console.WriteLine("TC3Login_86_Thuy: nhap email va password -> Fail ");
            else
                Console.WriteLine("TC3_Login_86_Thuy: nhap email va password -> Pass ");
            Thread.Sleep(5000);

        }

        private void btSharePin_86_Thuy_Click(object sender, EventArgs e)
        {
            //điều hướng đến pin muốn chia chia sẻ
            driver_86_thuy.Navigate().GoToUrl("https://www.pinterest.com/pin/338121884554282407/");
            Thread.Sleep(5000);

            //lấy nút chia sẻ và nhấn
            driver_86_thuy.FindElement(By.CssSelector("div[data-test-id='closeup-share-button'] button")).Click();
            Thread.Sleep(5000);

            //TC4_SharePin_86_Thuy: không nhập tên người nhận
            driver_86_thuy.FindElement(By.Id("contactSearch")).SendKeys("");
            //kiểm tra từ khoá "view chat" có tồn tại hay không, nếu không tồn tại -> Pass, ngược lại -> Fail
            if (driver_86_thuy.FindElements(By.XPath("//div[text()='View chat']")).Count == 0)
                Console.WriteLine("TC4_SharePin_86_Thuy: khong nhap ten nguoi nhan -> Pass ");
            else
                Console.WriteLine("TC4_SharePin_86_Thuy: khong nhap ten nguoi nhan -> Fail ");

            //TC5_SharePin_86_Thuy: nhập tên người nhận
            //lấy input và nhập tên người dùng
            driver_86_thuy.FindElement(By.Id("contactSearch")).SendKeys("KTPM_86_Thuy");
            Thread.Sleep(3000);
            //tìm và nhấn button send
            driver_86_thuy.FindElement(By.CssSelector("div[data-test-id='sharesheet-contact-item'] button")).Click();
            Thread.Sleep(7000);
            //kiểm tra từ khoá "view chat" có tồn tại hay không, nếu tồn tại -> Pass, ngược lại -> Fail
            if (driver_86_thuy.FindElements(By.XPath("//div[text()='View chat']")).Count > 0)
                    Console.WriteLine("TC5_SharePin_86_Thuy: nhap ten nguoi nhan -> Pass ");
            else
                Console.WriteLine("TC5_SharePin_86_Thuy: nhap ten nguoi nhan -> Fail ");
        }

        private void btCreatePin_86_Thuy_Click(object sender, EventArgs e)
        {
            //tìm và nhấn nút Create Pin
            driver_86_thuy.FindElement(By.XPath("//*[@id=\"VerticalNavContent\"]/div/div/div[1]/div[3]/div/div/div/a")).Click();
            Thread.Sleep(2000);

            //TC6_CreatePin_86_Thuy: đăng video .mp4 > 200MB
            //lấy đường đẫn ảnh
            string filemp4_86_Thuy = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                @"picture\videokhonghople.mp4");
            driver_86_thuy.FindElement(By.Id("storyboard-upload-input")).SendKeys(filemp4_86_Thuy);
            Thread.Sleep(10000);
            //kiểm tra button Publish có tồn tại hay không, nếu không tồn tại -> Pass, ngược lại -> Fail
            if (driver_86_thuy.FindElements(By.CssSelector("div[data-test-id='storyboard-creation-nav-done'] button")).Count == 0)
                Console.WriteLine("TC6_CreatePin_86_Thuy: video .mp4 > 200MB -> Pass");
            else
                Console.WriteLine("TC6_CreatePin_86_Thuy: video .mp4 > 200MB -> Fail");


            //TC7_CreatePin_86_Thuy: đăng ảnh .jpg < 20MB
            //lấy đường đẫn ảnh
            string filejpg_86_Thuy = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                @"picture\anhhople.jpg");
            driver_86_thuy.FindElement(By.Id("storyboard-upload-input")).SendKeys(filejpg_86_Thuy);
            Thread.Sleep(5000);
            //kiểm tra button Publish có tồn tại hay không, nếu tồn tại -> Pass, ngược lại -> Fail
            if (driver_86_thuy.FindElements(By.CssSelector("div[data-test-id='storyboard-creation-nav-done'] button")).Count > 0)
            {
                //Nhập title nếu muốn
                driver_86_thuy.FindElement(By.Id("storyboard-selector-title")).SendKeys("galaxy");
                Thread.Sleep(2000);
                driver_86_thuy.FindElement(By.CssSelector("div[data-test-id='storyboard-creation-nav-done'] button")).Click();
                Console.WriteLine("TC7_CreatePin_86_Thuy: anh .jpg <20MB -> Pass");
            }
            else
                Console.WriteLine("TC7_CreatePin_86_Thuy: anh .jpg <20MB -> Fail");

        }
    }
}
