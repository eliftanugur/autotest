using OpenQA.Selenium;
using SeleniumExtras.PageObjects;



namespace AutoTest.PageObject
{
    class EAPageObject
    {
       public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#popupContainer > div > div:nth-child(3) > a > span.homepage-popup-gender")]
        public IWebElement ImgClick { get; set; }



        [FindsBy(How = How.CssSelector, Using = "#accountNavigationRoot > div > ul > li.login-register-button-container > div.icon-container")]
        public IWebElement SigninClick { get; set; }


        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "loginSubmit")]
        public IWebElement SaveButton { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#dynamic-boutiques > div > div > div:nth-child(1) > div.butik-large-image")]
        public IWebElement SelectBoutique { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#root > div > ul > li:nth-child(1) > div")]
        public IWebElement SelectProduct { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#product-detail-app > div > div.pr-cn > div.pr-cn-in > div.pr-in-at > div.hl-cn > div.hl-cl > div > div.open.pr-in-sz-pk")]
        public IWebElement ListSize { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#product-detail-app > div > div.pr-cn > div.pr-cn-in > div.pr-in-at > div.hl-cn > div.hl-cl > div > div.open.pr-in-drp > ul > li:nth-child(3)")]
        public IWebElement SelectSize { get; set; }



        [FindsBy(How = How.CssSelector, Using = "#product-detail-app > div > div.pr-cn > div.pr-cn-in > div.pr-in-at > div:nth-child(3) > button.pr-in-btn.add-to-bs")]
        public IWebElement AddBasketProduct { get; set; }








    }
}
