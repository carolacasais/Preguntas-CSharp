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
            new DataContractJsonSerializer(typeof(Location)) // RESPUESTA CORRECTA 
            //new DataContractSerializer(typeof(Location)) // No es JSON - No funciona - Serializa una instancia de un tipo en un flujo o en un documento XML
            //new XmlSerializer(typeof(Location)) // No hereda de XmlObjectSerializer
            //new System.Runtime.Serialization.NetDataContractSerializer() // No hereda de XmlObjectSerializer // ESTE ES EL CODIGO INSERTADO
            ));

        }
        public static string WriteObject(Location miL, XmlObjectSerializer miOS)
        {
            MemoryStream ms = new MemoryStream();
            miOS.WriteObject(ms, miL);
            byte[] cadena = ms.ToArray();
            ms.Close();

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
