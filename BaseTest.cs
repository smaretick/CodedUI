using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestProject1
{

    [CodedUITest]
    public class BaseTest
    {
        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
        private string elapseMs;

        [ClassInitialize]
        public static void LaunchBroswer(TestContext context)
        {
            Playback.Initialize();
            BrowserWindow browser = BrowserWindow.Launch(new System.Uri("https://qa.portfoliopathway.com"));
        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            LogIn();
        }

        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            LogOut();
        }

        public void LogIn()
        {
            //open BrowserWindow
            //Playback.Initialize();
            //BrowserWindow browser = BrowserWindow.Launch(new System.Uri("https://qa.portfoliopathway.com"));
            ////******************************LOG ON*********************************************
            var watch = System.Diagnostics.Stopwatch.StartNew();
            System.Diagnostics.Debug.WriteLine("LogOn method start time is:", watch);

            //UIMap.UIGoogleInternetExplorWindow.LaunchUrl(new System.Uri("http://www.portfoliopathway.com"));
            UIMap.UIGoogleInternetExplorWindow.LaunchUrl(new Uri("https://qa.portfoliopathway.com"));

            // Click 'Portfolio Pathway' button
            //  Mouse.Click(UIMap.UIGoogleInternetExplorWindow.UIPortfolioPathwayDocument.uIPortfolioPathwayButton, new Point(87, 10));

            // Click 'Continue to this website (not recommended).' link
            //Mouse.Click(UIMap.UIGoogleInternetExplorWindow.FilterProperties[HtmlHyperlink.PropertyNames.InnerText] = "Continue to this website (not recommended).");
            //this.UIMap.RecordedMethod2();

            // Type 'DemoFirm' in 'UserName' text box
            UIMap.UIGoogleInternetExplorWindow.UIPortfolioPathwayDocument.UIUserNameEdit.Text = "DemoFirm";

            // Type '{Tab}' in 'UserName' text box
            Keyboard.SendKeys(UIMap.UIGoogleInternetExplorWindow.UIPortfolioPathwayDocument.UIUserNameEdit, "{Tab}", System.Windows.Input.ModifierKeys.None);

            // Type '********' in 'Password' text box
            //uIPasswordEdit.Password = this.RecordedMethod1Params.UIPasswordEditPassword;
            UIMap.UIGoogleInternetExplorWindow.UIPortfolioPathwayDocument.UIPasswordEdit.Text = "FirmDemo";

            //// Type '{Enter}' in 'Password' text box
            Keyboard.SendKeys(UIMap.UIGoogleInternetExplorWindow.UIPortfolioPathwayDocument.UIPasswordEdit, "{Enter}", System.Windows.Input.ModifierKeys.None);
            var elapsedMs = watch.ElapsedMilliseconds;
            System.Diagnostics.Debug.WriteLine("LogOn method execution time is: {0} SECS", watch.Elapsed.Seconds);
            watch.Stop();
            ////************************************************************************************
            //BrowserWindow browserWindow = UIMap.UIGoogleInternetExplorWindow;
            //Image MyImage = UITestControl.Desktop.CaptureImage();
            //MyImage.Save(@"C:\Users\smaretick\Desktop\BrowserPP.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            ////************************************************************************************
            ////ADMIN CENTER->Ops Center
            watch = System.Diagnostics.Stopwatch.StartNew();
            this.UIMap.ADMIN_CENTER_Ops_Center();
            elapsedMs = watch.ElapsedMilliseconds;
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Ops Center method execution time is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            ////ADMIN CENTER->Group Maintenance->Households
            watch = System.Diagnostics.Stopwatch.StartNew();
            this.UIMap.ADMIN_CENTER_GrpMain_House();
            elapsedMs = watch.ElapsedMilliseconds;
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->Households method execution time is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            ////ADMIN CENTER->Group Maintenance->Client Groups
            watch = System.Diagnostics.Stopwatch.StartNew();
            this.UIMap.ADMIN_CENTER_GrpMain_ClientGrp();
            elapsedMs = watch.ElapsedMilliseconds;
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->Client Groups method execution time is: {0}SECS", watch.Elapsed.Seconds);
            ////+++++++++++++++++++++++MULTIPLE LEVEL MOUSE TRAVERSES TOO SLOW USE BUTTONS++++++++++++++++++++++++++++++++++++++++++++++ 
            ////////ADMIN CENTER->Group Maintenance->Portfolio Group->Membership
            //watch = System.Diagnostics.Stopwatch.StartNew();
            //this.UIMap.ADMIN_CENTER_GrpMain_CPortGrp_Member();
            //System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->Portfolio Group->Membership method execution time is: {0}SECS", watch.Elapsed.Seconds);
            //////************************************************************************************
            ////////ADMIN CENTER->Group Maintenance->Portfolio Group->Enrollment History
            //////this.UIMap.ADMIN_CENTER_GrpMain_PortGrp_EnrollmentH();
            //elapsedMs = watch.ElapsedMilliseconds;
            //System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->Portfolio Group->Enrollment History method execution time is: {0}SECS", watch.Elapsed.Seconds);
            //////************************************************************************************
            ////////ADMIN CENTER->Group Maintenance->Model Group->Membership
            //this.UIMap.ADMIN_CENTER_GrpMain_ModelGrp_Membership();
            //elapsedMs = watch.ElapsedMilliseconds;
            //System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->Model Group->Membership method execution time is: {0}SECS", watch.Elapsed.Seconds);
            //////************************************************************************************
            ////////ADMIN CENTER->Group Maintenance->Model Group->Enrollment History
            //this.UIMap.ADMIN_CENTER_GrpMain_ModelGrp_EnrollmentH();
            //elapsedMs = watch.ElapsedMilliseconds;
            //System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->Model Group->Enrollment History method execution time is: {0}SECS", watch.Elapsed.Seconds);
            ////+++++++++++++++++++++++MULTIPLE LEVEL MOUSE TRAVERSES TOO SLOW USE BUTTONS++++++++++++++++++++++++++++++++++++++++++++++ 
            ////************************************************************************************
            //////ADMIN CENTER->Group Maintenance->ACCOUNT GROUP->Household(BUTTON)
            this.UIMap.ADMIN_CENTER_ACCTGRP_Household_B();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->ACCOUNT GROUP->Household(BUTTON) is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            //// ADMIN CENTER->Group Maintenance->ACCOUNT GROUP->Client Group(BUTTON)
            this.UIMap.ADMIN_CENTER_ACCTGRP_Client_B();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->ACCOUNT GROUP->Client Group(BUTTON) is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            //// ADMIN CENTER->Group Maintenance->PORTFOLIO GROUP->Membership(BUTTON)
            //this.UIMap.ADMIN_CENTER_PORTGRP_Member_B();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->PORTFOLIO GROUP->Membership(BUTTON) is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            //// ADMIN CENTER->Group Maintenance->PORTFOLIO GROUP->Enrollment(BUTTON)
            this.UIMap.ADMIN_CENTER_PORTGRP_Enroll_B();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->PORTFOLIO GROUP->Enrollment(BUTTON) is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            //// ADMIN CENTER->Group Maintenance->MODEL GROUP->Membership(BUTTON)
            this.UIMap.ADMIN_CENTER_MODELGRP_Member_B();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->MODEL GROUP->Membership(BUTTON) is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            //// ADMIN CENTER->Group Maintenance->MODEL GROUP->Enrollment(BUTTON)
            this.UIMap.ADMIN_CENTER_MODELGRP_Enrollment_B();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Group Maintenance->MODEL GROUP->Enrollment(BUTTON) is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            ////ADMIN CENTER->Custom Categories
            this.UIMap.ADMIN_CENTER_CustomCat();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Custom Categories is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            ////ADMIN CENTER->Billing
            this.UIMap.ADMIN_CENTER_Billing();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Billing is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            ////ADMIN CENTER->Security Classifications
            this.UIMap.ADMIN_CENTER_SecurityClass();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Security Classifications is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            ////ADMIN CENTER->ID Management
            this.UIMap.ADMIN_CENTER_ID_Mgmt();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->ID Management is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            ////ADMIN CENTER->Nanual Entry
            this.UIMap.ADMIN_CENTER_Man_Entry();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Nanual Entry is: {0}SECS", watch.Elapsed.Seconds);
            ////************************************************************************************
            ////ADMIN CENTER->Account-Advisor Setup
            this.UIMap.ADMIN_CENTER_ACC_Adv_Setup();
            System.Diagnostics.Debug.WriteLine("ADMIN CENTER->Account-Advisor Setup is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //MY ACCOUNTS->Households Under Management
            this.UIMap.MY_ACCOUNTS_HseUnderMgmt();
            System.Diagnostics.Debug.WriteLine("MY ACCOUNTS->Households Under Management is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //MY ACCOUNTS->Accounts Under Management
            this.UIMap.MY_ACCOUNTS_AcctsUnderMgmt();
            System.Diagnostics.Debug.WriteLine("MY ACCOUNTS->Accounts Under Management is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //MY ACCOUNTS->Profile Management->Account Profile
            this.UIMap.MY_ACCOUNTS_ProMgmt_AcctPro();
            System.Diagnostics.Debug.WriteLine("MY ACCOUNTS->Profile Management->Account Profile is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //MY ACCOUNTS->Profile Management->Household Profile
            this.UIMap.MY_ACCOUNTS_ProMgmt_HsePro();
            System.Diagnostics.Debug.WriteLine("MY ACCOUNTS->Profile Management->Household Profile is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //MY ACCOUNTS->Composite Reporting
            this.UIMap.MY_ACCOUNTS_CompRpt();
            System.Diagnostics.Debug.WriteLine("MY ACCOUNTS->Composite Reporting is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //MY ACCOUNTS->Documents
            this.UIMap.MY_ACCOUNTS_Docs();
            System.Diagnostics.Debug.WriteLine("MY ACCOUNTS->Documents is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //MY ACCOUNTS->Report Center->Firm Analysis
            this.UIMap.MY_ACCOUNTS_RptCtr_FA();
            System.Diagnostics.Debug.WriteLine("MY ACCOUNTS->Report Center->Firm Analysis is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //MY ACCOUNTS->Report Center->Security Analysis
            this.UIMap.MY_ACCOUNTS_RptCtr_SA();
            System.Diagnostics.Debug.WriteLine("MY ACCOUNTS->Report Center->Security Analysis is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //MY ACCOUNTS->Report Center->Security Performance
            this.UIMap.MY_ACCOUNTS_RptCtr_SP();
            System.Diagnostics.Debug.WriteLine("MY ACCOUNTS->Report Center->Security Performance is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //MY ACCOUNTS->Report Center->Transaction History
            this.UIMap.MY_ACCOUNTS_RptCtr_TH();
            System.Diagnostics.Debug.WriteLine("MY ACCOUNTS->Report Center->Transaction History is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Holdings
            this.UIMap.ACCT_DETAILS_Holdings();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Holdings is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Asset Allocation
            this.UIMap.ACCT_DETAILS_Asset_Alloc();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Asset Allocation is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Transactions
            this.UIMap.ACCT_DETAILS_Transactions();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Transactions is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Report Center->Unrealized Gain/Loss
            this.UIMap.ACCT_DETAILS_RptCtr_UnGL();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Report Center->Unrealized Gain/Loss is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Report Center->Realized Gain/Loss
            this.UIMap.ACCT_DETAILS_RptCtr_GL();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Report Center->Realized Gain/Loss is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Report Center->Fixed Income Interest
            this.UIMap.ACCT_DETAILS_RptCtr_FixInInt();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Report Center->Fixed Income Interest is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Report Center->Fees
            this.UIMap.ACCT_DETAILS_RptCtr_Fees();
            System.Diagnostics.Debug.WriteLine("ACCT_DETAILS_RptCtr_Fees is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Report Center->Income Summary
            this.UIMap.ACCT_DETAILS_RptCtr_IncSum();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Report Center->Income Summary is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Report Center->Income & Dividend
            this.UIMap.ACCT_DETAILS_RptCtr_IncDiv();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Report Center->Income & Dividend is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Performance->Account Performance
            this.UIMap.ACCT_DETAILS_Perf_AccPerf();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Performance->Account Performance is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Performance->Growth Against Index
            this.UIMap.ACCT_DETAILS_Perf_GrowAIndex();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Performance->Growth Against Index is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Performance->Performance History
            this.UIMap.ACCT_DETAILS_Perf_PerfHist();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Performance->Performance History is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Performance->Security Performance Rollup
            this.UIMap.ACCT_DETAILS_Perf_SecPerfRoll();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Performance->Security Performance Rollup is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Performance->Security Performance
            this.UIMap.ACCT_DETAILS_Perf_SecPerf();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Performance->Security Performance is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Documents
            this.UIMap.ACCT_DETAILS_Docs();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Documents is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ACCOUNT DETAILS->Profile
            this.UIMap.ACCT_DETAILS_Profile();
            System.Diagnostics.Debug.WriteLine("ACCOUNT DETAILS->Profile is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //************************************************************************************                   
            //REBALX->Dashboard
            this.UIMap.REBALX_DashBs();
            System.Diagnostics.Debug.WriteLine("REBALX->Dashboard is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************                       
            //REBALX->Order Management
            this.UIMap.REBALX_OrderMgmt();
            System.Diagnostics.Debug.WriteLine("REBALX->Order Management is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Allocation Status
            this.UIMap.REBALX_AllocStatus();
            System.Diagnostics.Debug.WriteLine("REBALX->Allocation Status is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Model Management->UMA Model
            this.UIMap.REBALX_ModMgmt_UMA();
            System.Diagnostics.Debug.WriteLine("REBALX->Model Management->UMA Model is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Model Management->Sub-Model
            this.UIMap.REBALX_ModMgmt_SubMod();
            System.Diagnostics.Debug.WriteLine("REBALX->Model Management->Sub-Model is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Reports->Account Status
            this.UIMap.REBALX_Rpts_AcctStatus();
            System.Diagnostics.Debug.WriteLine("REBALX->Reports->Account Status is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Reports->Cash Reserve
            this.UIMap.REBALX_Rpts_CashReserve();
            System.Diagnostics.Debug.WriteLine("REBALX->Reports->Cash Reserve is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Reports->Expired Cash Reserve
            this.UIMap.REBALX_Rpts_ExpCashReserve();
            System.Diagnostics.Debug.WriteLine("REBALX->Reports->Expired Cash Reserve is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Reports->Security Restrictions
            this.UIMap.REBALX_Rpts_SecRestrict();
            System.Diagnostics.Debug.WriteLine("REBALX->Reports->Security Restrictions is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Reports->UMA Assignment
            this.UIMap.REBALX_Rpts_UMAAssign();
            System.Diagnostics.Debug.WriteLine("REBALX->Reports->UMA Assignment is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Reports->Cash Drift
            this.UIMap.REBALX_Rpts_CashDrift();
            System.Diagnostics.Debug.WriteLine("REBALX->Reports->Cash Drift is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Reports->UMA Drift
            this.UIMap.REBALX_Rpts_UMADrift();
            System.Diagnostics.Debug.WriteLine("REBALX->Reports->UMA Drift is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Reports->Accounts Not Model Invested
            this.UIMap.MY_ACCOUNTS_RptCtr_AcctsNotModInv();
            System.Diagnostics.Debug.WriteLine("REBALX->Reports->Accounts Not Model Invested is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Reports->UMA Funding Sleeve Audit
            this.UIMap.REBALX_Rpts_UMA_FundSleeveAudit();
            System.Diagnostics.Debug.WriteLine("REBALX_Rpts_UMA_FundSleeveAudit is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //REBALX->Reports->ALL
            this.UIMap.REBALX_Rpts_ALL();
            System.Diagnostics.Debug.WriteLine("REBALX_Rpts_ALL is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //TOP BUTTONS
            //************************************************************************************
            //Ops Center
            this.UIMap.OpsCenter_button();
            System.Diagnostics.Debug.WriteLine("OpsCenter_button is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //Group Maintenance
            this.UIMap.GrpMaintenance_button();
            System.Diagnostics.Debug.WriteLine("GrpMaintenance_button is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //Custom Categories
            this.UIMap.CustomCat_button();
            System.Diagnostics.Debug.WriteLine("CustomCatagoties_button is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //Billing
            this.UIMap.Billing_button();
            System.Diagnostics.Debug.WriteLine("Billing_button is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //Security Classifications
            this.UIMap.SecurityClass_button();
            System.Diagnostics.Debug.WriteLine("Security Classifications is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //ID Mgmt
            this.UIMap.ID_Mgmt_button();
            System.Diagnostics.Debug.WriteLine("ID_Mgmt_button is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //Manual Entry
            this.UIMap.ManEntry_button();
            System.Diagnostics.Debug.WriteLine("Manual Entry is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************
            //AcctAdvisor Setup
            this.UIMap.AcctAdvSetup_button();
            System.Diagnostics.Debug.WriteLine("AcctAdvisor Setup is: {0}SECS", watch.Elapsed.Seconds);
            //************************************************************************************  
        }

        public void LogOut()
        {
//            UIMap.UIGoogleInternetExplorWindow.Close();
        }
        
    }
}
