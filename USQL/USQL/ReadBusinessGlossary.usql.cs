using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HafslundCommon
{

    public class Functions
    {
        /// <summary>
        /// Returns a string that removes line terminators in string
        /// Removes: Line Feed (U000A), Vertical Tab (U000B), Form Feed (U000C), Carriage Return (U000D),
        /// Next line (U0085), Line Separator (U2028) and Paragraph Separator (U2029)
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>String without line terminators</returns>
        public static string cleanString(String input)
        {
            string output = Regex.Replace(input, @"[\u000A\u000B\u000C\u000D\u2028\u2029\u0085]+", String.Empty);

            return output;

        }
        
      
    }
}