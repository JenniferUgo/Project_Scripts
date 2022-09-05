using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestingGroupJ.Utilities;

namespace TestingGroupJ.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

         IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement Email => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));
        IWebElement Password => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(3) > input"));
        IWebElement SignUpButton => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys("Jennee" + randomInt);
        }

        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys("demo" + randomInt + "@gmail.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("thechosenone");
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }
        
        public Boolean IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }
    }
}
