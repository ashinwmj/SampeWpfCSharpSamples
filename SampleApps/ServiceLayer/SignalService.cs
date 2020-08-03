using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces.Models;
using Application.Interfaces.Models.Interfaces;


namespace ServiceLayer
{


   public class SignalService:ISignalService
   {
       private IRepository<Signal> _signalRepository;
        public SignalService(IRepository<Signal> signalRepository)
        {
            _signalRepository = signalRepository;
        }
        public Task<IList<SignalResponse>> GetAllSignals()
        {
             return Task.Run(() =>
            {
                IList<SignalResponse> signalResponses = new List<SignalResponse>();
                foreach (var signal in (_signalRepository.GetAll()))
                {
                    var signalResponse = new SignalResponse();
                    signalResponse.Name = signal.Name;
                    signalResponse.Attributes = signal.Attributes;
                    signalResponse.TagSource = signal.Signal_Source;
                    signalResponses.Add(signalResponse);
                }
                return signalResponses;
            });
        }

        public Task<IList<SignalResponse>> GetHarmonySignals()
        {
            return Task.Run(() =>
            {
                IList<SignalResponse> signalResponses = new List<SignalResponse>();
                foreach (var signal in (_signalRepository.GetAll().Where(x=>x.Signal_Source.Equals("COMPOSERHARMONY"))))
                {
                    var signalResponse = new SignalResponse();
                    signalResponse.Name = signal.Name;
                    signalResponse.Attributes = signal.Attributes;
                    signalResponse.TagSource = signal.Signal_Source;
                    signalResponses.Add(signalResponse);
                }
                return signalResponses;
            });
        }
   }
}
