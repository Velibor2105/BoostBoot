using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execute
{
    public static class SelectorOld
    {
        public static string UserName = "#user_name";
        public static string Password = "#user_password";
        public static string LoginButton = "#login_button";
        public static string CancelButton = ".boxy-buttons input:nth-child(3)";
        public static string SearchField = "#query_string";
        public static string CompanyExist = "#content > table > tbody > tr > td > h3";
        public static string SearchButton = "#search > form > .button";
    }
}
