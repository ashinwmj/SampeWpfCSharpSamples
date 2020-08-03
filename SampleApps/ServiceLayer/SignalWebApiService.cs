using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Models;
using Application.Interfaces.Models.Interfaces;

namespace ServiceLayer
{
   public class SignalWebApiService:ISignalService
    {
        public Task<IList<SignalResponse>> GetAllSignals()
        {
            return Task.Run(() =>
            {
                IList<SignalResponse> signalResponses = new List<SignalResponse>();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44345/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("signals");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<Signal[]>();
                        readTask.Wait();

                        var signals = readTask.Result;
                        foreach (var signal in signals)
                        {
                            signalResponses.Add(new SignalResponse()
                                {Name = signal.Name, TagSource = signal.Signal_Source, Attributes = signal.Attributes});
                        }
                    }
                }

                return signalResponses;
            });
        }

        public Task<IList<SignalResponse>> GetHarmonySignals()
        {
            return Task.Run(() =>
            {
                IList<SignalResponse> signalResponses = new List<SignalResponse>();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:60464/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("signals");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<SignalEx[]>();
                        readTask.Wait();

                        var signals = readTask.Result;
                        foreach (var signal in signals.Where(x=>x.Source=="CH"))
                        {
                            signalResponses.Add(new SignalResponse()
                                { Name = signal.Name, TagSource = signal.Source, Attributes = signal.Attributes });
                        }
                    }
                }

                return signalResponses;
            });
        }
    }

   public class SignalEx
   {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Source { get; set; }
       public Dictionary<string, string> Attributes { get; set; }
    }

}
