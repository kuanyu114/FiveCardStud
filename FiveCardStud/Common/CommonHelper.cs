using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveCardStud.Common
{
    public static class CommonHelper
    {
        public static List<T> Swap<T>(this List<T> list, int index1, int index2)
        {
            var temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;    
            return list;
        }
    }
}
