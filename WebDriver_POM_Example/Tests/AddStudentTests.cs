
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver_POM_Example.Pages;

namespace WebDriver_POM_Example.Tests
{
    public class AddStudentTests
    {

        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
        }
        [TearDown]  
        public void ShutDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestAddStudentPage_Url_Heading_Title()
        {
            var add_student = new AddStudentPage(driver);
            add_student.Open();
            Assert.That(driver.Url, Is.EqualTo(add_student.GetPageUrl()));
            Assert.That(add_student.GetPageHeading(), Is.EqualTo("Register New Student"));
            Assert.That(add_student.GetPageTitle(), Is.EqualTo("Add Student"));
        }
        [Test]
        public void TestHomePage()
        {
            var add_student = new AddStudentPage(driver);
            add_student.Open();
            add_student.HomeLink.Click();
            var home_page = new HomePage(driver);
            Assert.That(home_page.GetPageTitle(), Is.EqualTo("MVC Example"));


        }
        [Test]
        public void TestAddStudentPage_ViewStudents()
        {
            var add_student = new AddStudentPage(driver);
            add_student.Open();
            add_student.ViewStudentsLink.Click();
            var view_student = new ViewStusentsPage(driver);
            Assert.That(view_student.GetPageTitle(), Is.EqualTo("Students"));
            Assert.That(driver.Url, Is.EqualTo(view_student.GetPageUrl()));

        }
      
      
    }
}
