

using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Language:Driver
    {


        // private static IWebElement language_Tab => driver.FindElement(By.LinkText("Languages"));

        //private static IWebElement language_Tab => driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[1]"));
        private static IWebElement language_Tab => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
        private static IWebElement addLanguageButton => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement addLanguageTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement languageDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='level']"));
        private static IWebElement addButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        private static IWebElement cancelButton => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
        //private static IWebElement EditButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
      private static IWebElement editLanguageTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
        // private static IWebElement editLanguageTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
        //  private static IWebElement editLanguageTextBox => Driver.driver.FindElement(By.cssSelector[placeholder = "Add Language"]);
        
          private static IWebElement editedLanguageLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
      //  private static IWebElement editedLanguageLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement updateButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
      
        private static IWebElement deletedRecord => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr"));

        public void AddLanguage(IWebDriver driver, string Language, string LanguageLevel)
        {
            language_Tab.Click();
            wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 20);
            //wait.ElementToBeClickable(addLanguageButton,5);
         //   var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
          //  var clickableElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")));
            addLanguageButton.Click();
            addLanguageTextBox.SendKeys(Language);
            SelectElement element = new SelectElement(languageDropdown);
            element.SelectByValue(LanguageLevel);
            addButton.Click();

            

        }
        public void VerifyAddLanguage(string Language)
        {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            bool languageAdded = false;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            IWebElement tableElement = Driver.driver.FindElement(By.XPath("(//table[@class='ui fixed table'])[1]"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            foreach (IWebElement row in tableRow)
            {
                if (row.Text.Contains(Language))
                {
                    languageAdded = true;
                    Console.WriteLine("Language Added");
                    break;
                }
            }
        }

        public void EditLanguageButton(string Language)
        {
            language_Tab.Click();
            // IWebElement EditButton = Driver.driver.FindElement(By.XPath("//td[text()='" + Language + "']/following::td[2]/descendant::i[@class='outline write icon']"));
            IWebElement EditButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            EditButton.Click();
           
            
        }

        public void EditLanguage(string Language1, string LanguageLevel1)
        {
           editLanguageTextBox.Clear();
            editLanguageTextBox.SendKeys(Language1);
            SelectElement element = new SelectElement(languageDropdown);
            element.SelectByValue(LanguageLevel1);
            updateButton.Click();

        }

        public void VerifyLanguageUpdated(string Language1, string LanguageLevel1)

        {
            language_Tab.Click();
            IList<IWebElement> LangTableRow = Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[1]/tbody/tr"));
        /*   var rownum = LangTableRow.Count;
#pragma warning disable CS0162 // Unreachable code detected
            for (var i = 1; i <= rownum; i++)
            {
                if ((Language1 == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[1]/tbody/tr[1]/td[1])[" + i + "]")).Text) &&
                    (LanguageLevel1 == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[1]/tbody/tr[1]/td[2])[" + i + "]")).Text))
                    Console.WriteLine("Language level updated");
                break;
            }*/
#pragma warning restore CS0162 // Unreachable code detected
        }

        internal void DeleteLanguage(string Language1)
        {
            language_Tab.Click();
            wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 20);
             IWebElement DeleteLanguageButton = Driver.driver.FindElement(By.XPath("//td[text()='" + Language1 + "']/following::td[2]/descendant::i[@class='remove icon']"));
           // IWebElement DeleteLanguageButton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i"));
            DeleteLanguageButton.Click();
        }
        public string VerifyDeletedLanguage(IWebDriver driver)
        {
            string deletedrecordtext = deletedRecord.Text;
            return deletedrecordtext;
        }


    }
    

}
