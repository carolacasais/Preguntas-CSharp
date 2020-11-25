using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Web;
using System.Data.SqlClient;
using System.Threading;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program(); //creating object of class Program
            //p.GetData(new object()); // Calling method
            //GetData();
            var response = GetData(WebResponse);
            Console.WriteLine(response.Result);
            
        }
        private async void GetData(WebResponse response)
            {
                var streamReader = new StreamReader(response.GetResponseStream());
                var utlTextText = await streamReader.ReadLineAsync();
            }
    }
}
