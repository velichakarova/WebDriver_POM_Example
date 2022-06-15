
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriver_POM_Example.Pages;

namespace WebDriver_POM_Example.Tests
{
    public class ViewStudent:BaseTests
    {

      
        [Test]
        public void TestViewPage_Url_Heading_Title()
        {
            var view_student = new ViewStusentsPage(driver);
            view_student.Open();
            Assert.That(driver.Url, Is.EqualTo(view_student.GetPageUrl()));
            Assert.That(view_student.GetPageHeading(), Is.EqualTo("Registered Students"));
            Assert.That(view_student.GetPageTitle(), Is.EqualTo("Students"));
        }
        [Test]
        public void TestViewPageLink()
        {
            var view_student = new HomePage(driver);
            view_student.Open();
            view_student.HomeLink.Click();
            Assert.That(view_student.GetPageTitle(), Is.EqualTo("MVC Example"));


        }
        [Test]
        public void TestViewPage_HomePage()
        {
            var view_student = new HomePage(driver);
            view_student.Open();
            view_student.ViewStudentsLink.Click();
            var home_page = new HomePage(driver);
            Assert.That(home_page.GetPageTitle(), Is.EqualTo("Students"));
            Assert.That(driver.Url, Is.EqualTo(home_page.GetPageUrl()));

        }
        [Test]
        public void TestViewPage_AddStudents()
        {
            var view_student = new HomePage(driver);
            view_student.Open();
            view_student.AddStudentLink.Click();

            var add_student = new AddStudentPage(driver);
            Assert.That(add_student.GetPageTitle(), Is.EqualTo("Add Student"));
            Assert.That(driver.Url, Is.EqualTo(add_student.GetPageUrl()));


        }
        [Test]
        public void TestViewPage_Check_Students()
        {
           var view_student = new ViewStusentsPage(driver);
            view_student.Open();
            var students = view_student.GetStudents();
            foreach (var student in students)
            {
                Assert.IsTrue(student.IndexOf("(") > 0);
                Assert.IsTrue(student.IndexOf(")") == student.Length-1);
            }



        }
    }
}
