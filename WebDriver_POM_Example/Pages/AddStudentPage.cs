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
        
        
    }
}
