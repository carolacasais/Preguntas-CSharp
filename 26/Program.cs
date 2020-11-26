using System;
using System.IO;
using System.Net;


namespace _26
{
    class Program
    {
        private async void GetData(WebResponse response)
        {
            var streamreader = new StreamReader(response.GetResponseStream());
            //var utlTextText = await streamReader.ReadLineAsync(); estp es lo que proponía la batería de preguntas
            Console.WriteLine (await streamreader.ReadLineAsync());
            streamreader.Close();
            // El porque ReadLineAsync() y no ReadToEndAsync() es por the method must return a string value that contains the first line
        }
        static void Main(string[] args)
        {
            Console.WriteLine("este ejemplo va a escribir la primera linea de la pagina https://dotnetfoundation.org/; ");
            WebRequest myWebRequest = WebRequest.Create("https://dotnetfoundation.org/");
            WebResponse myWebResponse = myWebRequest.GetResponse();
            
            //new Program().GetData(myWebResponse);
            Program pr = new Program();
            pr.GetData(myWebResponse); // le llamamos asi porque main es static y GetData no

            myWebResponse.Close();
            Console.WriteLine("Claro : <!DOCTYPE html> que te esperabas ;)");
        }

    }
}
