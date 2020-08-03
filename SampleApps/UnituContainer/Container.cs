using Application.Interfaces.Models;
using Application.Interfaces.Models.Interfaces;
using ServiceLayer;
using DataAccessLayer.Repositories;
using Microsoft.Practices.Unity;
using CommonItems.ProgressWindow;

namespace UnityContainer
{
    public class Container
    {
        private IUnityContainer _unityContainer;
        private Container()
        {
            _unityContainer=new Microsoft.Practices.Unity.UnityContainer();
            ResolveTypes(_unityContainer);
        }

        private void ResolveTypes(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IRepository<Signal>, SignalRepository>();
            unityContainer.RegisterType<ISignalService, SignalService>("ownservice");
            unityContainer.RegisterType<ISignalService, SignalWebApiService>("webapi");
            unityContainer.RegisterType<IProgressbarService,ProgressBarService>(new ContainerControlledLifetimeManager());
            unityContainer.RegisterType<IProjectWebApi, ProjectWebApiService>();

        }


        private static Container _instance;

        public static Container Instance
        { 
            get
            {
                if (_instance == null)
                {
                    return _instance= new Container();
                }
                return _instance;
            }
        }

        public Microsoft.Practices.Unity.UnityContainer GetUnityContainer()
        {
            return (Microsoft.Practices.Unity.UnityContainer)_unityContainer;
        }

    }
}
