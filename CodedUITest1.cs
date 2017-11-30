using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using System.Globalization;
using System.Diagnostics;

//RYAN'S TEMPLATE

namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1 : BaseTest
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void LogInTest()
        {


            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            //this.UIMap.RecordedMethod2();
            ////******************ADMIN CENTER*******************************
            //this.UIMap.ADMIN_CENTER_Ops_Center();
            //this.UIMap.ADMIN_CENTER_GrpMain_House();
            //this.UIMap.ADMIN_CENTER_GrpMain_ClientGrp();
            //this.UIMap.ADMIN_CENTER_GrpMain_CPortGrp_Member();
            //this.UIMap.ADMIN_CENTER_GrpMain_PortGrp_EnrollmentH();
            //this.UIMap.ADMIN_CENTER_GrpMain_ModelGrp_Membership();
            //this.UIMap.ADMIN_CENTER_GrpMain_ModelGrp_EnrollmentH();
            //this.UIMap.ADMIN_CENTER_ACCTGRP_Household_B();
            //this.UIMap.ADMIN_CENTER_ACCTGRP_Client_B();
            //this.UIMap.ADMIN_CENTER_PORTGRP_Member_B();
            //this.UIMap.ADMIN_CENTER_PORTGRP_Enroll_B();
            //this.UIMap.ADMIN_CENTER_MODELGRP_Member_B();
            //this.UIMap.ADMIN_CENTER_MODELGRP_Enrollment_B();
            //this.UIMap.ADMIN_CENTER_CustomCat();
            //this.UIMap.ADMIN_CENTER_Billing();
            //this.UIMap.ADMIN_CENTER_SecurityClass();
            //this.UIMap.ADMIN_CENTER_ID_Mgmt();
            //this.UIMap.ADMIN_CENTER_Man_Entry();
            //this.UIMap.ADMIN_CENTER_ACC_Adv_Setup()
            ////******************MY ACCOUNTS*******************************
            //this.UIMap.MY_ACCOUNTS_HseUnderMgmt();
            //this.UIMap.MY_ACCOUNTS_AcctsUnderMgmt();
            //this.UIMap.MY_ACCOUNTS_ProMgmt_AcctPro();
            //this.UIMap.MY_ACCOUNTS_ProMgmt_HsePro();
            //this.UIMap.MY_ACCOUNTS_CompRpt();
            //this.UIMap.MY_ACCOUNTS_Docs();
            //this.UIMap.MY_ACCOUNTS_RptCtr_FA();
            //this.UIMap.MY_ACCOUNTS_RptCtr_SA();
            //this.UIMap.MY_ACCOUNTS_RptCtr_SP();
            //this.UIMap.MY_ACCOUNTS_RptCtr_TH();
            //////*****************ACCOUNT DETAILS****************************
            //this.UIMap.ACCT_DETAILS_Holdings();
            //this.UIMap.ACCT_DETAILS_Asset_Alloc();
            //this.UIMap.ACCT_DETAILS_Transactions();
            //this.UIMap.ACCT_DETAILS_RptCtr_UnGL();
            //this.UIMap.ACCT_DETAILS_RptCtr_GL();
            //this.UIMap.ACCT_DETAILS_RptCtr_FixInInt();
            //this.UIMap.ACCT_DETAILS_RptCtr_Fees();
            //this.UIMap.ACCT_DETAILS_RptCtr_IncSum();
            //this.UIMap.ACCT_DETAILS_RptCtr_IncDiv();
            //this.UIMap.ACCT_DETAILS_Perf_AccPerf();
            //this.UIMap.ACCT_DETAILS_Perf_GrowAIndex();
            //this.UIMap.ACCT_DETAILS_Perf_PerfHist();
            //this.UIMap.ACCT_DETAILS_Perf_SecPerfRoll();
            //this.UIMap.ACCT_DETAILS_Perf_SecPerf();
            //this.UIMap.ACCT_DETAILS_Docs();
            //this.UIMap.ACCT_DETAILS_Profile();
            //////******************REBALX************************************
            //this.UIMap.REBALX_DashBs();
            //this.UIMap.REBALX_OrderMgmt();
            //this.UIMap.REBALX_AllocStatus();
            //this.UIMap.REBALX_ModMgmt_UMA();
            //this.UIMap.REBALX_ModMgmt_SubMod();
            //this.UIMap.REBALX_Rpts_AcctStatus();
            //this.UIMap.REBALX_Rpts_CashReserve();
            //this.UIMap.REBALX_Rpts_ExpCashReserve();
            //this.UIMap.REBALX_Rpts_SecRestrict();
            //this.UIMap.REBALX_Rpts_UMAAssign();
            //this.UIMap.REBALX_Rpts_CashDrift();
            //this.UIMap.REBALX_Rpts_UMADrift();
            //this.UIMap.MY_ACCOUNTS_RptCtr_AcctsNotModInv();
            //this.UIMap.REBALX_Rpts_UMA_FundSleeveAudit();
            //this.UIMap.REBALX_Rpts_ALL();
            //////*********************BUTTONS*********************************
            //this.UIMap.OpsCenter_button();
            //this.UIMap.GrpMaintenance_button();
            //this.UIMap.CustomCat_button();
            //this.UIMap.Billing_button();
            //this.UIMap.SecurityClass_button();
            //this.UIMap.ID_Mgmt_button();
            //this.UIMap.ManEntry_button();
            //this.UIMap.AcctAdvSetup_button();
        }



        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public new UIMap UIMap
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
    }
}
