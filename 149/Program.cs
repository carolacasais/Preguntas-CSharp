using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Web;

namespace _149
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeesList = new List<Employee>();
        
        }

        public static IEnumerable<TSource> Page<TSource>(this IEnumerable<TSource> source, int page, int pageSize)
        {
            return source.Skip((pageSize - 1) * page).Take(pageSize);
        } //B. Respuesta marcada como correcta

        /*public static IEnumerable<int> Page(IEnumerable<int> source, int page, int pageSize)
        {
            return source.Take((pageSize - 1) * page).Skip(pageSize);
        } A. */

        /*public static IEnumerable<int> Page(IEnumerable<int> source, int page, int pageSize)
        {
            return source.Skip((pageSize - 1) * page).Take(pageSize);
        } C. */

        /*public static IEnumerable<TSource> Page<TSource>(this IEnumerable<TSource>source, int page, int pageSize)
        {
            return source.Take((page - 1) * pageSize).Skip(pageSize);
        } D. */
    }

}
