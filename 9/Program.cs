using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            
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

            public override void WriteObject (System.Xml.XmlWriter writer, object? graph); // esto es lo que añadí para que funcione
            {
                
                public class Test
                {
                    private void WriteObjectWithInstance(XmlObjectSerializer xm, Location graph,
                    string fileName)
                    {
                        // Use either the XmlDataContractSerializer or NetDataContractSerializer,
                        // or any other class that inherits from XmlObjectSerializer to write with.
                        Console.WriteLine(xm.GetType());
                        FileStream fs = new FileStream(fileName, FileMode.Create);
                        XmlDictionaryWriter writer = XmlDictionaryWriter.CreateTextWriter(fs);
                        xm.WriteObject(writer, graph);
                        Console.WriteLine("Done writing {0}", fileName);
                    }

                    void DoWork() // de aqui hacia abajo está bien
                    {
                            var location = new Location { Label = "Test", Direction = Compass.West };
                            Console.WriteLine(WriteObject(location,
                            new DataContractJsonSerializer(typeof(Location)) // ESTE ES EL CODIGO INSERTADO
                            )); 
                    }

                }
            }


            
}


