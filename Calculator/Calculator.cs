using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Calculator
    {
        public string Add(string value1, string value2)
        {

           // decimal v1 = string.IsNullOrEmpty(value1) ? 0 : Convert.ToDecimal(value1);
           // decimal v2 = string.IsNullOrEmpty(value2) ? 0 : Convert.ToDecimal(value2);

           // //var v1s = value1.ToCharArray();
           // //var v2s = value2.ToCharArray();

           // //var v1v2s = 
           // //for (int i = 0; i < v1s.Length; i++)
           // //{
           // //    for (int j = 0; j < v2s.Length; j++)
           // //    {
           // //        v1s[i]
           // //    }
           // //}

           // //int sign1 = value1[0] == '-' ? -1 : 1;
           // //int sign2 = value2[0] == '-' ? -1 : 1;

           // //char ch1 = value1[value1.Length - 1];
           // //char ch2 = value2[value2.Length - 1];

            
           //// string  ((Convert.ToInt32(ch1)*sign1)+(int.Parse(ch2)*sign2)).ToString();



            //var result = v1 + v2;
            //return result.ToString();
            if (string.IsNullOrEmpty(value1)) value1 = "0";
            if (string.IsNullOrEmpty(value2)) value2 = "0";

            if (HasNoneDigits(value1) || HasNoneDigits(value2))
            {
                throw new ArgumentException("value cannot contain non digit character","value1");
            }

            
            int sign1 = value1[0] == '-' ? -1 : 1;
          //  if(value1[0])
            int sign2 = value2[0] == '-' ? -1 : 1;

            char ch1 = value1[value1.Length - 1];
            char ch2 = value2[value2.Length - 1];

            int v1 = (int)(ch1 - '0') * sign1;
            int v2 = (int)(ch2 - '0') * sign2;

            return (v1 + v2).ToString();

        }

        private bool HasNoneDigits(string value)
        {
            foreach (char ch in value)
            {
                if ((!Char.IsDigit(ch) && ch!='-')) return true;
               // throw new NotImplementedException();
               // throw new Exception();
               // throw  new ArgumentException("value cannot contains non digit characters","value1");
            }
            return false;
        }
        public string Add_BAK(string value1, string value2)
        {
            // throw new NotImplementedException();
            // return "2";
            // decimal v1 = value1==string.Empty?0:Convert.ToDecimal(value1);
            // decimal v2 = value2 == string.Empty ? 0 : Convert.ToDecimal(value2);

            decimal v1 = string.IsNullOrEmpty(value1) ? 0 : Convert.ToDecimal(value1);
            decimal v2 = string.IsNullOrEmpty(value2) ? 0 : Convert.ToDecimal(value2);
            var result = v1 + v2;
            return result.ToString();

        }
    }

}
