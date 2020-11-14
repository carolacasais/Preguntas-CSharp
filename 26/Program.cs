using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Web;

namespace _26
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program(); //creating object of class Program
            pr.GetData(); // Calling method
        }
        private async void GetData(WebResponse response)
            {
                var streamReader = new StreamReader(response.GetResponseStream());
                var utlTextText = await streamReader.ReadLineAsync();
            }
    }
}
