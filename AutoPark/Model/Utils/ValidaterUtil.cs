using AutoPark.Entity;
using System.Text.RegularExpressions;


namespace AutoPark.Model.Utils
{
    public class ValidaterUtil
    {
        public static bool IsValidString(string str, string pattern) {            
            return IsValidString(str) && IsValidString(pattern) && new Regex(pattern).IsMatch(str.Trim());            
        }

        public static bool IsValidString(string str) {
            return str != null && str.Trim() != "";
        }
    }
}
