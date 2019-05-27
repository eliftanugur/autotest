using OpenQA.Selenium;

namespace AutoTest
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssSelector,
        ClassName,
        XPath
    }

    class PropertiesCollection
    {
        public static IWebDriver Driver { get; set; }
    }
}
