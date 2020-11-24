using System;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace _152
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
                26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 46, 47, 48, 49, 50
            };
            
            var page = items.Skip(20).Take(10);
            //var page = items.Skip(20).Take(10).ToList();
            foreach (var items in page)
                Console.WriteLine(page);


            /*
            otra opcion que probé
            int pageSize = 10;
            List<string> page = new List<string>();
            //List<String> page = null;

            for (int i = 0; i < filteredList.Count; ++i)
            {
                // if page reach pageSize, add a new one 
                if (i % pageSize == 0)
                {
                    page = new List<String>(pageSize);

                    allResponses.Add(page);
                }

                page.Add(filteredList[i]);
            }*/

            //var page = items.Skip(20).Take(10); Esta es la respuesta de la batería de preguntas
        }
    }
}
