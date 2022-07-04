using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.Utils;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class EducationStepDefinitions : Driver
    {
        SignIn si = new SignIn();
        Education addEducationObj = new Education();
        [Given(@"Navigate to Education tab")]
        public void GivenNavigateToEducationTab()
        {
            si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);
        }

        [When(@"I add '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' to Education tab")]
        public void WhenIAddAndAndAndAndToEducationTab(string Country, string University, string Title, string Degree, string Year)
        {
            //si.Login();
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);

            addEducationObj.AddEducation(driver, Country, University, Title, Degree, Year);
        }

        [Then(@"The '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' should be created successfully\.")]
        public void ThenTheAndAndAndAndShouldBeCreatedSuccessfully_(string Country, string University, string Title, string Degree, int Yea)
        {
           
            addEducationObj.VerifyEducationAdded(Degree);
        }
    }
}
