using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
     class Skills : Driver
    {
       // private static IWebElement skill_Tab => Driver.driver.FindElement(By.XPath("//div/a[text()='Skills']"));
        private static IWebElement skill_Tab => Driver.driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[2]"));
        private static IWebElement add_Button => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement addSkillTextbox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement skillDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='level']"));
        private static IWebElement addSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private static IWebElement actualSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]"));
       
        private static IWebElement actualSkillLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
        private static IWebElement editSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        private static IWebElement editSkillTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));

        
        private static IWebElement editSkillLevelDropdown => Driver.driver.FindElement(By.XPath(".//*[@name='level']"));
        private static IWebElement updateSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
       // //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]
        private static IWebElement editedSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
        private static IWebElement editedSkillLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[2]"));
        private static IWebElement deleteSkillButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[2]/i"));
        private static IWebElement deletedSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
        private static IWebElement deletedSkillLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[2]"));

        internal void AddSkills(IWebDriver driver, string Skill, string SkillLevel)
        {
            skill_Tab.Click();
            wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 20);
            add_Button.Click();
            addSkillTextbox.SendKeys(Skill);
            SelectElement element = new SelectElement(skillDropdown);
            element.SelectByValue(SkillLevel);
            addSkillButton.Click();
        }
        public string GetSkill(IWebDriver driver)
        {
            return actualSkill.Text;
        }
        public string GetSkillLevel(IWebDriver driver)
        {
            return actualSkillLevel.Text;
        }
        internal void EditSkills(IWebDriver driver, string Skill1, string SkillLevel1)
        {
            skill_Tab.Click();
            wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 5);
           // IWebElement FindCreatedSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
            editSkillButton.Click();
            editSkillTextBox.Clear();
            editSkillTextBox.SendKeys(Skill1);
            SelectElement element = new SelectElement(editSkillLevelDropdown);
            element.SelectByValue(SkillLevel1);
            updateSkillButton.Click();
        }
        public string GeteditedSkill(IWebDriver driver)
        {
            return editedSkill.Text;
        }
        public string GeteditedSkillLevel(IWebDriver driver)
        {
            return editedSkillLevel.Text;
        }
        internal void DeleteSkill(IWebDriver driver)
        {
            skill_Tab.Click();
            wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]", 5);
            IWebElement FindEditedSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
            deleteSkillButton.Click();
        }
        public string GetDeletedSkill(IWebDriver driver)
        {
            return deletedSkill.Text;
        }
        public string GetDeletedSkillLevel(IWebDriver driver)
        {
            return deletedSkillLevel.Text;
        }
    }
}
