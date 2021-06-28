using OpenQA.Selenium.Chrome;
using System;

namespace ConsoleApp1
{
    public class ChromeManager
    {
        private readonly ChromeDriverService _driverService = ChromeDriverService.CreateDefaultService();
        private readonly ChromeOptions _options = new();

        public ChromeDriver Driver { get; }

        public ChromeManager()
        {
            //_driverService.HideCommandPromptWindow = false;
            _options.AddArgument("disable-gpu");
            //_options.AddArgument("headless");
            _options.AddArgument(
                "user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

            Driver = new ChromeDriver(_driverService, _options);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }
    }
}