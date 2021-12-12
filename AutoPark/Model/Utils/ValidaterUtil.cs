using AutoPark.Entity;
using System.Text.RegularExpressions;


namespace AutoPark.Model.Utils
{
    class ValidaterUtil
    {
        public static bool ValidateCar(Car car) {
            return IsValidString(car.Model) && IsValidString(car.CategoryId) && IsValidString(car.Number, "[A-Z0-9-]{4,10}");
        }

        public static bool IsValidCategoryName(string name) {
            return IsValidString(name, "[A-Z][a-z]{0,20}");
        }

        public static bool IsValidString(string str, string pattern) {            
            return IsValidString(str) && IsValidString(pattern) && new Regex(pattern).IsMatch(str.Trim());            
        }

        public static bool IsValidString(string str) {
            return str != null && str.Trim() != "";
        }
    }
}
