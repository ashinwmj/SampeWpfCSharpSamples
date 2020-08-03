using System.Collections.ObjectModel;
using System.Data;
using System.Threading.Tasks;
using Application.Interfaces.Models.Interfaces;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using UnityContainer;

namespace UISide.SignalManager
{
    public class SmViewModel:BindableBase
    {
        public IProjectWebApi ProjectService { get; set; }
        public SmViewModel()
        {
            ProjectService = Container.Instance.GetUnityContainer().Resolve<IProjectWebApi>();
        }

        private string _signalCount;
        private DataTable _smData;
        
        public DataTable SmData
        {
            get { return _smData; }
            set
            {
                SetProperty(ref _smData, value);
                SignalCount = _smData.Rows.Count.ToString();
            }
        }
        public string SignalCount
        {
            
            get
            {
                if (SmData != null)
                {
                    return _signalCount =_smData.Rows.Count.ToString();
                }
                else
                {
                    return _signalCount= 0.ToString();
                }

            }
            set { SetProperty(ref _signalCount, value); }
        }
        private ISmDataProvider _smDataProvider = null;
        public ISmDataProvider SmDataProvider
        {
            get
            {
                if (_smDataProvider == null)
                {
                    return new SmDataProvider();
                }

                return _smDataProvider;
            }
        }

        public async Task FetchSmData()
        {
            SmData?.Clear();
          SmData =await SmDataProvider.GetData();
        }
    }

}
