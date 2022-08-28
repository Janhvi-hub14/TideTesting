using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideTesting.BaseClass;

namespace TideTesting.Tests
{
    public class ContactTest
    {
        public void OpenUrl()
        {
        }
        public void ClickOnContactUs()
        {
            Thread.Sleep(2000);
            BaseTest.driver.FindElement(By.XPath("//a[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseTest.driver.FindElement(By.XPath("//a[text()='Contact Us']")).Click();
        }
        public void DisplayOptions()
        {
            ((ITakesScreenshot)BaseTest.driver).GetScreenshot().SaveAsFile
                (@"C:E:\TideTesting\TideTesting\ScreenShots\contactus.png");
        }
    }
}
