using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Web;
using System.Reflection;
using System.Collections.ObjectModel;

namespace _153
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Int32 returnStatus = Int32.MinValue;
            var status = Convert.ToString(returnStatus); //esto lo añadi
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
            Console.WriteLine(returnStatus); //esto era return en vez de cw pero si no no ejecutaba
        }// da siempre -1
    }
}
