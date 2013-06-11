using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UGTools.Entity;

namespace UGTools.BusinessLogic
{
    public class RoboFormBll
    {
        public static RoboFormBll Intance
        {
            get { return new RoboFormBll(); }
        }

        public DateTime RandomBirthday()
        {
            var start = new DateTime(1930, 1, 1);
            var end = new DateTime(1992, 12, 31);
            var gen = new Random();
            var range = (int) (end - start).TotalDays;
            return start.AddDays(gen.Next(range));
        }

        public string RandomPassword()
        {
            #region -- Const Value --

            const int minLength = 8;
            const int maxLength = 10;
            const string allowedChars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ!@#$%^&";

            #endregion


            var random = new Random();
            var lenth = random.Next(minLength, maxLength);

            var chars = new char[lenth];
            var allowedCharsCount = allowedChars.Count();
            for (var i = 0; i < lenth; i++)
            {
                chars[i] = allowedChars[(int) (allowedCharsCount*random.NextDouble())];
            }

            return new string(chars);
        }

        public string RandomUsername(string firstname, string lasname)
        {
            var random = new Random();
            var ex = random.Next(1930, 2013);
            var result = string.Format("{0}{1}{2}", firstname.ToLower(), lasname.ToLower(), ex);
            return result;
        }

        public Personal AutoDetectCc(string input, char splitChar)
        {
            var part = input.Split(splitChar);
            return new Personal();
        }
    }
}
