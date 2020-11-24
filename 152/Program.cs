using System;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace _152
{
    class Program
    {
        static void Main(string[] args)
        {
            int pageSize = 10;

            List<String> page = null;

            for (int i = 0; i < filteredList.Count; ++i)
            {
                // if page reach pageSize, add a new one 
                if (i % pageSize == 0)
                {
                    page = new List<String>(pageSize);

                    allResponses.Add(page);
                }

                page.Add(filteredList[i]);
            }
            //var page = items.Skip(20).Take(10);
        }
    }
}
