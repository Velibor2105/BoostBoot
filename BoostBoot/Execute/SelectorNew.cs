using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execute
{
    public static class SelectorNew
    {
        public static string UserName = "#user_name";
        public static string Password = "#user_password";
        public static string LoginButton = "#bigbutton";
        public static string SearchBox = "div.desktop-bar > ul > li:nth-child(3) > form > div > input";
        public static string ExistingCompanies = "table > tbody:nth-child(3) > tr > td:nth-child(2) > a";
    }
}
