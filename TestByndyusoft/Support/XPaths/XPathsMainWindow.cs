using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestByndyusoft.Support.XPaths
{
    public class XPathsMainWindow
    {
        public static By ButtonOrderPresentation = By.XPath(@"//span[@class='btn btn--lg btn--info js-popup-callback-show']");
        // XPath того чего надо проверить 
        public static By HrefNumberPhone = By.XPath(@"//div[@class='popup-callback__footer-contacts']//a[@href='tel:88007751521']");
        public static By HrefEmail = By.XPath(@"//div[@class='popup-callback__footer-contacts']//a[@href='mailto:sales@byndyusoft.com']");
    }
}
