﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DatabaseHelper
    {
        public static SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=LEOKUN-73C61U1\SMS;Initial Catalog=SuperMarket_Management_DB_Version4;User ID=sa;Password=Forever1@");
            //return new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=SuperMarket_Management_DB;User ID=sa;Password=123");
            //return new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=SuperMarket_Management_DB;User ID=sa;Password=123");
            //return new SqlConnection(@"Data Source=LAPTOP-BD4B517R;Initial Catalog=SuperMarket_Management_DB;User ID=sa;Password=123");
            //return new SqlConnection(@"Data Source = MYSUPERASUS\MYSUPERASUS; Initial Catalog = SuperMarket_Management_DB; Persist Security Info = True; User ID = sa; Password = 123");
            //return new SqlConnection(@"Data Source=LAPTOP-IECMHDS7;Initial Catalog=QLST;Persist Security Info=True;User ID=sa;Password=123");
        }
    }
}