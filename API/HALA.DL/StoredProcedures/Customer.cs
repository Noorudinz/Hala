﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HALA.DL.StoredProcedures
{
    public class CustomerSP
    {
        public const string PostCustomerMaster = "CUS_InsertCustomerMaster";
        public const string UserNamePrecheck = "SP_PrecheckUserName";
        public const string EmailPrecheck = "CUS_PrecheckEmailId";
        public const string FetchCustomerDetails = "CUS_FetchCustomerDetails";
    }
}