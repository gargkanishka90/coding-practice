using System.Linq;
using System.Text;

namespace ScratchPad.String
{
    public class StringIntegerConvert
    {
        public int StringToInteger(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            input = input.Trim();

            input = GetParseSegment(input.ToCharArray());
            // This method is also known as "Horner's Method".
            var result = 0;
            var flag = false;
            var start = 0;

            if (input[0] == '-')
            {
                flag = true;
                start = 1;
            }

            for (var i = start; i < input.Length; ++i)
            {
                result = result * 10 + (input[i] - '0');
            }

            return flag ? -1 * result : result;
        }

        private string GetParseSegment(char[] input)
        {
            var i = 0;
            while (char.IsDigit(input[i]))
            {
                i++;
            }

            return input.ToString().Substring(0, i);
        }

        public string IntegerToString(int input)
        {
            string result = null;
            var flag = input < 0 ? 1 : 0;
            if (flag == 1)
                input = -1 * input;

            var sb = new StringBuilder();

            while (input != 0)
            {
                var remainder = input % 10;
                sb.Append(remainder);
                input = input / 10;
            }

            var sb1 = new StringBuilder();

            var temp = sb.ToString().ToCharArray();

            if (flag == 1)
                sb1.Append("-");

            for (var i = temp.Length - 1; i >= 0; i--)
            {
                sb1.Append(temp[i]);
            }

            return sb1.ToString();
        }
    }
}