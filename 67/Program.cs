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

namespace _67
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; 
            x = 0.0;
            y = 0.0;
            
            Console.WriteLine($"Dividir entre cero Double:{x/y}"); 


            float a,b;
            a = 0.0f;
            b = 0.0f;
            Console.WriteLine($"Dividir entre cero float:{a/b}"); 

            int z,w;
            z = 0;
            w = 0;
            try
            {
                Console.WriteLine(z/w);
            }
            catch (System.Exception e)
            {
                
                Console.WriteLine($"Dividir entre cero int:{e.Message}"); 
            }

            decimal l,m;
            l = 0.0m;
            m = 0.0m;
            try
            {
                Console.WriteLine(l/m);
            }
            catch (System.Exception e)
            {
                
                Console.WriteLine($"Dividir entre cero decimal:{e.Message}"); 
            }
            
        }
    }
}
