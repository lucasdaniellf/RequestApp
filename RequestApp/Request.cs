using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestApp
{
    public class Request
    {
        public async Task MakeRequest(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var result = JsonConvert.DeserializeObject<Model[]>(content);

                    if (result?.Length > 0)
                    {
                        foreach (Model model in result)
                        {
                            Console.WriteLine($"{model.Id} - {model.Title}: {model.Completed}");
                        }

                    }
                }

                client.Dispose(); 
            }
        }
    }
}
