using DataDrivenWithExamplesProject.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace DataDrivenWithExamplesProject.StepDefinition
{
    [Binding]
    public class DataDrivenWithExamplesSteps
    {
        DataDrivenWithExamplesPage dataDrivenWithExamplesPage;

            public DataDrivenWithExamplesSteps()
        {
            dataDrivenWithExamplesPage = new DataDrivenWithExamplesPage();
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithExamplesPage.NavigateToWebsite(url);
        }
        
        [Given(@"I click on Sign Up")]
        public void GivenIClickOnSignUp()
        {
            dataDrivenWithExamplesPage.ClickOnSignUp();
        }
        
        [Given(@"I enter my username text""(.*)""")]
        public void GivenIEnterMyUsernameText(string username)
        {
            dataDrivenWithExamplesPage.EnterUsername(username);
        }
        
        [Given(@"I enter my email text ""(.*)""")]
        public void GivenIEnterMyEmailText(string email)
        {
            dataDrivenWithExamplesPage.EnterEmail(email);
        }
        
        [Given(@"I enter my password text ""(.*)""")]
        public void GivenIEnterMyPasswordText(string password)
        {
            dataDrivenWithExamplesPage.EnterPassword(password);
        }
        
        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            dataDrivenWithExamplesPage.ClickOnSignUpButton();
        }

        [Then(@"I can register successfully")]
        public void ThenICanRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(dataDrivenWithExamplesPage.IsNewArticleDisplayed);
        }

    }
}
