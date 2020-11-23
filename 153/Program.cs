using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Web;

namespace _153
{
    class Program
    {
        static void Main(string[] args)
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
