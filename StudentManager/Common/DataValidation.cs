using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace StudentManager
{
    public class DataValidation
    {
        public static bool IsInteger(string txt)
        {
            Regex objReg = new Regex(@"^[1-9]\d*$");
            return objReg.IsMatch(txt);
        }


        public static bool IsIdentityCard(string txt)
        {
            Regex objReg = new Regex(@"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");

            return objReg.IsMatch(txt);
        }
    }
}
