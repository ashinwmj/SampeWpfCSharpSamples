using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Models.Interfaces;
using Unity;
using UnityContainer;

namespace CosumerPro
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var unityContainer = Container.Instance.GetUnityContainer();
            var signalService =unityContainer.Resolve<ISignalService>();
            var signals = await signalService.GetHarmonySignals();
        }
    }
}
