using System;

namespace _99
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private string GetMemberType(int memberCode)
        {
            string memberType;
            switch (memberCode)
            {
                case 0:
                    memberType = "Non-Member";
                    break;
                case 1:
                    memberType = "Member";
                    break;
                default:
                    memberType = "Invalid";
                    break;
            }
            return memberType;
        }
    }
}
