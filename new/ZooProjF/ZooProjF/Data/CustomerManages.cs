﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooProjF.Data
{
    public class CustomerManages
    {
        public class CustomerManagerment
        {
            //public static int  Customer_Id { get; set; }
            public string Customer_Id { get; internal set; }
            public string First_Name { get; internal set; }

            public string Last_Name { get; internal set; }

            public string Email { get; internal set; }

            public int Phone_Number { get; internal set; }

            public string Street_Name { get; internal set; }

            public int Zip_Code { get; internal set; }
            public string City { get; internal set; }

            public string State { get; internal set; }

            public string Password { get; internal set; }
            public object Customer_ID { get; internal set; }

        }
    };
}