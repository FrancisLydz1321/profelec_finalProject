/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/


//using RabbitMQ.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;



namespace CurrencyApp // api call
{
    public class CurrencyConverter
    {
        Dictionary<string, string> symbols;
        public Dictionary<string, string> GetSymbols()
        {
            if(symbols == null)
            {
                symbols= new Dictionary<string, string>();
                string responseContent = getResponseString("exchangerates_data/symbols");
                //string responseContent = getResponseString();

                Dictionary<string,object> responseData = JsonConvert.DeserializeObject<Dictionary<string,object>>(responseContent);
                if ((bool)responseData["success"])
                {
                    var tempSymbols = (JObject)responseData["symbols"];
                    symbols = tempSymbols.ToObject<Dictionary<string, string>>();
                }
            }
            return symbols;
        }

        public double Convert(string fromCurrency, string toCurrency, double currencyAmount)
        {
            string responseContent = getResponseString($"exchangerates_data/convert?to={toCurrency}&from={fromCurrency}&amount={currencyAmount}");
            //string responseContent = getResponseString();

            Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseContent);
            if ((bool)responseData["success"])
            {
                //var tempSymbols = (JObject)responseData["symbols"];
                //symbols = tempSymbols.ToObject<Dictionary<string, string>>();
                return (double)responseData["result"];
            }
            else
            {
                return -1;
            }
        }

        private string getResponseString(string relativeURI)
        {
            var client = new RestClient("https://api.apilayer.com/");
            // client.Timeout = -1;

            var request = new RestRequest(relativeURI, Method.Get);
            request.AddHeader("apikey", "OHR2ao0G911S95Q09rrreueLj0DPnjr8");

            RestResponse response = client.Execute(request);
            
            return response.Content;
        }
    }
}
