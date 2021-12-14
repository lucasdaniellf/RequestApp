
using Newtonsoft.Json;


namespace RequestApp
{
    public class MainClass
    {
        static string url
        {
            get { return "https://jsonplaceholder.typicode.com"; }
        }

        public static async Task Main(string[] args)
        {
            Request request = new Request();
            Console.WriteLine("Making Requests");

            await request.MakeRequest(url + "/todos");

            Console.WriteLine("Finished");
        }
    }
}