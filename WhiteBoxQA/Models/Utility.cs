using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace WhiteBoxQA.Models
{
    public static class Utility
    {
        // example function to unit test
        public static int AddTen(int number)
        {
            return number + 10;
        }

        public static string AddPrefixSlash(string absolutePath)
        {
            if ((absolutePath != null) && !absolutePath.StartsWith("/"))
            {
                absolutePath = "/" + absolutePath;
            }

            return absolutePath;
        }

        public static string GetCustomerURL(string customerName)
        {
            StringBuilder customerURL = new StringBuilder();

            customerURL.Append(ConfigurationManager.AppSettings["SiteRootPath"]);
            customerURL.Append("/");
            customerURL.Append(customerName[0]);
            customerURL.Append("/");
            customerURL.Append(customerName);

            return customerURL.ToString();
        }
    }
}