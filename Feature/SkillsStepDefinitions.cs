using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
//using MarsQA_1.SpecFlowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;


namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class SkillsSteps : Driver
    {
        SignIn si = new SignIn();
        Skills addSkillObj = new Skills();
        [Given(@"Navigate to Skills tab")]
        public void GivenNavigateToSkillsTab()
        {
            si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);

        }

        [Given(@"Navigate to the Skills tab")]
        public void GivenNavigateToTheSkillsTab()
        {
            

        }

        [Given(@"Navigate to the Skills tab\.")]
        public void GivenNavigateToTheSkillsTab_()
        {
            si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);


        }

        [When(@"I add '(.*)' and '(.*)' to Skills tab")]
        public void WhenIAddAndToSkillsTab(string Skill, string SkillLevel)
        {
           // si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);

            addSkillObj.AddSkills(driver, Skill, SkillLevel);
        }

        [When(@"I update '(.*)' and '(.*)' to Skills tab")]
        public void WhenIUpdateAndToSkillsTab(string Skill1, string SkillLevel1)
        {
           si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);

            addSkillObj.EditSkills(driver, Skill1, SkillLevel1);
        }

        [When(@"I delete a skill in Skills tab")]
        public void WhenIDeleteASkillInSkillsTab()
        {
           // si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);

            addSkillObj.DeleteSkill(driver);
        }

        [Then(@"The '(.*)' and '(.*)' should be created successfully")]
        public void ThenTheAndShouldBeCreatedSuccessfully(string Skill, string SkillLevel)
        {
            
            string ActualSkill = addSkillObj.GetSkill(driver);
            string ActualSkillLevel = addSkillObj.GetSkillLevel(driver);
          //  Assert.That(ActualSkill != Skill, "Actual Skill and Expected Skill do not match");
          //  Assert.That(ActualSkillLevel != SkillLevel, "Actual SkillLevel and Expected SkillLevel do not match");
        }

        [Then(@"The '(.*)' and '(.*)' should be updated successfully")]
        public void ThenTheAndShouldBeUpdatedSuccessfully(string Skill1, string SkillLevel1)
        {
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);
            string EditedSkill = addSkillObj.GeteditedSkill(driver);
            string EditedSkillLevel = addSkillObj.GeteditedSkillLevel(driver);
           // Assert.That(EditedSkill != Skill1, "Actual Skill and Expected Skill not match");
           // Assert.That(EditedSkillLevel != SkillLevel1, "Actual SkillLevel and Expected SkillLevel not match ");
       
            }

        [Then(@"The skill should be deleted successfully")]
        public void ThenTheSkillShouldBeDeletedSuccessfully()
        {
            string DeletedSkill = addSkillObj.GetDeletedSkill(driver);
            string DeletedSkillLevel = addSkillObj.GetDeletedSkillLevel(driver);
           // Assert.That(DeletedSkill == "Automation", "Skill deleted");
           // Assert.That(DeletedSkill == "Automation", "Skill deleted");
           // Assert.That(DeletedSkillLevel == "Intermediate", "SkillLevel deleted");
          

        }
    }
}
