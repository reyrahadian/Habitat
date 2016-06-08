﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Habitat.Website.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CompatibleRenderingsFeature : Xunit.IClassFixture<CompatibleRenderingsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Compatible Renderings.feature"
#line hidden
        
        public CompatibleRenderingsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Compatible Renderings", "\tAs an editor \r\n\tI want to be able to switch between layouts \r\n\tSo that I have fl" +
                    "exibility in the layout of the pages", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(CompatibleRenderingsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC1_Check compatible renderings in the Person module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC1_Check compatible renderings in the Person module")]
        [Xunit.TraitAttribute("Category", "OnlyManual")]
        public virtual void CompatibleRenderings_UC1_CheckCompatibleRenderingsInThePersonModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC1_Check compatible renderings in the Person module", new string[] {
                        "OnlyManual"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("Expirience Editor application is launched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.And("en/Modules/Feature/Person page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("EmployeeTeaser rendering is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.When("User clicks <Replace with another component> button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.And("Selects EmployeeContactTeaser from <Select a replacement rendering> dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("Rendering name changed to EmployeeContactTeaser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.And("Contact information is added in the bottom of the rendering", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC2_Data source was not changed")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC2_Data source was not changed")]
        [Xunit.TraitAttribute("Category", "OnlyManual")]
        public virtual void CompatibleRenderings_UC2_DataSourceWasNotChanged()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC2_Data source was not changed", new string[] {
                        "OnlyManual"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("Expirience Editor application is launched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.And("en/Modules/Feature/Accounts page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("PageSidebarLeft rendering is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.When("User clicks <Replace with another component> button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.And("Selects PageSidebarRight from <Select a replacement rendering> dialog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.Then("Rendering name changed to PageSidebarRight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.And("SecondaryMenu rendering is now on the right side of the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC3_Check that where is no repeated renderings in the list")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC3_Check that where is no repeated renderings in the list")]
        [Xunit.TraitAttribute("Category", "OnlyManual")]
        public virtual void CompatibleRenderings_UC3_CheckThatWhereIsNoRepeatedRenderingsInTheList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC3_Check that where is no repeated renderings in the list", new string[] {
                        "OnlyManual"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.Given("Expirience Editor application is launched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
 testRunner.And("Modules/Feature/Teasers page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.When("User selects <Inner 2 Column 6-6> rendering", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.And("User clicks <Replace with another component> button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Rendering Name"});
            table1.AddRow(new string[] {
                        "Inner 2 Column 4-8"});
            table1.AddRow(new string[] {
                        "Inner 2 Column 8-4"});
            table1.AddRow(new string[] {
                        "Inner 1 Column"});
#line 35
 testRunner.Then("Following rendering available on the <Select a replacement rendering> dialog", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC4_Accounts module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC4_Accounts module")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC4_AccountsModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC4_Accounts module", new string[] {
                        "Ready"});
#line 45
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table2.AddRow(new string[] {
                        "Edit Profile"});
            table2.AddRow(new string[] {
                        "Forgot Password"});
            table2.AddRow(new string[] {
                        "Login"});
            table2.AddRow(new string[] {
                        "Login Menu"});
            table2.AddRow(new string[] {
                        "Register"});
#line 46
 testRunner.Then("Feature/Accounts module contains incompatible renderings", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC5_Demo module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC5_Demo module")]
        [Xunit.TraitAttribute("Category", "Bug")]
        public virtual void CompatibleRenderings_UC5_DemoModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC5_Demo module", new string[] {
                        "Bug"});
#line 58
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table3.AddRow(new string[] {
                        "xDB Contact Details"});
            table3.AddRow(new string[] {
                        "xDB Visit Details"});
#line 59
 testRunner.Then("Feature/Demo module contains compatible renderings", ((string)(null)), table3, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table4.AddRow(new string[] {
                        "Demo Content"});
            table4.AddRow(new string[] {
                        "xDB Panel"});
#line 63
 testRunner.And("Feature/Demo module contains incompatible renderings", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC6_FAQ module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC6_FAQ module")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC6_FAQModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC6_FAQ module", new string[] {
                        "Ready"});
#line 72
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table5.AddRow(new string[] {
                        "FAQ Accordion"});
#line 73
 testRunner.Then("Feature/FAQ module contains incompatible renderings", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC7_Identity module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC7_Identity module")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC7_IdentityModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC7_Identity module", new string[] {
                        "Ready"});
#line 80
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table6.AddRow(new string[] {
                        "Contact Information"});
#line 81
 testRunner.Then("Feature/Identity module contains incompatible renderings", ((string)(null)), table6, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table7.AddRow(new string[] {
                        "Copyright"});
            table7.AddRow(new string[] {
                        "Logo"});
#line 84
 testRunner.And("Feature/Identity module contains compatible renderings", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC8_Language")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC8_Language")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC8_Language()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC8_Language", new string[] {
                        "Ready"});
#line 92
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table8.AddRow(new string[] {
                        "Language menu"});
#line 93
 testRunner.Then("Feature/Language module contains incompatible renderings", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC9_Maps module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC9_Maps module")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC9_MapsModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC9_Maps module", new string[] {
                        "Ready"});
#line 100
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table9.AddRow(new string[] {
                        "Map"});
#line 101
 testRunner.Then("Feature/Maps module contains incompatible renderings", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC10_Media module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC10_Media module")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC10_MediaModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC10_Media module", new string[] {
                        "Ready"});
#line 108
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table10.AddRow(new string[] {
                        "Media Carousel"});
            table10.AddRow(new string[] {
                        "Media Gallery"});
#line 109
 testRunner.Then("Feature/Media module contains compatible renderings", ((string)(null)), table10, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table11.AddRow(new string[] {
                        "Image with Lightbox"});
            table11.AddRow(new string[] {
                        "Page Header Media Carousel"});
            table11.AddRow(new string[] {
                        "Page Header with Media"});
            table11.AddRow(new string[] {
                        "Section with Media"});
            table11.AddRow(new string[] {
                        "Video with Lightbox"});
#line 113
 testRunner.And("Feature/Media module contains incompatible renderings", ((string)(null)), table11, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC11_Metadata module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC11_Metadata module")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC11_MetadataModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC11_Metadata module", new string[] {
                        "Ready"});
#line 124
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table12.AddRow(new string[] {
                        "HTML Metadata"});
#line 125
 testRunner.Then("Feature/Metadata module contains incompatible renderings", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC12_Multisute module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC12_Multisute module")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC12_MultisuteModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC12_Multisute module", new string[] {
                        "Ready"});
#line 132
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table13.AddRow(new string[] {
                        "Site Menu"});
#line 133
 testRunner.Then("Feature/Multisite module contains incompatible renderings", ((string)(null)), table13, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC13_Navigation module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC13_Navigation module")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC13_NavigationModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC13_Navigation module", new string[] {
                        "Ready"});
#line 140
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table14.AddRow(new string[] {
                        "Breadcrumb"});
            table14.AddRow(new string[] {
                        "Primary Menu"});
            table14.AddRow(new string[] {
                        "Secondary Menu"});
            table14.AddRow(new string[] {
                        "Menu with links"});
            table14.AddRow(new string[] {
                        "Navigation Links"});
#line 141
 testRunner.Then("Feature/Navigation module contains incompatible renderings", ((string)(null)), table14, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC14_News module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC14_News module")]
        [Xunit.TraitAttribute("Category", "Bug")]
        public virtual void CompatibleRenderings_UC14_NewsModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC14_News module", new string[] {
                        "Bug"});
#line 151
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table15.AddRow(new string[] {
                        "Latest News"});
            table15.AddRow(new string[] {
                        "News List"});
#line 152
 testRunner.Then("Feature/News module contains compatible renderings", ((string)(null)), table15, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table16.AddRow(new string[] {
                        "News Content Header Title"});
            table16.AddRow(new string[] {
                        "News Related Content"});
            table16.AddRow(new string[] {
                        "News Article"});
            table16.AddRow(new string[] {
                        "News Article Teaser"});
#line 156
 testRunner.And("Feature/News module contains incompatible renderings", ((string)(null)), table16, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC15_PageContent module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC15_PageContent module")]
        [Xunit.TraitAttribute("Category", "Bug")]
        public virtual void CompatibleRenderings_UC15_PageContentModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC15_PageContent module", new string[] {
                        "Bug"});
#line 167
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table17.AddRow(new string[] {
                        "Page Body"});
            table17.AddRow(new string[] {
                        "Page Content Header Title"});
            table17.AddRow(new string[] {
                        "Page Image Header"});
            table17.AddRow(new string[] {
                        "Page Teaser"});
#line 168
 testRunner.Then("Feature/PageContent module contains compatible renderings", ((string)(null)), table17, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table18.AddRow(new string[] {
                        "Child Page List"});
            table18.AddRow(new string[] {
                        "Page Title"});
            table18.AddRow(new string[] {
                        "PageImage"});
#line 174
 testRunner.And("Feature/PageContent module contains incompatible renderings", ((string)(null)), table18, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC16_Person module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC16_Person module")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC16_PersonModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC16_Person module", new string[] {
                        "Ready"});
#line 183
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table19.AddRow(new string[] {
                        "Employee Contact Teaser"});
            table19.AddRow(new string[] {
                        "Employee Details"});
            table19.AddRow(new string[] {
                        "Employee Header Contact"});
            table19.AddRow(new string[] {
                        "Employee Teaser"});
#line 184
 testRunner.Then("Feature/Person module contains compatible renderings", ((string)(null)), table19, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table20.AddRow(new string[] {
                        "Employee Header"});
            table20.AddRow(new string[] {
                        "Employees Carousel"});
            table20.AddRow(new string[] {
                        "Employees List"});
            table20.AddRow(new string[] {
                        "Quote"});
#line 190
 testRunner.And("Feature/Person module contains incompatible renderings", ((string)(null)), table20, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC17_Search module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC17_Search module")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC17_SearchModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC17_Search module", new string[] {
                        "Ready"});
#line 205
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table21.AddRow(new string[] {
                        "Paged Search Results"});
            table21.AddRow(new string[] {
                        "Search Results"});
#line 206
 testRunner.Then("Feature/Search module contains compatible renderings", ((string)(null)), table21, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table22.AddRow(new string[] {
                        "Global Search"});
            table22.AddRow(new string[] {
                        "Search Results Header"});
#line 210
 testRunner.Then("Feature/Search module contains incompatible renderings", ((string)(null)), table22, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC18_Social module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC18_Social module")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC18_SocialModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC18_Social module", new string[] {
                        "Ready"});
#line 219
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table23.AddRow(new string[] {
                        "Facebook Open Graph Metadata"});
            table23.AddRow(new string[] {
                        "Twitter Feed"});
#line 220
 testRunner.Then("Feature/Social module contains incompatible renderings", ((string)(null)), table23, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC19_Teasers module")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC19_Teasers module")]
        [Xunit.TraitAttribute("Category", "Bug")]
        public virtual void CompatibleRenderings_UC19_TeasersModule()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC19_Teasers module", new string[] {
                        "Bug"});
#line 229
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table24.AddRow(new string[] {
                        "Call to Action"});
            table24.AddRow(new string[] {
                        "Content Teaser with Image"});
            table24.AddRow(new string[] {
                        "Content Teaser with Image and Summary"});
            table24.AddRow(new string[] {
                        "Content Teaser with Summary"});
#line 230
 testRunner.Then("Feature/Teasers module contains compatible renderings", ((string)(null)), table24, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table25.AddRow(new string[] {
                        "Accordion"});
            table25.AddRow(new string[] {
                        "Tabs"});
#line 236
 testRunner.And("Feature/Teasers module contains compatible renderings", ((string)(null)), table25, "And ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table26.AddRow(new string[] {
                        "Jumbotron Carousel"});
            table26.AddRow(new string[] {
                        "Teaser Carousel"});
#line 240
 testRunner.And("Feature/Teasers module contains compatible renderings", ((string)(null)), table26, "And ");
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table27.AddRow(new string[] {
                        "Headline"});
            table27.AddRow(new string[] {
                        "Call to Action Header"});
#line 244
 testRunner.And("Feature/Teasers module contains incompatible renderings", ((string)(null)), table27, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC20_Project common")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC20_Project common")]
        [Xunit.TraitAttribute("Category", "Bug")]
        public virtual void CompatibleRenderings_UC20_ProjectCommon()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC20_Project common", new string[] {
                        "Bug"});
#line 252
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table28.AddRow(new string[] {
                        "Article Aside Right"});
            table28.AddRow(new string[] {
                        "Article Aside Both"});
            table28.AddRow(new string[] {
                        "Article Aside Left"});
#line 253
 testRunner.Then("Project/Common module contains compatible renderings", ((string)(null)), table28, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table29.AddRow(new string[] {
                        "Main Navigation Activity"});
            table29.AddRow(new string[] {
                        "Header Topbar"});
            table29.AddRow(new string[] {
                        "Main Navigation"});
            table29.AddRow(new string[] {
                        "Page Header"});
            table29.AddRow(new string[] {
                        "Section"});
            table29.AddRow(new string[] {
                        "Footer"});
#line 258
 testRunner.And("Project/Common module contains incompatible renderings", ((string)(null)), table29, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC21_Project Section Columns")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC21_Project Section Columns")]
        [Xunit.TraitAttribute("Category", "Bug")]
        public virtual void CompatibleRenderings_UC21_ProjectSectionColumns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC21_Project Section Columns", new string[] {
                        "Bug"});
#line 271
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table30.AddRow(new string[] {
                        "2 Column 3-9"});
            table30.AddRow(new string[] {
                        "2 Column 4-8"});
            table30.AddRow(new string[] {
                        "2 Column 8-4"});
            table30.AddRow(new string[] {
                        "2 Column 9-3"});
#line 272
 testRunner.Then("Project/Common/Section Columns module contains compatible renderings", ((string)(null)), table30, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table31.AddRow(new string[] {
                        "3 Column 3-3-6"});
            table31.AddRow(new string[] {
                        "3 Column 6-3-3"});
#line 278
 testRunner.And("Project/Common/Section Columns module contains compatible renderings", ((string)(null)), table31, "And ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Incompatible renderings"});
            table32.AddRow(new string[] {
                        "1 Column"});
            table32.AddRow(new string[] {
                        "2 Column 6-6"});
            table32.AddRow(new string[] {
                        "3 Column 4-4-4"});
            table32.AddRow(new string[] {
                        "4 Column 2-2-4-4"});
            table32.AddRow(new string[] {
                        "4 Column 3-3-3-3"});
            table32.AddRow(new string[] {
                        "6 Column 2-2-2-2-2-2"});
#line 282
 testRunner.And("Project/Common/Section Columns module contains incompatible renderings", ((string)(null)), table32, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Compatible Renderings_UC22_Project Article Columns")]
        [Xunit.TraitAttribute("FeatureTitle", "Compatible Renderings")]
        [Xunit.TraitAttribute("Description", "Compatible Renderings_UC22_Project Article Columns")]
        [Xunit.TraitAttribute("Category", "Ready")]
        public virtual void CompatibleRenderings_UC22_ProjectArticleColumns()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Compatible Renderings_UC22_Project Article Columns", new string[] {
                        "Ready"});
#line 296
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Compatible renderings"});
            table33.AddRow(new string[] {
                        "Inner 1 Column"});
            table33.AddRow(new string[] {
                        "Inner 2 Column 4-8"});
            table33.AddRow(new string[] {
                        "Inner 2 Column 6-6"});
            table33.AddRow(new string[] {
                        "Inner 2 Column 8-4"});
#line 297
 testRunner.Then("Project/Common/Article Columns module contains compatible renderings", ((string)(null)), table33, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CompatibleRenderingsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CompatibleRenderingsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
