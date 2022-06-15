using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriver_POM_Example.Pages
{
    internal class AddStudentPage : BasePage
    {
        //construktor inherite BasePage
        public AddStudentPage(IWebDriver driver): base(driver)
        { 
        }

        public override string PageUrl => "https://mvc-app-node-express.nakov.repl.co/add-student";

        public IWebElement nameFild => driver.FindElement(By.CssSelector("#name"));
        public IWebElement emailFild => driver.FindElement(By.CssSelector("#email"));
        public IWebElement add_button => driver.FindElement(By.CssSelector("body > form > button"));
        public IWebElement errorMessage => driver.FindElement(By.CssSelector("body > div"));

        public void RegisterStudent (string name, string email)
        {
            nameFild.SendKeys(name);
            emailFild.SendKeys(email);
            add_button.Click();

        }
    }
}
