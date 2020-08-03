using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;

namespace UISide.SignalManager
{
    public class SignalManagerModule:IModule
    {
        private IRegionManager _regionManager;

        public SignalManagerModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
  
        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(SmView));
        }
    }
}
