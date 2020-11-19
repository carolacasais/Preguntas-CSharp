using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Web;
using System.Text.RegularExpressions;


namespace _57
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(GetValidEmailAddresses());
            //Program pr = new Program(); //creating object of class Program
            //pr.GetValidEmailAddresses(); // Calling method
            List<String> GetValidEmailAddresses = new List<String>();
    

            
        }
        
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
            return GetValidEmailAddresses;
        } // B

            /*private static List<String> GetValidEmailAdresses(string input, string pattern)
            {
                var regex = new Regex1(pattern);
                var matches = regex.Matches(input);
                return (from Match match in matches where match.Succes select match.Value).ToList();
            } C */

             /*private static List<String> GetValidEmailAdresses(string input, string pattern)
            {
                var regex = new Regex1(pattern);
                var matches = regex.Matches(input);
                return (from Match match in matches where match.Succes select match.Success.ToSring()).ToList();
            } D */

            /*private static List<String> GetValidEmailAddresses(string input, string pattern)
            {
                var regex = new Regex(pattern);
                var matches = regex.Matches(input);
                var GetValidEmailAddresses = new List<String>();
                foreach(ArrayTypeMismatchException match in matches)
                {
                    if(match.Success)
                    {
                        validEmailAddresses.Add(match.Value);
                    }
                }
                return GetValidEmailAddresses;
            } A */
    }
}
