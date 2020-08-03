using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Models.Interfaces
{
    public interface ISignalService
    {
        Task<IList<SignalResponse>> GetAllSignals();

        Task<IList<SignalResponse>> GetHarmonySignals();
    }
}
