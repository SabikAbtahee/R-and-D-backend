using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardUI.Validators
{
    class ValidationHelper
    {
        public static bool IsValid(double arg)
        {
            return !Double.IsNaN(arg);
        }

        public static bool IsPositiveValue(double value)
        {
            if (value >= 0) return true;

            return false;
        }

        public static bool IsValueMaxTwentyFive(double value)
        {
            if (value <= 25)
            {
                return true;
            }
            return false;
        }
        public static bool IsValueMaxEighteenDigit(double value)
        {
            if (value <= 999999999999999999)
            {
                return true;
            }
            return false;
        }
        public static bool IsValueMaxEighteenDigits(double value)
        {
            if (value <= 999999999999999999)
            {
                return true;
            }
            return false;
        }

        public static bool isDouble<T>(T value) {
            if (value.GetType().FullName == "System.Double") {
                return true;
            }
            return false;
        }

        public static bool isInteger<T>(T value)
        {
            if (value.GetType().FullName == "System.Int32" || value.GetType().FullName == "System.Int64")
            {
                return true;
            }
            return false;
        }

        public static bool isString<T>(T value)
        {
            if (value.GetType().FullName == "System.String")
            {
                return true;
            }
            return false;
        }

        public static bool isNotString<T>(T value)
        {
            if (value.GetType().FullName != "System.String")
            {
                return true;
            }
            return false;
        }

        
    }
}
