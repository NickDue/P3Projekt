using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class TestValidationInput
    {

        public int ValidationTestProductnumber(string possibleNumber)
        {
            int productNumber = Int32.Parse(possibleNumber);

            return productNumber;
        }
        public double ValidationTestVolumenumber()
        {
            return 500.0;
        }
        public int ValidationAmountLength(string possibleAmountNumber)
        {
            int amountLength = possibleAmountNumber.Length;
            return amountLength;
        }
        public string ValidationColli(string possibleColli)
        {
            string[] colli = { "1/1","1/2", "2/2", "1/3","2/3", "3/3", "1/4", "2/4", "3/4", "4/4",
                                "1/5", "2/5", "3/5", "4/5", "5/5", "1/6", "2/6", "3/6", "4/6", "5/6",
                                "6/6", "1/7","2/7", "3/7","4/7","5/7", "6/7", "7/7","1/8", "2/8", "3/8",
                                "4/8", "5/8", "6/8", "7/8", "8/8","1/9","2/9", "3/9", "4/9","5/9", "6/9",
                                "7/9", "8/9", "9/9"};

            foreach (string c in colli)
            {
                if (possibleColli == c)
                {
                    return c;
                }
            }
            return null;

        }

        public string ConvertDataByteToString(byte[] possibleByteInput)
        {
            string possibleString = ASCIIEncoding.ASCII.GetString(possibleByteInput);
            return possibleString;
        }
        public byte[] ConvertDataStringToByte(string possibleStringInput)
        {
            byte[] possibleByte = ASCIIEncoding.ASCII.GetBytes(possibleStringInput);
            return possibleByte;
        }

    }
}
