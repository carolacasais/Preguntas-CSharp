using System;

namespace _153
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.DoWork();
        }

        public void DoWork();
        {
            Int32 returnStatus = Int32.MinValue;
            switch (status)
            {
                case "Active":
                returnStatus = 1;
                break;
                case "Inactive":
                returnStatus = 0;
                break;
                default:
                returnStatus = -1;
                break;
                
            }
            return returnStatus;
        }
    }
}
