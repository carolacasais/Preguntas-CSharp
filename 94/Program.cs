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
using System.ComponentModel.DataAnnotations;

namespace _94
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = 0;
            Program pr = new Program();
            pr.IsNull(obj);
            Console.WriteLine(IsNull(obj));
        }
        private bool IsNull (object obj)
            {
                if (obj == null)
                {
                    return true;
                }
                return false;
            }
    }
}
