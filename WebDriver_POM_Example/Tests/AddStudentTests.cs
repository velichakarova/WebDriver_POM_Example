
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using WebDriver_POM_Example.Pages;

namespace WebDriver_POM_Example.Tests
{
    public class AddStudentTests:BaseTests
    {

            

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
        [Test]
        public void TestAddStudentPage_EmpetyFild()
        {
            var add_student = new AddStudentPage(driver);
            add_student.Open();
            Assert.That(add_student.emailFild.Text, Is.EqualTo(""));
        }
        [Test]
        public void TestAddStudentPage_AddValidStudent()
        {
            var add_studen = new AddStudentPage(driver);
            add_studen.Open();
            string name = "Gorge" + DateTime.Now.Ticks;
            string email = "George" + DateTime.Now.Ticks + "@mail.com";
            add_studen.RegisterStudent(name, email);

            var view_student = new ViewStusentsPage(driver);
            Assert.IsTrue(view_student.isOpen());
            var students = view_student.GetStudents();
            var last_student = students.Last();
            Assert.Contains(last_student, students);
        }
        [Test]
        public void TestaddStudentPage_AddInvalidStudet()
        {
            var add_student = new AddStudentPage(driver);
            add_student.Open();
            string name = "";
            string email = "";
            add_student.RegisterStudent(name, email);

            Assert.IsTrue(add_student.isOpen());
            Assert.That(add_student.errorMessage.Text, Is.EqualTo("Cannot add student. Name and email fields are required!"));

        }
      
      
    }
}
