using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace ProcessArray
{
    public class ProcessArray
    {
        static public string ArrayRow(string stringArray1, char columnDelimiter, char rowDelimiter, int rowIndex)
        {
            string result = string.Empty;

            var array1 = stringArray1.Split(rowDelimiter).Select(x => x.Split(columnDelimiter)).ToArray();

            var rowArray = array1[rowIndex];

            for(int i = 0; i < rowArray.Length; i++)
            {
                result = result + rowArray[i] + columnDelimiter;
            }

            result = result.TrimEnd(columnDelimiter);

            return result;
        }
    }
}
