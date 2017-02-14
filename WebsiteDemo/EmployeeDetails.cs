﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteDemo
{
    public class EmployeeDetails
    {
        private int _ID = 0;
        private string _FirstName = "";
        private string _LastName = "";
        private string _JobTitle = "";
        private string _FullName = "";
        private int _ContactID = 0;
        private string _ContactEmail = "";
        private string _ContactHomePhone = "";
        private string _ContactCellPhone = "";
        private string _ContactFax = "";
        private int _AddressID = 0;
        private string _AddressLine = "";
        private string _AddressLine2 = "";
        private string _AddressCity = "";
        private int _AddressStateID = 0;
        private string _AddressZip = "";



        public EmployeeDetails(int Employee_ID, string FName, string LName, string Employee_JobTitle, int Employee_ContactID, string Employee_ContactEmail, string Employee_ContactHomePhone, string Employee_ContactCellPhone, string Employee_ContactFax, int Employee_AddressID, string Employee_AddressLine, string Employee_AddressLine2, string Employee_AddressCity, int Employee_Address_StateID, string Employee_AddressZip)
        {
            this._ID = Employee_ID;
            this._FirstName = FName;
            this._LastName = LName;
            this._JobTitle = Employee_JobTitle;
            this._ContactID = Employee_ContactID;
            this._ContactEmail = Employee_ContactEmail;
            this._ContactHomePhone = Employee_ContactHomePhone;
            this._ContactCellPhone = Employee_ContactCellPhone;
            this._ContactFax = Employee_ContactFax;
            this._AddressID = Employee_AddressID;
            this._AddressLine = Employee_AddressLine;
            this._AddressLine2 = Employee_AddressLine2;
            this._AddressCity = Employee_AddressCity;
            this._AddressStateID = Employee_Address_StateID;
            this._AddressZip = Employee_AddressZip;
        }

        public EmployeeDetails()
        {
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public string JobTitle
        {
            get { return _JobTitle; }
            set { _JobTitle = value; }
        }

        public string FullName
        {
            get { return _FirstName + " " + _LastName; }

        }

        public int ContactID
        {
            get { return _ContactID; }
            set { _ContactID = value; }
        }

        public string ContactEmail
        {
            get { return _ContactEmail; }
            set { _ContactEmail = value; }
        }

        public string ContactHomePhone
        {
            get { return _ContactHomePhone; }
            set { _ContactHomePhone = value; }
        }

        public string ContactCellPhone
        {
            get { return _ContactCellPhone; }
            set { _ContactCellPhone = value; }
        }

        public string ContactFax
        {
            get { return _ContactFax; }
            set { _ContactFax = value; }
        }

        public int Employee_AddressID
        {
            get { return _AddressID; }
            set { _AddressID = value; }
        }

        public string Employee_AddressLine
        {
            get { return _AddressLine; }
            set { _AddressLine = value; }
        }

        public string Employee_AddressLine2
        {
            get { return _AddressLine2; }
            set { _AddressLine2 = value; }
        }

        public string Employee_AddressCity
        {
            get { return _AddressCity; }
            set { _AddressCity = value; }
        }

        public int Employee_Address_StateID
        {
            get { return _AddressStateID; }
            set { _AddressStateID = value; }
        }

        public string Employee_AddressZip
        {
            get { return _AddressZip; }
            set { _AddressZip = value; }
        }

    }
}