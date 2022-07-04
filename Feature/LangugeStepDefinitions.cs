using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.Utils;
//using MarsQA_1.SpecFlowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class LangugeStepDefinitions : Start
    {
        SignIn si = new SignIn();
        Language addLanguageObj = new Language();

        [Given(@"Navigate to Language tab")]
        public void GivenNavigateToLanguageTab()
        {
            si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);


        }


        [When(@"I add '([^']*)' and '([^']*)' to Languages tab")]
        public void WhenIAddAndToLanguagesTab(string Language, string LanguageLevel)
        {
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);
            addLanguageObj.AddLanguage(driver, Language, LanguageLevel);
        }

        [Then(@"The '([^']*)' should be created successfully\.")]
        
        public void ThenTheAndShouldBeCreatedSuccessfully_(string Language)
         {

              addLanguageObj.VerifyAddLanguage(Language);
         }

        

        [Given(@"Click on Edit Button near '([^']*)'")]
        public void GivenClickOnEditButtonNear(string Language)
        {
            si.Login();
           Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);
            addLanguageObj.EditLanguageButton(Language);
        }

        [When(@"I update '([^']*)' and '([^']*)' in Languages tab")]
        public void WhenIUpdateAndInLanguagesTab(string Language1, string LanguageLevel1)
        {
          //  si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);
            addLanguageObj.EditLanguage(Language1, LanguageLevel1);
        }

        [Then(@"The '([^']*)' and '([^']*)' should be updated successfully\.")]
        public void ThenTheAndShouldBeUpdatedSuccessfully_(string Language1, string LanguageLevel1)
        {

            addLanguageObj.VerifyLanguageUpdated(Language1, LanguageLevel1);
        }

        [Given(@"Navigate to the Languages tab")]
        public void GivenNavigateToTheLanguagesTab()
        {
            si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);


        }

        [When(@"I delete a '([^']*)' in Languages tab")]
        public void WhenIDeleteAInLanguagesTab(string Language1)
        {
           // si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);

            addLanguageObj.DeleteLanguage(Language1);
        }

        [Then(@"The '([^']*)' should be deleted successfully")]
        public void ThenTheShouldBeDeletedSuccessfully(string Language1)
        {
           // si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);

            Language addLanguageObj = new Language();
            string record = addLanguageObj.VerifyDeletedLanguage(driver);
            Assert.That(record != Language1, "Language not deleted");
        }

        [When(@"I click on the add new button in Language Tab")]
        public void WhenIClickOnTheAddNewButtonInLanguageTab()
        {
            
        }

    }
}
