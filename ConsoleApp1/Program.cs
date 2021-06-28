using OpenQA.Selenium;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new ChromeManager();

            manager.Driver.Navigate().GoToUrl("https://github.com/login?return_to=%2Fsearch%3Fq%3Dasdf");

            var userNameTextBox = manager.Driver.FindElementByXPath("//input[@id='login_field']");
            var passWordTextBox = manager.Driver.FindElementByXPath("//input[@id='password']");
            var loginButton = manager.Driver.FindElementByXPath("//body/div[3]/main[1]/div[1]/div[4]/form[1]/div[1]/input[12]");

            userNameTextBox.Click();
            userNameTextBox.SendKeys("dmswo546@naver.com");
            passWordTextBox.Click();
          
            loginButton.Click();

            Console.ReadLine();
        }
    }
}
