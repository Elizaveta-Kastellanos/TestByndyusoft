using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestByndyusoft.Support.XPaths
{
    public class XPathGoogle
    {
        public static By InputSearch = By.XPath(@"//input[@name='q']");
        public static By ButtonSearch = By.XPath(@"//div[@class='FPdoLc lJ9FBc']//input[@name='btnK']");
        public static By LabelGoogle = By.XPath(@"//div[@class='k1zIA rSk4se']");
        public static By HrefByndyusoft = By.XPath(@"//a[@href='https://byndyusoft.com/']//h3");
    }
}
