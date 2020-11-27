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
            string ListaEmails = "ahotmail.com";
            string pattern = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{​​\|}​​~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{​​\|}​​~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";
            List<String> Lista = GetValidEmailAddresses(ListaEmails, pattern);
           Console.WriteLine("probando opcion 1!");
            foreach(var item in Lista)
            {
                Console.WriteLine(item);
            }
            
        }
        
        private static List<String> GetValidEmailAddresses(string input, string pattern)
        {
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);
            var ValidEmailAddresses = new List<String>();
            foreach(Match match in matches)
            {
                if(!match.Success)
                {
                    ValidEmailAddresses.Add(match.Value);
                }
            }
            return ValidEmailAddresses;
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


