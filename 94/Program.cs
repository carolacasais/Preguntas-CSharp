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
            ClaseEvaluar clase = new ClaseEvaluar();
            new Program().IsNullA(clase);
            new Program().IsNullB(clase);
            new Program().IsNullC(clase);
            new Program().IsNullD(clase);
        }
        private bool IsNullA(object obj)
        {
            if (obj = null)
            {
                return true;
            }
            return false;
        }

        private bool IsNullB(object obj)
        {
            if (null)
            {
                return true;
            }
            return false;
        }

        private bool IsNullC(object obj)
        {
            if (obj == 0)
            {
                return true;
            }
            return false;
        }

        private bool IsNullD(object obj)
        {
            if (obj == null)
            {
                return true;
            }
            return false;
        }
    }

    public class ClaseEvaluar
    {

    }
}
