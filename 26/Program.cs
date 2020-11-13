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
            
        }
        private async void GetData(WebResponse resonse)
            {
                var streamReader = new StreamReader(response.GetResponseStream());
                urlText.Text = await streamReader.ReadLineAsync();
            }
    }
}
