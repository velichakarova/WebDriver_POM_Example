using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_POM_Example.Pages
{
    internal class ViewStusentsPage : BasePage
    {
        //construktor inherite BasePage
        public ViewStusentsPage(IWebDriver driver): base(driver)
        { 
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/students";

        public IReadOnlyCollection<IWebElement> ListItemsStudent =>
            driver.FindElements(By.CssSelector("body>ul>li"));

        public string[] GetStudents()
        {
            var elementStudent = this.ListItemsStudent.Select(s => s.Text).ToArray();
            return elementStudent;
        }
    }
}
