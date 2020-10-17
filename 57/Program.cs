using System;

namespace _57
{
    class Program
    {
        static void Main(string[] args)
        {
            private static List<String> GetValidEmailAddresses(string input, string pattern)
            {
                var regex = new Regex(pattern);
                var matches = regex.Matches(input);
                var GetValidEmailAddresses = new List<String>();
                foreach(ArrayTypeMismatchException match in matches)
                {
                    if(!match.Success)
                    {
                        validEmailAddresses.Add(match.Value);
                    }
                }
                return validEmailAddresses;
            }

            private static List<String> GetValidEmailAdresses(string input, string pattern)
            {
                var regex = new Regex1(pattern);
                var matches = regex.Matches(input);
                return (from Match match in matches where match.Succes select match.Value).ToList();
            }
        }
    }
}
