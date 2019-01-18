using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimble.Automation.Repository.Locators
{
    public interface IPersonalDetails
    {
        By Title { get; }

        By FirstName { get; }

        By MiddleName { get; }

        By LastName { get; }

        By DOB { get; }

        By Dob_Day { get; }

        By Dob_Month { get; }

        By Dob_Year { get; }

        By Email { get; }

        By ExistingEmailError { get; }

        By Password { get; }

        By ConfirmPassword { get; }

        By Homephone { get; }

        By Mobilephone { get; }

        By Address { get; }

        By AddressSearch { get; }

        By AddressAutoFillBtn { get; }

        By Unitnumber { get; }

        By Streetnumber { get; }

        By Next2Button { get; }

        By StreetName { get; }

        By Streettype { get; }

        By Suburbtype { get; }

        By Postcode { get; }

        By Next3Button { get; }

        By EmploymentStatus { get; }

        By ShortTermLoanStatusYes { get; }

        By ShortTermLoanStatusNo { get; }

        By ReadPrivacychecked { get; }

        By ReadPrivacyunchecked { get; }

        By ReadCreditGuidechecked { get; }

        By ReadCreditGuideunchecked { get; }

        By personaldetailscontinuebutton { get; }

        By checkoutContinueButton { get; }

        By AutomaticVerificationButton { get; }

        By DNQText { get; }

        By DNQMessage { get; }

        By personaldetailscontinuebuttonRLMobile { get; }

        By personaldetailsRequestbuttonRLDesktop { get; }

        By MemberAreaButton { get; }

        By UpdateYourProfile { get; }

        By EditDetails { get; }

        By ContactDetails { get; }

        By PersonalUseYes { get; }

        By PersonalUseNo { get; }

        By UnemploymentDesc { get; }

        By PersonalDetails { get; }

        By SaveButton { get; }

        By ContactPageSaveButton { get; }
    }

    public class PersonalDetailsMobileNLLoc : IPersonalDetails
    {
        public By Title => By.XPath(".//select[@id='title']");

        public By FirstName => By.XPath(".//input[@id='firstname']");

        public By MiddleName => By.XPath(".//input[@id='middlenames']");

        public By LastName => By.XPath(".//input[@id='surname']");

        public By DOB => By.XPath(".//input[@id='dob']");

        public By Dob_Day => By.XPath(".//select[@id='dob_day']");

        public By Dob_Month => By.XPath(".//select[@id='dob_month']");

        public By Dob_Year => By.XPath(".//select[@id='dob_year']");

        public By Email => By.XPath("//input[@id='email']");

        public By ExistingEmailError => By.XPath(".//div[@class='error-wrap']/p");

        public By Password => By.XPath(".//input[@id='password']");

        public By ConfirmPassword => By.XPath(".//input[@id='confirmpassword']");

        public By Homephone => By.XPath(".//input[@id='homephone']");

        public By Mobilephone => By.XPath(".//input[@id='mobilephone']");

        public By Address => By.XPath(".//input[@id='addressplaceholder']");

        public By AddressSearch => By.XPath(".//input[@id='addresssearch']");

        public By AddressAutoFillBtn => By.XPath(".//ul[@id='addressoptions']/li[@class='ui-first-child ui-last-child']/a");

        public By Unitnumber => By.XPath(".//input[@id='unitnumber']");

        public By Streetnumber => By.XPath("//input[@id='streetnumber']");

        public By StreetName => By.XPath(".//input[@id='streetname']");

        public By Streettype => By.XPath(".//input[@id='streettypevalue']");

        public By Suburbtype => By.XPath(".//input[@id='suburbvalue']");

        public By Postcode => By.XPath(".//input[@id='postcode']");

        public By Next2Button => By.XPath("(.//*[text()='Continue'])[last()-2]");//new(continue button after confirm password)

        public By Next3Button => By.XPath(".//*[@id='next3']");

        public By EmploymentStatus => By.XPath(".//select[@id='empstatusid']");

        public By PersonalUseYes => By.XPath("//*[@id='isSelfEmployedPolsForPersonal']/label[1]");

        public By PersonalUseNo => By.XPath("//*[@id='isSelfEmployedPolsForPersonal']/label[2]");

        public By ShortTermLoanStatusYes => By.XPath(".//*[@id='hashad2ormoreshorttermloansinlast90days']/label[contains(text(),'Yes')]");

        public By ShortTermLoanStatusNo => By.XPath(".//*[@id='hashad2ormoreshorttermloansinlast90days']/label[contains(text(),'No')]");

        public By ReadPrivacychecked => By.XPath(".//*[@id='termsandconditions']/following-sibling::div");

        // public By ReadPrivacyunchecked => By.XPath(".//*[@id='termsandconditionscontent']/div[1]/div[@class='checkbox']");
        public By ReadPrivacyunchecked => By.XPath(".//*[@id='termsandconditions']/following-sibling::div[contains(@class,'check')]");//new

        public By ReadCreditGuidechecked => By.XPath(".//input[@id='creditguide']/following-sibling::div");

        //  public By ReadCreditGuideunchecked => By.XPath(".//*[@id='termsandconditionscontent']/div[2]/div[@class='checkbox']");
        public By ReadCreditGuideunchecked => By.XPath(".//input[@id='creditguide']/following-sibling::div[contains(@class,'check')]");//new

        public By personaldetailscontinuebutton => By.XPath(".//*[@id='submit']");

        public By personaldetailscontinuebuttonRLMobile => By.XPath(".//*[@id='btnSubmit']");

        public By personaldetailsRequestbuttonRLDesktop => By.XPath(".//*[@class='secureSubmitButton sml button']");

        public By checkoutContinueButton => By.XPath(".//*[@id='btnContinue']");

        public By AutomaticVerificationButton => By.XPath(".//*[@id='btnVerifyAutoOpen']");

        public By DNQText => By.XPath(".//h2[@class='center p-b-10']");

        public By DNQMessage => By.XPath(".//*[@class='center m-b-20']");

        public By MemberAreaButton => By.XPath("//*[text()='Member Area']");

        public By UpdateYourProfile => By.XPath("//a[@href='/Account/MemberProfile']");

        public By PersonalDetails => By.XPath("//p[@class='font-16 bold600 green']");

        public By EditDetails => By.XPath("//a[@id='editDetailsBtn']");

        public By ContactDetails => By.XPath("//p[text()='Contact']");

        public By UnemploymentDesc => By.XPath(".//select[@id='empsubstatusid']");

        public By SaveButton => By.XPath("//button[text()='Save']");

        public By ContactPageSaveButton => By.XPath("//button[@id='submit-2']");
    }

    public class PersonalDetailsDesktopNLLoc : IPersonalDetails
    {
        public By Title => By.XPath(".//select[@id='title']");

        public By FirstName => By.XPath(".//input[@id='firstname']");

        public By MiddleName => By.XPath(".//input[@id='middlenames']");

        public By LastName => By.XPath(".//input[@id='surname']");

        public By DOB => By.XPath(".//input[@id='dob']");

        public By Dob_Day => By.XPath(".//select[@id='dob_day']");

        public By Dob_Month => By.XPath(".//select[@id='dob_month']");

        public By Dob_Year => By.XPath(".//select[@id='dob_year']");

        public By ExistingEmailError => By.XPath(".//div[@class='error-wrap']/p");

        public By Email => By.XPath(".//input[@id='email']");

        public By Password => By.XPath(".//input[@id='password']");

        public By ConfirmPassword => By.XPath(".//input[@id='confirmpassword']");

        public By Homephone => By.XPath(".//input[@id='homephone']");

        public By Mobilephone => By.XPath(".//input[@id='mobilephone']");

        public By Address => By.XPath(".//input[@id='address']");

        public By AddressSearch => By.XPath(".//input[@id='addresssearch']");

        public By AddressAutoFillBtn => By.XPath(".//ul[@id='ui-id-1']/li[@class='ui-menu-item']");

        public By Unitnumber => By.XPath(".//input[@id='unitnumber']");

        public By Streetnumber => By.XPath(".//input[@id='streetnumber']");

        public By StreetName => By.XPath(".//input[@id='streetname']");

        public By Streettype => By.XPath(".//input[@id='streettypevalue']");

        public By Suburbtype => By.XPath(".//input[@id='suburbvalue']");

        public By Postcode => By.XPath(".//input[@id='postcode']");

        public By EmploymentStatus => By.XPath(".//select[@id='empstatusid']");

        public By PersonalUseYes => By.XPath("//*[@id='isSelfEmployedPolsForPersonal']/label[1]");

        public By PersonalUseNo => By.XPath("//*[@id='isSelfEmployedPolsForPersonal']/label[2]");

        public By ShortTermLoanStatusYes => By.XPath(".//*[@id='hashad2ormoreshorttermloansinlast90days']/label[contains(text(),'YES')]");

        public By ShortTermLoanStatusNo => By.XPath(".//*[@id='hashad2ormoreshorttermloansinlast90days']/label[contains(text(),'NO')]");

        public By ReadPrivacychecked => By.XPath(".//*[@id='termsandconditions']/following-sibling::div");

        //public By ReadPrivacyunchecked => By.XPath(".//*[@id='termsandconditionscontent']/div[1]/div[@class='checkbox']");
        public By ReadPrivacyunchecked => By.XPath(".//*[@id='termsandconditionscontent']/div[1]/div");

        public By ReadCreditGuidechecked => By.XPath(".//input[@id='creditguide']/following-sibling::div");

        //public By ReadCreditGuideunchecked => By.XPath(".//*[@id='termsandconditionscontent']/div[2]/div[@class='checkbox']");

        public By ReadCreditGuideunchecked => By.XPath("//*[@id='termsandconditionscontent']/div[2]/div");//new

        public By personaldetailscontinuebutton => By.XPath(".//*[@id='SubmitContainer']/button");

        public By personaldetailscontinuebuttonRLMobile => By.XPath(".//*[@id='btnSubmit']");

        public By personaldetailsRequestbuttonRLDesktop => By.XPath(".//*[@class='secureSubmitButton sml button']");

        public By checkoutContinueButton => By.XPath(".//*[@id='btnContinue']");

        public By AutomaticVerificationButton => By.XPath(".//*[@id='btnVerifyAutoOpen']");

        public By DNQText => By.XPath(".//h2[@class='center p-b-10']");

        public By DNQMessage => By.XPath(".//*[@class='center m-b-20']");

        public By MemberAreaButton => By.XPath("//*[text()='Member Area']");

        public By UpdateYourProfile => By.XPath("//a[@href='/Account/MemberProfile']");

        public By EditDetails => By.XPath("//a[@id='editDetailsBtn']");

        public By ContactDetails => By.XPath("//h3[@id='contactDetailsHeader']");

        public By UnemploymentDesc => By.XPath(".//select[@id='empsubstatusid']");

        public By PersonalDetails => By.XPath("//h3[@id='personalDetailsHeader']");

        public By SaveButton => By.XPath("//a[@id='SaveButton']");

        public By ContactPageSaveButton => By.XPath("//button[@id='submit-2']");

        public By Next2Button
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public By Next3Button
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    public class PersonalDetailsMobileRLLoc : IPersonalDetails
    {
        public By Title => By.XPath(".//select[@id='title']");

        public By FirstName => By.XPath(".//input[@id='firstname']");

        public By MiddleName => By.XPath(".//input[@id='middlenames']");

        public By LastName => By.XPath(".//input[@id='surname']");

        public By DOB => By.XPath(".//input[@id='dob']");

        public By Dob_Day => By.XPath(".//select[@id='dob_day']");

        public By Dob_Month => By.XPath(".//select[@id='dob_month']");

        public By Dob_Year => By.XPath(".//select[@id='dob_year']");

        public By Email => By.XPath("//input[@id='email']");

        public By ExistingEmailError => By.XPath(".//div[@class='error-wrap']/p");

        public By Password => By.XPath(".//input[@id='password']");

        public By ConfirmPassword => By.XPath(".//input[@id='confirmpassword']");

        public By Homephone => By.XPath(".//input[@id='homephone']");

        public By Mobilephone => By.XPath(".//input[@id='mobilephone']");

        public By Address => By.XPath(".//input[@id='address']");

        public By AddressSearch => By.XPath(".//input[@id='addresssearch']");

        public By AddressAutoFillBtn => By.XPath(".//ul[@id='addressoptions']/li[@class='ui-first-child ui-last-child']");

        public By Unitnumber => By.XPath(".//input[@id='unitnumber']");

        public By Streetnumber => By.XPath("//input[@id='streetnumber']");

        public By StreetName => By.XPath(".//input[@id='streetname']");

        public By Streettype => By.XPath(".//input[@id='streettypevalue']");

        public By Suburbtype => By.XPath(".//input[@id='suburbvalue']");

        public By Postcode => By.XPath(".//input[@id='postcode']");

        public By Next2Button => By.XPath("(.//*[text()='Continue'])[last()-2]");//new(continue button after confirm password)

        public By Next3Button => By.XPath(".//*[@id='next3']");

        public By EmploymentStatus => By.XPath(".//select[@id='empstatusid']");

        public By PersonalUseYes => By.XPath("//*[@id='isSelfEmployedPolsForPersonal']/label[1]");

        public By PersonalUseNo => By.XPath("//*[@id='isSelfEmployedPolsForPersonal']/label[2]");

        public By ShortTermLoanStatusYes => By.XPath(".//*[@id='hashad2ormoreshorttermloansinlast90days']/label[contains(text(),'YES')]");

        public By ShortTermLoanStatusNo => By.XPath(".//*[@id='hashad2ormoreshorttermloansinlast90days']/label[contains(text(),'NO')]");

        public By ReadPrivacychecked => By.XPath(".//*[@id='termsandconditions']/following-sibling::div");

        // public By ReadPrivacyunchecked => By.XPath(".//*[@id='termsandconditionscontent']/div[1]/div[@class='checkbox']");
        public By ReadPrivacyunchecked => By.XPath(".//*[@id='termsandconditions']/following-sibling::div[contains(@class,'check')]");//new

        public By ReadCreditGuidechecked => By.XPath(".//input[@id='creditguide']/following-sibling::div");

        //  public By ReadCreditGuideunchecked => By.XPath(".//*[@id='termsandconditionscontent']/div[2]/div[@class='checkbox']");
        public By ReadCreditGuideunchecked => By.XPath(".//input[@id='creditguide']/following-sibling::div[contains(@class,'check')]");//new

        public By personaldetailscontinuebutton => By.XPath(".//*[@id='submit']");

        public By personaldetailscontinuebuttonRLMobile => By.XPath(".//*[@id='btnSubmit']");

        public By personaldetailsRequestbuttonRLDesktop => By.XPath(".//*[@class='secureSubmitButton sml button']");

        public By checkoutContinueButton => By.XPath(".//*[@id='btnContinue']");

        public By AutomaticVerificationButton => By.XPath(".//*[@id='btnVerifyAutoOpen']");

        public By DNQText => By.XPath(".//h1[@id='headertxt']");

        public By DNQMessage => By.XPath(".//h2[@class='m-b-20']");

        public By MemberAreaButton => By.XPath("//*[text()='Member Area']");

        public By UpdateYourProfile => By.XPath("//a[@href='/Account/MemberProfile']");

        public By EditDetails => By.XPath("//a[@id='editDetailsBtn']");

        public By ContactDetails => By.XPath("//p[text()='Contact']");

        public By UnemploymentDesc => By.XPath(".//select[@id='empsubstatusid']");

        public By PersonalDetails => By.XPath("//p[@class='font-16 bold600 green']");

        public By SaveButton => By.XPath("//button[text()='Save']");

        public By ContactPageSaveButton => By.XPath("//button[@id='submit-2']");
    }

    public class PersonalDetailsDesktopRLLoc : IPersonalDetails
    {
        public By Title => By.XPath(".//select[@id='title']");

        public By FirstName => By.XPath(".//input[@id='firstname']");

        public By MiddleName => By.XPath(".//input[@id='middlenames']");

        public By LastName => By.XPath(".//input[@id='surname']");

        public By DOB => By.XPath(".//input[@id='dob']");

        public By Dob_Day => By.XPath(".//select[@id='dob_day']");

        public By Dob_Month => By.XPath(".//select[@id='dob_month']");

        public By Dob_Year => By.XPath(".//select[@id='dob_year']");

        public By Email => By.XPath(".//input[@id='email']");

        public By ExistingEmailError => By.XPath(".//div[@class='error-wrap']/p");

        //  public By Password => By.XPath(".//input[@id='password']");
        public By Password => By.XPath("(.//input[@id='password'])[last()-1]");//new

        public By ConfirmPassword => By.XPath(".//input[@id='confirmpassword']");

        public By Homephone => By.XPath(".//input[@id='homephone']");

        public By Mobilephone => By.XPath(".//input[@id='mobilephone']");

        public By Address => By.XPath(".//input[@id='address']");

        public By AddressSearch => By.XPath(".//input[@id='addresssearch']");

        public By AddressAutoFillBtn => By.XPath(".//ul[@id='ui-id-3']/li[@class='ui-menu-item']");

        public By Unitnumber => By.XPath(".//input[@id='unitnumber']");

        public By Streetnumber => By.XPath(".//input[@id='streetnumber']");

        public By StreetName => By.XPath(".//input[@id='streetname']");

        public By Streettype => By.XPath(".//input[@id='streettypevalue']");

        public By Suburbtype => By.XPath(".//input[@id='suburbvalue']");

        public By Postcode => By.XPath(".//input[@id='postcode']");

        public By EmploymentStatus => By.XPath(".//select[@id='empstatusid']");

        public By PersonalUseYes => By.XPath("//*[@id='isSelfEmployedPolsForPersonal']/label[1]");

        public By PersonalUseNo => By.XPath("//*[@id='isSelfEmployedPolsForPersonal']/label[2]");

        public By ShortTermLoanStatusYes => By.XPath(".//*[@id='hashad2ormoreshorttermloansinlast90days']/label[contains(text(),'YES')]");

        public By ShortTermLoanStatusNo => By.XPath(".//*[@id='hashad2ormoreshorttermloansinlast90days']/label[contains(text(),'NO')]");

        public By ReadPrivacychecked => By.XPath(".//*[@id='termsandconditions']/following-sibling::div");

        //public By ReadPrivacyunchecked => By.XPath(".//*[@id='termsandconditionscontent']/div[1]/div[@class='checkbox']");
        public By ReadPrivacyunchecked => By.XPath(".//*[@id='termsandconditionscontent']/div[1]/div");

        public By ReadCreditGuidechecked => By.XPath(".//input[@id='creditguide']");

        //public By ReadCreditGuideunchecked => By.XPath(".//*[@id='termsandconditionscontent']/div[2]/div[@class='checkbox']");

        public By ReadCreditGuideunchecked => By.XPath("//*[@id='termsandconditionscontent']/div[2]/div");//new

        public By personaldetailscontinuebutton => By.XPath(".//*[@id='SubmitContainer']/button");

        public By personaldetailscontinuebuttonRLMobile => By.XPath(".//*[@id='btnSubmit']");

        public By personaldetailsRequestbuttonRLDesktop => By.XPath(".//*[@class='secureSubmitButton sml button']");

        public By checkoutContinueButton => By.XPath(".//*[@id='btnContinue']");

        public By AutomaticVerificationButton => By.XPath(".//*[@id='btnVerifyAutoOpen']");

        public By DNQText => By.XPath(".//h2[@class='center p-b-10']");

        public By DNQMessage => By.XPath("//*[@class='center m-b-20']");

        public By MemberAreaButton => By.XPath("//*[text()='Member Area']");

        public By UpdateYourProfile => By.XPath("//a[@href='/Account/MemberProfile']");

        public By EditDetails => By.XPath("//a[@id='editDetailsBtn']");

        public By ContactDetails => By.XPath("//h3[@id='contactDetailsHeader']");

        public By UnemploymentDesc => By.XPath(".//select[@id='empsubstatusid']");

        public By PersonalDetails => By.XPath("//h3[@id='personalDetailsHeader']");

        public By SaveButton => By.XPath("//a[@id='SaveButton']");

        public By ContactPageSaveButton => By.XPath("//button[@id='submit-2']");

        public By Next2Button
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public By Next3Button
        {
            get
            {
                throw new NotImplementedException();
            }
        }

    }

    public class WebSiteRefreshPersonalDetailsLoc
    {
        public static By Email => By.XPath(".//input[@id='email']");

        public static By Title => By.XPath(".//select[@id='title']");

        public static By FirstName => By.XPath(".//input[@id='firstname']");

        public static By MiddleName => By.XPath(".//input[@id='middlenames']");

        public static By LastName => By.XPath(".//input[@id='surname']");

        public static By DOB => By.XPath("//input[@id='dob']");

        public static By RandomYear => By.XPath("//select[@class='ui-datepicker-year']");

        public static By RandomMonth => By.XPath("//select[@class='ui-datepicker-month']");

        public static By Dob_Day => By.XPath(".//select[@id='dob_day']");

        public static By Dob_Month => By.XPath(".//select[@id='dob_month']");

        public static By Dob_Year => By.XPath(".//select[@id='dob_year']");

        public static By EmploymentStatus => By.XPath(".//select[@id='empstatusid']");

        public static By ShortTermLoanStatusYes => By.XPath(".//*[@id='hashad2ormoreshorttermloansinlast90days']/label[contains(text(),'YES')]");

        public static By ShortTermLoanStatusNo => By.XPath(".//*[@id='hashad2ormoreshorttermloansinlast90days']/label[contains(text(),'NO')]");

        public static By Homephone => By.XPath(".//input[@id='homephone']");

        public static By Mobilephone => By.XPath(".//input[@id='mobilephone']");

        public static By Address => By.XPath(".//input[@id='address']");

        public static By AddressSearch => By.XPath(".//input[@id='addresssearch']");

        // public static By AddressAutoFillBtn => By.XPath("//ul[@id='ui-id-3']/li[contains(text(),'Use entered address: Southport')]");

        public static By AddressAutoFillBtn => By.XPath("//ul[@class='ui-autocomplete ui-front ui-menu ui-widget ui-widget-content']/li[contains(text(),'Use entered address: southport')]");

        public static By Unitnumber => By.XPath(".//input[@id='unitnumber']");

        public static By Streetnumber => By.XPath(".//input[@id='streetnumber']");

        public static By StreetName => By.XPath(".//input[@id='streetname']");

        public static By Streettype => By.XPath(".//input[@id='streettypevalue']");

        public static By Suburbtype => By.XPath(".//input[@id='suburbvalue']");

        public static By Postcode => By.XPath(".//input[@id='postcode']");

        public static By Password => By.XPath(".//input[@id='password']");

        public static By ConfirmPassword => By.XPath(".//input[@id='confirmpassword']");

        //public static By ReadPrivacychecked => By.XPath(".//div[@id='termswrap']//label");

        //public static By ReadCreditGuidechecked => By.XPath(".//div[@id='creditwrap']//label");

        public static By ReadPrivacychecked => By.XPath("//div[@id='termswrap']//div[@class='formfield checkbox-field']//span");

        public static By ReadCreditGuidechecked => By.XPath("//div[@id='creditwrap']//div[@class='formfield checkbox-field']//span");

        public static By RandomDate(string Date)
        {
            return By.XPath("//table[@class='ui-datepicker-calendar']//tbody/tr/td/a[contains(text(),'" + Date + "')]");
        }

        public static By EmailErr => By.XPath("//div[@id='email_error']//p");

        public static By FirstNameErr => By.XPath("//div[@id='firstname_error']//p");

        public static By TitleErr => By.XPath("//div[@id='title_error']//p");

        public static By LastNameErr => By.XPath("//div[@id='surname_error']//p");

        public static By DOBErr => By.XPath("//div[@id='dob_error']//p");

        public static By EmploymentErr => By.XPath("//div[@id='empstatusid_error']//p");

        public static By ShortTermLoanErr => By.XPath("//div[@id='hashad2ormoreshorttermloansinlast90days_error']//p");

        public static By MobilePhoneErr => By.XPath("//div[@id='mobilephone_error']//p");

        public static By StreetNumberErr => By.XPath("//div[@id='streetnumber_error']//p");

        public static By StreetNameErr => By.XPath("//div[@id='streetname_error']//p");

        public static By StreetTypeErr => By.XPath("//div[@id='streettypevalue_error']//p");

        public static By CityErr => By.XPath("//div[@id='suburbvalue_error']//p");

        public static By PostCodeErr => By.XPath("//div[@id='postcode_error']//p");

        public static By addressErr => By.XPath("//div[@id='address_error']//p");

        public static By passwordErr => By.XPath("//div[@id='password_error']//p");

        public static By privacyErr => By.XPath("//div[@id='termswrap_error']//p");

        public static By creditGuidErr => By.XPath("//div[@id='creditwrap_error']//p");

        public static By confirmPasswordErr => By.XPath("//div[@id='confirmpassword_error']//p");

        public static By SelfEmployedYes => By.XPath(".//*[@id='isSelfEmployedPolsForPersonal']/label[contains(text(),'YES')]");

        public static By SelfEmployedNo => By.XPath(".//*[@id='isSelfEmployedPolsForPersonal']/label[contains(text(),'NO')]");

        public static By ExistingMemberDialog => By.XPath("//div[@id='existingMemberDialog']//p");

        //div[@id='termswrap_error']//p

    }
}
