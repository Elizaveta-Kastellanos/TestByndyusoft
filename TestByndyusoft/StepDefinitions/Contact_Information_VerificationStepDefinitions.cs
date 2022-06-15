using System;
using TechTalk.SpecFlow;

namespace TestByndyusoft.StepDefinitions
{
    [Binding]
    public class Contact_Information_VerificationStepDefinitions
    {
        private IWebDriver _driver;

        [Given(@"Open google chrome browser with (.*) and (.*)")]
        public void GivenOpenGoogleChromeBrowserWithAnd(int length, int width)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Position = new Point(0, 0);
            _driver.Manage().Window.Size = new Size(length, width);
        }


        [Given(@"I go to the right url")]
        public void GivenIGoToTheRightUrl()
        {
            _driver.Navigate().GoToUrl(UrlStorage.Google);
        }

        [Given(@"I enter ""([^""]*)"" in the search box and follow the first link")]
        public void GivenIEnterInTheSearchBoxAndFollowTheFirstLink(string byndyusoft)
        {
            var inputSearch = _driver.FindElement(XPathGoogle.InputSearch);
            inputSearch.SendKeys(byndyusoft);
            var labelGoogle = _driver.FindElement(XPathGoogle.LabelGoogle);
            labelGoogle.Click();
            var buttonSearch = _driver.FindElement(XPathGoogle.ButtonSearch);
            buttonSearch.Click();
            var hrefByndyusoft = _driver.FindElement(XPathGoogle.HrefByndyusoft);
            hrefByndyusoft.Click();
            _driver.SwitchTo().Window(_driver.WindowHandles[1]);
            string urlActual = _driver.Url;
            string urlExpected = UrlStorage.MainWindow;
            Assert.AreEqual(urlExpected, urlActual);
        }



        [When(@"I find and click on the button Order a presentation")]
        public void WhenIFindAndClickOnTheButtonOrderAPresentation()
        {
            var buttonOrderPresentation = _driver.FindElement(XPathsMainWindow.ButtonOrderPresentation);
            buttonOrderPresentation.Click();
        }

        [Then(@"I check the correctness of the phone number and mailbox, expected phone number ""([^""]*)"" and e-mail ""([^""]*)""")]
        public void ThenICheckTheCorrectnessOfThePhoneNumberAndMailboxExpectedPhoneNumberAndE_Mail(string expectedPhone, string expectedEmail)
        {
            string actualPhone = _driver.FindElement(XPathsMainWindow.HrefNumberPhone).Text;
            string actualEmail = _driver.FindElement(XPathsMainWindow.HrefEmail).Text;
            Assert.AreEqual(expectedPhone, actualPhone);
            Assert.AreEqual(expectedEmail, actualEmail);

        }
    }
}
