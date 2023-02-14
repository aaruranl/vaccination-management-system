using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace newTestvms
{
    class Validation
    {
        public static string validateName = "^[A-Za-z ]{3,}$";

        public static string validateNewNIC = "^[0-9]{4}[01235678]{1}[0-9]{7}$";

        public static string validateOldNIC = "^[0-9]{2}[01235678]{1}[0-9]{6}[VX]{1}$";

        // gender vise validate NIC
        //public static string validatemaleNEWCustomerNIC = "^[0-9]{4}[0123]{1}[0-9]{7}$";
       // public static string validatemaleOLDCustomerNIC = "^[0-9]{2}[0123]{1}[0-9]{6}[VX]{1}$";
        // public static string validatefemaleNEWCustomerNIC = "^[0-9]{4}[5678]{1}[0-9]{7}$";
        // public static string validatefemaleOLDCustomerNIC = "^[0-9]{2}[5678]{1}[0-9]{6}[VX]{1}$";

        public static string validateEmail = "^[a-zA-Z0-9.-_]{1,30}[@]{1}[a-z.]{1,10}[.]{1}[a-z]{2,3}$";






        public static bool ValidEmail(string email)
        {
            return Regex.IsMatch(email, validateEmail);
        }

        public static bool ValidName(string cusname)
        {
            return Regex.IsMatch(cusname, validateName);
        }

        public static bool ValidNewNIC(string nnic)
        {
            return Regex.IsMatch(nnic, validateNewNIC);
        }

        public static bool ValidOldNIC(string onic)
        {
            return Regex.IsMatch(onic, validateOldNIC);
        }

    }
}
