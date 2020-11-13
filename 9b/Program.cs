using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace _9b
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Program().DoWork();
            Program pr = new Program();
            pr.DoWork();
        }
        void DoWork() // de aqui hacia abajo está bien
        {
            var location = new Location { Label = "Test", Direction = Compass.West };
            Console.WriteLine(WriteObject(location,
            new DataContractJsonSerializer(typeof(Location)) // ESTE ES EL CODIGO INSERTADO
            ));

        }
        public static string WriteObject(Location miL, XmlObjectSerializer miOS)
        {
            MemoryStream ms = new MemoryStream();
            miOS.WriteObject(ms, miL);
            byte[] cadena = new byte[ms.Length];
            ms.Read(cadena, 0, (int) ms.Length);
            return System.Text.Encoding.Default.GetString(cadena);
        }
    }
    public enum Compass
    {
        North,
        South,
        East,
        West,
    }
    [DataContract]
    public class Location
    {
        [DataMember]
        public string Label { get; set; }
        [DataMember]
        public Compass Direction { get; set; }



        

    }
}
