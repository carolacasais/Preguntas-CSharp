using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
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
            void DoWork()
            {
                var location = new Location { Label = "Test", Direction = Compass.West };
                Console.WriteLine(WriteObject(location,
                New DataContractJsonSerializer(typeof(Location)) // AQUI INSERTAR CODIGO
                )); 
            }
        }
    }
}
