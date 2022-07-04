using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class Education
    {
        private static IWebElement education_Tab => Driver.driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[3]"));
        private static IWebElement add_Button => Driver.driver.FindElement(By.XPath(".//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private static IWebElement countryDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='country']"));
        private static IWebElement addNameTextbox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
       
        private static IWebElement titleDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='title']"));
        private static IWebElement addDegreeTextbox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
    
        private static IWebElement yearDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='yearOfGraduation']"));
        private static IWebElement addEducationButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        
        private static IWebElement actualCountry => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
        
        private static IWebElement actualUniversity => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
        private static IWebElement actualTitle => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
        private static IWebElement actualDegree => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
        private static IWebElement actualYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));

        internal void AddEducation(IWebDriver driver, string Country, string University, string Title, string Degree, string Year)
        {
            education_Tab.Click();
            add_Button.Click();
            SelectElement element = new SelectElement(countryDropdown);
            element.SelectByValue(Country);
            addNameTextbox.SendKeys(University);
            SelectElement element1 = new SelectElement(titleDropdown);
            element1.SelectByValue(Title);
            addDegreeTextbox.SendKeys(Degree);
            SelectElement element2 = new SelectElement(yearDropdown);
            element2.SelectByValue(Year.ToString());
            addEducationButton.Click();


        }
        public void VerifyEducationAdded(string Degree)
        {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            bool EducationRecord = false;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            IWebElement tableElement = Driver.driver.FindElement(By.XPath("(//table[@class='ui fixed table'])[3]"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            foreach (IWebElement row in tableRow)
            {
                if (row.Text.Contains(Degree))
                {
                   EducationRecord = true;
                    Console.WriteLine("Education detail added");
                    break;
                }
            }
        }
    }

}

