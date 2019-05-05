using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.R.T.A.D
{
    class CheckPrefix
    {
        /// <summary>
        /// not optimal, got frustrated :/
        /// </summary>
        /// <param name="strs"></param>
        /// <returns>string => prefix</returns>
        public static string Run(string[] strs)
        {
            var commonSeq = "";
            var prefix = "";
            var hasCommonPrefix = false;

            if (strs.Length == 1)
            {
                return strs[0];
            }

            if (strs.Length > 1)
            {
                var firstWord = strs[0].ToCharArray();

                foreach (var letter in firstWord)
                {
                    commonSeq += letter;
                    hasCommonPrefix = strs.All(pref => pref.StartsWith(commonSeq));
                    if (!hasCommonPrefix)
                    {
                        break;
                    }
                    else
                    {
                        prefix = commonSeq;
                    }
                }
            }
            return prefix;
        }
    }
}
