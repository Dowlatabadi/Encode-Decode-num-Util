using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encode_Decode
{
    public static class CodeHelper
    {
        static CodeHelper()
        {
            Map = new char[] {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H','I', 'J', 'K','L',
            'M', 'N','O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W',
            'X', 'Y', 'Z', '0','1', '2', '3', '4', '5', '6', '7',
                '8', '9',
            };
        }
        private static long Get_Offset(int Min_Length,int character_space)
        {
            var doubleOffset = Math.Pow(10, Math.Floor(Math.Log10(Math.Pow(character_space, Min_Length))));
            if (doubleOffset > long.MaxValue)
                throw new Exception("length is too long");
            var offset = (long)doubleOffset;
            return offset;
        }
        private static char[] Map;
        /// <summary>
        /// Converts an long input to coresponding String
        /// </summary>
        /// <param name="inp">input number</param>
        /// <param name="Min_Length">the length of output string for zero</param>
        /// <param name="map">optional map to define allowed characters for the resut String</param>
        /// <returns></returns>
        public static string Encode(long inp, int Min_Length, IEnumerable<char> map = null)
        {
            if (map == null)
                map = Map;
            var b = map.Count();
            var offset = Get_Offset(Min_Length,b);
            inp += offset;
            var toChar = map.Select((v, i) => new { Value = v, Index = i }).ToDictionary(i => i.Index, i => i.Value);
            var res = "";
            if (inp == 0)
            {
                return "" + toChar[0];
            }
            while (inp > 0)
            {
                var val = (int)(inp % b);
                inp = inp / b;
                res += toChar[val];
            }
            return res;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="encoded">encoded string</param>
        /// <param name="Min_Length">the length of output string for zero</param>
        /// <param name="map">optional map to define allowed characters for the resut String</param>
        /// <returns></returns>
        public static long Decode(string encoded, int Min_Length, IEnumerable<char> map = null)
        {
            if (map == null)
                map = Map;
            var b = Map.Count();
            var offset = Get_Offset(Min_Length,b);
            var array = encoded.ToString().ToCharArray().ToList();
            var toNum = Map.Select((v, i) => new { Value = v, Index = i }).ToDictionary(i => i.Value, i => i.Index);
            long res = 0;
            var pos = 0;
            foreach (var item in array)
            {
                res += (long)((double)toNum[item] * Math.Pow(b, pos++));
            }

            return (res - offset);
        }

    }
}
