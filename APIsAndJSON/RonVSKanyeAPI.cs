using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        HttpClient client = new HttpClient();
        string kanyeURL = "https://api.kanye.rest/";
        string swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
        public void RonKanyeConvo(int sentenceCount)
        {

            if (sentenceCount < 5)
            {
                var ronKanyeConvo = new List<string>();
                Console.WriteLine("This conversation must have at least 5 exchanges per person! I will be using that format.");

                for (int i = 1; i <= 5; i++)
                {
                    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                    Console.WriteLine($"Kanye:  {JObject.Parse(kanyeResponse).GetValue("quote").ToString()}");
                    var ronResponse = client.GetStringAsync(swansonURL).Result;
                    Console.WriteLine($"Ron: {JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim()}");

                }

            }
            else
            {
                for (int i = 1; i <= sentenceCount; i++)
                {
                    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                    Console.WriteLine($"Kanye:  {JObject.Parse(kanyeResponse).GetValue("quote").ToString()}");
                    var ronResponse = client.GetStringAsync(swansonURL).Result;
                    Console.WriteLine($"Ron: {JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim()}");

                }


            }


        }
        public void RonKanyeConvo()
        {
            for (int i = 1; i <= 5; i++)
            {
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                Console.WriteLine($"Kanye:  {JObject.Parse(kanyeResponse).GetValue("quote").ToString()}");
                var ronResponse = client.GetStringAsync(swansonURL).Result;
                Console.WriteLine($"Ron: {JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim()}");

            }
        }
    }
}
